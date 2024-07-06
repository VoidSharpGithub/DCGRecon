namespace DCGRecon.Forms
{
    partial class AddReceiverfrm
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
            NameLbl = new Label();
            ReceiverNameTxtbox = new TextBox();
            ReceiverIDTxtbox = new TextBox();
            ReceiverIDLbl = new Label();
            ReceiverIPTxtbox = new TextBox();
            ReceiverIPLbl = new Label();
            CancelBtn = new Button();
            OKBtn = new Button();
            HelpLbl = new Label();
            SuspendLayout();
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(12, 9);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(42, 15);
            NameLbl.TabIndex = 0;
            NameLbl.Text = "Name:";
            // 
            // ReceiverNameTxtbox
            // 
            ReceiverNameTxtbox.Location = new Point(12, 27);
            ReceiverNameTxtbox.Name = "ReceiverNameTxtbox";
            ReceiverNameTxtbox.Size = new Size(172, 23);
            ReceiverNameTxtbox.TabIndex = 1;
            // 
            // ReceiverIDTxtbox
            // 
            ReceiverIDTxtbox.Location = new Point(12, 71);
            ReceiverIDTxtbox.Name = "ReceiverIDTxtbox";
            ReceiverIDTxtbox.Size = new Size(172, 23);
            ReceiverIDTxtbox.TabIndex = 3;
            // 
            // ReceiverIDLbl
            // 
            ReceiverIDLbl.AutoSize = true;
            ReceiverIDLbl.Location = new Point(12, 53);
            ReceiverIDLbl.Name = "ReceiverIDLbl";
            ReceiverIDLbl.Size = new Size(68, 15);
            ReceiverIDLbl.TabIndex = 2;
            ReceiverIDLbl.Text = "Receiver ID:";
            // 
            // ReceiverIPTxtbox
            // 
            ReceiverIPTxtbox.Location = new Point(12, 115);
            ReceiverIPTxtbox.Name = "ReceiverIPTxtbox";
            ReceiverIPTxtbox.Size = new Size(172, 23);
            ReceiverIPTxtbox.TabIndex = 5;
            // 
            // ReceiverIPLbl
            // 
            ReceiverIPLbl.AutoSize = true;
            ReceiverIPLbl.Location = new Point(12, 97);
            ReceiverIPLbl.Name = "ReceiverIPLbl";
            ReceiverIPLbl.Size = new Size(65, 15);
            ReceiverIPLbl.TabIndex = 4;
            ReceiverIPLbl.Text = "IP Address:";
            // 
            // CancelBtn
            // 
            CancelBtn.DialogResult = DialogResult.Cancel;
            CancelBtn.Location = new Point(221, 146);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 6;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            OKBtn.Location = new Point(140, 146);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(75, 23);
            OKBtn.TabIndex = 7;
            OKBtn.Text = "Add";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // HelpLbl
            // 
            HelpLbl.AutoSize = true;
            HelpLbl.Location = new Point(190, 74);
            HelpLbl.Name = "HelpLbl";
            HelpLbl.Size = new Size(92, 15);
            HelpLbl.TabIndex = 8;
            HelpLbl.Text = "Ex: R0123456789";
            // 
            // AddReceiverfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(308, 181);
            Controls.Add(HelpLbl);
            Controls.Add(OKBtn);
            Controls.Add(CancelBtn);
            Controls.Add(ReceiverIPTxtbox);
            Controls.Add(ReceiverIPLbl);
            Controls.Add(ReceiverIDTxtbox);
            Controls.Add(ReceiverIDLbl);
            Controls.Add(ReceiverNameTxtbox);
            Controls.Add(NameLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddReceiverfrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Receiver";
            Load += AddReceiverfrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLbl;
        private TextBox ReceiverNameTxtbox;
        private TextBox ReceiverIDTxtbox;
        private Label ReceiverIDLbl;
        private TextBox ReceiverIPTxtbox;
        private Label ReceiverIPLbl;
        private Button CancelBtn;
        private Button OKBtn;
        private Label HelpLbl;
    }
}