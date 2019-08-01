namespace Forms
{
    partial class Monitor
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
            this.StatusBox = new System.Windows.Forms.Label();
            this.ControlBox = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.SystemColors.Control;
            this.StatusBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.ForeColor = System.Drawing.Color.Black;
            this.StatusBox.Location = new System.Drawing.Point(0, 0);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(0);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(480, 24);
            this.StatusBox.TabIndex = 5;
            this.StatusBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ControlBox
            // 
            this.ControlBox.Controls.Add(this.CloseBtn);
            this.ControlBox.Controls.Add(this.StatusBox);
            this.ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBox.Location = new System.Drawing.Point(1, 1);
            this.ControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ControlBox.Size = new System.Drawing.Size(480, 25);
            this.ControlBox.TabIndex = 4;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseBtn.Location = new System.Drawing.Point(437, 0);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(43, 24);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(482, 347);
            this.Controls.Add(this.ControlBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(483, 347);
            this.MinimumSize = new System.Drawing.Size(482, 347);
            this.Name = "Monitor";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.ControlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label StatusBox;
        internal System.Windows.Forms.Panel ControlBox;
        internal System.Windows.Forms.Button CloseBtn;
    }
}