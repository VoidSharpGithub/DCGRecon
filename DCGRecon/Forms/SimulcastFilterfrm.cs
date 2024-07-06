using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adobe.PDFServicesSDK;
using Adobe.PDFServicesSDK.auth;
using Adobe.PDFServicesSDK.io;
using Adobe.PDFServicesSDK.options.exportpdf;
using Adobe.PDFServicesSDK.pdfops;
using DCGRecon.Classes;
using OfficeOpenXml;

namespace DCGRecon.Forms
{
    public partial class SimulcastFilterfrm : Form
    {
        public bool IsFilterSet = false;
        public string CurFilterSet = "";
        public List<string> CurFilterList = new List<string>();
        public SimulcastFilterfrm()
        {
            InitializeComponent();
        }

        private bool IsFileMatchingFormat(string filename)
        {
            // Split the filename into parts
            string[] parts = filename.Split(new[] { " - " }, StringSplitOptions.None);

            // Check if there are two parts: Month and Year
            if (parts.Length == 2)
            {
                // Validate the Month part
                if (!DateTime.TryParseExact(parts[0], "MMMM", CultureInfo.CurrentCulture, DateTimeStyles.None, out _))
                {
                    return false;
                }

                // Validate the Year part
                if (!int.TryParse(parts[1], out int year))
                {
                    return false;
                }

                return true;
            }

            return false;
        }
        private void LoadSchedulesToCombobox(ComboBox comboBox)
        {
            // Clear existing items
            comboBox.Items.Clear();

            // Check if the directory exists
            if (!Directory.Exists("***REMOVED***"))
            {
                MessageBox.Show($"Directory not found: ***REMOVED***");
                return;
            }

            // Get all .xlsx files in the directory
            string[] files = Directory.GetFiles("***REMOVED***", "*.xlsx");

            foreach (string file in files)
            {
                // Extract the filename without the extension
                string filenameWithoutExtension = Path.GetFileNameWithoutExtension(file);

                // Check if the filename matches the format "<Month> - <Year>"
                if (IsFileMatchingFormat(filenameWithoutExtension))
                {
                    // Add the filename to the ComboBox
                    comboBox.Items.Add(filenameWithoutExtension);
                }
            }
            comboBox.Items.Add("Submit Schedule Manually");
        }
        private void NoteInformationLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality of the DCG Recon Application, utilized a API called \"Adobe PDF Services API\".\nThis API can be used up to 500 times in a month before costing a Developer License via Adobe.\n\nI have gotten around this by storing the exported documents and referencing them for the given month once the API runs once.\n\nIf you would like to know where they are located, please contact support via the About section of this Application.", "Adobe API Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (MonthCombobox.SelectedItem == null || MonthCombobox.SelectedItem.ToString() == "Submit Schedule Manually" || MonthCombobox.SelectedItem.ToString() == "")
            {
                IsFilterSet = false;
                CurFilterSet = "";
                CurFilterList = new List<string>();
            }
            else
            {
                IsFilterSet = true;
                CurFilterSet = MonthCombobox.SelectedItem.ToString();
            }
        }
        private void SimulcastFilterfrm_Load(object sender, EventArgs e)
        {
            if (!IsFilterSet)
            {
                this.Size = new Size(590, 156);
                FilterGroupbox.Visible = false;
                SetupGroupbox.Size = new Size(549, 66);
                LoadSchedulesToCombobox(MonthCombobox);
            }
            else
            {
                LoadSchedulesToCombobox(MonthCombobox);
                MonthCombobox.SelectedIndex = MonthCombobox.Items.IndexOf(CurFilterSet);
                ClearFilterBtn.Visible = true;
            }
        }
        private async void SetupSubmitBtn_Click(object sender, EventArgs e)
        {
            URLTextbox.Enabled = false;
            SetupSubmitBtn.Enabled = false;
            string ScheduleDate = await SimulcastUtilities.GetScheduleDate(URLTextbox.Text);
            if (ScheduleDate == string.Empty)
                return;
            URLTextbox.Enabled = true;
            SetupSubmitBtn.Enabled = true;
            if (!SimulcastUtilities.DoesScheduleFileExist(ScheduleDate))
            {
                if (!SimulcastUtilities.IsNetworkDirectoryAccessible())
                    return;
                await SimulcastUtilities.CreateXLSXFromURL(URLTextbox.Text, ScheduleDate);
                LoadSchedulesToCombobox(MonthCombobox);
                MonthCombobox.SelectedIndex = MonthCombobox.Items.IndexOf(ScheduleDate);
                return;
            }
            MonthCombobox.SelectedIndex = MonthCombobox.Items.IndexOf(ScheduleDate);
        }
        private async void MonthCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MonthCombobox.SelectedItem.ToString() == "Submit Schedule Manually")
            {
                FilterSimulcastDataGridView.Rows.Clear();
                URLTextbox.Enabled = true;
                SetupGroupbox.Size = new Size(549, 110);
                this.Size = new Size(590, 200);

                FilterGroupbox.Location = new Point(12, 128);
                FilterGroupbox.Size = new Size(549, 281);
                FilterGroupbox.Visible = false;
                ChurchillPDFURLLbl.Visible = true;
                URLTextbox.Visible = true;
                URLTextbox.Enabled = true;
            }
            else
            {
                URLTextbox.Enabled = false;
                SetupGroupbox.Size = new Size(549, 66);
                this.Size = new Size(590, 156);
                FilterGroupbox.Location = new Point(12, 84);
                FilterGroupbox.Size = new Size(549, 325);
                ChurchillPDFURLLbl.Visible = false;
                URLTextbox.Visible = false;
                URLTextbox.Enabled = false;


                if (!await SimulcastUtilities.LoadFilterData(FilterSimulcastDataGridView, $"***REMOVED***{MonthCombobox.SelectedItem}.xlsx", CurFilterList))
                {
                    this.Size = new Size(590, 156);
                    FilterGroupbox.Visible = false;
                    SetupGroupbox.Size = new Size(549, 66);
                    return;
                }
                this.Size = new Size(590, 490);
                FilterGroupbox.Visible = true;
                SaveBtn.Enabled = true;
                IsFilterSet = true;
            }
        }
        private void ClearFilterBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear your filter and save?", "Clear Filter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IsFilterSet = false;
                CurFilterSet = "";
                CurFilterList = new List<string>();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
