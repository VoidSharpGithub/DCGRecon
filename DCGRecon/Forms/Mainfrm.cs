using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using DCGRecon.Classes;
using DCGRecon.Forms;
using DCGRecon.Recon;

namespace DCGRecon
{
    public partial class Mainfrm : Form
    {
        private ReconStruct reconInfo = new ReconStruct();
        private Dictionary<int, string> ActiveChannels = new Dictionary<int, string>();
        public Mainfrm()
        {
            InitializeComponent();
        }
        #region Custom Methods
        private bool GetChannel(int tuner, out int channel)
        {
            if (int.TryParse(tuner == 0 ? T1_ChannelTxtbox.Text : this.T2_ChannelTxtbox.Text, out channel))
                return true;
            MessageBox.Show("Invalid channel enetered.", "Set Channel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (tuner == 0)
            {
                T1_ChannelTxtbox.SelectAll();
                T1_ChannelTxtbox.Focus();
            }
            else
            {
                T2_ChannelTxtbox.SelectAll();
                T2_ChannelTxtbox.Focus();
            }
            return false;
        }
        private void RefreshReceiverList()
        {
            ReceiverDataGridView.Rows.Clear();
            foreach (Receivers receiver in reconInfo.receivers)
            {
                ReceiverDataGridView.Rows.Add(receiver.receivername, receiver.receivernumber);
            }
            DCGReconRegistry.SaveRegistry(reconInfo);
            ReconUtilities.SetReceiverUpdates(reconInfo);
        }
        private async Task RefreshVisualReceiver()
        {
            if (ReceiverDataGridView.SelectedRows.Count <= 0)
            {
                ReceiverGroupBox.Visible = false;
                this.Size = new Size(280, 489);
                return;
            }
            await Task.Delay(150);
            Receivers Receiver = reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index];
            string IPAddress = Receiver.ipaddress;
            if (await ReconUtilities.CheckReceiverConnection(IPAddress))
            {
                //Receiver Specific
                ReceiverGroupBox.Text = ReceiverDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                ReceiverIDInputLbl.Text = ReceiverDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                ReceiverIPInputLbl.Text = IPAddress;
                DateTime? Updates = await ReconUtilities.GetReceiverUpdates(IPAddress);
                if (!Updates.HasValue || Updates == null)
                    ReceiverUpdatesInputLbl.Text = "Disabled";
                else
                    ReceiverUpdatesInputLbl.Text = $"Enabled {Updates.Value.ToString("hh:mmtt").ToLower()}";
                ReceiverModelInputLbl.Text = await ReconUtilities.GetReceiverModel(IPAddress);
                ReceiverVersionInputLbl.Text = await ReconUtilities.GetReceiverSoftwareVersion(IPAddress);

                //Tuner Specific
                if (await ReconUtilities.GetTunerAVStatus(IPAddress, 0) == 1)
                {
                    T1_SetChannelBtn.Enabled = true;
                    T1_StandbyBtn.Enabled = true;
                    T1_StandbyBtn.Text = "Standby";
                    T1_ChannelTxtbox.Enabled = true;
                    T1_ChannelLbl.Text = $"Channel: {await ReconUtilities.GetTunerChannel(IPAddress, 0)}";
                    T1_TitleLbl.Text = $"Title: {await ReconUtilities.GetChannelName(IPAddress, 0)}";
                    T1_DescLbl.Text = $"Event: {await ReconUtilities.GetChannelDesc(IPAddress, 0)}";
                    T1_TimeLbl.Text = $"Schedule: {await SimulcastUtilities.GetSimulcastSchedule(await ReconUtilities.GetTunerChannel(IPAddress, 0), await ReconUtilities.GetChannelName(IPAddress, 0))}";
                }
                else
                {
                    T1_SetChannelBtn.Enabled = false;
                    T1_StandbyBtn.Enabled = true;
                    T1_StandbyBtn.Text = "Wake Up";
                    T1_ChannelTxtbox.Enabled = false;
                    T1_ChannelLbl.Text = $"Channel: Standby";
                    T1_TitleLbl.Text = $"Title: Standby";
                    T1_DescLbl.Text = $"Event: Standby";
                    T1_TimeLbl.Text = $"Schedule: Standby";
                }
                if (await ReconUtilities.GetTunerAVStatus(IPAddress, 1) == 1)
                {
                    T2_SetChannelBtn.Enabled = true;
                    T2_StandbyBtn.Enabled = true;
                    T2_StandbyBtn.Text = "Standby";
                    T2_ChannelTxtbox.Enabled = true;
                    T2_ChannelLbl.Text = $"Channel: {await ReconUtilities.GetTunerChannel(IPAddress, 1)}";
                    T2_TitleLbl.Text = $"Title: {await ReconUtilities.GetChannelName(IPAddress, 1)}";
                    T2_DescLbl.Text = $"Event: {await ReconUtilities.GetChannelDesc(IPAddress, 1)}";
                    T2_TimeLbl.Text = $"Schedule: {await SimulcastUtilities.GetSimulcastSchedule(await ReconUtilities.GetTunerChannel(IPAddress, 1), await ReconUtilities.GetChannelName(IPAddress, 1))}";
                }
                else
                {
                    T2_SetChannelBtn.Enabled = false;
                    T2_StandbyBtn.Enabled = true;
                    T2_StandbyBtn.Text = "Wake Up";
                    T2_ChannelTxtbox.Enabled = false;
                    T2_ChannelLbl.Text = $"Channel: Standby";
                    T2_TitleLbl.Text = $"Title: Standby";
                    T2_DescLbl.Text = $"Event: Standby";
                    T2_TimeLbl.Text = $"Schedule: Standby";
                }

            }
            else
            {
                if (ReceiverDataGridView.SelectedRows.Count <= 0)
                {
                    ReceiverGroupBox.Text = "Unknown Receiver";
                    ReceiverIDInputLbl.Text = "Unknown";
                }
                else
                {
                    ReceiverGroupBox.Text = ReceiverDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    ReceiverIDInputLbl.Text = ReceiverDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                }
                ReceiverIPInputLbl.Text = IPAddress;
                ReceiverUpdatesInputLbl.Text = "Network Error";
                ReceiverModelInputLbl.Text = "Network Error";
                ReceiverVersionInputLbl.Text = "Network Error";

                T1_SetChannelBtn.Enabled = false;
                T2_SetChannelBtn.Enabled = false;
                T1_StandbyBtn.Enabled = false;
                T2_StandbyBtn.Enabled = false;
                T1_ChannelTxtbox.Enabled = false;
                T2_ChannelTxtbox.Enabled = false;

                T1_ChannelLbl.Text = $"Channel: Unknown";
                T2_ChannelLbl.Text = $"Channel: Unknown";
                T1_TitleLbl.Text = $"Title: Unknown";
                T2_TitleLbl.Text = $"Title: Unknown";
                T1_DescLbl.Text = $"Event: Unknown";
                T2_DescLbl.Text = $"Event: Unknown";

            }
            ReceiverGroupBox.Visible = true;
            this.Size = new Size(1000, 489);
        }
        #endregion
        #region Click Events
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CRLMenuItem_Click(object sender, EventArgs e)
        {
            ConfigReceiverListfrm frm = new ConfigReceiverListfrm();
            frm.reconInfo = reconInfo;
            if (frm.ShowDialog(this) != DialogResult.Cancel)
            {
                this.reconInfo = (ReconStruct)frm.reconInfo;
                this.RefreshReceiverList();
            }
        }
        private void OptionsMenuItem_Click(object sender, EventArgs e)
        {
            Optionsfrm frm = new Optionsfrm();
            frm.reconInfo = reconInfo;
            if (frm.ShowDialog(this) != DialogResult.Cancel)
            {
                reconInfo = (ReconStruct)frm.reconInfo;
                this.RefreshReceiverList();
            }
        }
        private void CheckUpdatesMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CheckUpdatesfrm();
            frm.ShowDialog(this);
        }
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Aboutfrm();
            frm.ShowDialog(this);
        }
        private void SetUpdatesBtn_Click(object sender, EventArgs e)
        {
            Optionsfrm frm = new Optionsfrm();
            frm.reconInfo = reconInfo;
            if (frm.ShowDialog(this) != DialogResult.Cancel)
            {
                reconInfo = (ReconStruct)frm.reconInfo;
                this.RefreshReceiverList();
            }
        }
        private void T1_StandbyBtn_Click(object sender, EventArgs e)
        {
            if (this.T1_StandbyBtn.Text != "Wake Up" && MessageBox.Show("Are you sure you want to put `Tuner 1` into Standby?", "Standby Tuner", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            ReconUtilities.WakeUpTuner(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, 0, this.T1_StandbyBtn.Text == "Wake Up");
            RefreshVisualReceiver();
        }
        private void T2_StandbyBtn_Click(object sender, EventArgs e)
        {
            if (this.T2_StandbyBtn.Text != "Wake Up" && MessageBox.Show("Are you sure you want to put `Tuner 2` into Standby?", "Standby Tuner", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            ReconUtilities.WakeUpTuner(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, 0, this.T2_StandbyBtn.Text == "Wake Up");
        }
        private void RenameReceiverMenuItem_Click(object sender, EventArgs e)
        {
            RenameReceiverfrm frm = new RenameReceiverfrm();
            frm.CurReceiverName = ReceiverDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            frm.NameExclusions = ReceiverDataGridView.Rows.Cast<DataGridViewRow>().Select(row => row.Cells[0].Value?.ToString()).ToList();
            if (frm.ShowDialog(this) != DialogResult.Cancel)
            {
                ReconStruct TempStruct = reconInfo;
                List<Receivers> Receiverss = TempStruct.receivers;
                Receivers Receiver = Receiverss.ElementAt(ReceiverDataGridView.SelectedRows[0].Index);
                Receiver.receivername = frm.NewReceiverName;
                Receiverss[ReceiverDataGridView.SelectedRows[0].Index] = Receiver;
                TempStruct.receivers = Receiverss;
                reconInfo = TempStruct;
                this.RefreshReceiverList();
            }
        }
        private async void T1_SetChannelBtn_Click(object sender, EventArgs e)
        {
            T1_SetChannelBtn.Enabled = false;
            T1_StandbyBtn.Enabled = false;
            T1_ChannelTxtbox.Enabled = false;
            string ipaddress = reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress;
            int channel;
            if (this.GetChannel(0, out channel))
            {
                int statusCode = await ReconUtilities.ChangeChannel(ipaddress, 0, channel);
                if (statusCode == -1)
                {
                    T1_SetChannelBtn.Enabled = true;
                    T1_StandbyBtn.Enabled = true;
                    T1_ChannelTxtbox.Enabled = true;
                    MessageBox.Show("Failed to set channel. Channel does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (statusCode == -2)
                {
                    T1_SetChannelBtn.Enabled = true;
                    T1_StandbyBtn.Enabled = true;
                    T1_ChannelTxtbox.Enabled = true;
                    MessageBox.Show("Failed to set channel. Most likely reason is not currently authorized for requested channel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (statusCode == 1)
                {
                    T1_SetChannelBtn.Enabled = true;
                    T1_StandbyBtn.Enabled = true;
                    T1_ChannelTxtbox.Enabled = true;
                    T1_ChannelTxtbox.Text = "";
                    T1_ChannelTxtbox.Focus();
                }
                else
                {
                    T1_SetChannelBtn.Enabled = true;
                    T1_StandbyBtn.Enabled = true;
                    T1_ChannelTxtbox.Enabled = true;
                    MessageBox.Show("Something went wrong, this is new...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            RefreshVisualReceiver();
        }
        private async void T2_SetChannelBtn_Click(object sender, EventArgs e)
        {
            T2_SetChannelBtn.Enabled = false;
            T2_StandbyBtn.Enabled = false;
            T2_ChannelTxtbox.Enabled = false;
            string ipaddress = reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress;
            int channel;
            if (this.GetChannel(1, out channel))
            {
                int statusCode = await ReconUtilities.ChangeChannel(ipaddress, 1, channel);
                if (statusCode == -1)
                {
                    T2_SetChannelBtn.Enabled = true;
                    T2_StandbyBtn.Enabled = true;
                    T2_ChannelTxtbox.Enabled = true;
                    MessageBox.Show("Failed to set channel. Channel does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (statusCode == -2)
                {
                    T2_SetChannelBtn.Enabled = true;
                    T2_StandbyBtn.Enabled = true;
                    T2_ChannelTxtbox.Enabled = true;
                    MessageBox.Show("Failed to set channel. Most likely reason is not currently authorized for requested channel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (statusCode == 1)
                {
                    T2_SetChannelBtn.Enabled = true;
                    T2_StandbyBtn.Enabled = true;
                    T2_ChannelTxtbox.Enabled = true;
                    T2_ChannelTxtbox.Text = "";
                    T2_ChannelTxtbox.Focus();
                }
                else
                {
                    T2_SetChannelBtn.Enabled = true;
                    T2_StandbyBtn.Enabled = true;
                    T2_ChannelTxtbox.Enabled = true;
                    MessageBox.Show("Something went wrong, this is new...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            RefreshVisualReceiver();
        }
        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            await SimulcastUtilities.LoadSimulcastRaces(SimulcastDataGridView, reconInfo.filterList, ActiveChannels);
            if (OnlyShowActiveCheckBox.Checked)
            {
                foreach (DataGridViewRow row in SimulcastDataGridView.Rows)
                {
                    // Check if the cell in the CheckBoxColumn is checked (index 0)
                    bool isChecked = Convert.ToBoolean(row.Cells["ActiveRaceColumn"].Value);

                    // Toggle the visibility of the row based on the checkbox state
                    row.Visible = isChecked;
                }
                return;
            }
            foreach (DataGridViewRow row in SimulcastDataGridView.Rows)
            {
                row.Visible = true;
            }
        }
        private void FilterBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is a work in progress.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //return;
            SimulcastFilterfrm frm = new SimulcastFilterfrm();
            if (reconInfo.filter == "")
                frm.IsFilterSet = false;
            else
                frm.IsFilterSet = true;
            frm.CurFilterSet = reconInfo.filter;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                reconInfo.filter = frm.CurFilterSet;
                reconInfo.filterList = frm.CurFilterList;
                DCGReconRegistry.SaveRegistry(reconInfo);
            }
        }
        private void ToggleAutoSimulcastBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is a work in progress.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        #endregion
        #region Load Events
        private async void Mainfrm_Load(object sender, EventArgs e)
        {
            if (Environment.UserName.ToLower() != "jamie.head" && Environment.UserName.ToLower() != "j.head")
                DebugMenuItem.Visible = false;
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assemblyLocation);
            this.Text = $"DCG - Recon v{fileVersionInfo.FileVersion}";
            ReceiverGroupBox.Visible = false;
            this.Size = new Size(280, 489);
            if (DCGReconRegistry.LoadReceiverList(ref this.reconInfo) != 0)
            {
                this.reconInfo.receivers = new List<Receivers>();
                this.reconInfo.appkey = ReconMgmt.GenerateNewAppKey();
                this.reconInfo.updatesenabled = true;
                this.reconInfo.updatetime = DateTime.Today.AddHours(3);
                MessageBox.Show("It appears that you have yet to configure your receiver list.\r\rConfigure your receivers via (Tools -> Configure Receiver List).\n\nThis prompt will re-occur until atleast one Receiver is configured.", "DCG Recon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            RefreshReceiverList();
            ReceiverDataGridView.ClearSelection();
            ReceiverDataGridView.SelectionChanged += ReceiverDataGridView_SelectionChanged;
            await GatherActiveChannels();
            SimulcastUtilities.LoadSimulcastRaces(SimulcastDataGridView, reconInfo.filterList, ActiveChannels);
        }
        private void Mainfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecieverTimer.Stop();
        }
        #endregion
        #region ReceiverDataGridView Events
        private void ReceiverDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            RefreshVisualReceiver();
        }
        private void ReceiverDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Select the row at which the right-click occurred
                    ReceiverDataGridView.CurrentCell = ReceiverDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Show the context menu
                    ReceiverMenuStrip.Show(Cursor.Position);
                }
            }
        }
        private void ReceiverDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ReceiverDataGridView.SelectedRows.Count <= 0)
                return;
            if (e.RowIndex <= -1)
                return;
            RenameReceiverfrm frm = new RenameReceiverfrm();
            frm.CurReceiverName = ReceiverDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            frm.NameExclusions = ReceiverDataGridView.Rows.Cast<DataGridViewRow>().Select(row => row.Cells[0].Value?.ToString()).ToList();
            if (frm.ShowDialog(this) != DialogResult.Cancel)
            {
                ReconStruct TempStruct = reconInfo;
                List<Receivers> Receiverss = TempStruct.receivers;
                Receivers Receiver = Receiverss.ElementAt(ReceiverDataGridView.SelectedRows[0].Index);
                Receiver.receivername = frm.NewReceiverName;
                Receiverss[ReceiverDataGridView.SelectedRows[0].Index] = Receiver;
                TempStruct.receivers = Receiverss;
                reconInfo = TempStruct;
                this.RefreshReceiverList();
            }
        }
        #endregion
        #region SimulcastDataGridView Events
        private void SimulcastDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Select the row at which the right-click occurred
                    SimulcastDataGridView.CurrentCell = SimulcastDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Show the context menu
                    SimulcastMenuStrip.Show(Cursor.Position);
                }
            }
        }
        private void SimulcastDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (SimulcastDataGridView.SelectedRows.Count <= 0)
                return;
            SimulcastChannelfrm frm = new SimulcastChannelfrm();
            frm.Channel = SimulcastDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            frm.ChannelName = SimulcastDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            frm.ShowDialog(this);
        }
        private void DeleteRaceMenuItem_Click(object sender, EventArgs e)
        {
            if (SimulcastDataGridView.SelectedRows.Count <= 0)
                return;
            SimulcastDataGridView.Rows.RemoveAt(SimulcastDataGridView.SelectedRows[0].Index);
        }
        private void OpenRaceMenuItem_Click(object sender, EventArgs e)
        {
            if (SimulcastDataGridView.SelectedRows.Count <= 0)
                return;
            SimulcastChannelfrm frm = new SimulcastChannelfrm();
            frm.Channel = SimulcastDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            frm.ChannelName = SimulcastDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            frm.ShowDialog(this);
        }
        private void OnlyShowActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlyShowActiveCheckBox.Checked)
            {
                foreach (DataGridViewRow row in SimulcastDataGridView.Rows)
                {
                    // Check if the cell in the CheckBoxColumn is checked (index 0)
                    bool isChecked = Convert.ToBoolean(row.Cells["ActiveRaceColumn"].Value);

                    // Toggle the visibility of the row based on the checkbox state
                    row.Visible = isChecked;
                }
                return;
            }
            foreach (DataGridViewRow row in SimulcastDataGridView.Rows)
            {
                row.Visible = true;
            }
        }
        #endregion
        #region Debugging Events
        private void DebuggingLogMenuItem_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            log.ShowDebug();
        }

        private async void Tuner1StatusMenuItem_Click(object sender, EventArgs e)
        {
            int tuner = 0;
            int Status = await ReconUtilities.GetTunerStatus(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            int AV_Status = await ReconUtilities.GetTunerAVStatus(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            int SignalStrength = await ReconUtilities.GetTunerStrength(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            int Channel = await ReconUtilities.GetTunerChannel(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);

            string DebugPrint = $"Tuner Status: {Status}\nAV Status: {AV_Status}\nSignal Strength: {SignalStrength}\nChannel: {Channel}";

            MessageBox.Show(DebugPrint, $"Debugging Tuner {tuner + 1}");
        }

        private async void Tuner2StatusMenuItem_Click(object sender, EventArgs e)
        {
            int tuner = 1;
            int Status = await ReconUtilities.GetTunerStatus(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            int AV_Status = await ReconUtilities.GetTunerAVStatus(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            int SignalStrength = await ReconUtilities.GetTunerStrength(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            int Channel = await ReconUtilities.GetTunerChannel(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);

            string DebugPrint = $"Tuner Status: {Status}\nAV Status: {AV_Status}\nSignal Strength: {SignalStrength}\nChannel: {Channel}";

            MessageBox.Show(DebugPrint, $"Debugging Tuner {tuner + 1}");
        }

        private async void Tuner1ChannelInfoMenuItem_Click(object sender, EventArgs e)
        {
            int tuner = 0;
            int Channel = await ReconUtilities.GetTunerChannel(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            string ChannelName = await ReconUtilities.GetChannelName(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            string ChannelDesc = await ReconUtilities.GetChannelDesc(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            DateTime StartTime = await ReconUtilities.GetChannelStart(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            DateTime EndTime = await ReconUtilities.GetChannelEnd(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);

            string DebugPrint = $"Channel: {Channel}\nChannel Name: {ChannelName}\nChannel Desc: {ChannelDesc}\nStart Time: {StartTime.ToString("hh:mmtt").ToLower()}\nEnd Time: {(EndTime.ToString("hh:mmtt").ToLower() == "12:00am" ? "End of Day" : EndTime.ToString("hh:mmtt").ToLower())}";

            MessageBox.Show(DebugPrint, $"Debugging Tuner {tuner + 1}");
        }

        private async void Tuner2ChannelInfoMenuItem_Click(object sender, EventArgs e)
        {
            int tuner = 1;
            int Channel = await ReconUtilities.GetTunerChannel(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            string ChannelName = await ReconUtilities.GetChannelName(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            string ChannelDesc = await ReconUtilities.GetChannelDesc(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            DateTime StartTime = await ReconUtilities.GetChannelStart(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);
            DateTime EndTime = await ReconUtilities.GetChannelEnd(reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress, tuner);

            string DebugPrint = $"Channel: {Channel}\nChannel Name: {ChannelName}\nChannel Desc: {ChannelDesc}\nStart Time: {StartTime.ToString("hh:mmtt").ToLower()}\nEnd Time: {(EndTime.ToString("hh:mmtt").ToLower() == "12:00am" ? "End of Day" : EndTime.ToString("hh:mmtt").ToLower())}";

            MessageBox.Show(DebugPrint, $"Debugging Tuner {tuner + 1}");
        }

        private async void ReceiverInfoMenuItem_Click(object sender, EventArgs e)
        {
            string ReceiverName = ReceiverDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string ReceiverID = ReceiverDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string ReceiverIP = reconInfo.receivers[ReceiverDataGridView.SelectedRows[0].Index].ipaddress;

            string ReceiverModel = await ReconUtilities.GetReceiverModel(ReceiverIP);
            string ReceiverSoftwareVer = await ReconUtilities.GetReceiverSoftwareVersion(ReceiverIP);
            DateTime? ReceiverUpdates = await ReconUtilities.GetReceiverUpdates(ReceiverIP);
            string Updates;
            if (!ReceiverUpdates.HasValue || ReceiverUpdates == null)
                Updates = "Disabled";
            else
                Updates = $"Enabled {ReceiverUpdates.Value.ToString("hh:mmtt").ToLower()}";

            string DebugPrint = $"Receiver Name: {ReceiverName}\nReceiver ID: {ReceiverID}\nReceiver IP: {ReceiverIP}\nReceiver Modal: {ReceiverModel}\nSoftware Version: {ReceiverSoftwareVer}\nUpdates: {Updates}";

            MessageBox.Show(DebugPrint, $"Debugging Receiver \"{ReceiverName}\"");
        }
        #endregion
        private async void RecieverTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                await RefreshVisualReceiver();
            }
            catch (Exception ex)
            {

            }
        }

        private async Task GatherActiveChannels()
        {
            foreach (Receivers receiver in reconInfo.receivers)
            {
                //Determine if ActiveChannels is missing a channel
                if (!ActiveChannels.Keys.Contains(await ReconUtilities.GetTunerChannel(receiver.ipaddress, 0)) || !ActiveChannels.Keys.Contains(await ReconUtilities.GetTunerChannel(receiver.ipaddress, 1)) ||
                    !ActiveChannels.Values.Contains(await ReconUtilities.GetChannelName(receiver.ipaddress, 0)) || !ActiveChannels.Values.Contains(await ReconUtilities.GetChannelName(receiver.ipaddress, 1))
                    )
                {
                    //If Active Channel is missing a channel, clear the list, add all Active Channels back to the list, then return
                    ActiveChannels.Clear();
                    foreach (Receivers receiver_ in reconInfo.receivers)
                    {
                        int T1_channel = await ReconUtilities.GetTunerChannel(receiver_.ipaddress, 0);
                        string T1_channelName = await ReconUtilities.GetChannelName(receiver_.ipaddress, 0);
                        int T2_channel = await ReconUtilities.GetTunerChannel(receiver_.ipaddress, 1);
                        string T2_channelName = await ReconUtilities.GetChannelName(receiver_.ipaddress, 1);
                        if (ActiveChannels.Keys.Contains(T1_channel))
                            continue;
                        ActiveChannels.Add(T1_channel, T1_channelName);
                        if (ActiveChannels.Keys.Contains(T2_channel))
                            continue;
                        ActiveChannels.Add(T2_channel, T2_channelName);
                    }
                    return;
                }
            }
        }

        private void T1_ChannelTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void T2_ChannelTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void debugTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> list = await ReconUtilities.GetAuthChannelList("172.16.96.44");
            foreach (string channel in list)
            {
                Debug.WriteLine(channel);
            }
        }

        private void SimulcastMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void SetTuner1MenuItem_Click(object sender, EventArgs e)
        {
            if (SimulcastDataGridView.SelectedRows.Count <= 0)
                return;
            T1_ChannelTxtbox.Text = SimulcastDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            T1_SetChannelBtn.PerformClick();
        }

        private void SetTuner2MenuItem_Click(object sender, EventArgs e)
        {
            if (SimulcastDataGridView.SelectedRows.Count <= 0)
                return;
            T2_ChannelTxtbox.Text = SimulcastDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            T2_SetChannelBtn.PerformClick();
        }

        private void SimulcastDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private async void ActiveChannelTimer_Tick(object sender, EventArgs e)
        {
            await GatherActiveChannels();
        }
    }
}