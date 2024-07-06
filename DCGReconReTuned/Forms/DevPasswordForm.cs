using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCGReconReTuned.Forms
{
    public partial class DevPasswordForm : Form
    {
        public DevPasswordForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "R3C0NT007Z") 
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Password, try again");
                PasswordTextbox.Clear();
                PasswordTextbox.Focus();
            }
        }
    }
}
