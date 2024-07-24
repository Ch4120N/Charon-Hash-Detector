namespace Charon_Hash_Detector
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.close_pic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new Telerik.WinControls.UI.RadPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ResultData = new System.Windows.Forms.RichTextBox();
            this.Detect_BTN = new Telerik.WinControls.UI.RadButton();
            this.HashTB = new Telerik.WinControls.UI.RadTextBox();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.close_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Detect_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HashTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // close_pic
            // 
            this.close_pic.BackColor = System.Drawing.Color.Transparent;
            this.close_pic.BackgroundImage = global::Charon_Hash_Detector.Properties.Resources.cancel_21px;
            this.close_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_pic.Location = new System.Drawing.Point(13, 13);
            this.close_pic.Name = "close_pic";
            this.close_pic.Size = new System.Drawing.Size(21, 21);
            this.close_pic.TabIndex = 0;
            this.close_pic.TabStop = false;
            this.close_pic.Click += new System.EventHandler(this.close_pic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Charon_Hash_Detector.Properties.Resources.minus_21px;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.radGroupBox1);
            this.MainPanel.Controls.Add(this.Detect_BTN);
            this.MainPanel.Controls.Add(this.HashTB);
            this.MainPanel.Location = new System.Drawing.Point(81, 385);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(291, 224);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.ThemeName = "VisualStudio2012Dark";
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ResultData);
            this.radGroupBox1.HeaderText = "Result";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.Location = new System.Drawing.Point(14, 40);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(265, 148);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Result";
            this.radGroupBox1.ThemeName = "Windows8";
            // 
            // ResultData
            // 
            this.ResultData.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.ResultData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ResultData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ResultData.ForeColor = System.Drawing.Color.White;
            this.ResultData.Location = new System.Drawing.Point(6, 21);
            this.ResultData.Name = "ResultData";
            this.ResultData.Size = new System.Drawing.Size(254, 121);
            this.ResultData.TabIndex = 0;
            this.ResultData.Text = "";
            this.ResultData.WordWrap = false;
            // 
            // Detect_BTN
            // 
            this.Detect_BTN.Location = new System.Drawing.Point(52, 194);
            this.Detect_BTN.Name = "Detect_BTN";
            this.Detect_BTN.Size = new System.Drawing.Size(180, 24);
            this.Detect_BTN.TabIndex = 4;
            this.Detect_BTN.Text = "Detect";
            this.Detect_BTN.ThemeName = "FluentDark";
            this.Detect_BTN.Click += new System.EventHandler(this.Detect_BTN_Click);
            // 
            // HashTB
            // 
            this.HashTB.Location = new System.Drawing.Point(14, 10);
            this.HashTB.Name = "HashTB";
            this.HashTB.NullText = "Enter Hash";
            this.HashTB.ShowNullText = true;
            this.HashTB.Size = new System.Drawing.Size(265, 24);
            this.HashTB.TabIndex = 1;
            this.HashTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HashTB.ThemeName = "VisualStudio2012Dark";
            // 
            // radMenu1
            // 
            this.radMenu1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2});
            this.radMenu1.Location = new System.Drawing.Point(0, 632);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(441, 20);
            this.radMenu1.TabIndex = 3;
            this.radMenu1.ThemeName = "VisualStudio2012Dark";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.SvgImageXml = resources.GetString("radMenuItem1.SvgImageXml");
            this.radMenuItem1.Text = "About Us";
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.SvgImageXml = resources.GetString("radMenuItem2.SvgImageXml");
            this.radMenuItem2.Text = "Source Code";
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 652);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close_pic);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Charon Hash Detector";
            this.ThemeName = "VisualStudio2012Dark";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.close_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Detect_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HashTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.PictureBox close_pic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadPanel MainPanel;
        private Telerik.WinControls.UI.RadTextBox HashTB;
        private Telerik.WinControls.UI.RadButton Detect_BTN;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.RichTextBox ResultData;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
    }
}

