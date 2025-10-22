namespace ColorApp
{
    /// <summary>
    /// Klass för huvudformuläret i applikationen.
    /// Hanterar användarinteraktion, färggenerering och visning av färger.
    /// </summary>
    public partial class Form1 : Form
    {
        // Färggeneratorer för olika färgtyper
        private IColorGenerator _generator = new RandomColorGenerator();
        private IColorGenerator _greyGenerator = new GrayScaleGenerator();
        private IColorGenerator _fuzzyGenerator = new FuzzyGrayScaleGenerator();
        private IColorGenerator _pastelGenerator = new PastelColorGenerator();

        // Färgmodeller för aktuell färg och varianter        
        private ColorModel _currentColor;
        private ColorModel _greyColor;
        private ColorModel _pastelcolor;

        // Färglagring för att hantera sparade färger
        private ColorStorage _colorStorage;

        /// <summary>
        /// Initierar huvudformuläret, dess komponenter och startlogik.
        /// </summary>
        public Form1()
        {
            // Skapar och placerar alla UI-komponenter
            InitializeComponent();
            // Sätter fönstrets ikon
            this.Icon = new Icon("favicon.ico");

            // Registrerar händelse för Form.Load
            this.Load += Form1_Load!;

            // Genererar initiala färger
            _currentColor = _generator.Generate();
            _greyColor = _greyGenerator.Generate();
            _pastelcolor = _pastelGenerator.Generate();

            // Visar färgerna i respektive panel
            pnlColor.BackColor = _currentColor.ToColor();
            panelGreyscale.BackColor = _greyColor.ToColor();
            panelPastel.BackColor = _pastelcolor.ToColor();

            // Initierar färglagring
            _colorStorage = new ColorStorage();

            // Uppdaterar etiketter och UI
            labelColors();
            labelGreyScale();
            labelPastelColor();
            UpdateUI();
        }

        /// <summary>
        /// Event-handler för formulärets Load-händelse.
        /// Läser in sparade färger, uppdaterar miniatyrer och initierar verktygstips.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Läser in färger från JSON-fil om den finns
            _colorStorage.LoadFromFile("colors.json");

            // Uppdaterar färgminiatyrer i gränssnittet
            UpdateColorThumbnails();

            // Initierar verktygstips för UI-komponenter
            InitializeToolTips();

            //läser in sparad data från settingsfilen om typ av färgkod för ettiketterna (labels)
            ToolStripMenuItemHexCode.Checked = Properties.Settings.Default.VisaHexKod;
        }

        /// <summary>
        /// Uppdaterar användargränssnittet med aktuell färginformation och kontroller.
        /// Anropar metoder för att uppdatera paneler, etiketter, reglage och textfält.
        /// </summary>
        private void UpdateUI()
        {
            UpdatePanelColor();             // Uppdaterar huvudfärgpanelen
            labelColors();                  // Visar RGB-värden för huvudfärgen
            labelGreyScale();               // Visar RGB-värden för gråtonen
            UpdatePanelPastelColor();       // Uppdaterar pastellfärgpanelen
            labelPastelColor();             // Visar RGB-värden för pastellfärgen
            setTrackbarValue();             // Synkroniserar reglage med aktuell färg
            settextBoxRGBValue();           // Visar RGB-värden i textfält
        }

        /// <summary>
        /// Synkroniserar RGB-reglagen med den aktuella färgens värden.
        /// </summary>
        private void setTrackbarValue()
        {
            trackBarRed.Value = _currentColor.Red;
            trackBarGreen.Value = _currentColor.Green;
            trackBarBlue.Value = _currentColor.Blue;
        }

        /// <summary>
        /// Synkroniserar textBox-kontrollerna med den aktuella färgens RGB-värden.
        /// </summary>
        private void settextBoxRGBValue()
        {
            textBoxRed.Text = _currentColor.Red.ToString();
            textBoxGreen.Text = _currentColor.Green.ToString();
            textBoxBlue.Text = _currentColor.Blue.ToString();
        }

        /// <summary>
        /// Uppdaterar texten i den angivna etiketten så att färgen visas antingen i hexadecimal form eller som en strängrepresentation.
        /// </summary>
        /// <remarks>
        /// Formatet för den visade färgen bestäms av statusen för <see cref="ToolStripMenuItemHexCode"/>-kryssrutan.
        /// Om kryssrutan är markerad visas färgen i hexadecimal form; annars används färgens standardsträngrepresentation.
        /// </remarks>
        /// <param name="etikett">Den <see cref="Label"/>-kontroll vars text ska uppdateras.</param>
        /// <param name="färg">Den <see cref="ColorModel"/> som representerar färgen som ska visas.</param>
        private void UpdateColorLabel(Label etikett, ColorModel färg)
        {
            // Använder kryssrutans status för att bestämma visningsformat
            etikett.Text = ToolStripMenuItemHexCode.Checked ? färg.ToHex() : färg.ToString();
        }

        /// <summary>
        /// Uppdaterar etiketten med den aktuella färgens RGB-kod som sträng.
        /// </summary>
        private void labelColors()
        {
            // Använder den gemensamma metoden för att uppdatera etiketten
            UpdateColorLabel(labelRGBCode, _currentColor);

            //if (ToolStripMenuItemHexCode.Checked)
            //{
            //    labelRGBCode.Text = _currentColor.ToHex();
            //}
            //else
            //{
            //    labelRGBCode.Text = _currentColor.ToString();
            //}

        }

        ///<summary>
        ///Uppdaterar etiketten med den aktuella pastellfärgens RGB-kod.
        ///</summary>
        private void labelPastelColor()
        {
            // Använder den gemensamma metoden för att uppdatera etiketten
            UpdateColorLabel(labelPastel, _pastelcolor);
            //if (ToolStripMenuItemHexCode.Checked)
            //{
            //    labelPastel.Text = _pastelcolor.ToHex();
            //}
            //else
            //{
            //    labelPastel.Text = _pastelcolor.ToString(); // eller annan representation
            //}
        }

        ///<summary>
        /// Uppdaterar etiketten med den aktuella gråskale-färgens RGB-kod.
        ///</summary>
        private void labelGreyScale()
        {
            // Använder den gemensamma metoden för att uppdatera etiketten
            UpdateColorLabel(labelShowGreyscale, _greyColor);
            //if (ToolStripMenuItemHexCode.Checked)
            //{
            //    labelShowGreyscale.Text = _greyColor.ToHex();
            //}
            //else
            //{
            //    labelShowGreyscale.Text = _greyColor.ToString();
            //}
        }

        ///<summary>
        ///Uppdaterar färgpanelen med den aktuella färgen
        ///</summary>
        private void UpdatePanelColor()
        {
            pnlColor.BackColor = _currentColor.ToColor();
        }


        ///<summary>
        /// Uppdaterar färgpanelen med den aktuella pastellfärgen.
        ///</summary>
        private void UpdatePanelPastelColor()
        {
            panelPastel.BackColor = _pastelcolor.ToColor();
        }

        ///<summary>
        /// Uppdaterar panelen med miniatyrer av sparade färger.
        /// Läser in färger från fil, skapar paneler dynamiskt och kopplar klickhändelser.
        ///</summary>
        private void UpdateColorThumbnails()
        {
            // Läser in färger från JSON-fil
            _colorStorage.LoadFromFile("colors.json");

            // Rensar tidigare miniatyrer
            flowPanelColors.Controls.Clear();

            foreach (var color in _colorStorage.Colors)
            {
                // Skapar en panel för varje färg
                var panel = new Panel
                {
                    Width = 40,
                    Height = 40,
                    BackColor = color.ToColor(),
                    Margin = new Padding(5),
                    Cursor = Cursors.Hand,
                    Tag = color // Lagrar färgobjektet i Tag för åtkomst vid klick
                };

                // Kopplar en klick-händelse till panelen för varje sparad färg (dynamiskt skapad kontroll)
                panel.Click += ColorPanel_Click!; // Ta bort varning för null-referens

                // Lägger till tooltip för användarinteraktion
                toolTipSavedColorsPanel.SetToolTip(panel, $"Klicka på färgen för att kopiera färgkoden till urklipp!");

                // Lägger till panelen i FlowLayoutPanel
                flowPanelColors.Controls.Add(panel);
            }
        }

        /// <summary>
        /// Initierar verktygstips för UI-komponenter för att förbättra användarupplevelsen.
        /// Verktygstipsen förklarar funktioner och guidar användaren i gränssnittet.
        /// </summary>
        private void InitializeToolTips()
        {
            // Spara-knappar
            ToolTipGeneral.SetToolTip(buttonSaveRGBColor, "Lägg till färgen i paletten");
            ToolTipGeneral.SetToolTip(buttonSavePastellColor, "Lägg till färgen i paletten");
            ToolTipGeneral.SetToolTip(buttonSaveGreyColor, "Lägg till färgen i paletten");
            // Genereringsknappar
            ToolTipGeneral.SetToolTip(btnGeneratePastel, "Generera en ny pastellfärg");
            ToolTipGeneral.SetToolTip(btnGenerate, "Generera en ny RGB-färg");
            ToolTipGeneral.SetToolTip(buttonGreyScale, "Generera en ny gråskala");
            // Reglage
            ToolTipGeneral.SetToolTip(trackBarRed, "Justera den röda komponenten");
            ToolTipGeneral.SetToolTip(trackBarGreen, "Justera den gröna komponenten");
            ToolTipGeneral.SetToolTip(trackBarBlue, "Justera den blå komponenten");
            // Textfält
            ToolTipGeneral.SetToolTip(textBoxRed, "Ange ett värde mellan 0 och 255 för den röda komponenten");
            ToolTipGeneral.SetToolTip(textBoxGreen, "Ange ett värde mellan 0 och 255 för den gröna komponenten");
            ToolTipGeneral.SetToolTip(textBoxBlue, "Ange ett värde mellan 0 och 255 för den blå komponenten");
            // Radioknappar
            ToolTipGeneral.SetToolTip(radioBtnGreyscale, "Standard gråskala");
            ToolTipGeneral.SetToolTip(radioBtnFuzzy, "Alternativ \"fuzzy\" gråskala");
            ToolTipGeneral.SetToolTip(radioBtnBiasGrey, "Alternativ \"biased\" gråskala");
            // Slumpknappar
            ToolTipGeneral.SetToolTip(BtnRed, "Slumpa den röda komponenten");
            ToolTipGeneral.SetToolTip(BtnGreen, "Slumpa den gröna komponenten");
            ToolTipGeneral.SetToolTip(BtnBlue, "Slumpa den blå komponenten");
        }

        /// <summary>
        ///  Händelsehanterare för knapptryck som slumpmässigt ändrar den röda RGB-komponenten.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void BtnRed_Click_1(object sender, EventArgs e)
        {
            // Skapar en ny slumpmässig färgkomponent
            var newColor = _generator.Generate();
            // Tar den röda komponenten från den nya färgen
            _currentColor.Red = newColor.Red;
            // Uppdaterar användargränssnittet
            UpdateUI();
        }

        /// <summary>
        ///  Händelsehanterare för knappar som slumpmässigt ändrar den gröna RGB-komponenten.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void BtnGreen_Click_1(object sender, EventArgs e)
        {
            // Skapa en ny färgkomponent
            var newColor = _generator.Generate();
            // Tar den gröna komponenten från den nyskapade färgen
            _currentColor.Green = newColor.Green;
            // Uppdaterar användargränssnittet
            UpdateUI();
        }

        /// <summary>
        ///  Händelsehanterare för knappar som slumpmässigt ändrar den blå RGB-komponenten.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void BtnBlue_Click_1(object sender, EventArgs e)
        {
            // Skapar en ny färgkomponent
            var newColor = _generator.Generate();
            // Tar den blå komponenten från den nyskapade färgen
            _currentColor.Blue = newColor.Blue;
            // Uppdaterar användargränssnittet
            UpdateUI();
        }

        /// <summary>
        /// Hanterar klickhändelsen för knappen som genererar en ny slumpmässig RGB-färg.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Generera en ny slumpmässig RGB-färg
            _currentColor = _generator.Generate();
            // Uppdatera användargränssnittet
            UpdateUI();
        }

        /// <summary>
        /// Hanterar klickhändelsen för knappen som genererar en ny slumpmässig Gråskale-färg.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void buttonGreyScale_Click(object sender, EventArgs e)
        {
            if (radioBtnGreyscale.Checked)
            {
                _greyColor = _greyGenerator.Generate(); // Standard gråskala
            }
            else if (radioBtnFuzzy.Checked)
            {
                _greyColor = _fuzzyGenerator.Generate(); // Alternativ "fuzzy" gråskala
            }
            else if (radioBtnBiasGrey.Checked)
            {
                var biasedGenerator = new BiasedGrayScaleGenerator();
                _greyColor = biasedGenerator.Generate(); // Alternativ "biased" gråskala
            }

            panelGreyscale.BackColor = _greyColor.ToColor();
            //Uppdatera information i UI
            labelGreyScale();
        }

        /// <summary>
        /// Händelsehanterare för reglaget som uppdaterar den röda färgkomponenten.
        /// Hämtar värdet från trackBarRed och tilldelar det till den aktuella färgens röda komponent.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för värdeförändringen.</param>
        private void trackBarRed_ValueChanged(object sender, EventArgs e)
        {
            // Uppdatera den röda komponenten i den aktuella färgen
            _currentColor.Red = trackBarRed.Value;
            UpdateUI();
        }

        /// <summary>
        /// Händelsehanterare för reglaget som uppdaterar den gröns färgkomponenten.
        /// Hämtar värdet från trackBarGreen och tilldelar det till den aktuella färgens röda komponent.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för värdeförändringen.</param>
        private void trackBarGreen_ValueChanged(object sender, EventArgs e)
        {
            // Uppdatera den gröna komponenten i den aktuella färgen    
            _currentColor.Green = trackBarGreen.Value;
            UpdateUI();
        }

        /// <summary>
        /// Händelsehanterare för reglaget som uppdaterar den blå färgkomponenten.
        /// Hämtar värdet från trackBarBlue och tilldelar det till den aktuella färgens röda komponent.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för värdeförändringen.</param>
        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            // Uppdatera den blå komponenten i den aktuella färgen
            _currentColor.Blue = trackBarBlue.Value;
            UpdateUI();
        }

        /// <summary>
        /// Händelsehanterare för textBoxRed som uppdaterar den röda färgkomponenten.
        /// Validerar inmatningen, begränsar värdet till reglagets intervall och uppdaterar färgen.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för textförändringen.</param>
        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            int min = trackBarRed.Minimum;
            int max = trackBarRed.Maximum;
            if (int.TryParse(textBoxRed.Text, out int value))
            {
                // Begränsar värdet till reglagets intervall
                if (value < min) value = min;
                if (value > max) value = max;

                // Sätter värdet för den röda komponenten i den aktuella färgen
                _currentColor.Red = value;
                // Uppdaterar gränssnittet
                UpdateUI();
            }
            else
            {
                // Visar felmeddelande vid ogiltig inmatning
                MessageBox.Show("Endast heltal mellan 0 och 255 är tillåtna.", "Felaktig inmatning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Händelsehanterare för textBoxGreen som uppdaterar den gröna färgkomponenten.
        /// Validerar inmatningen, begränsar värdet till reglagets intervall och uppdaterar färgen.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för textförändringen.</param>
        private void textBoxGreen_TextChanged(object sender, EventArgs e)
        {
            int min = trackBarGreen.Minimum;
            int max = trackBarGreen.Maximum;
            if (int.TryParse(textBoxGreen.Text, out int value))
            {
                // Begränsar värdet till reglagets intervall
                if (value < min) value = min;
                if (value > max) value = max;
                // Uppdaterar värdet för den gröna komponenten i den aktuella färgen
                _currentColor.Green = value;
                // Uppdaterar snvändargränssnittet
                UpdateUI();
            }
            else
            {
                // Visar felmeddelande vid ogiltig inmatning
                MessageBox.Show("Endast heltal mellan 0 och 255 är tillåtna.", "Felaktig inmatning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Händelsehanterare för textBoxBlue som uppdaterar den blå färgkomponenten.
        /// Validerar inmatningen, begränsar värdet till reglagets intervall och uppdaterar färgen.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för textförändringen.</param>
        private void textBoxBlue_TextChanged(object sender, EventArgs e)
        {
            int min = trackBarBlue.Minimum;
            int max = trackBarBlue.Maximum;
            if (int.TryParse(textBoxBlue.Text, out int value))
            {
                // Bebgränsar värde till max/min från reglaget
                if (value < min) value = min;
                if (value > max) value = max;
                // Sätter värdet för den blå komponenten i den aktuella färgen
                _currentColor.Blue = value;
                //Uppdaterar UI gränssnittet
                UpdateUI();
            }
            else
            {
                // Visar felmeddelande vid ogiltig inmatning
                MessageBox.Show("Endast heltal mellan 0 och 255 är tillåtna.", "Felaktig inmatning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Hanterar klickhändelsen för knappen som genererar en ny pastellfärg.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Genererar en ny pastellfärg
            _pastelcolor = _pastelGenerator.Generate();
            // Uppdaterar gränssnittet
            UpdateUI();
        }

        /// <summary>
        /// Hanterar menyhändelsen för kommandot "Avsluta" och stänger programmet.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Avslutar programmet
            Application.Exit();
        }

        /// <summary>
        /// Hanterar klickhändelsen för knappen som sparar aktuell RGB-färg.
        /// Lägger till färgen i listan, sparar hela listan till fil och uppdaterar miniatyrpanelen.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void buttonSaveRGBColor_Click(object sender, EventArgs e)
        {
            _colorStorage.AddColor(_currentColor);      // lägger till aktuell färg till Listan 
            _colorStorage.SaveToFile("colors.json");    // Sparar listan med färger till fil 
            MessageBox.Show($"Färgen {_currentColor} har sparats."); // Meddelar användaren att färgen sparats
            UpdateColorThumbnails();                    // Uppdaterar miniatyrpanelen
        }


        /// <summary>
        /// Hanterar klickhändelsen för knappen som sparar aktuell pastellfärg.
        /// Lägger till färgen i listan, sparar hela listan till fil och uppdaterar miniatyrpanelen.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void buttonSavePastellColor_Click(object sender, EventArgs e)
        {
            _colorStorage.AddColor(_pastelcolor);       // lägger till aktuell pastellfärg till listan
            _colorStorage.SaveToFile("colors.json");    // Sparar lstan med färger till filen colors.json
            MessageBox.Show($"Färgen {_pastelcolor} har sparats."); // Meddelar användaren att färgen har sparats
            UpdateColorThumbnails();                    // Uppdaterar miniatyrpanelen
        }

        /// <summary>
        /// Hanterar klickhändelsen för knappen som sparar aktuell gråskalefärg.
        /// Lägger till färgen i listan, sparar hela listan till fil och uppdaterar miniatyrpanelen.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void buttonSaveGreyColor_Click(object sender, EventArgs e)
        {
            _colorStorage.AddColor(_greyColor);         // Lägger till aktuell gråskalefärg till listan
            _colorStorage.SaveToFile("colors.json");    // Sparar lstan med färger till filen colors.json
            MessageBox.Show($"Färgen {_greyColor} har sparats."); // Meddelar användaren att färgen har sparats
            UpdateColorThumbnails();                    // Uppdaterar miniatyrpanelen
        }

        /// <summary>
        /// Hanterar klickhändelser på sparade miniatyrer av färger
        /// Genererar en kopiering av färgkoden till urklipp
        /// Formatet på färgkoden (hexadecimal eller RGB-sträng) styrs av menyvalet.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void ColorPanel_Click(object sender, EventArgs e)
        {
            if (sender is Panel panel && panel.Tag is ColorModel color) { 
                string kod = ToolStripMenuItemHexCode.Checked ? color.ToHex() : color.ToString();
                Clipboard.SetText(kod);
                MessageBox.Show("Färgkoden är kopierad!", "Kopierat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        // <summary>
        /// Hanterar menyhändelsen för menyvalet "Redigera sparade färger".
        /// Öppnar redigeringsfönstret och kopplar uppdateringshändelsen till miniatyrpanelen.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void redigeraSparadeFärgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Skapar ett nytt redigeringsfönster
            var editColors = new EditColorsForm();
            // Lambda-uttryck som hanterar ColorsUpdated-eventet genom att kalla UpdateColorThumbnails().
            // Kopplar ColorsUpdated-eventet till metoden som uppdaterar miniatyrerna
            editColors.ColorsUpdated += (s, e) => UpdateColorThumbnails();
            // Visar redigeringsfönstret
            editColors.Show();
        }

        /// <summary>
        ///  Hanterar menyvalet "Om Färgkollaren".
        /// Visar en informationsruta med upphovsinformation om applikationen.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste händelsen.</param>
        /// <param name="e">Eventdata för klickhändelsen.</param>
        private void omFärgkollarenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En applikation gjord hösten 2025 i kursen:\nDatateknik GR (A), Programmering i C#.NET DT071G D2401 \nAv Torbjörn Lundberg");
        }

        /// <summary>
        /// Uppdaterar alla färgetiketter i användargränssnittet.
        /// </summary>
        /// <remarks>Etiketterna uppdateras för att visa antingen den hexadecimala representationen 
        /// eller strängrepresentationen i form av RGB-kod av färgerna, beroende på tillståndet för <see cref="ToolStripMenuItemHexCode"/>
        /// checkbox.</remarks>
        private void UpdateAllColorLabels()
        {
            bool visaHex = ToolStripMenuItemHexCode.Checked;

            labelPastel.Text = visaHex ? _pastelcolor.ToHex() : _pastelcolor.ToString();
            labelRGBCode.Text = visaHex ? _currentColor.ToHex() : _currentColor.ToString();
            labelShowGreyscale.Text = visaHex ? _greyColor.ToHex() : _greyColor.ToString();

        }

        /// <summary>
        /// Händelsehanterare för CheckedChanged för Visa färgkod i hexkod menyn.
        /// </summary>
        /// <param name="sender">Den kontroll som utlöste eventet, menyvalet i detta fall.</param>
        /// <param name="e">An <see cref="EventArgs"/> Eventdata för händelsen.</param>
        private void ToolStripMenuItemHexCode_CheckedChanged(object sender, EventArgs e)
        {
            // Uppdaterar alla färgetiketter baserat på det nya tillståndet för kryssrutan
            UpdateAllColorLabels();
            // Sparar inställningen i applikationens inställningar
            Properties.Settings.Default.VisaHexKod = ToolStripMenuItemHexCode.Checked;
            // Sparar inställningen i användarens konfigurationsfil
            Properties.Settings.Default.Save();
        }
    }
}

