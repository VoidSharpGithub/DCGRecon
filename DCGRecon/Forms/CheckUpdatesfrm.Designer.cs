namespace DCGRecon.Forms
{
    partial class CheckUpdatesfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UpdateLbl = new Label();
            LoadingBar = new ProgressBar();
            UpdateWorker = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // UpdateLbl
            // 
            UpdateLbl.Location = new Point(12, 9);
            UpdateLbl.Name = "UpdateLbl";
            UpdateLbl.Size = new Size(248, 78);
            UpdateLbl.TabIndex = 0;
            UpdateLbl.Text = "Checking For Updates...";
            UpdateLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoadingBar
            // 
            LoadingBar.Location = new Point(12, 64);
            LoadingBar.Name = "LoadingBar";
            LoadingBar.Size = new Size(248, 23);
            LoadingBar.TabIndex = 1;
            // 
            // UpdateWorker
            // 
            UpdateWorker.WorkerReportsProgress = true;
            UpdateWorker.DoWork += UpdateWorker_DoWork;
            UpdateWorker.ProgressChanged += UpdateWorker_ProgressChanged;
            UpdateWorker.RunWorkerCompleted += UpdateWorker_RunWorkerCompleted;
            // 
            // CheckUpdatesfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 96);
            Controls.Add(LoadingBar);
            Controls.Add(UpdateLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CheckUpdatesfrm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Checking for Updates...";
            Load += CheckUpdatesfrm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label UpdateLbl;
        private ProgressBar LoadingBar;
        private System.ComponentModel.BackgroundWorker UpdateWorker;
    }
}