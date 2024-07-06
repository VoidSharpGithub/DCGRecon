using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCGRecon.Forms
{
    public partial class RenameReceiverfrm : Form
    {
        public string CurReceiverName;
        public string NewReceiverName;
        public List<string> NameExclusions;
        public RenameReceiverfrm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            NewReceiverName = ReceiverNameTxtbox.Text.Trim();
            if (NewReceiverName == null || NewReceiverName.Length == 0)
            {
                MessageBox.Show("Receiver name cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ReceiverNameTxtbox.Focus();
                return;
            }
            if (NameExclusions.Contains(NewReceiverName))
            {
                MessageBox.Show("A Receiver with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ReceiverNameTxtbox.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void RenameReceiverfrm_Load(object sender, EventArgs e)
        {
            if (CurReceiverName != null)
            {
                ReceiverNameTxtbox.Text = CurReceiverName;
            }
        }
    }
}
