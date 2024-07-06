using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCGRecon.Classes;

namespace DCGRecon.Forms
{
    public partial class Optionsfrm : Form
    {
        public ReconStruct? reconInfo;
        private ReconStruct NewStruct;
        public Optionsfrm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            NewStruct.updatesenabled = DailyUpdatesCheckbox.Checked;
            int Multiplier = AMRadioBtn.Checked == true ? 1 : 2;
            NewStruct.updatetime = DateTime.Today.AddHours(Int32.Parse(HourComboBox.SelectedItem.ToString()) * Multiplier).AddMinutes(Int32.Parse(MinuteComboBox.SelectedItem.ToString()));
            reconInfo = NewStruct;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Optionsfrm_Load(object sender, EventArgs e)
        {
            NewStruct = (ReconStruct)reconInfo;
            if (NewStruct.updatesenabled)
            {
                DailyUpdatesCheckbox.Checked = true;
                HourComboBox.SelectedItem = NewStruct.updatetime.ToString("hh");
                MinuteComboBox.SelectedItem = NewStruct.updatetime.ToString("mm");
                if (NewStruct.updatetime.ToString("tt").ToUpper() == "AM")
                    AMRadioBtn.Checked = true;
                else
                    PMRadioBtn.Checked = true;
            }
            else
            {
                DailyUpdatesCheckbox.Checked = false;
                HourComboBox.Visible = false;
                MinuteComboBox.Visible = false;
                AMRadioBtn.Visible = false;
                PMRadioBtn.Visible = false;
                MiddleTimeLbl.Visible = false;
                HourComboBox.SelectedItem = "03";
                MinuteComboBox.SelectedItem = "00";
                AMRadioBtn.Checked = true;
            }

        }

        private void DailyUpdatesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!DailyUpdatesCheckbox.Checked)
            {
                HourComboBox.Visible = false;
                MinuteComboBox.Visible = false;
                AMRadioBtn.Visible = false;
                PMRadioBtn.Visible = false;
                MiddleTimeLbl.Visible = false;
            }
            else
            {
                HourComboBox.Visible = true;
                MinuteComboBox.Visible = true;
                AMRadioBtn.Visible = true;
                PMRadioBtn.Visible = true;
                MiddleTimeLbl.Visible = true;
            }
        }
    }
}
