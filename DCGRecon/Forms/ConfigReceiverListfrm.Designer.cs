namespace DCGRecon.Forms
{
    partial class ConfigReceiverListfrm
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
            groupBox1 = new GroupBox();
            DeleteReceiverBtn = new Button();
            EditReceiverBtn = new Button();
            AddReceiverBtn = new Button();
            groupBox2 = new GroupBox();
            OrderSortBtn = new Button();
            OrderMoveDownBtn = new Button();
            OrderMoveUpBtn = new Button();
            ReceiverMgmtDataGridView = new DataGridView();
            ReceiverNameColumn = new DataGridViewTextBoxColumn();
            ReceiverIDColumn = new DataGridViewTextBoxColumn();
            ReceiverIPColumn = new DataGridViewTextBoxColumn();
            ReceiverStatusColumn = new DataGridViewTextBoxColumn();
            CancelBtn = new Button();
            SaveBtn = new Button();
            ImportBtn = new Button();
            ExportBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReceiverMgmtDataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DeleteReceiverBtn);
            groupBox1.Controls.Add(EditReceiverBtn);
            groupBox1.Controls.Add(AddReceiverBtn);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(ReceiverMgmtDataGridView);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 458);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Receiver Manager";
            // 
            // DeleteReceiverBtn
            // 
            DeleteReceiverBtn.Cursor = Cursors.Hand;
            DeleteReceiverBtn.Location = new Point(168, 369);
            DeleteReceiverBtn.Name = "DeleteReceiverBtn";
            DeleteReceiverBtn.Size = new Size(75, 23);
            DeleteReceiverBtn.TabIndex = 4;
            DeleteReceiverBtn.Text = "Delete";
            DeleteReceiverBtn.UseVisualStyleBackColor = true;
            DeleteReceiverBtn.Click += DeleteReceiverBtn_Click;
            // 
            // EditReceiverBtn
            // 
            EditReceiverBtn.Cursor = Cursors.Hand;
            EditReceiverBtn.Location = new Point(87, 369);
            EditReceiverBtn.Name = "EditReceiverBtn";
            EditReceiverBtn.Size = new Size(75, 23);
            EditReceiverBtn.TabIndex = 3;
            EditReceiverBtn.Text = "Edit";
            EditReceiverBtn.UseVisualStyleBackColor = true;
            EditReceiverBtn.Click += EditReceiverBtn_Click;
            // 
            // AddReceiverBtn
            // 
            AddReceiverBtn.Cursor = Cursors.Hand;
            AddReceiverBtn.Location = new Point(6, 369);
            AddReceiverBtn.Name = "AddReceiverBtn";
            AddReceiverBtn.Size = new Size(75, 23);
            AddReceiverBtn.TabIndex = 2;
            AddReceiverBtn.Text = "Add";
            AddReceiverBtn.UseVisualStyleBackColor = true;
            AddReceiverBtn.Click += AddReceiverBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(OrderSortBtn);
            groupBox2.Controls.Add(OrderMoveDownBtn);
            groupBox2.Controls.Add(OrderMoveUpBtn);
            groupBox2.Location = new Point(6, 398);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(277, 54);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Receiver Order In List";
            // 
            // OrderSortBtn
            // 
            OrderSortBtn.Cursor = Cursors.Hand;
            OrderSortBtn.Location = new Point(173, 22);
            OrderSortBtn.Name = "OrderSortBtn";
            OrderSortBtn.Size = new Size(95, 23);
            OrderSortBtn.TabIndex = 2;
            OrderSortBtn.Text = "Sort By Name";
            OrderSortBtn.UseVisualStyleBackColor = true;
            OrderSortBtn.Click += OrderSortBtn_Click;
            // 
            // OrderMoveDownBtn
            // 
            OrderMoveDownBtn.Cursor = Cursors.Hand;
            OrderMoveDownBtn.Location = new Point(87, 22);
            OrderMoveDownBtn.Name = "OrderMoveDownBtn";
            OrderMoveDownBtn.Size = new Size(80, 23);
            OrderMoveDownBtn.TabIndex = 1;
            OrderMoveDownBtn.Text = "Move Down";
            OrderMoveDownBtn.UseVisualStyleBackColor = true;
            OrderMoveDownBtn.Click += OrderMoveDownBtn_Click;
            // 
            // OrderMoveUpBtn
            // 
            OrderMoveUpBtn.Cursor = Cursors.Hand;
            OrderMoveUpBtn.Location = new Point(6, 22);
            OrderMoveUpBtn.Name = "OrderMoveUpBtn";
            OrderMoveUpBtn.Size = new Size(75, 23);
            OrderMoveUpBtn.TabIndex = 0;
            OrderMoveUpBtn.Text = "Move Up";
            OrderMoveUpBtn.UseVisualStyleBackColor = true;
            OrderMoveUpBtn.Click += OrderMoveUpBtn_Click;
            // 
            // ReceiverMgmtDataGridView
            // 
            ReceiverMgmtDataGridView.AllowUserToAddRows = false;
            ReceiverMgmtDataGridView.AllowUserToDeleteRows = false;
            ReceiverMgmtDataGridView.AllowUserToResizeColumns = false;
            ReceiverMgmtDataGridView.AllowUserToResizeRows = false;
            ReceiverMgmtDataGridView.BackgroundColor = SystemColors.Control;
            ReceiverMgmtDataGridView.BorderStyle = BorderStyle.Fixed3D;
            ReceiverMgmtDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReceiverMgmtDataGridView.Columns.AddRange(new DataGridViewColumn[] { ReceiverNameColumn, ReceiverIDColumn, ReceiverIPColumn, ReceiverStatusColumn });
            ReceiverMgmtDataGridView.GridColor = SystemColors.Control;
            ReceiverMgmtDataGridView.Location = new Point(6, 22);
            ReceiverMgmtDataGridView.MultiSelect = false;
            ReceiverMgmtDataGridView.Name = "ReceiverMgmtDataGridView";
            ReceiverMgmtDataGridView.ReadOnly = true;
            ReceiverMgmtDataGridView.RowHeadersVisible = false;
            ReceiverMgmtDataGridView.RowTemplate.Height = 25;
            ReceiverMgmtDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReceiverMgmtDataGridView.Size = new Size(473, 341);
            ReceiverMgmtDataGridView.TabIndex = 0;
            // 
            // ReceiverNameColumn
            // 
            ReceiverNameColumn.HeaderText = "Name";
            ReceiverNameColumn.Name = "ReceiverNameColumn";
            ReceiverNameColumn.ReadOnly = true;
            ReceiverNameColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            ReceiverNameColumn.Width = 150;
            // 
            // ReceiverIDColumn
            // 
            ReceiverIDColumn.HeaderText = "Receiver";
            ReceiverIDColumn.Name = "ReceiverIDColumn";
            ReceiverIDColumn.ReadOnly = true;
            ReceiverIDColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ReceiverIDColumn.Width = 120;
            // 
            // ReceiverIPColumn
            // 
            ReceiverIPColumn.HeaderText = "IP Address";
            ReceiverIPColumn.Name = "ReceiverIPColumn";
            ReceiverIPColumn.ReadOnly = true;
            ReceiverIPColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ReceiverStatusColumn
            // 
            ReceiverStatusColumn.HeaderText = "Status";
            ReceiverStatusColumn.Name = "ReceiverStatusColumn";
            ReceiverStatusColumn.ReadOnly = true;
            ReceiverStatusColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // CancelBtn
            // 
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.Location = new Point(422, 476);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 1;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.Location = new Point(341, 476);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 2;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ImportBtn
            // 
            ImportBtn.Cursor = Cursors.Hand;
            ImportBtn.Location = new Point(12, 476);
            ImportBtn.Name = "ImportBtn";
            ImportBtn.Size = new Size(75, 23);
            ImportBtn.TabIndex = 3;
            ImportBtn.Text = "Import";
            ImportBtn.UseVisualStyleBackColor = true;
            ImportBtn.Click += ImportBtn_Click;
            // 
            // ExportBtn
            // 
            ExportBtn.Cursor = Cursors.Hand;
            ExportBtn.Location = new Point(93, 476);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(75, 23);
            ExportBtn.TabIndex = 4;
            ExportBtn.Text = "Export";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // ConfigReceiverListfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(509, 511);
            Controls.Add(ExportBtn);
            Controls.Add(ImportBtn);
            Controls.Add(SaveBtn);
            Controls.Add(CancelBtn);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfigReceiverListfrm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Receiver Configuration";
            Load += ConfigReceiverListfrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReceiverMgmtDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button CancelBtn;
        private Button SaveBtn;
        private DataGridView ReceiverMgmtDataGridView;
        private GroupBox groupBox2;
        private Button OrderSortBtn;
        private Button OrderMoveDownBtn;
        private Button OrderMoveUpBtn;
        private Button DeleteReceiverBtn;
        private Button EditReceiverBtn;
        private Button AddReceiverBtn;
        private Button ImportBtn;
        private Button ExportBtn;
        private DataGridViewTextBoxColumn ReceiverNameColumn;
        private DataGridViewTextBoxColumn ReceiverIDColumn;
        private DataGridViewTextBoxColumn ReceiverIPColumn;
        private DataGridViewTextBoxColumn ReceiverStatusColumn;
    }
}