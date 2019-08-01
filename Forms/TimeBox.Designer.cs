namespace Forms
{
    partial class TimeBox
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Seconds = new System.Windows.Forms.NumericUpDown();
            this.Minutes = new System.Windows.Forms.NumericUpDown();
            this.Hours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.Seconds);
            this.MainPanel.Controls.Add(this.Minutes);
            this.MainPanel.Controls.Add(this.Hours);
            this.MainPanel.Controls.Add(this.Cancel_Button);
            this.MainPanel.Controls.Add(this.OK_Button);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(8, 8);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(228, 149);
            this.MainPanel.TabIndex = 5;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(132, 98);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(78, 35);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(44, 98);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(78, 35);
            this.OK_Button.TabIndex = 6;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Seconds
            // 
            this.Seconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Seconds.Font = new System.Drawing.Font("Arial", 17F);
            this.Seconds.Location = new System.Drawing.Point(150, 49);
            this.Seconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(60, 34);
            this.Seconds.TabIndex = 10;
            this.Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Minutes
            // 
            this.Minutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Minutes.Font = new System.Drawing.Font("Arial", 17F);
            this.Minutes.Location = new System.Drawing.Point(84, 49);
            this.Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(60, 34);
            this.Minutes.TabIndex = 9;
            this.Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hours
            // 
            this.Hours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Hours.Font = new System.Drawing.Font("Arial", 17F);
            this.Hours.Location = new System.Drawing.Point(18, 49);
            this.Hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(60, 34);
            this.Hours.TabIndex = 8;
            this.Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Time [H:m:s]";
            // 
            // TimeBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(244, 165);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(244, 165);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(244, 165);
            this.Name = "TimeBox";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Timer";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.NumericUpDown Seconds;
        private System.Windows.Forms.NumericUpDown Minutes;
        private System.Windows.Forms.NumericUpDown Hours;
        private System.Windows.Forms.Label label1;
    }
}