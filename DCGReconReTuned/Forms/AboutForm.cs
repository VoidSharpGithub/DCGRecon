using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCGReconReTuned.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    var psi = new ProcessStartInfo
                    {
                        FileName = $"mailto:{linkLabel1.Text}",
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error occurred: " + ex.Message);
                }
            }
            else
            {
                Clipboard.SetText(linkLabel1.Text);
                MessageBox.Show("Email address copied to clipboard.");
            }
        }

        private void Aboutfrm_Load(object sender, EventArgs e)
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assemblyLocation);
            label1.Text = $"DCG Recon v{fileVersionInfo.FileVersion}";
        }
    }
}
