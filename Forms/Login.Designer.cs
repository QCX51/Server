namespace Forms
{
    partial class Login

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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.CancelLnk = new System.Windows.Forms.LinkLabel();
            this.StatusBox = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Black;
            this.LoginPanel.Controls.Add(this.CancelLnk);
            this.LoginPanel.Controls.Add(this.StatusBox);
            this.LoginPanel.Controls.Add(this.TitleLabel);
            this.LoginPanel.Controls.Add(this.PasswordBox);
            this.LoginPanel.Controls.Add(this.PassLabel);
            this.LoginPanel.Controls.Add(this.UserNameBox);
            this.LoginPanel.Controls.Add(this.KeyLabel);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.ForeColor = System.Drawing.Color.Black;
            this.LoginPanel.Location = new System.Drawing.Point(8, 8);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(234, 334);
            this.LoginPanel.TabIndex = 1;
            // 
            // CancelLnk
            // 
            this.CancelLnk.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.CancelLnk.BackColor = System.Drawing.Color.Transparent;
            this.CancelLnk.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelLnk.ForeColor = System.Drawing.Color.DimGray;
            this.CancelLnk.LinkColor = System.Drawing.Color.Gray;
            this.CancelLnk.Location = new System.Drawing.Point(90, 240);
            this.CancelLnk.MaximumSize = new System.Drawing.Size(55, 13);
            this.CancelLnk.MinimumSize = new System.Drawing.Size(55, 13);
            this.CancelLnk.Name = "CancelLnk";
            this.CancelLnk.Size = new System.Drawing.Size(55, 13);
            this.CancelLnk.TabIndex = 23;
            this.CancelLnk.TabStop = true;
            this.CancelLnk.Text = "Close";
            this.CancelLnk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelLnk.VisitedLinkColor = System.Drawing.Color.SkyBlue;
            // 
            // StatusBox
            // 
            this.StatusBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.StatusBox.Location = new System.Drawing.Point(2, 261);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(230, 61);
            this.StatusBox.TabIndex = 22;
            this.StatusBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.TitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleLabel.Location = new System.Drawing.Point(67, 30);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(100, 30);
            this.TitleLabel.TabIndex = 21;
            this.TitleLabel.Text = "Login";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.Black;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Font = new System.Drawing.Font("Arial", 9F);
            this.PasswordBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PasswordBox.Location = new System.Drawing.Point(67, 158);
            this.PasswordBox.MaximumSize = new System.Drawing.Size(100, 21);
            this.PasswordBox.MaxLength = 16;
            this.PasswordBox.MinimumSize = new System.Drawing.Size(100, 21);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.ShortcutsEnabled = false;
            this.PasswordBox.Size = new System.Drawing.Size(100, 21);
            this.PasswordBox.TabIndex = 20;
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.WordWrap = false;
            // 
            // PassLabel
            // 
            this.PassLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PassLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PassLabel.Location = new System.Drawing.Point(72, 91);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(90, 15);
            this.PassLabel.TabIndex = 19;
            this.PassLabel.Text = "Username";
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameBox
            // 
            this.UserNameBox.BackColor = System.Drawing.Color.Black;
            this.UserNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.UserNameBox.Location = new System.Drawing.Point(62, 108);
            this.UserNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.UserNameBox.MaxLength = 16;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(110, 21);
            this.UserNameBox.TabIndex = 18;
            this.UserNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserNameBox.WordWrap = false;
            // 
            // KeyLabel
            // 
            this.KeyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.KeyLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.KeyLabel.Location = new System.Drawing.Point(87, 141);
            this.KeyLabel.MaximumSize = new System.Drawing.Size(60, 15);
            this.KeyLabel.MinimumSize = new System.Drawing.Size(60, 15);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(60, 15);
            this.KeyLabel.TabIndex = 17;
            this.KeyLabel.Text = "Password";
            this.KeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(78, 198);
            this.LoginButton.MaximumSize = new System.Drawing.Size(78, 35);
            this.LoginButton.MinimumSize = new System.Drawing.Size(78, 35);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(78, 35);
            this.LoginButton.TabIndex = 16;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.LoginPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel CancelLnk;
        private System.Windows.Forms.Label StatusBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Button LoginButton;
        public System.Windows.Forms.Panel LoginPanel;
    }
}