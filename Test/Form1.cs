namespace ColorApp
{
    public partial class Form1 : Form
    {
        private IColorGenerator _generator = new RandomColorGenerator();
        private IColorGenerator _greyGenerator = new GrayScaleGenerator();
        private IColorGenerator _pastelGenerator = new PastelColorGenerator();
        private ColorModel _currentColor;
        private ColorModel _greyColor;
        private ColorModel _pastelcolor;

        public Form1()
        {
            InitializeComponent();

            _currentColor = _generator.Generate();
            _greyColor = _greyGenerator.Generate();
            _pastelcolor = _pastelGenerator.Generate();

            pnlColor.BackColor = _currentColor.ToColor();
            panelGreyscale.BackColor = _greyColor.ToColor();
            panelPastel.BackColor = _pastelcolor.ToColor();

            labelColors();
            labelGreyScale();
            labelPastelColor();
            UpdateUI();
        }


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

        private void setTrackbarValue()
        {
            trackBarRed.Value = _currentColor.Red;
            trackBarGreen.Value = _currentColor.Green;
            trackBarBlue.Value = _currentColor.Blue;
        }


        private void settextBoxRGBValue()
        {
            textBoxRed.Text = _currentColor.Red.ToString();
            textBoxGreen.Text = _currentColor.Green.ToString();
            textBoxBlue.Text = _currentColor.Blue.ToString();
        }

        private void labelColors()
        {
            labelRGBCode.Text = _currentColor.ToString();
        }

        private void labelPastelColor()
        {
            labelPastel.Text = _pastelcolor.ToString();
        }



        private void labelGreyScale()
        {
            labelShowGreyscale.Text = _greyColor.ToString();
        }


        private void UpdatePanelColor()
        {
            pnlColor.BackColor = _currentColor.ToColor();
        }

        private void UpdatePanelPastelColor()
        {
            panelPastel.BackColor = _pastelcolor.ToColor();
        }

        private void BtnRed_Click_1(object sender, EventArgs e)
        {
            // Skapa en ny färg med slumpad röd komponent, behåll övriga
            var newColor = _generator.Generate();
            _currentColor.Red = newColor.Red;
            UpdateUI();
        }

        private void BtnGreen_Click_1(object sender, EventArgs e)
        {
            var newColor = _generator.Generate();
            _currentColor.Green = newColor.Green;
            UpdateUI();
        }

        private void BtnBlue_Click_1(object sender, EventArgs e)
        {
            var newColor = _generator.Generate();
            _currentColor.Blue = newColor.Blue;
            UpdateUI();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            _currentColor = _generator.Generate();
            UpdateUI();
        }

        private void buttonGreyScale_Click(object sender, EventArgs e)
        {
            _greyColor = _greyGenerator.Generate();
            panelGreyscale.BackColor = _greyColor.ToColor();
            labelGreyScale();
        }

        private void trackBarRed_ValueChanged(object sender, EventArgs e)
        {
            _currentColor.Red = trackBarRed.Value;
            UpdateUI();
        }

        private void trackBarGreen_ValueChanged(object sender, EventArgs e)
        {
            _currentColor.Green = trackBarGreen.Value;
            UpdateUI();
        }

        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            _currentColor.Blue = trackBarBlue.Value;
            UpdateUI();
        }

        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            int min = trackBarRed.Minimum;
            int max = trackBarRed.Maximum;
            if (int.TryParse(textBoxRed.Text, out int value))
            {
                if (value < min) value = min;
                if (value > max) value = max;
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
                _currentColor.Blue = value;
                UpdateUI();
            }
            else
            {
                // Felmeddelande utan try-catch
                MessageBox.Show("Endast heltal mellan 0 och 255 är tillåtna.", "Felaktig inmatning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _pastelcolor = _pastelGenerator.Generate();
            UpdateUI();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

