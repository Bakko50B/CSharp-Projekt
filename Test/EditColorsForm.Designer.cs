namespace ColorApp
{
    partial class EditColorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowPanelColorList = new FlowLayoutPanel();
            btnDeleteSelected = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // flowPanelColorList
            // 
            flowPanelColorList.AutoScroll = true;
            flowPanelColorList.Dock = DockStyle.Top;
            flowPanelColorList.FlowDirection = FlowDirection.TopDown;
            flowPanelColorList.Location = new Point(0, 0);
            flowPanelColorList.Name = "flowPanelColorList";
            flowPanelColorList.Size = new Size(800, 385);
            flowPanelColorList.TabIndex = 0;
            flowPanelColorList.WrapContents = false;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.Location = new Point(97, 391);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(216, 47);
            btnDeleteSelected.TabIndex = 1;
            btnDeleteSelected.Text = "Radera markerade";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(442, 391);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(216, 47);
            btnClose.TabIndex = 2;
            btnClose.Text = "Stäng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // EditColorsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteSelected);
            Controls.Add(flowPanelColorList);
            Name = "EditColorsForm";
            Text = "EditColorsForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanelColorList;
        private Button btnDeleteSelected;
        private Button btnClose;
    }
}