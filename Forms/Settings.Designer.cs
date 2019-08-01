namespace Forms
{
    internal partial class Settings

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
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.StartPriceValue = new System.Windows.Forms.NumericUpDown();
            this.MinimumValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceValue = new System.Windows.Forms.NumericUpDown();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PtNoLabel = new System.Windows.Forms.Label();
            this.PtNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPvX = new System.Windows.Forms.TextBox();
            this.IPvXLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartPriceValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceValue)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.Black;
            this.SettingsPanel.Controls.Add(this.label8);
            this.SettingsPanel.Controls.Add(this.label7);
            this.SettingsPanel.Controls.Add(this.label6);
            this.SettingsPanel.Controls.Add(this.ApplyButton);
            this.SettingsPanel.Controls.Add(this.StartPriceValue);
            this.SettingsPanel.Controls.Add(this.MinimumValue);
            this.SettingsPanel.Controls.Add(this.label5);
            this.SettingsPanel.Controls.Add(this.label4);
            this.SettingsPanel.Controls.Add(this.PriceValue);
            this.SettingsPanel.Controls.Add(this.Password);
            this.SettingsPanel.Controls.Add(this.UserName);
            this.SettingsPanel.Controls.Add(this.PasswordLabel);
            this.SettingsPanel.Controls.Add(this.UserNameLabel);
            this.SettingsPanel.Controls.Add(this.PtNoLabel);
            this.SettingsPanel.Controls.Add(this.PtNo);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.IPvX);
            this.SettingsPanel.Controls.Add(this.IPvXLabel);
            this.SettingsPanel.Controls.Add(this.CloseButton);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.ForeColor = System.Drawing.Color.Black;
            this.SettingsPanel.Location = new System.Drawing.Point(8, 8);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Padding = new System.Windows.Forms.Padding(8);
            this.SettingsPanel.Size = new System.Drawing.Size(284, 434);
            this.SettingsPanel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(39, 244);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "[ Internet ]";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(39, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "[ Security ]";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(39, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "[ End Point ]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(42, 366);
            this.ApplyButton.MaximumSize = new System.Drawing.Size(78, 35);
            this.ApplyButton.MinimumSize = new System.Drawing.Size(78, 35);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(78, 35);
            this.ApplyButton.TabIndex = 39;
            this.ApplyButton.Text = "Save";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // StartPriceValue
            // 
            this.StartPriceValue.BackColor = System.Drawing.SystemColors.Control;
            this.StartPriceValue.DecimalPlaces = 2;
            this.StartPriceValue.ForeColor = System.Drawing.Color.Black;
            this.StartPriceValue.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.StartPriceValue.Location = new System.Drawing.Point(126, 313);
            this.StartPriceValue.Margin = new System.Windows.Forms.Padding(0);
            this.StartPriceValue.Name = "StartPriceValue";
            this.StartPriceValue.Size = new System.Drawing.Size(120, 21);
            this.StartPriceValue.TabIndex = 38;
            this.StartPriceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MinimumValue
            // 
            this.MinimumValue.BackColor = System.Drawing.SystemColors.Control;
            this.MinimumValue.DecimalPlaces = 2;
            this.MinimumValue.ForeColor = System.Drawing.Color.Black;
            this.MinimumValue.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.MinimumValue.Location = new System.Drawing.Point(126, 290);
            this.MinimumValue.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.MinimumValue.Name = "MinimumValue";
            this.MinimumValue.Size = new System.Drawing.Size(120, 21);
            this.MinimumValue.TabIndex = 37;
            this.MinimumValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinimumValue.Value = new decimal(new int[] {
            300,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(39, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Start Price:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(39, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Minimum:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceValue
            // 
            this.PriceValue.BackColor = System.Drawing.SystemColors.Control;
            this.PriceValue.DecimalPlaces = 2;
            this.PriceValue.ForeColor = System.Drawing.Color.Black;
            this.PriceValue.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.PriceValue.Location = new System.Drawing.Point(126, 267);
            this.PriceValue.Margin = new System.Windows.Forms.Padding(0);
            this.PriceValue.Name = "PriceValue";
            this.PriceValue.Size = new System.Drawing.Size(120, 21);
            this.PriceValue.TabIndex = 31;
            this.PriceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PriceValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            131072});
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Black;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Arial", 9F);
            this.Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Password.Location = new System.Drawing.Point(126, 209);
            this.Password.Margin = new System.Windows.Forms.Padding(0);
            this.Password.MaxLength = 16;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.ShortcutsEnabled = false;
            this.Password.Size = new System.Drawing.Size(120, 21);
            this.Password.TabIndex = 28;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.UseSystemPasswordChar = true;
            this.Password.WordWrap = false;
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.Black;
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.Font = new System.Drawing.Font("Arial", 9F);
            this.UserName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.UserName.Location = new System.Drawing.Point(126, 186);
            this.UserName.Margin = new System.Windows.Forms.Padding(0);
            this.UserName.MaxLength = 10;
            this.UserName.Name = "UserName";
            this.UserName.ShortcutsEnabled = false;
            this.UserName.Size = new System.Drawing.Size(120, 21);
            this.UserName.TabIndex = 27;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserName.WordWrap = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PasswordLabel.Location = new System.Drawing.Point(39, 212);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(66, 15);
            this.PasswordLabel.TabIndex = 30;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.UserNameLabel.Location = new System.Drawing.Point(39, 189);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(69, 15);
            this.UserNameLabel.TabIndex = 29;
            this.UserNameLabel.Text = "Username:";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PtNoLabel
            // 
            this.PtNoLabel.AutoSize = true;
            this.PtNoLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PtNoLabel.Location = new System.Drawing.Point(39, 130);
            this.PtNoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PtNoLabel.Name = "PtNoLabel";
            this.PtNoLabel.Size = new System.Drawing.Size(32, 15);
            this.PtNoLabel.TabIndex = 21;
            this.PtNoLabel.Text = "Port:";
            this.PtNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PtNo
            // 
            this.PtNo.BackColor = System.Drawing.Color.Black;
            this.PtNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PtNo.Font = new System.Drawing.Font("Arial", 9F);
            this.PtNo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PtNo.Location = new System.Drawing.Point(126, 128);
            this.PtNo.MaxLength = 5;
            this.PtNo.Name = "PtNo";
            this.PtNo.ShortcutsEnabled = false;
            this.PtNo.Size = new System.Drawing.Size(120, 21);
            this.PtNo.TabIndex = 17;
            this.PtNo.Text = "4096";
            this.PtNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PtNo.WordWrap = false;
            this.PtNo.TextChanged += new System.EventHandler(this.PtNo_TextChanged);
            this.PtNo.Validated += new System.EventHandler(this.PtNo_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(102, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPvX
            // 
            this.IPvX.BackColor = System.Drawing.Color.Black;
            this.IPvX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPvX.Font = new System.Drawing.Font("Arial", 9F);
            this.IPvX.ForeColor = System.Drawing.Color.DodgerBlue;
            this.IPvX.Location = new System.Drawing.Point(126, 105);
            this.IPvX.MaximumSize = new System.Drawing.Size(120, 20);
            this.IPvX.MaxLength = 5;
            this.IPvX.MinimumSize = new System.Drawing.Size(120, 20);
            this.IPvX.Name = "IPvX";
            this.IPvX.ReadOnly = true;
            this.IPvX.ShortcutsEnabled = false;
            this.IPvX.Size = new System.Drawing.Size(120, 20);
            this.IPvX.TabIndex = 20;
            this.IPvX.Text = "127.0.0.1";
            this.IPvX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IPvX.WordWrap = false;
            // 
            // IPvXLabel
            // 
            this.IPvXLabel.AutoSize = true;
            this.IPvXLabel.BackColor = System.Drawing.Color.Transparent;
            this.IPvXLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.IPvXLabel.Location = new System.Drawing.Point(39, 105);
            this.IPvXLabel.Margin = new System.Windows.Forms.Padding(0);
            this.IPvXLabel.Name = "IPvXLabel";
            this.IPvXLabel.Size = new System.Drawing.Size(69, 15);
            this.IPvXLabel.TabIndex = 18;
            this.IPvXLabel.Text = "IP Address:";
            this.IPvXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(168, 366);
            this.CloseButton.MaximumSize = new System.Drawing.Size(78, 35);
            this.CloseButton.MinimumSize = new System.Drawing.Size(78, 35);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(78, 35);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(39, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Price (Hour):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.SettingsPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Config_Load);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartPriceValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel SettingsPanel;
        internal System.Windows.Forms.Button CloseButton;
        internal System.Windows.Forms.Label PtNoLabel;
        internal System.Windows.Forms.TextBox IPvX;
        internal System.Windows.Forms.TextBox PtNo;
        internal System.Windows.Forms.Label IPvXLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox Password;
        internal System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button ApplyButton;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.NumericUpDown PriceValue;
        internal System.Windows.Forms.NumericUpDown StartPriceValue;
        internal System.Windows.Forms.NumericUpDown MinimumValue;
    }
}