namespace Forms
{
    partial class Checkout
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
            this.CompuLabel = new System.Windows.Forms.Label();
            this.HostNameBox = new System.Windows.Forms.Label();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.CompuLabel);
            this.MainPanel.Controls.Add(this.HostNameBox);
            this.MainPanel.Controls.Add(this.ContinueBtn);
            this.MainPanel.Controls.Add(this.CheckoutBtn);
            this.MainPanel.Controls.Add(this.PriceBox);
            this.MainPanel.Controls.Add(this.AmountLabel);
            this.MainPanel.Controls.Add(this.TimeBox);
            this.MainPanel.Controls.Add(this.TimeLabel);
            this.MainPanel.Controls.Add(this.TitleLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MainPanel.Location = new System.Drawing.Point(8, 8);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(234, 334);
            this.MainPanel.TabIndex = 9;
            // 
            // CompuLabel
            // 
            this.CompuLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompuLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompuLabel.ForeColor = System.Drawing.Color.Gray;
            this.CompuLabel.Location = new System.Drawing.Point(75, 80);
            this.CompuLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CompuLabel.Name = "CompuLabel";
            this.CompuLabel.Size = new System.Drawing.Size(85, 17);
            this.CompuLabel.TabIndex = 16;
            this.CompuLabel.Text = "Computer";
            this.CompuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CompuLabel.UseMnemonic = false;
            // 
            // HostNameBox
            // 
            this.HostNameBox.BackColor = System.Drawing.Color.Transparent;
            this.HostNameBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostNameBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.HostNameBox.Location = new System.Drawing.Point(0, 102);
            this.HostNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.HostNameBox.Name = "HostNameBox";
            this.HostNameBox.Size = new System.Drawing.Size(234, 21);
            this.HostNameBox.TabIndex = 17;
            this.HostNameBox.Text = "DESKTOP-5GYJF";
            this.HostNameBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HostNameBox.UseMnemonic = false;
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueBtn.ForeColor = System.Drawing.Color.Black;
            this.ContinueBtn.Location = new System.Drawing.Point(126, 262);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(78, 35);
            this.ContinueBtn.TabIndex = 15;
            this.ContinueBtn.Text = "Continue";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutBtn.ForeColor = System.Drawing.Color.Black;
            this.CheckoutBtn.Location = new System.Drawing.Point(30, 262);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(78, 35);
            this.CheckoutBtn.TabIndex = 14;
            this.CheckoutBtn.Text = "Checkout";
            this.CheckoutBtn.UseVisualStyleBackColor = true;
            // 
            // PriceBox
            // 
            this.PriceBox.BackColor = System.Drawing.Color.Transparent;
            this.PriceBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PriceBox.Location = new System.Drawing.Point(67, 199);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(0);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 21);
            this.PriceBox.TabIndex = 13;
            this.PriceBox.Text = "$ 24.56";
            this.PriceBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PriceBox.UseMnemonic = false;
            // 
            // AmountLabel
            // 
            this.AmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.ForeColor = System.Drawing.Color.Gray;
            this.AmountLabel.Location = new System.Drawing.Point(75, 181);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(85, 17);
            this.AmountLabel.TabIndex = 12;
            this.AmountLabel.Text = "Amount";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AmountLabel.UseMnemonic = false;
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = System.Drawing.Color.Transparent;
            this.TimeBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TimeBox.Location = new System.Drawing.Point(67, 150);
            this.TimeBox.Margin = new System.Windows.Forms.Padding(0);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(100, 21);
            this.TimeBox.TabIndex = 11;
            this.TimeBox.Text = "02:56:67";
            this.TimeBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeBox.UseMnemonic = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Gray;
            this.TimeLabel.Location = new System.Drawing.Point(75, 132);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(85, 17);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "Time";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeLabel.UseMnemonic = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gray;
            this.TitleLabel.Location = new System.Drawing.Point(66, 30);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(103, 24);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Checkout";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.UseMnemonic = false;
            // 
            // Checkout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Checkout";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.TopMost = true;
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label CompuLabel;
        internal System.Windows.Forms.Label HostNameBox;
        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.Button CheckoutBtn;
        internal System.Windows.Forms.Label PriceBox;
        private System.Windows.Forms.Label AmountLabel;
        internal System.Windows.Forms.Label TimeBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TitleLabel;
    }
}