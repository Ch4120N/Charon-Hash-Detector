using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.IO;
using System.Diagnostics;
using Charon_Hash_Detector.Core;

namespace Charon_Hash_Detector
{
    public partial class LegalDisclaimer : RadForm
    {
        public LegalDisclaimer()
        {
            InitializeComponent();
            legal_dis.Text = Charon_Hash_Detector.Core.LegalConfig.Legal_disclaimer_content();
        }

        private void bt_Accept_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(Config.TempDIR);
                if (!File.Exists(Config.LegalFile))
                {
                    using (FileStream fs = File.Create(Config.LegalFile))
                    {
                        // Ensures the file is closed immediately after creation
                    }
                }
                this.Enabled = false;
                this.Hide();
                MainWindow MainWIN = new MainWindow();
                MainWIN.Show();
                //this.Close(); // Optional, if you want to close the disclaimer form completely
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_Decline_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void LegalDisclaimer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //this.Hide();
        }

        private void LegalDisclaimer_Shown(object sender, EventArgs e)
        {
            if (Directory.Exists(Config.TempDIR))
            {
                if (File.Exists(Config.LegalFile))
                {
                    this.Opacity = 0;
                    this.Hide();
                    MainWindow MainWIN = new MainWindow();
                    MainWIN.Show();

                }
                else
                {
                    using (FileStream fs = File.Create(Config.LegalFile))
                    {
                        // Ensures the file is closed immediately after creation
                    }
                }
            }
            else
            {
                this.Enabled = true;
                this.Opacity = 100;

            }
        }

        private void LegalDisclaimer_Load(object sender, EventArgs e)
        {

        }
    }
}
