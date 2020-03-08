namespace TimeTracker
{
    partial class FormIndex
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
            this.FirstTimeUserLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.ClockInOrOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstTimeUserLabel
            // 
            this.FirstTimeUserLabel.AutoSize = true;
            this.FirstTimeUserLabel.Location = new System.Drawing.Point(133, 42);
            this.FirstTimeUserLabel.Name = "FirstTimeUserLabel";
            this.FirstTimeUserLabel.Size = new System.Drawing.Size(125, 20);
            this.FirstTimeUserLabel.TabIndex = 0;
            this.FirstTimeUserLabel.Text = "First Time User?";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerButton.Location = new System.Drawing.Point(37, 81);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(319, 62);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // ClockInOrOut
            // 
            this.ClockInOrOut.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClockInOrOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockInOrOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClockInOrOut.Location = new System.Drawing.Point(37, 250);
            this.ClockInOrOut.Name = "ClockInOrOut";
            this.ClockInOrOut.Size = new System.Drawing.Size(319, 62);
            this.ClockInOrOut.TabIndex = 2;
            this.ClockInOrOut.Text = "Clock In or Clock Out";
            this.ClockInOrOut.UseVisualStyleBackColor = false;
            this.ClockInOrOut.Click += new System.EventHandler(this.ClockInOrOut_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 359);
            this.Controls.Add(this.ClockInOrOut);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.FirstTimeUserLabel);
            this.Name = "FormIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIndex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstTimeUserLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button ClockInOrOut;
    }
}