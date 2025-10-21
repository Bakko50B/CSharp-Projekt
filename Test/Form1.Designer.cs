namespace ColorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnRed = new Button();
            BtnGreen = new Button();
            BtnBlue = new Button();
            pnlColor = new Panel();
            label1 = new Label();
            btnGenerate = new Button();
            label2 = new Label();
            labelRGBCode = new Label();
            panelGruppMedFärgknappar = new Panel();
            buttonSaveRGBColor = new Button();
            label4 = new Label();
            label3 = new Label();
            textBoxBlue = new TextBox();
            textBoxGreen = new TextBox();
            textBoxRed = new TextBox();
            trackBarBlue = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarRed = new TrackBar();
            label5 = new Label();
            btnGeneratePastel = new Button();
            buttonGreyScale = new Button();
            labelGreyscale = new Label();
            panelGreyscale = new Panel();
            labelShowGreyscale = new Label();
            panelPastel = new Panel();
            labelPastel = new Label();
            lblPastellfärger = new Label();
            lblGråskalefärger = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            avslutaToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            redigeraSparadeFärgerToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemHexCode = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            omFärgkollarenToolStripMenuItem = new ToolStripMenuItem();
            flowPanelColors = new FlowLayoutPanel();
            buttonSavePastellColor = new Button();
            labelSacedColors = new Label();
            groupGreyscale = new GroupBox();
            radioBtnBiasGrey = new RadioButton();
            radioBtnFuzzy = new RadioButton();
            radioBtnGreyscale = new RadioButton();
            buttonSaveGreyColor = new Button();
            toolTipSavedColorsPanel = new ToolTip(components);
            ToolTipGeneral = new ToolTip(components);
            panelGruppMedFärgknappar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            menuStrip1.SuspendLayout();
            groupGreyscale.SuspendLayout();
            SuspendLayout();
            // 
            // BtnRed
            // 
            BtnRed.BackColor = Color.Red;
            BtnRed.ForeColor = Color.Black;
            BtnRed.Location = new Point(746, 237);
            BtnRed.Name = "BtnRed";
            BtnRed.Size = new Size(112, 42);
            BtnRed.TabIndex = 0;
            BtnRed.Text = "Red";
            BtnRed.UseVisualStyleBackColor = false;
            BtnRed.Click += BtnRed_Click_1;
            // 
            // BtnGreen
            // 
            BtnGreen.BackColor = Color.Green;
            BtnGreen.ForeColor = Color.Black;
            BtnGreen.Location = new Point(864, 237);
            BtnGreen.Name = "BtnGreen";
            BtnGreen.Size = new Size(112, 42);
            BtnGreen.TabIndex = 1;
            BtnGreen.Text = "Green";
            BtnGreen.UseVisualStyleBackColor = false;
            BtnGreen.Click += BtnGreen_Click_1;
            // 
            // BtnBlue
            // 
            BtnBlue.BackColor = Color.Blue;
            BtnBlue.ForeColor = Color.White;
            BtnBlue.Location = new Point(982, 237);
            BtnBlue.Name = "BtnBlue";
            BtnBlue.Size = new Size(112, 42);
            BtnBlue.TabIndex = 2;
            BtnBlue.Text = "Blue";
            BtnBlue.UseVisualStyleBackColor = false;
            BtnBlue.Click += BtnBlue_Click_1;
            // 
            // pnlColor
            // 
            pnlColor.Anchor = AnchorStyles.Left;
            pnlColor.Location = new Point(721, 100);
            pnlColor.Name = "pnlColor";
            pnlColor.Size = new Size(395, 90);
            pnlColor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 22);
            label1.Name = "label1";
            label1.Size = new Size(175, 38);
            label1.TabIndex = 4;
            label1.Text = "Standardfärg";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(12, 100);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(238, 42);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Generera RGBfärg!";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(268, 25);
            label2.TabIndex = 6;
            label2.Text = "Slumpa fram komplett RGB-färg";
            // 
            // labelRGBCode
            // 
            labelRGBCode.Anchor = AnchorStyles.Left;
            labelRGBCode.AutoSize = true;
            labelRGBCode.Location = new Point(721, 57);
            labelRGBCode.Margin = new Padding(3, 0, 3, 15);
            labelRGBCode.Name = "labelRGBCode";
            labelRGBCode.Size = new Size(112, 25);
            labelRGBCode.TabIndex = 11;
            labelRGBCode.Text = "RGBfärgkod:";
            // 
            // panelGruppMedFärgknappar
            // 
            panelGruppMedFärgknappar.Controls.Add(buttonSaveRGBColor);
            panelGruppMedFärgknappar.Controls.Add(label4);
            panelGruppMedFärgknappar.Controls.Add(label3);
            panelGruppMedFärgknappar.Controls.Add(textBoxBlue);
            panelGruppMedFärgknappar.Controls.Add(textBoxGreen);
            panelGruppMedFärgknappar.Controls.Add(textBoxRed);
            panelGruppMedFärgknappar.Controls.Add(trackBarBlue);
            panelGruppMedFärgknappar.Controls.Add(trackBarGreen);
            panelGruppMedFärgknappar.Controls.Add(trackBarRed);
            panelGruppMedFärgknappar.Controls.Add(label2);
            panelGruppMedFärgknappar.Controls.Add(btnGenerate);
            panelGruppMedFärgknappar.Controls.Add(label1);
            panelGruppMedFärgknappar.Controls.Add(labelRGBCode);
            panelGruppMedFärgknappar.Controls.Add(BtnBlue);
            panelGruppMedFärgknappar.Controls.Add(pnlColor);
            panelGruppMedFärgknappar.Controls.Add(BtnGreen);
            panelGruppMedFärgknappar.Controls.Add(BtnRed);
            panelGruppMedFärgknappar.Dock = DockStyle.Top;
            panelGruppMedFärgknappar.Location = new Point(0, 33);
            panelGruppMedFärgknappar.Name = "panelGruppMedFärgknappar";
            panelGruppMedFärgknappar.Size = new Size(1139, 305);
            panelGruppMedFärgknappar.TabIndex = 12;
            // 
            // buttonSaveRGBColor
            // 
            buttonSaveRGBColor.Location = new Point(12, 152);
            buttonSaveRGBColor.Name = "buttonSaveRGBColor";
            buttonSaveRGBColor.Size = new Size(238, 34);
            buttonSaveRGBColor.TabIndex = 17;
            buttonSaveRGBColor.Text = "Spara färg";
            buttonSaveRGBColor.UseVisualStyleBackColor = true;
            buttonSaveRGBColor.Click += buttonSaveRGBColor_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 66);
            label4.Name = "label4";
            label4.Size = new Size(264, 25);
            label4.TabIndex = 16;
            label4.Text = "Styr Röd Grön och Blå av färgen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(746, 203);
            label3.Name = "label3";
            label3.Size = new Size(331, 25);
            label3.TabIndex = 15;
            label3.Text = "Slumpa fram del av färg i RGB-modellen";
            // 
            // textBoxBlue
            // 
            textBoxBlue.Location = new Point(590, 230);
            textBoxBlue.Name = "textBoxBlue";
            textBoxBlue.Size = new Size(95, 31);
            textBoxBlue.TabIndex = 14;
            textBoxBlue.TextChanged += textBoxBlue_TextChanged;
            // 
            // textBoxGreen
            // 
            textBoxGreen.Location = new Point(590, 174);
            textBoxGreen.Name = "textBoxGreen";
            textBoxGreen.Size = new Size(95, 31);
            textBoxGreen.TabIndex = 13;
            textBoxGreen.TextChanged += textBoxGreen_TextChanged;
            // 
            // textBoxRed
            // 
            textBoxRed.Location = new Point(590, 112);
            textBoxRed.Name = "textBoxRed";
            textBoxRed.Size = new Size(95, 31);
            textBoxRed.TabIndex = 12;
            textBoxRed.TextChanged += textBoxRed_TextChanged;
            // 
            // trackBarBlue
            // 
            trackBarBlue.BackColor = Color.Blue;
            trackBarBlue.Location = new Point(369, 211);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(215, 69);
            trackBarBlue.TabIndex = 11;
            trackBarBlue.ValueChanged += trackBarBlue_ValueChanged;
            // 
            // trackBarGreen
            // 
            trackBarGreen.BackColor = Color.Green;
            trackBarGreen.Location = new Point(369, 157);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(215, 69);
            trackBarGreen.TabIndex = 10;
            trackBarGreen.ValueChanged += trackBarGreen_ValueChanged;
            // 
            // trackBarRed
            // 
            trackBarRed.BackColor = Color.Red;
            trackBarRed.Location = new Point(369, 100);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(215, 69);
            trackBarRed.TabIndex = 9;
            trackBarRed.ValueChanged += trackBarRed_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 406);
            label5.Name = "label5";
            label5.Size = new Size(279, 25);
            label5.TabIndex = 18;
            label5.Text = "Slumpa fram komplett pastellfärg";
            // 
            // btnGeneratePastel
            // 
            btnGeneratePastel.Location = new Point(12, 443);
            btnGeneratePastel.Name = "btnGeneratePastel";
            btnGeneratePastel.Size = new Size(238, 42);
            btnGeneratePastel.TabIndex = 17;
            btnGeneratePastel.Text = "Generera pastellfärg!";
            btnGeneratePastel.UseVisualStyleBackColor = true;
            btnGeneratePastel.Click += button1_Click;
            // 
            // buttonGreyScale
            // 
            buttonGreyScale.Location = new Point(12, 624);
            buttonGreyScale.Name = "buttonGreyScale";
            buttonGreyScale.Size = new Size(238, 42);
            buttonGreyScale.TabIndex = 8;
            buttonGreyScale.Text = "Generera gråskala!";
            buttonGreyScale.UseVisualStyleBackColor = true;
            buttonGreyScale.Click += buttonGreyScale_Click;
            // 
            // labelGreyscale
            // 
            labelGreyscale.AutoSize = true;
            labelGreyscale.Location = new Point(12, 596);
            labelGreyscale.Name = "labelGreyscale";
            labelGreyscale.Size = new Size(200, 25);
            labelGreyscale.TabIndex = 7;
            labelGreyscale.Text = "Slumpa fram ny gråton.";
            // 
            // panelGreyscale
            // 
            panelGreyscale.Anchor = AnchorStyles.Left;
            panelGreyscale.Location = new Point(720, 632);
            panelGreyscale.Name = "panelGreyscale";
            panelGreyscale.Size = new Size(395, 89);
            panelGreyscale.TabIndex = 13;
            // 
            // labelShowGreyscale
            // 
            labelShowGreyscale.Anchor = AnchorStyles.Left;
            labelShowGreyscale.AutoSize = true;
            labelShowGreyscale.Location = new Point(720, 589);
            labelShowGreyscale.Margin = new Padding(3, 0, 3, 15);
            labelShowGreyscale.Name = "labelShowGreyscale";
            labelShowGreyscale.Size = new Size(145, 25);
            labelShowGreyscale.TabIndex = 14;
            labelShowGreyscale.Text = "Gråskalefärgkod:";
            // 
            // panelPastel
            // 
            panelPastel.Anchor = AnchorStyles.Left;
            panelPastel.Location = new Point(718, 446);
            panelPastel.Name = "panelPastel";
            panelPastel.Size = new Size(395, 90);
            panelPastel.TabIndex = 5;
            // 
            // labelPastel
            // 
            labelPastel.Anchor = AnchorStyles.Left;
            labelPastel.AutoSize = true;
            labelPastel.Location = new Point(718, 403);
            labelPastel.Margin = new Padding(3, 0, 3, 15);
            labelPastel.Name = "labelPastel";
            labelPastel.Size = new Size(112, 25);
            labelPastel.TabIndex = 15;
            labelPastel.Text = "RGBfärgkod:";
            // 
            // lblPastellfärger
            // 
            lblPastellfärger.AutoSize = true;
            lblPastellfärger.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPastellfärger.Location = new Point(12, 366);
            lblPastellfärger.Name = "lblPastellfärger";
            lblPastellfärger.Size = new Size(145, 38);
            lblPastellfärger.TabIndex = 17;
            lblPastellfärger.Text = "Pastellfärg";
            // 
            // lblGråskalefärger
            // 
            lblGråskalefärger.AutoSize = true;
            lblGråskalefärger.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGråskalefärger.Location = new Point(12, 547);
            lblGråskalefärger.Name = "lblGråskalefärger";
            lblGråskalefärger.Size = new Size(171, 38);
            lblGråskalefärger.TabIndex = 18;
            lblGråskalefärger.Text = "Gråskalefärg";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1139, 33);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { avslutaToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // avslutaToolStripMenuItem
            // 
            avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            avslutaToolStripMenuItem.Size = new Size(172, 34);
            avslutaToolStripMenuItem.Text = "Avsluta";
            avslutaToolStripMenuItem.Click += avslutaToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redigeraSparadeFärgerToolStripMenuItem, ToolStripMenuItemHexCode });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // redigeraSparadeFärgerToolStripMenuItem
            // 
            redigeraSparadeFärgerToolStripMenuItem.Name = "redigeraSparadeFärgerToolStripMenuItem";
            redigeraSparadeFärgerToolStripMenuItem.Size = new Size(303, 34);
            redigeraSparadeFärgerToolStripMenuItem.Text = "Redigera sparade färger";
            redigeraSparadeFärgerToolStripMenuItem.Click += redigeraSparadeFärgerToolStripMenuItem_Click;
            // 
            // ToolStripMenuItemHexCode
            // 
            ToolStripMenuItemHexCode.CheckOnClick = true;
            ToolStripMenuItemHexCode.Name = "ToolStripMenuItemHexCode";
            ToolStripMenuItemHexCode.Size = new Size(303, 34);
            ToolStripMenuItemHexCode.Text = "Visa färgkod i hexkod";
            ToolStripMenuItemHexCode.CheckedChanged += ToolStripMenuItemHexCode_CheckedChanged;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { omFärgkollarenToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(58, 29);
            helpToolStripMenuItem.Text = "Om";
            // 
            // omFärgkollarenToolStripMenuItem
            // 
            omFärgkollarenToolStripMenuItem.Name = "omFärgkollarenToolStripMenuItem";
            omFärgkollarenToolStripMenuItem.Size = new Size(243, 34);
            omFärgkollarenToolStripMenuItem.Text = "Om färgkollaren";
            omFärgkollarenToolStripMenuItem.Click += omFärgkollarenToolStripMenuItem_Click;
            // 
            // flowPanelColors
            // 
            flowPanelColors.Location = new Point(12, 822);
            flowPanelColors.Name = "flowPanelColors";
            flowPanelColors.Size = new Size(1104, 123);
            flowPanelColors.TabIndex = 20;
            toolTipSavedColorsPanel.SetToolTip(flowPanelColors, "Klicka på färgen för att kopiera färgkoden till urklipp!");
            // 
            // buttonSavePastellColor
            // 
            buttonSavePastellColor.Location = new Point(12, 491);
            buttonSavePastellColor.Name = "buttonSavePastellColor";
            buttonSavePastellColor.Size = new Size(238, 34);
            buttonSavePastellColor.TabIndex = 18;
            buttonSavePastellColor.Text = "Spara färg";
            buttonSavePastellColor.UseVisualStyleBackColor = true;
            buttonSavePastellColor.Click += buttonSavePastellColor_Click;
            // 
            // labelSacedColors
            // 
            labelSacedColors.AutoSize = true;
            labelSacedColors.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSacedColors.Location = new Point(12, 781);
            labelSacedColors.Name = "labelSacedColors";
            labelSacedColors.Size = new Size(199, 38);
            labelSacedColors.TabIndex = 21;
            labelSacedColors.Text = "Sparade färger";
            // 
            // groupGreyscale
            // 
            groupGreyscale.Controls.Add(radioBtnBiasGrey);
            groupGreyscale.Controls.Add(radioBtnFuzzy);
            groupGreyscale.Controls.Add(radioBtnGreyscale);
            groupGreyscale.Location = new Point(343, 596);
            groupGreyscale.Name = "groupGreyscale";
            groupGreyscale.Size = new Size(300, 160);
            groupGreyscale.TabIndex = 22;
            groupGreyscale.TabStop = false;
            groupGreyscale.Text = "Renderingsalternativ";
            // 
            // radioBtnBiasGrey
            // 
            radioBtnBiasGrey.AutoSize = true;
            radioBtnBiasGrey.Location = new Point(15, 119);
            radioBtnBiasGrey.Name = "radioBtnBiasGrey";
            radioBtnBiasGrey.Size = new Size(132, 29);
            radioBtnBiasGrey.TabIndex = 2;
            radioBtnBiasGrey.TabStop = true;
            radioBtnBiasGrey.Text = "Färgtonsgrå";
            radioBtnBiasGrey.UseVisualStyleBackColor = true;
            // 
            // radioBtnFuzzy
            // 
            radioBtnFuzzy.AutoSize = true;
            radioBtnFuzzy.Location = new Point(14, 76);
            radioBtnFuzzy.Name = "radioBtnFuzzy";
            radioBtnFuzzy.Size = new Size(119, 29);
            radioBtnFuzzy.TabIndex = 1;
            radioBtnFuzzy.Text = "Fuzzygrått";
            radioBtnFuzzy.UseVisualStyleBackColor = true;
            // 
            // radioBtnGreyscale
            // 
            radioBtnGreyscale.AutoSize = true;
            radioBtnGreyscale.Checked = true;
            radioBtnGreyscale.Location = new Point(14, 36);
            radioBtnGreyscale.Name = "radioBtnGreyscale";
            radioBtnGreyscale.Size = new Size(108, 29);
            radioBtnGreyscale.TabIndex = 0;
            radioBtnGreyscale.TabStop = true;
            radioBtnGreyscale.Text = "Standard";
            radioBtnGreyscale.UseVisualStyleBackColor = true;
            // 
            // buttonSaveGreyColor
            // 
            buttonSaveGreyColor.Location = new Point(12, 674);
            buttonSaveGreyColor.Name = "buttonSaveGreyColor";
            buttonSaveGreyColor.Size = new Size(238, 34);
            buttonSaveGreyColor.TabIndex = 23;
            buttonSaveGreyColor.Text = "Spara färg";
            buttonSaveGreyColor.UseVisualStyleBackColor = true;
            buttonSaveGreyColor.Click += buttonSaveGreyColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 994);
            Controls.Add(buttonSaveGreyColor);
            Controls.Add(groupGreyscale);
            Controls.Add(labelSacedColors);
            Controls.Add(buttonSavePastellColor);
            Controls.Add(flowPanelColors);
            Controls.Add(label5);
            Controls.Add(btnGeneratePastel);
            Controls.Add(lblGråskalefärger);
            Controls.Add(lblPastellfärger);
            Controls.Add(labelPastel);
            Controls.Add(panelPastel);
            Controls.Add(labelShowGreyscale);
            Controls.Add(buttonGreyScale);
            Controls.Add(labelGreyscale);
            Controls.Add(panelGreyscale);
            Controls.Add(panelGruppMedFärgknappar);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1161, 1050);
            MinimizeBox = false;
            MinimumSize = new Size(1161, 1050);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Färgkollaren";
            panelGruppMedFärgknappar.ResumeLayout(false);
            panelGruppMedFärgknappar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupGreyscale.ResumeLayout(false);
            groupGreyscale.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRed;
        private Button BtnGreen;
        private Button BtnBlue;
        private Panel pnlColor;
        private Label label1;
        private Button btnGenerate;
        private Label label2;
        private Label labelRGBCode;
        private Panel panelGruppMedFärgknappar;
        private Button buttonGreyScale;
        private Label labelGreyscale;
        private Panel panelGreyscale;
        private Label labelShowGreyscale;
        private TrackBar trackBarRed;
        private TrackBar trackBarBlue;
        private TrackBar trackBarGreen;
        private TextBox textBoxBlue;
        private TextBox textBoxGreen;
        private TextBox textBoxRed;
        private Panel panelPastel;
        private Label labelPastel;
        private Label lblPastellfärger;
        private Label lblGråskalefärger;
        private Label label3;
        private Label label5;
        private Button btnGeneratePastel;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem avslutaToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button buttonSaveRGBColor;
        private FlowLayoutPanel flowPanelColors;
        private Button buttonSavePastellColor;
        private Label labelSacedColors;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem redigeraSparadeFärgerToolStripMenuItem;
        private GroupBox groupGreyscale;
        private RadioButton radioBtnGreyscale;
        private RadioButton radioBtnFuzzy;
        private Button buttonSaveGreyColor;
        private RadioButton radioBtnBiasGrey;
        private ToolTip toolTipSavedColorsPanel;
        private ToolTip ToolTipGeneral;
        private ToolStripMenuItem omFärgkollarenToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemHexCode;
    }
}
