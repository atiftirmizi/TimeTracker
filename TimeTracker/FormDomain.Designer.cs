namespace TimeTracker
{
    partial class FormDomain
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
            this.clockInButton = new System.Windows.Forms.Button();
            this.clockOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Time = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ptoDetails = new System.Windows.Forms.LinkLabel();
            this.requestPTOLable = new System.Windows.Forms.Label();
            this.ptoButton = new System.Windows.Forms.Button();
            this.timeGroupBox = new System.Windows.Forms.GroupBox();
            this.timeDayLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.currentTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.commentsTextBox = new System.Windows.Forms.RichTextBox();
            this.concernLabel = new System.Windows.Forms.Label();
            this.concernsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.payGroupBox = new System.Windows.Forms.GroupBox();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.payLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Time.SuspendLayout();
            this.timeGroupBox.SuspendLayout();
            this.currentTimeGroupBox.SuspendLayout();
            this.payGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockInButton
            // 
            this.clockInButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.clockInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInButton.Location = new System.Drawing.Point(22, 26);
            this.clockInButton.Name = "clockInButton";
            this.clockInButton.Size = new System.Drawing.Size(188, 92);
            this.clockInButton.TabIndex = 0;
            this.clockInButton.Text = "Clock In";
            this.clockInButton.UseVisualStyleBackColor = false;
            this.clockInButton.Click += new System.EventHandler(this.clockInButton_Click);
            // 
            // clockOutButton
            // 
            this.clockOutButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.clockOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockOutButton.Location = new System.Drawing.Point(22, 138);
            this.clockOutButton.Name = "clockOutButton";
            this.clockOutButton.Size = new System.Drawing.Size(188, 92);
            this.clockOutButton.TabIndex = 1;
            this.clockOutButton.Text = "Clock Out";
            this.clockOutButton.UseVisualStyleBackColor = false;
            this.clockOutButton.Click += new System.EventHandler(this.clockOutButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Time
            // 
            this.Time.Controls.Add(this.label2);
            this.Time.Controls.Add(this.dateTimePicker2);
            this.Time.Controls.Add(this.ptoDetails);
            this.Time.Controls.Add(this.requestPTOLable);
            this.Time.Controls.Add(this.dateTimePicker1);
            this.Time.Location = new System.Drawing.Point(12, 258);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(326, 232);
            this.Time.TabIndex = 3;
            this.Time.TabStop = false;
            this.Time.Text = "Vacation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "To:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 195);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(288, 26);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // ptoDetails
            // 
            this.ptoDetails.AutoSize = true;
            this.ptoDetails.Location = new System.Drawing.Point(6, 37);
            this.ptoDetails.Name = "ptoDetails";
            this.ptoDetails.Size = new System.Drawing.Size(96, 20);
            this.ptoDetails.TabIndex = 5;
            this.ptoDetails.TabStop = true;
            this.ptoDetails.Text = "View Details";
            this.ptoDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ptoDetails_LinkClicked);
            // 
            // requestPTOLable
            // 
            this.requestPTOLable.AutoSize = true;
            this.requestPTOLable.Location = new System.Drawing.Point(6, 83);
            this.requestPTOLable.Name = "requestPTOLable";
            this.requestPTOLable.Size = new System.Drawing.Size(156, 20);
            this.requestPTOLable.TabIndex = 4;
            this.requestPTOLable.Text = "Request PTO (From)";
            // 
            // ptoButton
            // 
            this.ptoButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ptoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ptoButton.Location = new System.Drawing.Point(18, 495);
            this.ptoButton.Name = "ptoButton";
            this.ptoButton.Size = new System.Drawing.Size(320, 45);
            this.ptoButton.TabIndex = 6;
            this.ptoButton.Text = "Submit";
            this.ptoButton.UseVisualStyleBackColor = false;
            this.ptoButton.Click += new System.EventHandler(this.ptoButton_Click);
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.Controls.Add(this.timeDayLabel);
            this.timeGroupBox.Controls.Add(this.textBox2);
            this.timeGroupBox.Location = new System.Drawing.Point(344, 268);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Size = new System.Drawing.Size(302, 223);
            this.timeGroupBox.TabIndex = 7;
            this.timeGroupBox.TabStop = false;
            this.timeGroupBox.Text = "Time";
            // 
            // timeDayLabel
            // 
            this.timeDayLabel.AutoSize = true;
            this.timeDayLabel.Location = new System.Drawing.Point(6, 98);
            this.timeDayLabel.Name = "timeDayLabel";
            this.timeDayLabel.Size = new System.Drawing.Size(85, 20);
            this.timeDayLabel.TabIndex = 8;
            this.timeDayLabel.Text = "Time (Day)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(120, 26);
            this.textBox2.TabIndex = 7;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.Location = new System.Drawing.Point(20, 89);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(78, 32);
            this.currentTimeLabel.TabIndex = 8;
            this.currentTimeLabel.Text = "Time";
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.Location = new System.Drawing.Point(20, 26);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(75, 32);
            this.currentDateLabel.TabIndex = 9;
            this.currentDateLabel.Text = "Date";
            // 
            // currentTimeGroupBox
            // 
            this.currentTimeGroupBox.Controls.Add(this.currentTimeLabel);
            this.currentTimeGroupBox.Controls.Add(this.currentDateLabel);
            this.currentTimeGroupBox.Location = new System.Drawing.Point(268, 26);
            this.currentTimeGroupBox.Name = "currentTimeGroupBox";
            this.currentTimeGroupBox.Size = new System.Drawing.Size(501, 155);
            this.currentTimeGroupBox.TabIndex = 10;
            this.currentTimeGroupBox.TabStop = false;
            this.currentTimeGroupBox.Text = "Current Date and Time";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(651, 294);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(338, 195);
            this.commentsTextBox.TabIndex = 10;
            this.commentsTextBox.Text = "";
            // 
            // concernLabel
            // 
            this.concernLabel.AutoSize = true;
            this.concernLabel.Location = new System.Drawing.Point(651, 268);
            this.concernLabel.Name = "concernLabel";
            this.concernLabel.Size = new System.Drawing.Size(176, 20);
            this.concernLabel.TabIndex = 12;
            this.concernLabel.Text = "Comments or Concerns";
            // 
            // concernsButton
            // 
            this.concernsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.concernsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concernsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.concernsButton.Location = new System.Drawing.Point(822, 497);
            this.concernsButton.Name = "concernsButton";
            this.concernsButton.Size = new System.Drawing.Size(170, 43);
            this.concernsButton.TabIndex = 13;
            this.concernsButton.Text = "Submit";
            this.concernsButton.UseVisualStyleBackColor = false;
            this.concernsButton.Click += new System.EventHandler(this.concernsButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(4, 566);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 40);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // payGroupBox
            // 
            this.payGroupBox.Controls.Add(this.payTextBox);
            this.payGroupBox.Controls.Add(this.payLabel);
            this.payGroupBox.Location = new System.Drawing.Point(777, 26);
            this.payGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payGroupBox.Name = "payGroupBox";
            this.payGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payGroupBox.Size = new System.Drawing.Size(214, 155);
            this.payGroupBox.TabIndex = 15;
            this.payGroupBox.TabStop = false;
            this.payGroupBox.Text = "Salary";
            // 
            // payTextBox
            // 
            this.payTextBox.Location = new System.Drawing.Point(15, 75);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.ReadOnly = true;
            this.payTextBox.Size = new System.Drawing.Size(178, 26);
            this.payTextBox.TabIndex = 6;
            this.payTextBox.TextChanged += new System.EventHandler(this.payTextBox_TextChanged);
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payLabel.Location = new System.Drawing.Point(76, 32);
            this.payLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(53, 29);
            this.payLabel.TabIndex = 0;
            this.payLabel.Text = "Pay";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearButton.Location = new System.Drawing.Point(651, 497);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(170, 43);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FormDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 608);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.payGroupBox);
            this.Controls.Add(this.ptoButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.concernsButton);
            this.Controls.Add(this.concernLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.currentTimeGroupBox);
            this.Controls.Add(this.timeGroupBox);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clockOutButton);
            this.Controls.Add(this.clockInButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormDomain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.FormDomain_Load);
            this.Time.ResumeLayout(false);
            this.Time.PerformLayout();
            this.timeGroupBox.ResumeLayout(false);
            this.timeGroupBox.PerformLayout();
            this.currentTimeGroupBox.ResumeLayout(false);
            this.currentTimeGroupBox.PerformLayout();
            this.payGroupBox.ResumeLayout(false);
            this.payGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button clockInButton;
        public System.Windows.Forms.Button clockOutButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.GroupBox Time;
        public System.Windows.Forms.Label requestPTOLable;
        public System.Windows.Forms.Button ptoButton;
        public System.Windows.Forms.LinkLabel ptoDetails;
        public System.Windows.Forms.GroupBox timeGroupBox;
        public System.Windows.Forms.Label timeDayLabel;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label currentTimeLabel;
        public System.Windows.Forms.Label currentDateLabel;
        public System.Windows.Forms.GroupBox currentTimeGroupBox;
        public System.Windows.Forms.GroupBox payGroupBox;
        public System.Windows.Forms.RichTextBox commentsTextBox;
        public System.Windows.Forms.Label concernLabel;
        public System.Windows.Forms.Button concernsButton;
        public System.Windows.Forms.Button backButton;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label payLabel;
        public System.Windows.Forms.TextBox payTextBox;
        public System.Windows.Forms.Button ClearButton;
    }
}

