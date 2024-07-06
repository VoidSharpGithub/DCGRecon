using HtmlAgilityPack;
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
using System.Web;

namespace DCGRecon.Forms
{
    public partial class SimulcastChannelfrm : Form
    {
        public string Channel;
        public string ChannelName;
        public SimulcastChannelfrm()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private async void SimulcastChannelfrm_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            try
            {
                var response = await client.GetAsync("https://www.rtn.tv/rcnschedule/rcnschedule.aspx");
                response.EnsureSuccessStatusCode();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(await response.Content.ReadAsStringAsync());

                // Find the target table by id
                HtmlNode targetTable = doc.GetElementbyId("MainContent_tblScheduleList");

                // Check if the table was found
                if (targetTable != null)
                {
                    // Get all rows in the table, skipping the first and last rows
                    IEnumerable<HtmlNode> rows = targetTable.Descendants("tr").Skip(1).Take(targetTable.Descendants("tr").Count() - 2);

                    foreach (HtmlNode row in rows)
                    {
                        // Get all the cells in the row
                        IEnumerable<HtmlNode> cells = row.Descendants("td");

                        if (cells.Count() == 4)
                        {
                            string channel = cells.ElementAt(0).InnerText.Trim();
                            string channelName = HttpUtility.HtmlDecode(cells.ElementAt(1).InnerText.Trim());
                            if (channel != Channel || channelName != ChannelName)
                                continue;

                            bool ActiveRace = false;

                            DateTime StartTime = SimulcastUtilities.ConvertToDateTimeEst(cells.ElementAt(2).InnerText.Trim());
                            DateTime EndTime = SimulcastUtilities.AddDuration(StartTime, cells.ElementAt(3).InnerText.Trim());
                            TimeSpan Duration = SimulcastUtilities.GetDuration(cells.ElementAt(3).InnerText.Trim());

                            if (DateTime.Now >= StartTime && DateTime.Now <= EndTime)
                            {
                                ActiveRace = true;
                            }
                            else
                            {
                                ActiveRace = false;
                            }

                            ChannelGroupbox.Text = $"Channel {channel}";
                            EventNameInputLbl.Text = channelName;
                            StartTimeInputLbl.Text = StartTime.ToString("MM/dd/yyyy hh:mmtt");
                            EndTimeInputLbl.Text = EndTime.ToString("MM/dd/yyyy hh:mmtt");
                            if(Duration.Days >= 1)
                            {
                                DurationInputLbl.Text = $"24hr {Duration.Minutes}min";
                            }
                            else
                            {
                                DurationInputLbl.Text = $"{Duration.Hours}hr {Duration.Minutes}min";
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
