namespace ColorApp
{
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

        // Konstruktor för huvudformuläret. Initierar komponenter och startlogik.
        public Form1()
        {
            InitializeComponent();
            this.Icon = new Icon("favicon.ico");

            this.Load += Form1_Load!;


            _currentColor = _generator.Generate();
            _greyColor = _greyGenerator.Generate();
            _pastelcolor = _pastelGenerator.Generate();

            pnlColor.BackColor = _currentColor.ToColor();
            panelGreyscale.BackColor = _greyColor.ToColor();
            panelPastel.BackColor = _pastelcolor.ToColor();

            _colorStorage = new ColorStorage();

            labelColors();
            labelGreyScale();
            labelPastelColor();
            UpdateUI();
        }

        // Event-handler för formulärets Load-händelse. Utför initialisering innan formuläret visas.
        private void Form1_Load(object sender, EventArgs e)
        {
            _colorStorage.LoadFromFile("colors.json");
            UpdateColorThumbnails(); // 
            InitializeToolTips(); // Tooltip
        }

        // Uppdaterar användargränssnittet med aktuell färginformation och kontroller.
        private void UpdateUI()
        {
            UpdatePanelColor();
            labelColors();
            labelGreyScale();
            UpdatePanelPastelColor();
            labelPastelColor();
            setTrackbarValue();
            settextBoxRGBValue();
        }

        // Synkroniserar trackbar-kontrollerna med den aktuella färgens RGB-värden.
        private void setTrackbarValue()
        {
            trackBarRed.Value = _currentColor.Red;
            trackBarGreen.Value = _currentColor.Green;
            trackBarBlue.Value = _currentColor.Blue;
        }

        // Synkroniserar textBox-kontrollerna med den aktuella färgens RGB-värden.
        private void settextBoxRGBValue()
        {
            textBoxRed.Text = _currentColor.Red.ToString();
            textBoxGreen.Text = _currentColor.Green.ToString();
            textBoxBlue.Text = _currentColor.Blue.ToString();
        }

        // Uppdaterar etiketten med den aktuella färgens RGB-kod.
        private void labelColors()
        {
            labelRGBCode.Text = _currentColor.ToString();
        }

        // Uppdaterar etiketten med den aktuella pastellfärgens RGB-kod.
        private void labelPastelColor()
        {
            labelPastel.Text = _pastelcolor.ToString();
        }

        // Uppdaterar etiketten med den aktuella gråskale-färgens RGB-kod.
        private void labelGreyScale()
        {
            labelShowGreyscale.Text = _greyColor.ToString();
        }

        // Uppdaterar färgpanelen med den aktuella färgen.
        private void UpdatePanelColor()
        {
            pnlColor.BackColor = _currentColor.ToColor();
        }

        // Uppdaterar färgpanelen med den aktuella pastellfärgen.
        private void UpdatePanelPastelColor()
        {
            panelPastel.BackColor = _pastelcolor.ToColor();
        }

        // Uppdaterar panelen med miniatyrer av sparade färger.
        private void UpdateColorThumbnails()
        {
            _colorStorage.LoadFromFile("colors.json");
            flowPanelColors.Controls.Clear();

            foreach (var color in _colorStorage.Colors)
            {
                var panel = new Panel
                {
                    Width = 40,
                    Height = 40,
                    BackColor = color.ToColor(),
                    Margin = new Padding(5),
                    Cursor = Cursors.Hand,
                    Tag = color // spara färgen i Tag för att kunna hämta den vid klick
                };

                // Kopplar en klick-händelse till panelen för varje sparad färg (dynamiskt skapad kontroll)
                panel.Click += ColorPanel_Click;
                toolTipSavedColorsPanel.SetToolTip(panel, $"Klicka på färgen för att kopiera färgkoden till urklipp!");

                flowPanelColors.Controls.Add(panel);
            }
        }

        // Tooltip för formulärens kontroller
        private void InitializeToolTips()
        { 
            ToolTipGeneral.SetToolTip(buttonSaveRGBColor, "Lägg till färgen i paletten");
            ToolTipGeneral.SetToolTip(buttonSavePastellColor, "Lägg till färgen i paletten");
            ToolTipGeneral.SetToolTip(buttonSaveGreyColor, "Lägg till färgen i paletten");
            ToolTipGeneral.SetToolTip(btnGeneratePastel, "Generera en ny pastellfärg");
            ToolTipGeneral.SetToolTip(btnGenerate, "Generera en ny RGB-färg");
            ToolTipGeneral.SetToolTip(buttonGreyScale, "Generera en ny gråskala");
            ToolTipGeneral.SetToolTip(trackBarRed, "Justera den röda komponenten");
            ToolTipGeneral.SetToolTip(trackBarGreen, "Justera den gröna komponenten");
            ToolTipGeneral.SetToolTip(trackBarBlue, "Justera den blå komponenten");

            ToolTipGeneral.SetToolTip(textBoxRed, "Ange ett värde mellan 0 och 255 för den röda komponenten");
            ToolTipGeneral.SetToolTip(textBoxGreen, "Ange ett värde mellan 0 och 255 för den gröna komponenten");
            ToolTipGeneral.SetToolTip(textBoxBlue, "Ange ett värde mellan 0 och 255 för den blå komponenten");

            ToolTipGeneral.SetToolTip(radioBtnGreyscale, "Standard gråskala");
            ToolTipGeneral.SetToolTip(radioBtnFuzzy, "Alternativ \"fuzzy\" gråskala");
            ToolTipGeneral.SetToolTip(radioBtnBiasGrey, "Alternativ \"biased\" gråskala");

            ToolTipGeneral.SetToolTip(BtnRed, "Slumpa den röda komponenten");
            ToolTipGeneral.SetToolTip(BtnGreen, "Slumpa den gröna komponenten");
            ToolTipGeneral.SetToolTip(BtnBlue, "Slumpa den blå komponenten");

        }
        // Händelsehanterare för knappar som slumpmässigt ändrar en RGB-komponent
        private void BtnRed_Click_1(object sender, EventArgs e)
        {
            // Skapa en ny färgkomponent
            var newColor = _generator.Generate();
            // Sätter den nya färgens röda komponent från den nyskapade färgen
            _currentColor.Red = newColor.Red;
            // Uppdaterar användargränssnittet
            UpdateUI();
        }
        
        private void BtnGreen_Click_1(object sender, EventArgs e)
        {
            // Skapa en ny färgkomponent
            var newColor = _generator.Generate();
            // Sätter den nya färgens gröna komponent från den nyskapade färgen
            _currentColor.Green = newColor.Green;
            // Uppdaterar användargränssnittet
            UpdateUI();
        }

        private void BtnBlue_Click_1(object sender, EventArgs e)
        {
            // Skapa en ny färgkomponent
            var newColor = _generator.Generate();
            // Sätter den nya färgens blå komponent från den nyskapade färgen
            _currentColor.Blue = newColor.Blue;
            // Uppdaterar användargränssnittet
            UpdateUI();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Generera en ny slumpmässig RGB-färg
            _currentColor = _generator.Generate();
            // Uppdatera användargränssnittet
            UpdateUI();
        }

        // Rendera gråskalefärg baserat på vald radioknapp
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

        // Händelsehanterare för trackbars för att uppdatera färgkomponenter
        private void trackBarRed_ValueChanged(object sender, EventArgs e)
        {
            // Uppdatera den röda komponenten i den aktuella färgen
            _currentColor.Red = trackBarRed.Value;
            UpdateUI();
        }

        private void trackBarGreen_ValueChanged(object sender, EventArgs e)
        {
            // Uppdatera den gröna komponenten i den aktuella färgen    
            _currentColor.Green = trackBarGreen.Value;
            UpdateUI();
        }

        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            // Uppdatera den blå komponenten i den aktuella färgen
            _currentColor.Blue = trackBarBlue.Value;
            UpdateUI();
        }

        // Händelsehanterare för textBox-kontroller för att uppdatera färgkomponenter med felhantering
        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            int min = trackBarRed.Minimum;
            int max = trackBarRed.Maximum;
            if (int.TryParse(textBoxRed.Text, out int value))
            {
                if (value < min) value = min;
                if (value > max) value = max;
                // Sätter värdet för den röda komponenten i den aktuella färgen
                _currentColor.Red = value;
                UpdateUI();
            }
            else
            {
                // Felmeddelande utan try-catch
                MessageBox.Show("Endast heltal mellan 0 och 255 är tillåtna.", "Felaktig inmatning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxGreen_TextChanged(object sender, EventArgs e)
        {
            int min = trackBarGreen.Minimum;
            int max = trackBarGreen.Maximum;
            if (int.TryParse(textBoxGreen.Text, out int value))
            {
                if (value < min) value = min;
                if (value > max) value = max;
                // Sätter värdet för den gröna komponenten i den aktuella färgen
                _currentColor.Green = value;
                UpdateUI();
            }
            else
            {
                // Felmeddelande utan try-catch
                MessageBox.Show("Endast heltal mellan 0 och 255 är tillåtna.", "Felaktig inmatning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxBlue_TextChanged(object sender, EventArgs e)
        {
            int min = trackBarBlue.Minimum;
            int max = trackBarBlue.Maximum;
            if (int.TryParse(textBoxBlue.Text, out int value))
            {
                if (value < min) value = min;
                if (value > max) value = max;
                // Sätter värdet för den blå komponenten i den aktuella färgen
                _currentColor.Blue = value;
                UpdateUI();
            }
            else
            {
                // Felmeddelande utan try-catch
                MessageBox.Show("Endast heltal mellan 0 och 255 är tillåtna.", "Felaktig inmatning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Händelsehanterare för knapp som genererar ny pastellfärg
        private void button1_Click(object sender, EventArgs e)
        {
            // Generera en ny pastellfärg
            _pastelcolor = _pastelGenerator.Generate();
            UpdateUI();
        }

        // Händelsehanterare för menyvalet "Avsluta" – stänger applikationen
        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Händelsehanterare för menyvalet "Redigera sparade färger" – öppnar redigeringsfönstret
        private void buttonSaveRGBColor_Click(object sender, EventArgs e)
        {
            _colorStorage.AddColor(_currentColor);
            _colorStorage.SaveToFile("colors.json");
            MessageBox.Show($"Färgen {_currentColor} har sparats.");
            UpdateColorThumbnails();
        }

        // Spara pastellfärg
        private void buttonSavePastellColor_Click(object sender, EventArgs e)
        {
            _colorStorage.AddColor(_pastelcolor);
            _colorStorage.SaveToFile("colors.json");
            MessageBox.Show($"Färgen {_pastelcolor} har sparats.");
            UpdateColorThumbnails();
        }

        //  Spara gråskala
        private void buttonSaveGreyColor_Click(object sender, EventArgs e)
        {
            _colorStorage.AddColor(_greyColor);
            _colorStorage.SaveToFile("colors.json");
            MessageBox.Show($"Färgen {_greyColor} har sparats.");
            UpdateColorThumbnails();
        }

        // Klick-händelse för sparade färgpaneler som kopierar färgkoden till urklipp
        private void ColorPanel_Click(object sender, EventArgs e)
        {
            if (sender is Panel panel && panel.Tag is ColorModel color)
            {
                Clipboard.SetText(color.ToString());
                MessageBox.Show("Färgkoden är kopierad!", "Kopierat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Lambda-uttryck som hanterar ColorsUpdated-eventet genom att kalla UpdateColorThumbnails().
        private void redigeraSparadeFärgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editColors = new EditColorsForm();
            editColors.ColorsUpdated += (s, e) => UpdateColorThumbnails(); // Koppla eventet
            editColors.Show();
        }       
    }
}

