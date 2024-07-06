namespace DCGRecon.Forms
{
    partial class Optionsfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Optionsfrm));
            ReceiverUpdateGroupBox = new GroupBox();
            PMRadioBtn = new RadioButton();
            AMRadioBtn = new RadioButton();
            MiddleTimeLbl = new Label();
            MinuteComboBox = new ComboBox();
            HourComboBox = new ComboBox();
            DailyUpdatesCheckbox = new CheckBox();
            Info2Lbl = new Label();
            Info1Lbl = new Label();
            CancelBtn = new Button();
            SaveBtn = new Button();
            ReceiverUpdateGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ReceiverUpdateGroupBox
            // 
            ReceiverUpdateGroupBox.Controls.Add(PMRadioBtn);
            ReceiverUpdateGroupBox.Controls.Add(AMRadioBtn);
            ReceiverUpdateGroupBox.Controls.Add(MiddleTimeLbl);
            ReceiverUpdateGroupBox.Controls.Add(MinuteComboBox);
            ReceiverUpdateGroupBox.Controls.Add(HourComboBox);
            ReceiverUpdateGroupBox.Controls.Add(DailyUpdatesCheckbox);
            ReceiverUpdateGroupBox.Controls.Add(Info2Lbl);
            ReceiverUpdateGroupBox.Controls.Add(Info1Lbl);
            ReceiverUpdateGroupBox.Location = new Point(12, 12);
            ReceiverUpdateGroupBox.Name = "ReceiverUpdateGroupBox";
            ReceiverUpdateGroupBox.Size = new Size(687, 184);
            ReceiverUpdateGroupBox.TabIndex = 0;
            ReceiverUpdateGroupBox.TabStop = false;
            ReceiverUpdateGroupBox.Text = "Receiver Updates";
            // 
            // PMRadioBtn
            // 
            PMRadioBtn.AutoSize = true;
            PMRadioBtn.Location = new Point(214, 141);
            PMRadioBtn.Name = "PMRadioBtn";
            PMRadioBtn.Size = new Size(43, 19);
            PMRadioBtn.TabIndex = 7;
            PMRadioBtn.Text = "PM";
            PMRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AMRadioBtn
            // 
            AMRadioBtn.AutoSize = true;
            AMRadioBtn.Checked = true;
            AMRadioBtn.Location = new Point(164, 141);
            AMRadioBtn.Name = "AMRadioBtn";
            AMRadioBtn.Size = new Size(44, 19);
            AMRadioBtn.TabIndex = 6;
            AMRadioBtn.TabStop = true;
            AMRadioBtn.Text = "AM";
            AMRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MiddleTimeLbl
            // 
            MiddleTimeLbl.AutoSize = true;
            MiddleTimeLbl.Location = new Point(87, 142);
            MiddleTimeLbl.Name = "MiddleTimeLbl";
            MiddleTimeLbl.Size = new Size(10, 15);
            MiddleTimeLbl.TabIndex = 5;
            MiddleTimeLbl.Text = ":";
            // 
            // MinuteComboBox
            // 
            MinuteComboBox.DropDownHeight = 190;
            MinuteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MinuteComboBox.FormattingEnabled = true;
            MinuteComboBox.IntegralHeight = false;
            MinuteComboBox.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            MinuteComboBox.Location = new Point(103, 139);
            MinuteComboBox.Name = "MinuteComboBox";
            MinuteComboBox.Size = new Size(50, 23);
            MinuteComboBox.TabIndex = 4;
            // 
            // HourComboBox
            // 
            HourComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HourComboBox.FormattingEnabled = true;
            HourComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            HourComboBox.Location = new Point(31, 139);
            HourComboBox.Name = "HourComboBox";
            HourComboBox.Size = new Size(50, 23);
            HourComboBox.TabIndex = 3;
            // 
            // DailyUpdatesCheckbox
            // 
            DailyUpdatesCheckbox.AutoSize = true;
            DailyUpdatesCheckbox.Checked = true;
            DailyUpdatesCheckbox.CheckState = CheckState.Checked;
            DailyUpdatesCheckbox.Cursor = Cursors.Hand;
            DailyUpdatesCheckbox.Location = new Point(6, 114);
            DailyUpdatesCheckbox.Name = "DailyUpdatesCheckbox";
            DailyUpdatesCheckbox.Size = new Size(252, 19);
            DailyUpdatesCheckbox.TabIndex = 2;
            DailyUpdatesCheckbox.Text = "Force all receivers to perform daily updates";
            DailyUpdatesCheckbox.UseVisualStyleBackColor = true;
            DailyUpdatesCheckbox.CheckedChanged += DailyUpdatesCheckbox_CheckedChanged;
            // 
            // Info2Lbl
            // 
            Info2Lbl.AutoSize = true;
            Info2Lbl.Location = new Point(6, 86);
            Info2Lbl.Name = "Info2Lbl";
            Info2Lbl.Size = new Size(366, 15);
            Info2Lbl.TabIndex = 1;
            Info2Lbl.Text = "It is recommended that system updates be enabled on all receivers...";
            // 
            // Info1Lbl
            // 
            Info1Lbl.Location = new Point(6, 28);
            Info1Lbl.Name = "Info1Lbl";
            Info1Lbl.Size = new Size(675, 48);
            Info1Lbl.TabIndex = 0;
            Info1Lbl.Text = resources.GetString("Info1Lbl.Text");
            // 
            // CancelBtn
            // 
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.Location = new Point(624, 202);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 1;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.Location = new Point(543, 202);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 2;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Optionsfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(711, 237);
            Controls.Add(SaveBtn);
            Controls.Add(CancelBtn);
            Controls.Add(ReceiverUpdateGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Optionsfrm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "DCG Recon Options";
            Load += Optionsfrm_Load;
            ReceiverUpdateGroupBox.ResumeLayout(false);
            ReceiverUpdateGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ReceiverUpdateGroupBox;
        private Button CancelBtn;
        private Button SaveBtn;
        private Label Info1Lbl;
        private Label Info2Lbl;
        private CheckBox DailyUpdatesCheckbox;
        private ComboBox HourComboBox;
        private Label MiddleTimeLbl;
        private ComboBox MinuteComboBox;
        private RadioButton AMRadioBtn;
        private RadioButton PMRadioBtn;
    }
}