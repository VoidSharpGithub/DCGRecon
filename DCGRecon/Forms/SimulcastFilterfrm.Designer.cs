namespace DCGRecon.Forms
{
    partial class SimulcastFilterfrm
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
            CancelBtn = new Button();
            SetupGroupbox = new GroupBox();
            label1 = new Label();
            MonthCombobox = new ComboBox();
            SetupSubmitBtn = new Button();
            URLTextbox = new TextBox();
            ChurchillPDFURLLbl = new Label();
            FilterGroupbox = new GroupBox();
            FilterSimulcastDataGridView = new DataGridView();
            ScheduledTimeColumn = new DataGridViewTextBoxColumn();
            EventNameColumn = new DataGridViewTextBoxColumn();
            ClearFilterBtn = new Button();
            SaveBtn = new Button();
            NoteInformationLbl = new Label();
            SetupGroupbox.SuspendLayout();
            FilterGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FilterSimulcastDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.DialogResult = DialogResult.Cancel;
            CancelBtn.Location = new Point(486, 415);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 0;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SetupGroupbox
            // 
            SetupGroupbox.Controls.Add(label1);
            SetupGroupbox.Controls.Add(MonthCombobox);
            SetupGroupbox.Controls.Add(SetupSubmitBtn);
            SetupGroupbox.Controls.Add(URLTextbox);
            SetupGroupbox.Controls.Add(ChurchillPDFURLLbl);
            SetupGroupbox.Location = new Point(12, 12);
            SetupGroupbox.Name = "SetupGroupbox";
            SetupGroupbox.Size = new Size(549, 110);
            SetupGroupbox.TabIndex = 1;
            SetupGroupbox.TabStop = false;
            SetupGroupbox.Text = "Setup";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 4;
            label1.Text = "Select a Month:";
            // 
            // MonthCombobox
            // 
            MonthCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            MonthCombobox.FormattingEnabled = true;
            MonthCombobox.Location = new Point(6, 37);
            MonthCombobox.Name = "MonthCombobox";
            MonthCombobox.Size = new Size(537, 23);
            MonthCombobox.TabIndex = 3;
            MonthCombobox.SelectedIndexChanged += MonthCombobox_SelectedIndexChanged;
            // 
            // SetupSubmitBtn
            // 
            SetupSubmitBtn.Location = new Point(468, 81);
            SetupSubmitBtn.Name = "SetupSubmitBtn";
            SetupSubmitBtn.Size = new Size(75, 23);
            SetupSubmitBtn.TabIndex = 2;
            SetupSubmitBtn.Text = "Submit";
            SetupSubmitBtn.UseVisualStyleBackColor = true;
            SetupSubmitBtn.Click += SetupSubmitBtn_Click;
            // 
            // URLTextbox
            // 
            URLTextbox.Enabled = false;
            URLTextbox.Location = new Point(6, 81);
            URLTextbox.Name = "URLTextbox";
            URLTextbox.Size = new Size(456, 23);
            URLTextbox.TabIndex = 1;
            URLTextbox.Visible = false;
            // 
            // ChurchillPDFURLLbl
            // 
            ChurchillPDFURLLbl.AutoSize = true;
            ChurchillPDFURLLbl.Location = new Point(6, 63);
            ChurchillPDFURLLbl.Name = "ChurchillPDFURLLbl";
            ChurchillPDFURLLbl.Size = new Size(106, 15);
            ChurchillPDFURLLbl.TabIndex = 0;
            ChurchillPDFURLLbl.Text = "Churchill PDF URL:";
            ChurchillPDFURLLbl.Visible = false;
            // 
            // FilterGroupbox
            // 
            FilterGroupbox.Controls.Add(FilterSimulcastDataGridView);
            FilterGroupbox.Location = new Point(12, 128);
            FilterGroupbox.Name = "FilterGroupbox";
            FilterGroupbox.Size = new Size(549, 281);
            FilterGroupbox.TabIndex = 2;
            FilterGroupbox.TabStop = false;
            FilterGroupbox.Text = "Filter";
            // 
            // FilterSimulcastDataGridView
            // 
            FilterSimulcastDataGridView.AllowUserToAddRows = false;
            FilterSimulcastDataGridView.AllowUserToDeleteRows = false;
            FilterSimulcastDataGridView.AllowUserToResizeRows = false;
            FilterSimulcastDataGridView.BorderStyle = BorderStyle.Fixed3D;
            FilterSimulcastDataGridView.ColumnHeadersHeight = 26;
            FilterSimulcastDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            FilterSimulcastDataGridView.Columns.AddRange(new DataGridViewColumn[] { ScheduledTimeColumn, EventNameColumn });
            FilterSimulcastDataGridView.Dock = DockStyle.Fill;
            FilterSimulcastDataGridView.Location = new Point(3, 19);
            FilterSimulcastDataGridView.MultiSelect = false;
            FilterSimulcastDataGridView.Name = "FilterSimulcastDataGridView";
            FilterSimulcastDataGridView.ReadOnly = true;
            FilterSimulcastDataGridView.RowHeadersVisible = false;
            FilterSimulcastDataGridView.RowTemplate.Height = 25;
            FilterSimulcastDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FilterSimulcastDataGridView.Size = new Size(543, 259);
            FilterSimulcastDataGridView.TabIndex = 3;
            // 
            // ScheduledTimeColumn
            // 
            ScheduledTimeColumn.HeaderText = "Scheduled Time";
            ScheduledTimeColumn.Name = "ScheduledTimeColumn";
            ScheduledTimeColumn.ReadOnly = true;
            ScheduledTimeColumn.Width = 125;
            // 
            // EventNameColumn
            // 
            EventNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EventNameColumn.HeaderText = "Event Name";
            EventNameColumn.Name = "EventNameColumn";
            EventNameColumn.ReadOnly = true;
            // 
            // ClearFilterBtn
            // 
            ClearFilterBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearFilterBtn.Location = new Point(324, 415);
            ClearFilterBtn.Name = "ClearFilterBtn";
            ClearFilterBtn.Size = new Size(75, 23);
            ClearFilterBtn.TabIndex = 4;
            ClearFilterBtn.Text = "Clear Filter";
            ClearFilterBtn.UseVisualStyleBackColor = true;
            ClearFilterBtn.Visible = false;
            ClearFilterBtn.Click += ClearFilterBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveBtn.DialogResult = DialogResult.OK;
            SaveBtn.Enabled = false;
            SaveBtn.Location = new Point(405, 415);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // NoteInformationLbl
            // 
            NoteInformationLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NoteInformationLbl.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            NoteInformationLbl.Location = new Point(12, 409);
            NoteInformationLbl.Name = "NoteInformationLbl";
            NoteInformationLbl.Size = new Size(306, 43);
            NoteInformationLbl.TabIndex = 4;
            NoteInformationLbl.Text = "Note: This system uses an API provided by Adobe Developer, due to this, there is a limitation on how many requests can be sent for free.\n Click to view more.";
            NoteInformationLbl.TextAlign = ContentAlignment.MiddleCenter;
            NoteInformationLbl.Click += NoteInformationLbl_Click;
            // 
            // SimulcastFilterfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(574, 451);
            Controls.Add(ClearFilterBtn);
            Controls.Add(NoteInformationLbl);
            Controls.Add(SaveBtn);
            Controls.Add(FilterGroupbox);
            Controls.Add(SetupGroupbox);
            Controls.Add(CancelBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SimulcastFilterfrm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Filter Simulcast";
            Load += SimulcastFilterfrm_Load;
            SetupGroupbox.ResumeLayout(false);
            SetupGroupbox.PerformLayout();
            FilterGroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FilterSimulcastDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CancelBtn;
        private GroupBox SetupGroupbox;
        private Label ChurchillPDFURLLbl;
        private TextBox URLTextbox;
        private Button SetupSubmitBtn;
        private GroupBox FilterGroupbox;
        private DataGridView FilterSimulcastDataGridView;
        private Button SaveBtn;
        private Label NoteInformationLbl;
        private Button ClearFilterBtn;
        private ComboBox MonthCombobox;
        private Label label1;
        private DataGridViewTextBoxColumn ScheduledTimeColumn;
        private DataGridViewTextBoxColumn EventNameColumn;
    }
}