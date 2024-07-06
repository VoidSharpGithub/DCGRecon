using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCGRecon.Classes;

namespace DCGRecon.Forms
{
    public partial class AddReceiverfrm : Form
    {
        public string ReceiverName;
        public string ReceiverID;
        public string ReceiverIP;
        public List<string> NameExclusions;
        public List<string> IDExclusions;
        public List<string> IPExclusions;
        private bool isEdit = false;
        public AddReceiverfrm()
        {
            InitializeComponent();
        }

        private void ChangeForm(string title, string okbutton)
        {
            Text = title;
            OKBtn.Text = okbutton;
        }

        private void AddReceiverfrm_Load(object sender, EventArgs e)
        {
            if (ReceiverName == null || ReceiverID == null || ReceiverIP == null)
            {
                ChangeForm("Add Receiver", "Add");
            }
            else
            {
                isEdit = true;
                ReceiverNameTxtbox.Text = ReceiverName;
                ReceiverIDTxtbox.Text = ReceiverID;
                ReceiverIPTxtbox.Text = ReceiverIP;
                ChangeForm("Edit Receiver", "Save");
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            ReceiverName = ReceiverNameTxtbox.Text.Trim();
            if (ReceiverName == null || ReceiverName.Length == 0)
            {
                MessageBox.Show("Receiver name cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ReceiverNameTxtbox.Focus();
                return;
            }

            ReceiverID = ReceiverIDTxtbox.Text.Trim().ToUpper();
            if (ReceiverID == null || ReceiverID.Length == 0)
            {
                MessageBox.Show("Receiver ID cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ReceiverIDTxtbox.Focus();
                return;
            }

            if (ReceiverID.Length != 11 || ReceiverID[0] != 'R')
            {
                MessageBox.Show("Receiver ID is invalid!\n Please insure it is in `R0123456789` Format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ReceiverIDTxtbox.Focus();
                return;
            }

            for (int index = 1; index < 10; ++index)
            {
                if (ReceiverID[index] < '0' || ReceiverID[index] > '9')
                {
                    MessageBox.Show("Receiver ID is invalid!\n Please insure it is in `R0123456789` Format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ReceiverIDTxtbox.Focus();
                    return;
                }
            }

            ReceiverIP = ReceiverIPTxtbox.Text.Trim();
            IPAddress ipvalue = (IPAddress)null;
            if (Helper.GetIpAddressValue(ReceiverIP, ref ipvalue) != 0)
            {
                MessageBox.Show("Invalid IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ReceiverIPTxtbox.Focus();
                return;
            }

            if (NameExclusions.Contains(ReceiverName) && IDExclusions.Contains(ReceiverID) && IPExclusions.Contains(ReceiverIP))
            {
                MessageBox.Show("This Receiver already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ReceiverNameTxtbox.Focus();
                if (!isEdit)
                {
                    ReceiverNameTxtbox.Clear();
                    ReceiverIDTxtbox.Clear();
                    ReceiverIPTxtbox.Clear();
                }
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
