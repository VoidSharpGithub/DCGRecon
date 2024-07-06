namespace DCGRecon
{
    partial class Mainfrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            MenuStrip = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            ToolsMenuItem = new ToolStripMenuItem();
            CRLMenuItem = new ToolStripMenuItem();
            OptionsMenuItem = new ToolStripMenuItem();
            HelpMenuItem = new ToolStripMenuItem();
            CheckUpdatesMenuItem = new ToolStripMenuItem();
            AboutMenuItem = new ToolStripMenuItem();
            DebugMenuItem = new ToolStripMenuItem();
            GetTunerStatusMenuItem = new ToolStripMenuItem();
            Tuner1StatusMenuItem = new ToolStripMenuItem();
            Tuner2StatusMenuItem = new ToolStripMenuItem();
            GetChannelInfoMenuItem = new ToolStripMenuItem();
            Tuner1ChannelInfoMenuItem = new ToolStripMenuItem();
            Tuner2ChannelInfoMenuItem = new ToolStripMenuItem();
            ReceiverInfoMenuItem = new ToolStripMenuItem();
            DebuggingLogMenuItem = new ToolStripMenuItem();
            debugTestToolStripMenuItem = new ToolStripMenuItem();
            ReceiverDataGridView = new DataGridView();
            ReceiverNameColumn = new DataGridViewTextBoxColumn();
            ReceiverIDColumn = new DataGridViewTextBoxColumn();
            ReceiverMenuStrip = new ContextMenuStrip(components);
            RenameReceiverMenuItem = new ToolStripMenuItem();
            ReceiverLbl = new Label();
            SpacerPanel = new Panel();
            ReceiverGroupBox = new GroupBox();
            SimulcastGroupBox = new GroupBox();
            RefreshBtn = new Button();
            OnlyShowActiveCheckBox = new CheckBox();
            FilterBtn = new Button();
            SimulcastDataGridView = new DataGridView();
            ActiveRaceColumn = new DataGridViewCheckBoxColumn();
            RaceChannelColumn = new DataGridViewTextBoxColumn();
            RaceNameColumn = new DataGridViewTextBoxColumn();
            ReceiverInfoGroupBox = new GroupBox();
            ReceiverASInputLbl = new Label();
            ReceiverASLbl = new Label();
            ReceiverVersionInputLbl = new Label();
            ReceiverVersionLbl = new Label();
            ToggleAutoSimulcastBtn = new Button();
            SetUpdatesBtn = new Button();
            ReceiverModelInputLbl = new Label();
            ReceiverModelLbl = new Label();
            ReceiverUpdatesInputLbl = new Label();
            ReceiverIPInputLbl = new Label();
            ReceiverIDInputLbl = new Label();
            ReceiverUpdatesLbl = new Label();
            ReceiverIPLbl = new Label();
            ReceiverIDLbl = new Label();
            Tuner2GroupBox = new GroupBox();
            T2_TimeLbl = new Label();
            T2_StandbyBtn = new Button();
            T2_SetChannelBtn = new Button();
            T2_TitleLbl = new Label();
            T2_ChannelTxtbox = new TextBox();
            T2_DescLbl = new Label();
            T2_ChannelLbl = new Label();
            Tuner1GroupBox = new GroupBox();
            T1_TimeLbl = new Label();
            T1_StandbyBtn = new Button();
            T1_SetChannelBtn = new Button();
            T1_TitleLbl = new Label();
            T1_ChannelTxtbox = new TextBox();
            T1_DescLbl = new Label();
            T1_ChannelLbl = new Label();
            SimulcastMenuStrip = new ContextMenuStrip(components);
            OpenRaceMenuItem = new ToolStripMenuItem();
            DeleteRaceMenuItem = new ToolStripMenuItem();
            SetTuner1MenuItem = new ToolStripMenuItem();
            SetTuner2MenuItem = new ToolStripMenuItem();
            RecieverTimer = new System.Windows.Forms.Timer(components);
            ActiveChannelTimer = new System.Windows.Forms.Timer(components);
            MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReceiverDataGridView).BeginInit();
            ReceiverMenuStrip.SuspendLayout();
            ReceiverGroupBox.SuspendLayout();
            SimulcastGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SimulcastDataGridView).BeginInit();
            ReceiverInfoGroupBox.SuspendLayout();
            Tuner2GroupBox.SuspendLayout();
            Tuner1GroupBox.SuspendLayout();
            SimulcastMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(40, 40);
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuItem, ToolsMenuItem, HelpMenuItem, DebugMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(984, 24);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(37, 20);
            FileMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(93, 22);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // ToolsMenuItem
            // 
            ToolsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CRLMenuItem, OptionsMenuItem });
            ToolsMenuItem.Name = "ToolsMenuItem";
            ToolsMenuItem.Size = new Size(46, 20);
            ToolsMenuItem.Text = "Tools";
            // 
            // CRLMenuItem
            // 
            CRLMenuItem.Name = "CRLMenuItem";
            CRLMenuItem.Size = new Size(195, 22);
            CRLMenuItem.Text = "Configure Receiver List";
            CRLMenuItem.Click += CRLMenuItem_Click;
            // 
            // OptionsMenuItem
            // 
            OptionsMenuItem.Name = "OptionsMenuItem";
            OptionsMenuItem.Size = new Size(195, 22);
            OptionsMenuItem.Text = "Options";
            OptionsMenuItem.Click += OptionsMenuItem_Click;
            // 
            // HelpMenuItem
            // 
            HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CheckUpdatesMenuItem, AboutMenuItem });
            HelpMenuItem.Name = "HelpMenuItem";
            HelpMenuItem.Size = new Size(44, 20);
            HelpMenuItem.Text = "Help";
            // 
            // CheckUpdatesMenuItem
            // 
            CheckUpdatesMenuItem.Name = "CheckUpdatesMenuItem";
            CheckUpdatesMenuItem.Size = new Size(182, 22);
            CheckUpdatesMenuItem.Text = "Check For Updates...";
            CheckUpdatesMenuItem.Click += CheckUpdatesMenuItem_Click;
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.Size = new Size(182, 22);
            AboutMenuItem.Text = "About";
            AboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // DebugMenuItem
            // 
            DebugMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GetTunerStatusMenuItem, GetChannelInfoMenuItem, ReceiverInfoMenuItem, DebuggingLogMenuItem, debugTestToolStripMenuItem });
            DebugMenuItem.Name = "DebugMenuItem";
            DebugMenuItem.Size = new Size(54, 20);
            DebugMenuItem.Text = "Debug";
            // 
            // GetTunerStatusMenuItem
            // 
            GetTunerStatusMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tuner1StatusMenuItem, Tuner2StatusMenuItem });
            GetTunerStatusMenuItem.Name = "GetTunerStatusMenuItem";
            GetTunerStatusMenuItem.Size = new Size(163, 22);
            GetTunerStatusMenuItem.Text = "Get Tuner Status";
            // 
            // Tuner1StatusMenuItem
            // 
            Tuner1StatusMenuItem.Name = "Tuner1StatusMenuItem";
            Tuner1StatusMenuItem.Size = new Size(113, 22);
            Tuner1StatusMenuItem.Text = "Tuner 1";
            Tuner1StatusMenuItem.Click += Tuner1StatusMenuItem_Click;
            // 
            // Tuner2StatusMenuItem
            // 
            Tuner2StatusMenuItem.Name = "Tuner2StatusMenuItem";
            Tuner2StatusMenuItem.Size = new Size(113, 22);
            Tuner2StatusMenuItem.Text = "Tuner 2";
            Tuner2StatusMenuItem.Click += Tuner2StatusMenuItem_Click;
            // 
            // GetChannelInfoMenuItem
            // 
            GetChannelInfoMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tuner1ChannelInfoMenuItem, Tuner2ChannelInfoMenuItem });
            GetChannelInfoMenuItem.Name = "GetChannelInfoMenuItem";
            GetChannelInfoMenuItem.Size = new Size(163, 22);
            GetChannelInfoMenuItem.Text = "Get Channel Info";
            // 
            // Tuner1ChannelInfoMenuItem
            // 
            Tuner1ChannelInfoMenuItem.Name = "Tuner1ChannelInfoMenuItem";
            Tuner1ChannelInfoMenuItem.Size = new Size(113, 22);
            Tuner1ChannelInfoMenuItem.Text = "Tuner 1";
            Tuner1ChannelInfoMenuItem.Click += Tuner1ChannelInfoMenuItem_Click;
            // 
            // Tuner2ChannelInfoMenuItem
            // 
            Tuner2ChannelInfoMenuItem.Name = "Tuner2ChannelInfoMenuItem";
            Tuner2ChannelInfoMenuItem.Size = new Size(113, 22);
            Tuner2ChannelInfoMenuItem.Text = "Tuner 2";
            Tuner2ChannelInfoMenuItem.Click += Tuner2ChannelInfoMenuItem_Click;
            // 
            // ReceiverInfoMenuItem
            // 
            ReceiverInfoMenuItem.Name = "ReceiverInfoMenuItem";
            ReceiverInfoMenuItem.Size = new Size(163, 22);
            ReceiverInfoMenuItem.Text = "Get Receiver Info";
            ReceiverInfoMenuItem.Click += ReceiverInfoMenuItem_Click;
            // 
            // DebuggingLogMenuItem
            // 
            DebuggingLogMenuItem.Name = "DebuggingLogMenuItem";
            DebuggingLogMenuItem.Size = new Size(163, 22);
            DebuggingLogMenuItem.Text = "Debugging Log";
            DebuggingLogMenuItem.Click += DebuggingLogMenuItem_Click;
            // 
            // debugTestToolStripMenuItem
            // 
            debugTestToolStripMenuItem.Name = "debugTestToolStripMenuItem";
            debugTestToolStripMenuItem.Size = new Size(163, 22);
            debugTestToolStripMenuItem.Text = "DebugTest";
            debugTestToolStripMenuItem.Click += debugTestToolStripMenuItem_Click;
            // 
            // ReceiverDataGridView
            // 
            ReceiverDataGridView.AllowUserToAddRows = false;
            ReceiverDataGridView.AllowUserToDeleteRows = false;
            ReceiverDataGridView.AllowUserToResizeColumns = false;
            ReceiverDataGridView.AllowUserToResizeRows = false;
            ReceiverDataGridView.BackgroundColor = SystemColors.Control;
            ReceiverDataGridView.BorderStyle = BorderStyle.Fixed3D;
            ReceiverDataGridView.ColumnHeadersHeight = 26;
            ReceiverDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ReceiverDataGridView.Columns.AddRange(new DataGridViewColumn[] { ReceiverNameColumn, ReceiverIDColumn });
            ReceiverDataGridView.GridColor = SystemColors.Control;
            ReceiverDataGridView.Location = new Point(12, 60);
            ReceiverDataGridView.MultiSelect = false;
            ReceiverDataGridView.Name = "ReceiverDataGridView";
            ReceiverDataGridView.ReadOnly = true;
            ReceiverDataGridView.RowHeadersVisible = false;
            ReceiverDataGridView.RowHeadersWidth = 102;
            ReceiverDataGridView.RowTemplate.Height = 25;
            ReceiverDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReceiverDataGridView.Size = new Size(240, 378);
            ReceiverDataGridView.TabIndex = 0;
            ReceiverDataGridView.TabStop = false;
            ReceiverDataGridView.CellMouseClick += ReceiverDataGridView_CellMouseClick;
            ReceiverDataGridView.CellMouseDoubleClick += ReceiverDataGridView_CellMouseDoubleClick;
            // 
            // ReceiverNameColumn
            // 
            ReceiverNameColumn.HeaderText = "Receiver Name";
            ReceiverNameColumn.MinimumWidth = 12;
            ReceiverNameColumn.Name = "ReceiverNameColumn";
            ReceiverNameColumn.ReadOnly = true;
            ReceiverNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ReceiverIDColumn
            // 
            ReceiverIDColumn.HeaderText = "Receiver ID";
            ReceiverIDColumn.MinimumWidth = 12;
            ReceiverIDColumn.Name = "ReceiverIDColumn";
            ReceiverIDColumn.ReadOnly = true;
            ReceiverIDColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ReceiverIDColumn.Width = 136;
            // 
            // ReceiverMenuStrip
            // 
            ReceiverMenuStrip.ImageScalingSize = new Size(40, 40);
            ReceiverMenuStrip.Items.AddRange(new ToolStripItem[] { RenameReceiverMenuItem });
            ReceiverMenuStrip.Name = "ContextMenuStrip";
            ReceiverMenuStrip.Size = new Size(165, 26);
            // 
            // RenameReceiverMenuItem
            // 
            RenameReceiverMenuItem.Name = "RenameReceiverMenuItem";
            RenameReceiverMenuItem.Size = new Size(164, 22);
            RenameReceiverMenuItem.Text = "Rename Receiver";
            RenameReceiverMenuItem.Click += RenameReceiverMenuItem_Click;
            // 
            // ReceiverLbl
            // 
            ReceiverLbl.AutoSize = true;
            ReceiverLbl.Location = new Point(12, 42);
            ReceiverLbl.Name = "ReceiverLbl";
            ReceiverLbl.Size = new Size(59, 15);
            ReceiverLbl.TabIndex = 2;
            ReceiverLbl.Text = "Receivers:";
            // 
            // SpacerPanel
            // 
            SpacerPanel.Dock = DockStyle.Top;
            SpacerPanel.Location = new Point(0, 24);
            SpacerPanel.Name = "SpacerPanel";
            SpacerPanel.Size = new Size(984, 15);
            SpacerPanel.TabIndex = 3;
            // 
            // ReceiverGroupBox
            // 
            ReceiverGroupBox.Controls.Add(SimulcastGroupBox);
            ReceiverGroupBox.Controls.Add(ReceiverInfoGroupBox);
            ReceiverGroupBox.Controls.Add(Tuner2GroupBox);
            ReceiverGroupBox.Controls.Add(Tuner1GroupBox);
            ReceiverGroupBox.Location = new Point(258, 45);
            ReceiverGroupBox.Name = "ReceiverGroupBox";
            ReceiverGroupBox.Size = new Size(714, 393);
            ReceiverGroupBox.TabIndex = 4;
            ReceiverGroupBox.TabStop = false;
            ReceiverGroupBox.Text = "Receiver Name";
            // 
            // SimulcastGroupBox
            // 
            SimulcastGroupBox.Controls.Add(RefreshBtn);
            SimulcastGroupBox.Controls.Add(OnlyShowActiveCheckBox);
            SimulcastGroupBox.Controls.Add(FilterBtn);
            SimulcastGroupBox.Controls.Add(SimulcastDataGridView);
            SimulcastGroupBox.Location = new Point(357, 143);
            SimulcastGroupBox.Name = "SimulcastGroupBox";
            SimulcastGroupBox.Size = new Size(351, 244);
            SimulcastGroupBox.TabIndex = 3;
            SimulcastGroupBox.TabStop = false;
            SimulcastGroupBox.Text = "Simulcast";
            // 
            // RefreshBtn
            // 
            RefreshBtn.Cursor = Cursors.Hand;
            RefreshBtn.Location = new Point(189, 215);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 23);
            RefreshBtn.TabIndex = 9;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // OnlyShowActiveCheckBox
            // 
            OnlyShowActiveCheckBox.AutoSize = true;
            OnlyShowActiveCheckBox.Cursor = Cursors.Hand;
            OnlyShowActiveCheckBox.Location = new Point(11, 218);
            OnlyShowActiveCheckBox.Name = "OnlyShowActiveCheckBox";
            OnlyShowActiveCheckBox.Size = new Size(119, 19);
            OnlyShowActiveCheckBox.TabIndex = 8;
            OnlyShowActiveCheckBox.Text = "Only Show Active";
            OnlyShowActiveCheckBox.UseVisualStyleBackColor = true;
            OnlyShowActiveCheckBox.CheckedChanged += OnlyShowActiveCheckBox_CheckedChanged;
            // 
            // FilterBtn
            // 
            FilterBtn.Cursor = Cursors.Hand;
            FilterBtn.Enabled = false;
            FilterBtn.Location = new Point(270, 215);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(75, 23);
            FilterBtn.TabIndex = 7;
            FilterBtn.Text = "Filter";
            FilterBtn.UseVisualStyleBackColor = true;
            FilterBtn.Click += FilterBtn_Click;
            // 
            // SimulcastDataGridView
            // 
            SimulcastDataGridView.AllowUserToAddRows = false;
            SimulcastDataGridView.AllowUserToDeleteRows = false;
            SimulcastDataGridView.AllowUserToResizeRows = false;
            SimulcastDataGridView.BackgroundColor = SystemColors.Control;
            SimulcastDataGridView.BorderStyle = BorderStyle.Fixed3D;
            SimulcastDataGridView.ColumnHeadersHeight = 26;
            SimulcastDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            SimulcastDataGridView.Columns.AddRange(new DataGridViewColumn[] { ActiveRaceColumn, RaceChannelColumn, RaceNameColumn });
            SimulcastDataGridView.GridColor = SystemColors.Control;
            SimulcastDataGridView.Location = new Point(11, 22);
            SimulcastDataGridView.MultiSelect = false;
            SimulcastDataGridView.Name = "SimulcastDataGridView";
            SimulcastDataGridView.ReadOnly = true;
            SimulcastDataGridView.RowHeadersVisible = false;
            SimulcastDataGridView.RowHeadersWidth = 102;
            SimulcastDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            SimulcastDataGridView.RowTemplate.Height = 25;
            SimulcastDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SimulcastDataGridView.Size = new Size(334, 187);
            SimulcastDataGridView.TabIndex = 0;
            SimulcastDataGridView.TabStop = false;
            SimulcastDataGridView.CellFormatting += SimulcastDataGridView_CellFormatting;
            SimulcastDataGridView.CellMouseClick += SimulcastDataGridView_CellMouseClick;
            SimulcastDataGridView.CellMouseDoubleClick += SimulcastDataGridView_CellMouseDoubleClick;
            // 
            // ActiveRaceColumn
            // 
            ActiveRaceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ActiveRaceColumn.HeaderText = "Active";
            ActiveRaceColumn.MinimumWidth = 12;
            ActiveRaceColumn.Name = "ActiveRaceColumn";
            ActiveRaceColumn.ReadOnly = true;
            ActiveRaceColumn.Resizable = DataGridViewTriState.True;
            ActiveRaceColumn.Width = 46;
            // 
            // RaceChannelColumn
            // 
            RaceChannelColumn.HeaderText = "Race Channel";
            RaceChannelColumn.Name = "RaceChannelColumn";
            RaceChannelColumn.ReadOnly = true;
            RaceChannelColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // RaceNameColumn
            // 
            RaceNameColumn.HeaderText = "Race Name";
            RaceNameColumn.MinimumWidth = 12;
            RaceNameColumn.Name = "RaceNameColumn";
            RaceNameColumn.ReadOnly = true;
            RaceNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            RaceNameColumn.Width = 220;
            // 
            // ReceiverInfoGroupBox
            // 
            ReceiverInfoGroupBox.Controls.Add(ReceiverASInputLbl);
            ReceiverInfoGroupBox.Controls.Add(ReceiverASLbl);
            ReceiverInfoGroupBox.Controls.Add(ReceiverVersionInputLbl);
            ReceiverInfoGroupBox.Controls.Add(ReceiverVersionLbl);
            ReceiverInfoGroupBox.Controls.Add(ToggleAutoSimulcastBtn);
            ReceiverInfoGroupBox.Controls.Add(SetUpdatesBtn);
            ReceiverInfoGroupBox.Controls.Add(ReceiverModelInputLbl);
            ReceiverInfoGroupBox.Controls.Add(ReceiverModelLbl);
            ReceiverInfoGroupBox.Controls.Add(ReceiverUpdatesInputLbl);
            ReceiverInfoGroupBox.Controls.Add(ReceiverIPInputLbl);
            ReceiverInfoGroupBox.Controls.Add(ReceiverIDInputLbl);
            ReceiverInfoGroupBox.Controls.Add(ReceiverUpdatesLbl);
            ReceiverInfoGroupBox.Controls.Add(ReceiverIPLbl);
            ReceiverInfoGroupBox.Controls.Add(ReceiverIDLbl);
            ReceiverInfoGroupBox.Location = new Point(6, 143);
            ReceiverInfoGroupBox.Name = "ReceiverInfoGroupBox";
            ReceiverInfoGroupBox.Size = new Size(345, 244);
            ReceiverInfoGroupBox.TabIndex = 2;
            ReceiverInfoGroupBox.TabStop = false;
            ReceiverInfoGroupBox.Text = "Receiver Information";
            // 
            // ReceiverASInputLbl
            // 
            ReceiverASInputLbl.Anchor = AnchorStyles.Right;
            ReceiverASInputLbl.Location = new Point(201, 148);
            ReceiverASInputLbl.Name = "ReceiverASInputLbl";
            ReceiverASInputLbl.Size = new Size(138, 15);
            ReceiverASInputLbl.TabIndex = 22;
            ReceiverASInputLbl.Text = "Enabled";
            ReceiverASInputLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ReceiverASLbl
            // 
            ReceiverASLbl.AutoSize = true;
            ReceiverASLbl.Location = new Point(6, 148);
            ReceiverASLbl.Name = "ReceiverASLbl";
            ReceiverASLbl.Size = new Size(137, 15);
            ReceiverASLbl.TabIndex = 21;
            ReceiverASLbl.Text = "Receiver Auto Simulcast:";
            // 
            // ReceiverVersionInputLbl
            // 
            ReceiverVersionInputLbl.Anchor = AnchorStyles.Right;
            ReceiverVersionInputLbl.Location = new Point(208, 124);
            ReceiverVersionInputLbl.Name = "ReceiverVersionInputLbl";
            ReceiverVersionInputLbl.Size = new Size(131, 15);
            ReceiverVersionInputLbl.TabIndex = 20;
            ReceiverVersionInputLbl.Text = "X885RPHD-N";
            ReceiverVersionInputLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ReceiverVersionLbl
            // 
            ReceiverVersionLbl.AutoSize = true;
            ReceiverVersionLbl.Location = new Point(6, 124);
            ReceiverVersionLbl.Name = "ReceiverVersionLbl";
            ReceiverVersionLbl.Size = new Size(144, 15);
            ReceiverVersionLbl.TabIndex = 19;
            ReceiverVersionLbl.Text = "Receiver Software Version:";
            // 
            // ToggleAutoSimulcastBtn
            // 
            ToggleAutoSimulcastBtn.Cursor = Cursors.Hand;
            ToggleAutoSimulcastBtn.Location = new Point(6, 214);
            ToggleAutoSimulcastBtn.Name = "ToggleAutoSimulcastBtn";
            ToggleAutoSimulcastBtn.Size = new Size(183, 23);
            ToggleAutoSimulcastBtn.TabIndex = 18;
            ToggleAutoSimulcastBtn.Text = "Toggle Auto Simulcast";
            ToggleAutoSimulcastBtn.UseVisualStyleBackColor = true;
            ToggleAutoSimulcastBtn.Click += ToggleAutoSimulcastBtn_Click;
            // 
            // SetUpdatesBtn
            // 
            SetUpdatesBtn.Cursor = Cursors.Hand;
            SetUpdatesBtn.Location = new Point(195, 214);
            SetUpdatesBtn.Name = "SetUpdatesBtn";
            SetUpdatesBtn.Size = new Size(92, 23);
            SetUpdatesBtn.TabIndex = 17;
            SetUpdatesBtn.Text = "Set Updates";
            SetUpdatesBtn.UseVisualStyleBackColor = true;
            SetUpdatesBtn.Click += SetUpdatesBtn_Click;
            // 
            // ReceiverModelInputLbl
            // 
            ReceiverModelInputLbl.Anchor = AnchorStyles.Right;
            ReceiverModelInputLbl.Location = new Point(155, 100);
            ReceiverModelInputLbl.Name = "ReceiverModelInputLbl";
            ReceiverModelInputLbl.Size = new Size(183, 15);
            ReceiverModelInputLbl.TabIndex = 16;
            ReceiverModelInputLbl.Text = "ViP222k";
            ReceiverModelInputLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ReceiverModelLbl
            // 
            ReceiverModelLbl.AutoSize = true;
            ReceiverModelLbl.Location = new Point(6, 100);
            ReceiverModelLbl.Name = "ReceiverModelLbl";
            ReceiverModelLbl.Size = new Size(91, 15);
            ReceiverModelLbl.TabIndex = 15;
            ReceiverModelLbl.Text = "Receiver Model:";
            // 
            // ReceiverUpdatesInputLbl
            // 
            ReceiverUpdatesInputLbl.Anchor = AnchorStyles.Right;
            ReceiverUpdatesInputLbl.Location = new Point(164, 76);
            ReceiverUpdatesInputLbl.Name = "ReceiverUpdatesInputLbl";
            ReceiverUpdatesInputLbl.Size = new Size(175, 15);
            ReceiverUpdatesInputLbl.TabIndex = 6;
            ReceiverUpdatesInputLbl.Text = "(Universal) Enabled Daily";
            ReceiverUpdatesInputLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ReceiverIPInputLbl
            // 
            ReceiverIPInputLbl.Anchor = AnchorStyles.Right;
            ReceiverIPInputLbl.Location = new Point(178, 52);
            ReceiverIPInputLbl.Name = "ReceiverIPInputLbl";
            ReceiverIPInputLbl.Size = new Size(161, 15);
            ReceiverIPInputLbl.TabIndex = 5;
            ReceiverIPInputLbl.Text = "172.16.96.44";
            ReceiverIPInputLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ReceiverIDInputLbl
            // 
            ReceiverIDInputLbl.Anchor = AnchorStyles.Right;
            ReceiverIDInputLbl.Location = new Point(132, 28);
            ReceiverIDInputLbl.Name = "ReceiverIDInputLbl";
            ReceiverIDInputLbl.Size = new Size(206, 15);
            ReceiverIDInputLbl.TabIndex = 4;
            ReceiverIDInputLbl.Text = "R0111652353";
            ReceiverIDInputLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ReceiverUpdatesLbl
            // 
            ReceiverUpdatesLbl.AutoSize = true;
            ReceiverUpdatesLbl.Location = new Point(6, 76);
            ReceiverUpdatesLbl.Name = "ReceiverUpdatesLbl";
            ReceiverUpdatesLbl.Size = new Size(100, 15);
            ReceiverUpdatesLbl.TabIndex = 2;
            ReceiverUpdatesLbl.Text = "Receiver Updates:";
            // 
            // ReceiverIPLbl
            // 
            ReceiverIPLbl.AutoSize = true;
            ReceiverIPLbl.Location = new Point(6, 52);
            ReceiverIPLbl.Name = "ReceiverIPLbl";
            ReceiverIPLbl.Size = new Size(112, 15);
            ReceiverIPLbl.TabIndex = 1;
            ReceiverIPLbl.Text = "Receiver IP Address:";
            // 
            // ReceiverIDLbl
            // 
            ReceiverIDLbl.AutoSize = true;
            ReceiverIDLbl.Location = new Point(6, 28);
            ReceiverIDLbl.Name = "ReceiverIDLbl";
            ReceiverIDLbl.Size = new Size(68, 15);
            ReceiverIDLbl.TabIndex = 0;
            ReceiverIDLbl.Text = "Receiver ID:";
            // 
            // Tuner2GroupBox
            // 
            Tuner2GroupBox.Controls.Add(T2_TimeLbl);
            Tuner2GroupBox.Controls.Add(T2_StandbyBtn);
            Tuner2GroupBox.Controls.Add(T2_SetChannelBtn);
            Tuner2GroupBox.Controls.Add(T2_TitleLbl);
            Tuner2GroupBox.Controls.Add(T2_ChannelTxtbox);
            Tuner2GroupBox.Controls.Add(T2_DescLbl);
            Tuner2GroupBox.Controls.Add(T2_ChannelLbl);
            Tuner2GroupBox.Location = new Point(357, 22);
            Tuner2GroupBox.Name = "Tuner2GroupBox";
            Tuner2GroupBox.Size = new Size(351, 115);
            Tuner2GroupBox.TabIndex = 1;
            Tuner2GroupBox.TabStop = false;
            Tuner2GroupBox.Text = "Tuner 2";
            // 
            // T2_TimeLbl
            // 
            T2_TimeLbl.Location = new Point(6, 67);
            T2_TimeLbl.Name = "T2_TimeLbl";
            T2_TimeLbl.Size = new Size(281, 15);
            T2_TimeLbl.TabIndex = 10;
            T2_TimeLbl.Tag = "1";
            T2_TimeLbl.Text = "Schedule: ";
            // 
            // T2_StandbyBtn
            // 
            T2_StandbyBtn.Cursor = Cursors.Hand;
            T2_StandbyBtn.Location = new Point(212, 86);
            T2_StandbyBtn.Name = "T2_StandbyBtn";
            T2_StandbyBtn.Size = new Size(75, 23);
            T2_StandbyBtn.TabIndex = 6;
            T2_StandbyBtn.Tag = "1";
            T2_StandbyBtn.Text = "Standby";
            T2_StandbyBtn.UseVisualStyleBackColor = true;
            T2_StandbyBtn.Click += T2_StandbyBtn_Click;
            // 
            // T2_SetChannelBtn
            // 
            T2_SetChannelBtn.Cursor = Cursors.Hand;
            T2_SetChannelBtn.Location = new Point(126, 86);
            T2_SetChannelBtn.Name = "T2_SetChannelBtn";
            T2_SetChannelBtn.Size = new Size(80, 23);
            T2_SetChannelBtn.TabIndex = 5;
            T2_SetChannelBtn.Tag = "1";
            T2_SetChannelBtn.Text = "Set Channel";
            T2_SetChannelBtn.UseVisualStyleBackColor = true;
            T2_SetChannelBtn.Click += T2_SetChannelBtn_Click;
            // 
            // T2_TitleLbl
            // 
            T2_TitleLbl.Location = new Point(6, 36);
            T2_TitleLbl.Name = "T2_TitleLbl";
            T2_TitleLbl.Size = new Size(281, 15);
            T2_TitleLbl.TabIndex = 9;
            T2_TitleLbl.Tag = "1";
            T2_TitleLbl.Text = "Title: Simulcast Guide";
            // 
            // T2_ChannelTxtbox
            // 
            T2_ChannelTxtbox.Cursor = Cursors.IBeam;
            T2_ChannelTxtbox.Location = new Point(6, 86);
            T2_ChannelTxtbox.MaxLength = 4;
            T2_ChannelTxtbox.Name = "T2_ChannelTxtbox";
            T2_ChannelTxtbox.PlaceholderText = "####";
            T2_ChannelTxtbox.Size = new Size(114, 23);
            T2_ChannelTxtbox.TabIndex = 4;
            T2_ChannelTxtbox.Tag = "1";
            T2_ChannelTxtbox.KeyPress += T2_ChannelTxtbox_KeyPress;
            // 
            // T2_DescLbl
            // 
            T2_DescLbl.Location = new Point(6, 52);
            T2_DescLbl.Name = "T2_DescLbl";
            T2_DescLbl.Size = new Size(281, 15);
            T2_DescLbl.TabIndex = 7;
            T2_DescLbl.Tag = "1";
            T2_DescLbl.Text = "Event: Schedule of today's simulcasts.";
            // 
            // T2_ChannelLbl
            // 
            T2_ChannelLbl.Location = new Point(6, 20);
            T2_ChannelLbl.Name = "T2_ChannelLbl";
            T2_ChannelLbl.Size = new Size(281, 15);
            T2_ChannelLbl.TabIndex = 6;
            T2_ChannelLbl.Tag = "1";
            T2_ChannelLbl.Text = "Channel: 9000";
            // 
            // Tuner1GroupBox
            // 
            Tuner1GroupBox.Controls.Add(T1_TimeLbl);
            Tuner1GroupBox.Controls.Add(T1_StandbyBtn);
            Tuner1GroupBox.Controls.Add(T1_SetChannelBtn);
            Tuner1GroupBox.Controls.Add(T1_TitleLbl);
            Tuner1GroupBox.Controls.Add(T1_ChannelTxtbox);
            Tuner1GroupBox.Controls.Add(T1_DescLbl);
            Tuner1GroupBox.Controls.Add(T1_ChannelLbl);
            Tuner1GroupBox.Location = new Point(6, 22);
            Tuner1GroupBox.Name = "Tuner1GroupBox";
            Tuner1GroupBox.Size = new Size(345, 115);
            Tuner1GroupBox.TabIndex = 0;
            Tuner1GroupBox.TabStop = false;
            Tuner1GroupBox.Text = "Tuner 1";
            // 
            // T1_TimeLbl
            // 
            T1_TimeLbl.Location = new Point(6, 68);
            T1_TimeLbl.Name = "T1_TimeLbl";
            T1_TimeLbl.Size = new Size(280, 15);
            T1_TimeLbl.TabIndex = 4;
            T1_TimeLbl.Tag = "0";
            T1_TimeLbl.Text = "Schedule: ";
            // 
            // T1_StandbyBtn
            // 
            T1_StandbyBtn.Cursor = Cursors.Hand;
            T1_StandbyBtn.Location = new Point(212, 86);
            T1_StandbyBtn.Name = "T1_StandbyBtn";
            T1_StandbyBtn.Size = new Size(75, 23);
            T1_StandbyBtn.TabIndex = 3;
            T1_StandbyBtn.Tag = "0";
            T1_StandbyBtn.Text = "Standby";
            T1_StandbyBtn.UseVisualStyleBackColor = true;
            T1_StandbyBtn.Click += T1_StandbyBtn_Click;
            // 
            // T1_SetChannelBtn
            // 
            T1_SetChannelBtn.Cursor = Cursors.Hand;
            T1_SetChannelBtn.Location = new Point(126, 86);
            T1_SetChannelBtn.Name = "T1_SetChannelBtn";
            T1_SetChannelBtn.Size = new Size(80, 23);
            T1_SetChannelBtn.TabIndex = 2;
            T1_SetChannelBtn.Tag = "0";
            T1_SetChannelBtn.Text = "Set Channel";
            T1_SetChannelBtn.UseVisualStyleBackColor = true;
            T1_SetChannelBtn.Click += T1_SetChannelBtn_Click;
            // 
            // T1_TitleLbl
            // 
            T1_TitleLbl.Location = new Point(6, 36);
            T1_TitleLbl.Name = "T1_TitleLbl";
            T1_TitleLbl.Size = new Size(280, 15);
            T1_TitleLbl.TabIndex = 3;
            T1_TitleLbl.Tag = "0";
            T1_TitleLbl.Text = "Title: Simulcast Guide";
            // 
            // T1_ChannelTxtbox
            // 
            T1_ChannelTxtbox.Cursor = Cursors.IBeam;
            T1_ChannelTxtbox.Location = new Point(6, 86);
            T1_ChannelTxtbox.MaxLength = 4;
            T1_ChannelTxtbox.Name = "T1_ChannelTxtbox";
            T1_ChannelTxtbox.PlaceholderText = "####";
            T1_ChannelTxtbox.Size = new Size(114, 23);
            T1_ChannelTxtbox.TabIndex = 1;
            T1_ChannelTxtbox.Tag = "0";
            T1_ChannelTxtbox.KeyPress += T1_ChannelTxtbox_KeyPress;
            // 
            // T1_DescLbl
            // 
            T1_DescLbl.Location = new Point(6, 52);
            T1_DescLbl.Name = "T1_DescLbl";
            T1_DescLbl.Size = new Size(280, 15);
            T1_DescLbl.TabIndex = 1;
            T1_DescLbl.Tag = "0";
            T1_DescLbl.Text = "Event: Schedule of today's simulcasts.";
            // 
            // T1_ChannelLbl
            // 
            T1_ChannelLbl.Location = new Point(6, 20);
            T1_ChannelLbl.Name = "T1_ChannelLbl";
            T1_ChannelLbl.Size = new Size(280, 15);
            T1_ChannelLbl.TabIndex = 0;
            T1_ChannelLbl.Tag = "0";
            T1_ChannelLbl.Text = "Channel: 9000";
            // 
            // SimulcastMenuStrip
            // 
            SimulcastMenuStrip.Items.AddRange(new ToolStripItem[] { OpenRaceMenuItem, DeleteRaceMenuItem, SetTuner1MenuItem, SetTuner2MenuItem });
            SimulcastMenuStrip.Name = "SimulcastMenuStrip";
            SimulcastMenuStrip.Size = new Size(136, 92);
            SimulcastMenuStrip.Opening += SimulcastMenuStrip_Opening;
            // 
            // OpenRaceMenuItem
            // 
            OpenRaceMenuItem.Name = "OpenRaceMenuItem";
            OpenRaceMenuItem.Size = new Size(135, 22);
            OpenRaceMenuItem.Text = "Open Race";
            OpenRaceMenuItem.Click += OpenRaceMenuItem_Click;
            // 
            // DeleteRaceMenuItem
            // 
            DeleteRaceMenuItem.Name = "DeleteRaceMenuItem";
            DeleteRaceMenuItem.Size = new Size(135, 22);
            DeleteRaceMenuItem.Text = "Delete Race";
            DeleteRaceMenuItem.Click += DeleteRaceMenuItem_Click;
            // 
            // SetTuner1MenuItem
            // 
            SetTuner1MenuItem.Name = "SetTuner1MenuItem";
            SetTuner1MenuItem.Size = new Size(135, 22);
            SetTuner1MenuItem.Text = "Set Tuner 1";
            SetTuner1MenuItem.Click += SetTuner1MenuItem_Click;
            // 
            // SetTuner2MenuItem
            // 
            SetTuner2MenuItem.Name = "SetTuner2MenuItem";
            SetTuner2MenuItem.Size = new Size(135, 22);
            SetTuner2MenuItem.Text = "Set Tuner 2";
            SetTuner2MenuItem.Click += SetTuner2MenuItem_Click;
            // 
            // RecieverTimer
            // 
            RecieverTimer.Enabled = true;
            RecieverTimer.Interval = 1000;
            RecieverTimer.Tick += RecieverTimer_Tick;
            // 
            // ActiveChannelTimer
            // 
            ActiveChannelTimer.Enabled = true;
            ActiveChannelTimer.Interval = 3000;
            ActiveChannelTimer.Tick += ActiveChannelTimer_Tick;
            // 
            // Mainfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(ReceiverGroupBox);
            Controls.Add(SpacerPanel);
            Controls.Add(ReceiverLbl);
            Controls.Add(ReceiverDataGridView);
            Controls.Add(MenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(895, 489);
            MainMenuStrip = MenuStrip;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 489);
            Name = "Mainfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DCG - Recon";
            FormClosing += Mainfrm_FormClosing;
            Load += Mainfrm_Load;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReceiverDataGridView).EndInit();
            ReceiverMenuStrip.ResumeLayout(false);
            ReceiverGroupBox.ResumeLayout(false);
            SimulcastGroupBox.ResumeLayout(false);
            SimulcastGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SimulcastDataGridView).EndInit();
            ReceiverInfoGroupBox.ResumeLayout(false);
            ReceiverInfoGroupBox.PerformLayout();
            Tuner2GroupBox.ResumeLayout(false);
            Tuner2GroupBox.PerformLayout();
            Tuner1GroupBox.ResumeLayout(false);
            Tuner1GroupBox.PerformLayout();
            SimulcastMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem ToolsMenuItem;
        private ToolStripMenuItem CRLMenuItem;
        private ToolStripMenuItem OptionsMenuItem;
        private ToolStripMenuItem HelpMenuItem;
        private ToolStripMenuItem CheckUpdatesMenuItem;
        private ToolStripMenuItem AboutMenuItem;
        private DataGridView ReceiverDataGridView;
        private Label ReceiverLbl;
        private Panel SpacerPanel;
        private GroupBox ReceiverGroupBox;
        private GroupBox Tuner1GroupBox;
        private GroupBox Tuner2GroupBox;
        private GroupBox ReceiverInfoGroupBox;
        private Label T1_ChannelLbl;
        private Label T1_DescLbl;
        private Label T1_TitleLbl;
        private TextBox T1_ChannelTxtbox;
        private Button T1_StandbyBtn;
        private Button T1_SetChannelBtn;
        private Button T2_StandbyBtn;
        private Button T2_SetChannelBtn;
        private Label T2_TitleLbl;
        private TextBox T2_ChannelTxtbox;
        private Label T2_DescLbl;
        private Label T2_ChannelLbl;
        private Label ReceiverIDLbl;
        private Label ReceiverUpdatesLbl;
        private Label ReceiverIPLbl;
        private Label ReceiverIDInputLbl;
        private Label ReceiverUpdatesInputLbl;
        private Label ReceiverIPInputLbl;
        private GroupBox SimulcastGroupBox;
        private Button FilterBtn;
        private DataGridView SimulcastDataGridView;
        private Label ReceiverModelInputLbl;
        private Label ReceiverModelLbl;
        private ToolStripMenuItem DebugMenuItem;
        private CheckBox OnlyShowActiveCheckBox;
        private Button SetUpdatesBtn;
        private Button ToggleAutoSimulcastBtn;
        private Label ReceiverVersionLbl;
        private Label ReceiverVersionInputLbl;
        private ContextMenuStrip ReceiverMenuStrip;
        private ToolStripMenuItem RenameReceiverMenuItem;
        private ToolStripMenuItem GetTunerStatusMenuItem;
        private ToolStripMenuItem Tuner1StatusMenuItem;
        private ToolStripMenuItem Tuner2StatusMenuItem;
        private ToolStripMenuItem GetChannelInfoMenuItem;
        private ToolStripMenuItem Tuner1ChannelInfoMenuItem;
        private ToolStripMenuItem DebuggingLogMenuItem;
        private ToolStripMenuItem Tuner2ChannelInfoMenuItem;
        private ToolStripMenuItem ReceiverInfoMenuItem;
        private Label ReceiverASInputLbl;
        private Label ReceiverASLbl;
        private Label T2_TimeLbl;
        private Label T1_TimeLbl;
        private DataGridViewTextBoxColumn ReceiverNameColumn;
        private DataGridViewTextBoxColumn ReceiverIDColumn;
        private Button RefreshBtn;
        private DataGridViewCheckBoxColumn ActiveRaceColumn;
        private DataGridViewTextBoxColumn RaceChannelColumn;
        private DataGridViewTextBoxColumn RaceNameColumn;
        private ContextMenuStrip SimulcastMenuStrip;
        private ToolStripMenuItem OpenRaceMenuItem;
        private System.Windows.Forms.Timer RecieverTimer;
        private ToolStripMenuItem DeleteRaceMenuItem;
        private ToolStripMenuItem debugTestToolStripMenuItem;
        private ToolStripMenuItem SetTuner1MenuItem;
        private ToolStripMenuItem SetTuner2MenuItem;
        private System.Windows.Forms.Timer ActiveChannelTimer;
    }
}