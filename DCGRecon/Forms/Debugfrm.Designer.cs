namespace DCGRecon.Forms
{
    partial class Debugfrm
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
            listLog = new ListBox();
            SuspendLayout();
            // 
            // listLog
            // 
            listLog.Dock = DockStyle.Fill;
            listLog.FormattingEnabled = true;
            listLog.ItemHeight = 15;
            listLog.Location = new Point(0, 0);
            listLog.Name = "listLog";
            listLog.Size = new Size(358, 450);
            listLog.TabIndex = 0;
            // 
            // Debugfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 450);
            Controls.Add(listLog);
            MinimizeBox = false;
            Name = "Debugfrm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Debug Monitor";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listLog;
    }
}