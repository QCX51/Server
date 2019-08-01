namespace Forms
{
    internal partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.StatusBar = new System.Windows.Forms.Panel();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.HostBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.Black;
            this.StatusBar.Controls.Add(this.PortBox);
            this.StatusBar.Controls.Add(this.IPBox);
            this.StatusBar.Controls.Add(this.HostBox);
            this.StatusBar.Controls.Add(this.label4);
            this.StatusBar.Controls.Add(this.label3);
            this.StatusBar.Controls.Add(this.label2);
            this.StatusBar.Controls.Add(this.label1);
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar.Location = new System.Drawing.Point(2, 495);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(880, 33);
            this.StatusBar.TabIndex = 0;
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.Color.Black;
            this.PortBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PortBox.Location = new System.Drawing.Point(499, 10);
            this.PortBox.Name = "PortBox";
            this.PortBox.ReadOnly = true;
            this.PortBox.ShortcutsEnabled = false;
            this.PortBox.Size = new System.Drawing.Size(95, 14);
            this.PortBox.TabIndex = 6;
            this.PortBox.TabStop = false;
            this.PortBox.Text = "4096";
            this.PortBox.WordWrap = false;
            // 
            // IPBox
            // 
            this.IPBox.BackColor = System.Drawing.Color.Black;
            this.IPBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IPBox.Location = new System.Drawing.Point(301, 10);
            this.IPBox.Name = "IPBox";
            this.IPBox.ReadOnly = true;
            this.IPBox.ShortcutsEnabled = false;
            this.IPBox.Size = new System.Drawing.Size(156, 14);
            this.IPBox.TabIndex = 5;
            this.IPBox.TabStop = false;
            this.IPBox.Text = "127.0.0.1";
            this.IPBox.WordWrap = false;
            // 
            // HostBox
            // 
            this.HostBox.BackColor = System.Drawing.Color.Black;
            this.HostBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HostBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HostBox.Location = new System.Drawing.Point(118, 10);
            this.HostBox.Name = "HostBox";
            this.HostBox.ReadOnly = true;
            this.HostBox.ShortcutsEnabled = false;
            this.HostBox.Size = new System.Drawing.Size(156, 14);
            this.HostBox.TabIndex = 4;
            this.HostBox.TabStop = false;
            this.HostBox.Text = "HOST-NAME";
            this.HostBox.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(461, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(277, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // Server
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 530);
            this.Controls.Add(this.StatusBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(900, 569);
            this.Name = "Server";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = this.Name;
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel StatusBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.Label label1;
    }
}