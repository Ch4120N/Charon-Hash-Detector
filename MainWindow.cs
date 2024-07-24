using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Charon_Hash_Detector.Core;
using System.Diagnostics;

namespace Charon_Hash_Detector
{
    public partial class MainWindow : RadForm
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Win32 API to hide caret
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private CharonPlayerSounds.CharonPlayer ch_player = new CharonPlayerSounds.CharonPlayer();

        public MainWindow()
        {
            InitializeComponent();
            SetPanelOpacity(0.7f);
            ResultData.ReadOnly = true;
            ResultData.TabStop = false;
            ResultData.KeyPress += (sender, e) => e.Handled = true;
            ResultData.Enter += (sender, e) => ResultData.Parent.Focus();
            ResultData.Cursor = Cursors.Default;
            //ResultData.GotFocus += (sender, e) => HideCaret(ResultData.Handle);
            //ResultData.LostFocus += (sender, e) => HideCaret(ResultData.Handle);
            //ResultData.TextChanged += (sender, e) => HideCaret(ResultData.Handle);

            //this.Detect_BTN.ButtonElement.EnableElementShadow = false;
            //this.Detect_BTN.ButtonElement.EnableHighlight = false;
            //this.Detect_BTN.ButtonElement.EnableRippleAnimation = false;
            //this.Detect_BTN.ButtonElement.EnableFocusBorder = true;
            //this.Detect_BTN.ButtonElement.EnableBorderHighlight = true;
            this.Detect_BTN.ButtonElement.ButtonFillElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            this.Detect_BTN.ButtonElement.BorderElement.ForeColor = Color.DimGray;
            this.Detect_BTN.ButtonElement.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.Detect_BTN.ButtonElement.BorderElement.ForeColor2 = Color.DimGray;
            this.Detect_BTN.ButtonElement.BorderElement.ForeColor3 = Color.DimGray;
            this.Detect_BTN.ButtonElement.BorderElement.ForeColor4 = Color.DimGray;

        }

        private void close_pic_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20; // Adjust as needed
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(new System.Drawing.Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90);
            path.AddArc(new System.Drawing.Rectangle(this.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), -90, 90);
            path.AddArc(new System.Drawing.Rectangle(this.Width - cornerRadius * 2, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90);
            path.AddArc(new System.Drawing.Rectangle(0, this.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90);
            path.CloseFigure();

            // Apply the rounded rectangle to the form's border
            this.Region = new System.Drawing.Region(path);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            //RoundRectShape roundRectShape = new RoundRectShape();
            //roundRectShape.Radius = 15; // Set the desired corner radius
            //MainPanel.PanelElement.Shape = roundRectShape;

            int cornerRadius = 20; // Adjust as needed
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(new System.Drawing.Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90);
            path.AddArc(new System.Drawing.Rectangle(MainPanel.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), -90, 90);
            path.AddArc(new System.Drawing.Rectangle(MainPanel.Width - cornerRadius * 2, MainPanel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90);
            path.AddArc(new System.Drawing.Rectangle(0, MainPanel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90);
            path.CloseFigure();

            // Apply the rounded rectangle to the form's border
            MainPanel.Region = new System.Drawing.Region(path);
            
        }

        private void SetPanelOpacity(float opacity)
        {
            if (opacity < 0 || opacity > 1)
                throw new ArgumentOutOfRangeException("opacity", "Opacity must be between 0 and 1.");

            Color color = MainPanel.BackColor;
            MainPanel.BackColor = Color.FromArgb((int)(opacity * 255), color.R, color.G, color.B);
        }

        private void AddColoredText(List<object> parts)
        {
            parts.ForEach(part =>
            {
                if (part is Color)
                {
                    ResultData.SelectionColor = (Color)part;
                }
                else if (part is string)
                {
                    ResultData.AppendText((string)part);
                }
            });

            ResultData.SelectionColor = ResultData.ForeColor; // Reset color to default
        }

        private void Detect_BTN_Click(object sender, EventArgs e)
        {
            
             //Properties.Resources.start;
            if (HashTB.Text.Length == 0)
            {
                ch_player.PlaySound(Properties.Resources.error);
                MessageBox.Show("Please enter the desired hash", "ERROR FILL HASH INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ch_player.PlaySound(Properties.Resources.start);
                try
                {
                    Config.jerar.Clear();
                    ResultData.Clear();

                    HashAlgorithms.IdentifyHash(HashTB.Text.ToString());

                    if (Config.jerar.Count == 0)
                    {
                        ch_player.PlaySound(Properties.Resources.error);
                        AddColoredText(new List<object> { Color.DodgerBlue, "[", Color.Red, "-", Color.DodgerBlue, "]", Color.Red, " This Hash Is Not Found/Not Valid" });
                        return;
                        //Console.WriteLine("\n Not Found.");
                    }
                    else if (Config.jerar.Count > 2)
                    {
                        Config.jerar.Sort();
                        AddColoredText(new List<object> { Color.DodgerBlue, "[", Color.LimeGreen, "+", Color.DodgerBlue, "]", Color.LimeGreen, " Possible Hashes:\n\n" });
                        AddColoredText(new List<object> { Color.DodgerBlue, "[", Color.LimeGreen, "+", Color.DodgerBlue, "]", Color.LimeGreen, $" {Config.algorithms[Config.jerar[0]]}\n" });
                        AddColoredText(new List<object> { Color.DodgerBlue, "[", Color.LimeGreen, "+", Color.DodgerBlue, "]", Color.LimeGreen, $" {Config.algorithms[Config.jerar[1]]}\n" });

                        AddColoredText(new List<object> { Color.DodgerBlue, "\n[", Color.Yellow, "!", Color.DodgerBlue, "]", Color.Yellow, " Least Possible Hashes:\n\n" });
                        for (int i = 2; i < Config.jerar.Count; i++)
                        {
                            AddColoredText(new List<object> { Color.DodgerBlue, "[", Color.White, "*", Color.DodgerBlue, "]", Color.White, $" {Config.algorithms[Config.jerar[i]]}\n" });

                        }

                        ch_player.PlaySound(Properties.Resources.done);
                    }
                    else
                    {
                        Config.jerar.Sort();
                        AddColoredText(new List<object> { Color.DodgerBlue, "[", Color.LimeGreen, "+", Color.DodgerBlue, "]", Color.LimeGreen, " Possible Hashes:\n\n" });
                        foreach (var identifier in Config.jerar)
                        {
                            AddColoredText(new List<object> { Color.DodgerBlue, "[", Color.LimeGreen, "+", Color.DodgerBlue, "]", Color.LimeGreen, $" {Config.algorithms[identifier]}\n" });
                        }
                        ch_player.PlaySound(Properties.Resources.done);
                    }
                }
                catch (Exception ex)
                {
                    ch_player.PlaySound(Properties.Resources.error);
                    AddColoredText(new List<object> { Color.DodgerBlue, "[", Color.Red, "-", Color.DodgerBlue, "]", Color.Red, $" Somthing is wrong => {ex.Message}\n" });
                }

            }
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            About_Us ab_us = new About_Us();
            ab_us.Show();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Ch4120N/Charon-Hash-Detector";

            try
            {
                // Start the default browser with the specified URL
                Process.Start(url);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
