using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCGRecon.Forms
{
    public partial class CheckUpdatesfrm : Form
    {
        private string FilePath = "";
        private string SetupPath = "";
        private string InstallerVersion;
        private string CurrentAppVersion;
        public CheckUpdatesfrm()
        {
            InitializeComponent();
        }

        private string GetInstallerVersion(string filePath)
        {
            dynamic windowsInstaller = Activator.CreateInstance(Type.GetTypeFromProgID("WindowsInstaller.Installer"));
            dynamic database = windowsInstaller.GetType().InvokeMember("OpenDatabase", System.Reflection.BindingFlags.InvokeMethod, null, windowsInstaller, new object[] { filePath, 0 });

            UpdateWorker.ReportProgress(20);

            string query = "SELECT `Value` FROM `Property` WHERE `Property` = 'ProductVersion'";
            dynamic view = database.GetType().InvokeMember("OpenView", System.Reflection.BindingFlags.InvokeMethod, null, database, new object[] { query });
            view.GetType().InvokeMember("Execute", System.Reflection.BindingFlags.InvokeMethod, null, view, new object[] { null });
            dynamic record = view.GetType().InvokeMember("Fetch", System.Reflection.BindingFlags.InvokeMethod, null, view, new object[] { null });

            if (record == null)
            {
                throw new Exception("Unable to fetch version from MSI.");
            }

            UpdateWorker.ReportProgress(28);

            string version = record.GetType().InvokeMember("StringData", System.Reflection.BindingFlags.GetProperty, null, record, new object[] { 1 });

            UpdateWorker.ReportProgress(37);

            Marshal.FinalReleaseComObject(record);
            Marshal.FinalReleaseComObject(view);
            Marshal.FinalReleaseComObject(database);
            Marshal.FinalReleaseComObject(windowsInstaller);

            UpdateWorker.ReportProgress(43);

            return version;
        }
        private void CheckUpdatesfrm_Load(object sender, EventArgs e)
        {
            if (!UpdateWorker.IsBusy)
                UpdateWorker.RunWorkerAsync();
        }

        private void UpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!File.Exists(FilePath))
            {
                MessageBox.Show("Updates are currently down. Please try again later.", "Check for Updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            UpdateWorker.ReportProgress(10);
            InstallerVersion = GetInstallerVersion(FilePath);
            // Get the path of the currently executing assembly
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            UpdateWorker.ReportProgress(50);

            // Get the file version information
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assemblyLocation);
            UpdateWorker.ReportProgress(70);

            // Retrieve the file version
            CurrentAppVersion = fileVersionInfo.FileVersion;
            UpdateWorker.ReportProgress(100);
        }

        private void UpdateWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LoadingBar.Value = e.ProgressPercentage;
        }

        private void UpdateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (InstallerVersion != CurrentAppVersion)
            {
                var msg = MessageBox.Show($"Current Version is {CurrentAppVersion}\nUpdate {InstallerVersion} was Found\n\nWould you like to update now?", "Check for Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    Process.Start(SetupPath);
                    Application.Exit();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"You are running the latest version.\nCurrent Version is {CurrentAppVersion}", "Check for Updates", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }
    }
}
