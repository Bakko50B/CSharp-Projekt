using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ColorApp
{
    public partial class EditColorsForm : Form
    {
        private readonly ColorStorage _colorStorage = new ColorStorage();
        private const string FilePath = "colors.json";

        public event EventHandler? ColorsUpdated;

        public EditColorsForm()
        {
            InitializeComponent();
            LoadColors();
        }

        private void LoadColors()
        {
            _colorStorage.LoadFromFile(FilePath);
            flowPanelColorList.Controls.Clear();

            foreach (var color in _colorStorage.Colors)
            {
                var container = new Panel
                {
                    Width = 260,
                    Height = 40,
                    Margin = new Padding(5),
                    Tag = color
                };

                var colorBox = new Panel
                {
                    Width = 40,
                    Height = 40,
                    BackColor = color.ToColor(),
                    Margin = new Padding(0),
                    Dock = DockStyle.Left,
                    BorderStyle = BorderStyle.FixedSingle
                };

                var checkBox = new CheckBox
                {
                    //Text = "RGB " + color.ToString(), // t.ex. RGB(123, 45, 67)
                    Text = $"RGB ({color.Red}, {color.Green}, {color.Blue})",
                    AutoSize = true,
                    Dock = DockStyle.Left,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0)
                };
                
                container.Controls.Add(checkBox);
                container.Controls.Add(colorBox); 
                
                flowPanelColorList.Controls.Add(container);
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            var toDelete = new List<ColorModel>();

            foreach (Panel container in flowPanelColorList.Controls)
            {
                var checkBox = container.Controls.OfType<CheckBox>().FirstOrDefault();
                if (checkBox?.Checked == true && container.Tag is ColorModel color)
                {
                    toDelete.Add(color);
                }
            }

            foreach (var color in toDelete)
            {
                _colorStorage.Colors.Remove(color);
            }

            _colorStorage.SaveToFile(FilePath);
            LoadColors(); // Uppdatera listan
            ColorsUpdated?.Invoke(this, EventArgs.Empty); // Signalera till Form1 om att uppdatera färgpanelen
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}