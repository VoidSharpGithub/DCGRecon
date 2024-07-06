using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCGRecon.Classes;

namespace DCGRecon.Forms
{
    public partial class ConfigReceiverListfrm : Form
    {
        public ReconStruct? reconInfo;
        public ConfigReceiverListfrm()
        {
            InitializeComponent();
        }

        private void AddReceiver(string receiverName, string receiverID, string receiverIP)
        {
            ReceiverMgmtDataGridView.Rows.Add(receiverName, receiverID, receiverIP);
        }

        private void EditReceiver(DataGridViewRow row, string receiverName, string receiverID, string receiverIP)
        {
            row.SetValues(receiverName, receiverID, receiverIP, "");
        }

        private void MoveReceiverUp(DataGridViewRow row)
        {
            int rowIndex = row.Index;
            if (rowIndex > 0) // Check if it's not the first row
            {
                DataGridViewRow selectedRow = ReceiverMgmtDataGridView.Rows[rowIndex];
                ReceiverMgmtDataGridView.Rows.Remove(selectedRow);
                ReceiverMgmtDataGridView.Rows.Insert(rowIndex - 1, selectedRow);
                ReceiverMgmtDataGridView.ClearSelection();
                ReceiverMgmtDataGridView.Rows[rowIndex - 1].Selected = true;
            }
        }

        private void MoveReceiverDown(DataGridViewRow row)
        {
            int rowIndex = row.Index;
            if (rowIndex < ReceiverMgmtDataGridView.Rows.Count - 1) // Check if it's not the first row
            {
                DataGridViewRow selectedRow = ReceiverMgmtDataGridView.Rows[rowIndex];
                ReceiverMgmtDataGridView.Rows.Remove(selectedRow);
                ReceiverMgmtDataGridView.Rows.Insert(rowIndex + 1, selectedRow);
                ReceiverMgmtDataGridView.ClearSelection();
                ReceiverMgmtDataGridView.Rows[rowIndex + 1].Selected = true;
            }
        }

        private void AddReceiverBtn_Click(object sender, EventArgs e)
        {
            AddReceiverfrm frm = new AddReceiverfrm();
            frm.NameExclusions = ReceiverMgmtDataGridView.Rows.Cast<DataGridViewRow>().Select(row => row.Cells[0].Value?.ToString()).ToList();
            frm.IDExclusions = ReceiverMgmtDataGridView.Rows.Cast<DataGridViewRow>().Select(row => row.Cells[1].Value?.ToString()).ToList();
            frm.IPExclusions = ReceiverMgmtDataGridView.Rows.Cast<DataGridViewRow>().Select(row => row.Cells[2].Value?.ToString()).ToList();
            if (frm.ShowDialog() == DialogResult.Cancel)
                return;
            AddReceiver(frm.ReceiverName, frm.ReceiverID, frm.ReceiverIP);
        }

        private void EditReceiverBtn_Click(object sender, EventArgs e)
        {
            if (ReceiverMgmtDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = ReceiverMgmtDataGridView.SelectedRows[0];
                AddReceiverfrm frm = new AddReceiverfrm();
                frm.ReceiverName = (string)selectedRow.Cells[0].Value;
                frm.ReceiverID = (string)selectedRow.Cells[1].Value;
                frm.ReceiverIP = (string)selectedRow.Cells[2].Value;
                frm.NameExclusions = ReceiverMgmtDataGridView.Rows.Cast<DataGridViewRow>().Select(row => row.Cells[0].Value?.ToString()).ToList();
                frm.IDExclusions = ReceiverMgmtDataGridView.Rows.Cast<DataGridViewRow>().Select(row => row.Cells[1].Value?.ToString()).ToList();
                frm.IPExclusions = ReceiverMgmtDataGridView.Rows.Cast<DataGridViewRow>().Select(row => row.Cells[2].Value?.ToString()).ToList();
                if (frm.ShowDialog() == DialogResult.Cancel)
                    return;
                EditReceiver(selectedRow, frm.ReceiverName, frm.ReceiverID, frm.ReceiverIP);
            }
            else
            {
                MessageBox.Show("Please select a Receiver before Editting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DeleteReceiverBtn_Click(object sender, EventArgs e)
        {
            if (ReceiverMgmtDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete receiver " + ReceiverMgmtDataGridView.SelectedRows[0].Cells[0].Value + "?", "Delete Receiver", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = ReceiverMgmtDataGridView.SelectedRows[0].Index;
                    ReceiverMgmtDataGridView.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a Receiver before Deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OrderMoveUpBtn_Click(object sender, EventArgs e)
        {
            if (ReceiverMgmtDataGridView.SelectedRows.Count > 0)
            {
                MoveReceiverUp(ReceiverMgmtDataGridView.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Please select a Receiver before Moving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OrderMoveDownBtn_Click(object sender, EventArgs e)
        {
            if (ReceiverMgmtDataGridView.SelectedRows.Count > 0)
            {
                MoveReceiverDown(ReceiverMgmtDataGridView.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Please select a Receiver before Moving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OrderSortBtn_Click(object sender, EventArgs e)
        {
            DataGridViewColumn columnToSortBy = ReceiverMgmtDataGridView.Columns[0];
            ReceiverMgmtDataGridView.Sort(columnToSortBy, ListSortDirection.Ascending);
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if (ReceiverMgmtDataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("Please add a Receover before Exporting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "ReceiverList.cfg";
            saveFileDialog.Filter = "CFG files (*.cfg)|*.cfg|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                JArray ReceiverArray = new JArray();
                foreach (DataGridViewRow row in ReceiverMgmtDataGridView.Rows)
                {
                    JObject ReceiverObject = new JObject
                    {
                        { "Receiver Name", row.Cells[0].Value?.ToString() },
                        { "Receiver ID", row.Cells[1].Value?.ToString() },
                        { "Receiver IP", row.Cells[2].Value?.ToString() }
                    };
                    ReceiverArray.Add(ReceiverObject);
                }
                string json = ReceiverArray.ToString();
                File.WriteAllText(saveFileDialog.FileName, Helper.EncryptString(json));
                MessageBox.Show($"Receiver's have now been exported to \n{saveFileDialog.FileName}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            if (ReceiverMgmtDataGridView.Rows.Count > 0)
            {
                if (MessageBox.Show("Importing a Receiver List will remove all the Receivers in your current configuration.\n\nAre you sure you would like to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CFG files (*.cfg)|*.cfg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1; // Start with the .cfg filter
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string EncryptedJson = File.ReadAllText(openFileDialog.FileName);
                string json = Helper.DecryptString(EncryptedJson);
                try
                {
                    JArray ReceiverArray = JArray.Parse(json);
                    ReceiverMgmtDataGridView.Rows.Clear();
                    foreach (JObject Receiver in ReceiverArray)
                    {
                        ReceiverMgmtDataGridView.Rows.Add(Receiver["Receiver Name"].ToString(), Receiver["Receiver ID"].ToString(), Receiver["Receiver IP"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The file is either currupt or not a valid Receiver Configuration file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                MessageBox.Show($"Receiver's have now been imported from \n{openFileDialog.FileName}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (ReceiverMgmtDataGridView.Rows.Count <= 0)
            {
                ReconStruct ReconInfoCopy = reconInfo.Value;
                List<Receivers> receivers = new List<Receivers>();
                ReconInfoCopy.receivers = receivers;
                reconInfo = ReconInfoCopy;
                DCGReconRegistry.SaveRegistry(ReconInfoCopy);
                Close();
                return;
            }
            if (reconInfo != null && reconInfo.HasValue)
            {
                ReconStruct ReconInfoCopy = reconInfo.Value;
                List<Receivers> receivers = new List<Receivers>();
                foreach (DataGridViewRow row in ReceiverMgmtDataGridView.Rows)
                {
                    receivers.Add(new Receivers { receivername = row.Cells[0].Value.ToString(), receivernumber = row.Cells[1].Value.ToString(), ipaddress = row.Cells[2].Value.ToString() });
                }

                ReconInfoCopy.receivers = receivers;
                reconInfo = ReconInfoCopy;
                DCGReconRegistry.SaveRegistry(ReconInfoCopy);
                Close();
            }
        }

        private async void ConfigReceiverListfrm_Load(object sender, EventArgs e)
        {
            AddReceiverBtn.Enabled = false;
            DeleteReceiverBtn.Enabled = false;
            EditReceiverBtn.Enabled = false;
            OrderMoveDownBtn.Enabled = false;
            OrderMoveUpBtn.Enabled = false;
            OrderSortBtn.Enabled = false;
            ImportBtn.Enabled = false;
            ExportBtn.Enabled = false;
            SaveBtn.Enabled = false;
            ReceiverMgmtDataGridView.Rows.Clear();
            if (reconInfo != null && reconInfo.HasValue)
            {
                List<Receivers> receivers = reconInfo.Value.receivers;
                foreach (Receivers receiver in receivers)
                {
                    string status = await ReconUtilities.IsHostAccessible(receiver.ipaddress) ? "Online" : "Offline";
                    ReceiverMgmtDataGridView.Rows.Add(receiver.receivername, receiver.receivernumber, receiver.ipaddress, status);
                }
            }
            AddReceiverBtn.Enabled = true;
            DeleteReceiverBtn.Enabled = true;
            EditReceiverBtn.Enabled = true;
            OrderMoveDownBtn.Enabled = true;
            OrderMoveUpBtn.Enabled = true;
            OrderSortBtn.Enabled = true;
            ImportBtn.Enabled = true;
            ExportBtn.Enabled = true;
            SaveBtn.Enabled = true;
        }
    }
}
