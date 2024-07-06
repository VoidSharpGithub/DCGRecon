namespace DCGRecon.Forms
{
    partial class SimulcastChannelfrm
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
            OKBtn = new Button();
            ChannelGroupbox = new GroupBox();
            DurationInputLbl = new Label();
            EndTimeInputLbl = new Label();
            StartTimeInputLbl = new Label();
            EventNameInputLbl = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ChannelGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // OKBtn
            // 
            OKBtn.Location = new Point(277, 152);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(75, 23);
            OKBtn.TabIndex = 0;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // ChannelGroupbox
            // 
            ChannelGroupbox.Controls.Add(DurationInputLbl);
            ChannelGroupbox.Controls.Add(EndTimeInputLbl);
            ChannelGroupbox.Controls.Add(StartTimeInputLbl);
            ChannelGroupbox.Controls.Add(EventNameInputLbl);
            ChannelGroupbox.Controls.Add(label5);
            ChannelGroupbox.Controls.Add(label4);
            ChannelGroupbox.Controls.Add(label3);
            ChannelGroupbox.Controls.Add(label1);
            ChannelGroupbox.Location = new Point(12, 12);
            ChannelGroupbox.Name = "ChannelGroupbox";
            ChannelGroupbox.Size = new Size(340, 134);
            ChannelGroupbox.TabIndex = 1;
            ChannelGroupbox.TabStop = false;
            ChannelGroupbox.Text = "Channel";
            // 
            // DurationInputLbl
            // 
            DurationInputLbl.Location = new Point(77, 105);
            DurationInputLbl.Name = "DurationInputLbl";
            DurationInputLbl.Size = new Size(257, 15);
            DurationInputLbl.TabIndex = 10;
            DurationInputLbl.Text = "Loading...";
            // 
            // EndTimeInputLbl
            // 
            EndTimeInputLbl.Location = new Point(80, 80);
            EndTimeInputLbl.Name = "EndTimeInputLbl";
            EndTimeInputLbl.Size = new Size(254, 15);
            EndTimeInputLbl.TabIndex = 9;
            EndTimeInputLbl.Text = "Loading...";
            // 
            // StartTimeInputLbl
            // 
            StartTimeInputLbl.Location = new Point(84, 54);
            StartTimeInputLbl.Name = "StartTimeInputLbl";
            StartTimeInputLbl.Size = new Size(250, 15);
            StartTimeInputLbl.TabIndex = 8;
            StartTimeInputLbl.Text = "Loading...";
            // 
            // EventNameInputLbl
            // 
            EventNameInputLbl.Location = new Point(95, 29);
            EventNameInputLbl.Name = "EventNameInputLbl";
            EventNameInputLbl.Size = new Size(239, 15);
            EventNameInputLbl.TabIndex = 6;
            EventNameInputLbl.Text = "Loading...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 105);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Duration:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 80);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "End Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 54);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Start Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Event Name:";
            // 
            // SimulcastChannelfrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 182);
            Controls.Add(ChannelGroupbox);
            Controls.Add(OKBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SimulcastChannelfrm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Simulcast Data";
            Load += SimulcastChannelfrm_Load;
            ChannelGroupbox.ResumeLayout(false);
            ChannelGroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button OKBtn;
        private GroupBox ChannelGroupbox;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label EventNameInputLbl;
        private Label RatingInputLbl;
        private Label DurationInputLbl;
        private Label EndTimeInputLbl;
        private Label StartTimeInputLbl;
    }
}