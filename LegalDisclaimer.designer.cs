namespace Charon_Hash_Detector
{
    partial class LegalDisclaimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LegalDisclaimer));
            this.visualStudio2022DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.bt_Decline = new Telerik.WinControls.UI.RadButton();
            this.bt_Accept = new Telerik.WinControls.UI.RadButton();
            this.legal_dis = new System.Windows.Forms.RichTextBox();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Decline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Accept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Decline
            // 
            this.bt_Decline.Location = new System.Drawing.Point(133, 193);
            this.bt_Decline.Name = "bt_Decline";
            this.bt_Decline.Size = new System.Drawing.Size(110, 24);
            this.bt_Decline.SvgImageXml = resources.GetString("bt_Decline.SvgImageXml");
            this.bt_Decline.TabIndex = 5;
            this.bt_Decline.Text = "I Decline";
            this.bt_Decline.ThemeName = "FluentDark";
            this.bt_Decline.Click += new System.EventHandler(this.bt_Decline_Click);
            // 
            // bt_Accept
            // 
            this.bt_Accept.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bt_Accept.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Accept.Location = new System.Drawing.Point(6, 193);
            this.bt_Accept.Name = "bt_Accept";
            this.bt_Accept.Size = new System.Drawing.Size(113, 24);
            this.bt_Accept.SvgImageXml = resources.GetString("bt_Accept.SvgImageXml");
            this.bt_Accept.TabIndex = 4;
            this.bt_Accept.Text = "I Accept";
            this.bt_Accept.ThemeName = "FluentDark";
            this.bt_Accept.Click += new System.EventHandler(this.bt_Accept_Click);
            // 
            // legal_dis
            // 
            this.legal_dis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.legal_dis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.legal_dis.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.legal_dis.Location = new System.Drawing.Point(6, 12);
            this.legal_dis.Name = "legal_dis";
            this.legal_dis.ReadOnly = true;
            this.legal_dis.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.legal_dis.Size = new System.Drawing.Size(548, 175);
            this.legal_dis.TabIndex = 3;
            this.legal_dis.Text = "";
            // 
            // LegalDisclaimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 228);
            this.Controls.Add(this.bt_Decline);
            this.Controls.Add(this.bt_Accept);
            this.Controls.Add(this.legal_dis);
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(568, 258);
            this.MinimumSize = new System.Drawing.Size(568, 258);
            this.Name = "LegalDisclaimer";
            this.Opacity = 0D;
            // 
            // 
            // 
            this.RootElement.ShouldPaint = false;
            this.RootElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LegalDisclaimer";
            this.ThemeName = "VisualStudio2012Dark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LegalDisclaimer_FormClosing);
            this.Load += new System.EventHandler(this.LegalDisclaimer_Load);
            this.Shown += new System.EventHandler(this.LegalDisclaimer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bt_Decline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Accept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2022DarkTheme1;
        private Telerik.WinControls.UI.RadButton bt_Decline;
        private Telerik.WinControls.UI.RadButton bt_Accept;
        private System.Windows.Forms.RichTextBox legal_dis;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
    }
}