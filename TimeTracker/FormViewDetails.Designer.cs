namespace TimeTracker
{
    partial class FormViewDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ManagerLabel = new System.Windows.Forms.Label();
            this.ptoHistoryLabel = new System.Windows.Forms.Label();
            this.ptoAvailableLabel = new System.Windows.Forms.Label();
            this.EmploymentHistLabel = new System.Windows.Forms.Label();
            this.managerTextBox = new System.Windows.Forms.TextBox();
            this.ptoHistTextBox = new System.Windows.Forms.TextBox();
            this.vacationBalanceTextBox = new System.Windows.Forms.TextBox();
            this.employmentHistTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManagerLabel
            // 
            this.ManagerLabel.AutoSize = true;
            this.ManagerLabel.Location = new System.Drawing.Point(23, 24);
            this.ManagerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManagerLabel.Name = "ManagerLabel";
            this.ManagerLabel.Size = new System.Drawing.Size(49, 13);
            this.ManagerLabel.TabIndex = 0;
            this.ManagerLabel.Text = "Manager";
            // 
            // ptoHistoryLabel
            // 
            this.ptoHistoryLabel.AutoSize = true;
            this.ptoHistoryLabel.Location = new System.Drawing.Point(23, 86);
            this.ptoHistoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ptoHistoryLabel.Name = "ptoHistoryLabel";
            this.ptoHistoryLabel.Size = new System.Drawing.Size(84, 13);
            this.ptoHistoryLabel.TabIndex = 1;
            this.ptoHistoryLabel.Text = "Vacation History";
            // 
            // ptoAvailableLabel
            // 
            this.ptoAvailableLabel.AutoSize = true;
            this.ptoAvailableLabel.Location = new System.Drawing.Point(23, 148);
            this.ptoAvailableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ptoAvailableLabel.Name = "ptoAvailableLabel";
            this.ptoAvailableLabel.Size = new System.Drawing.Size(91, 13);
            this.ptoAvailableLabel.TabIndex = 2;
            this.ptoAvailableLabel.Text = "Vacation Balance";
            // 
            // EmploymentHistLabel
            // 
            this.EmploymentHistLabel.AutoSize = true;
            this.EmploymentHistLabel.Location = new System.Drawing.Point(23, 213);
            this.EmploymentHistLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmploymentHistLabel.Name = "EmploymentHistLabel";
            this.EmploymentHistLabel.Size = new System.Drawing.Size(99, 13);
            this.EmploymentHistLabel.TabIndex = 3;
            this.EmploymentHistLabel.Text = "Employment History";
            // 
            // managerTextBox
            // 
            this.managerTextBox.Location = new System.Drawing.Point(148, 24);
            this.managerTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.managerTextBox.Name = "managerTextBox";
            this.managerTextBox.ReadOnly = true;
            this.managerTextBox.Size = new System.Drawing.Size(167, 20);
            this.managerTextBox.TabIndex = 4;
            // 
            // ptoHistTextBox
            // 
            this.ptoHistTextBox.Location = new System.Drawing.Point(148, 86);
            this.ptoHistTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptoHistTextBox.Name = "ptoHistTextBox";
            this.ptoHistTextBox.ReadOnly = true;
            this.ptoHistTextBox.Size = new System.Drawing.Size(167, 20);
            this.ptoHistTextBox.TabIndex = 5;
            // 
            // vacationBalanceTextBox
            // 
            this.vacationBalanceTextBox.Location = new System.Drawing.Point(148, 146);
            this.vacationBalanceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vacationBalanceTextBox.Name = "vacationBalanceTextBox";
            this.vacationBalanceTextBox.ReadOnly = true;
            this.vacationBalanceTextBox.Size = new System.Drawing.Size(167, 20);
            this.vacationBalanceTextBox.TabIndex = 6;
            // 
            // employmentHistTextBox
            // 
            this.employmentHistTextBox.Location = new System.Drawing.Point(148, 209);
            this.employmentHistTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employmentHistTextBox.Name = "employmentHistTextBox";
            this.employmentHistTextBox.ReadOnly = true;
            this.employmentHistTextBox.Size = new System.Drawing.Size(167, 20);
            this.employmentHistTextBox.TabIndex = 7;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(26, 249);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(289, 26);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Return";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FormViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 287);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.employmentHistTextBox);
            this.Controls.Add(this.vacationBalanceTextBox);
            this.Controls.Add(this.ptoHistTextBox);
            this.Controls.Add(this.managerTextBox);
            this.Controls.Add(this.EmploymentHistLabel);
            this.Controls.Add(this.ptoAvailableLabel);
            this.Controls.Add(this.ptoHistoryLabel);
            this.Controls.Add(this.ManagerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormViewDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.FormViewDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManagerLabel;
        private System.Windows.Forms.Label ptoHistoryLabel;
        private System.Windows.Forms.Label ptoAvailableLabel;
        private System.Windows.Forms.Label EmploymentHistLabel;
        private System.Windows.Forms.TextBox managerTextBox;
        private System.Windows.Forms.TextBox ptoHistTextBox;
        private System.Windows.Forms.TextBox vacationBalanceTextBox;
        private System.Windows.Forms.TextBox employmentHistTextBox;
        private System.Windows.Forms.Button backButton;
    }

    #endregion
}
