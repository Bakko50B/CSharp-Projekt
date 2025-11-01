using ColorApp.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ColorApp
{
    /// <summary>
    /// Ett formulär (fönster) för att visa, redigera och hantera sparade färger.
    /// </summary>
    /// <remarks>
    /// Användaren kan se färger som miniatyrer, välja vilka som ska tas bort och spara ändringar till fil.
    /// När färgsamlingen uppdateras utlöses <see cref="ColorsUpdated"/> för att meddela huvudformuläret.
    /// </remarks>
    public partial class EditColorsForm : Form
    {
        /// <summary>
        /// Hanterar lagring och hämtning av färger från fil.
        /// Fältet är readonly för att förhindra att instansen byts ut under körning.
        /// </summary>
        private readonly ColorStorage _colorStorage = new ColorStorage();

        /// <summary>
        /// Sökvägen till filen där färgsamlingen sparas.
        /// </summary>
        private const string FilePath = "colors.json";

        /// <summary>
        /// Händelse som utlöses när färgsamlingen har uppdaterats.
        /// Används för att meddela andra formulär om att UI bör uppdateras.
        /// </summary>
        public event EventHandler? ColorsUpdated;

        /// <summary>
        /// Konstruktor för <see cref="EditColorsForm"/>.
        /// Initierar gränssnittet och laddar sparade färger från fil.
        /// </summary>
        public EditColorsForm()
        {
            InitializeComponent();  // Initierar alla kontroller och layoutinställningar som definierats i designern.
            LoadColors();           // Läser in sparade färger och uppdaterar gränssnittet
        }
        
        /// <summary>
        /// Läser sparade färger från fil och visar dem i användargränssnittet.
        /// </summary>
        /// <remarks>
        /// Metoden rensar den befintliga listan med färgpaneler och bygger upp den på nytt
        /// med färgerna som laddas från <see cref="FilePath"/>. Varje färg visas som en panel
        /// med en färgruta och en kryssruta som visar RGB-värdena.
        /// Vald värg kan raderas via en knapp
        /// </remarks>
        private void LoadColors()
        {
            _colorStorage.LoadFromFile(FilePath);   // laddar färger från fil
            flowPanelColorList.Controls.Clear();    // Rensa befintliga kontroller

            // Upprepar detta för alla sparade färger i colors.json
            foreach (var color in _colorStorage.Colors)
            {
                // Skapa en containerpanel där två andra paneler ska placeras 
                var container = new Panel
                {
                    Width = 260,
                    Height = 40,
                    Margin = new Padding(5),
                    Tag = color
                };
                // Panel för att visa färgen
                var colorBox = new Panel
                {
                    Width = 40,
                    Height = 40,
                    BackColor = color.ToColor(),
                    Margin = new Padding(0),
                    Dock = DockStyle.Left,
                    BorderStyle = BorderStyle.FixedSingle
                };
                //  Kryssruta för att välja bort färgen
                var checkBox = new CheckBox
                {                    
                    //Väljer färgvisningskod utefter sparade valet som hämtas från settings
                    Text = Settings.Default.VisaHexKod ? color.ToHex() : color.ToString(),
                    AutoSize = true,
                    Dock = DockStyle.Left,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0)
                };
                // Lägg till båda panelerna i containerpanelen
                container.Controls.Add(checkBox);
                container.Controls.Add(colorBox);
                // Lägg till containerpanelen i FlowLayoutPanel
                flowPanelColorList.Controls.Add(container);
            }
        }

        /// <summary>
        /// Hanterar klickhändelsen för knappen "Ta bort valda färger".
        /// Tar bort markerade färger från samlingen, sparar ändringarna och uppdaterar gränssnittet.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            var toDelete = new List<ColorModel>();

            // Gå igenom varje färgpanel och kontrollera om kryssrutan är markerad
            foreach (Panel container in flowPanelColorList.Controls)
            {
                var checkBox = container.Controls.OfType<CheckBox>().FirstOrDefault();
                if (checkBox?.Checked == true && container.Tag is ColorModel color)
                {
                    toDelete.Add(color); // Lägg till färgen i borttagningslistan
                }
            }

            // Ta bort markerade färger från samlingen
            foreach (var color in toDelete)
            {
                _colorStorage.Colors.Remove(color);  // Ta bort den/dela valda färger(na)
            }

            _colorStorage.SaveToFile(FilePath); // Spara uppdaterad samling till fil
            LoadColors(); // Uppdatera gränssnittet med nya listan
            ColorsUpdated?.Invoke(this, EventArgs.Empty); // Signalera till Form1 (huvudformuläret) om att uppdatera färgpanelen
        }
        /// <summary>
        /// Hanterar klickhändelsen för knappen "Stäng".
        /// Stänger formuläret.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}