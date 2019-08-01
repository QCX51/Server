namespace Forms
{
    internal partial class MsgBox
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
            this.MsgBoxPanel = new System.Windows.Forms.Panel();
            this.Examples = new System.Windows.Forms.Label();
            this.BallonTipOptn = new System.Windows.Forms.CheckBox();
            this.Title = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.MsgBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsgBoxPanel
            // 
            this.MsgBoxPanel.BackColor = System.Drawing.Color.Black;
            this.MsgBoxPanel.Controls.Add(this.Examples);
            this.MsgBoxPanel.Controls.Add(this.BallonTipOptn);
            this.MsgBoxPanel.Controls.Add(this.Title);
            this.MsgBoxPanel.Controls.Add(this.ExitButton);
            this.MsgBoxPanel.Controls.Add(this.SendBtn);
            this.MsgBoxPanel.Controls.Add(this.textBox);
            this.MsgBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsgBoxPanel.ForeColor = System.Drawing.Color.Black;
            this.MsgBoxPanel.Location = new System.Drawing.Point(8, 8);
            this.MsgBoxPanel.Name = "MsgBoxPanel";
            this.MsgBoxPanel.Size = new System.Drawing.Size(234, 334);
            this.MsgBoxPanel.TabIndex = 2;
            // 
            // Examples
            // 
            this.Examples.BackColor = System.Drawing.Color.Transparent;
            this.Examples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Examples.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Examples.ForeColor = System.Drawing.Color.Silver;
            this.Examples.Location = new System.Drawing.Point(30, 202);
            this.Examples.Name = "Examples";
            this.Examples.Size = new System.Drawing.Size(175, 46);
            this.Examples.TabIndex = 12;
            this.Examples.Text = "Examples:\nTaskkill.exe /T /IM notepad.exe /F\nStart notepad.exe";
            this.Examples.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Examples.Visible = false;
            // 
            // BallonTipOptn
            // 
            this.BallonTipOptn.AutoSize = true;
            this.BallonTipOptn.BackColor = System.Drawing.Color.Transparent;
            this.BallonTipOptn.ForeColor = System.Drawing.Color.Gray;
            this.BallonTipOptn.Location = new System.Drawing.Point(30, 212);
            this.BallonTipOptn.Name = "BallonTipOptn";
            this.BallonTipOptn.Size = new System.Drawing.Size(78, 19);
            this.BallonTipOptn.TabIndex = 11;
            this.BallonTipOptn.Text = "BallonTip";
            this.BallonTipOptn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BallonTipOptn.UseVisualStyleBackColor = false;
            this.BallonTipOptn.Visible = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Gray;
            this.Title.Location = new System.Drawing.Point(66, 30);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(103, 24);
            this.Title.TabIndex = 10;
            this.Title.Text = "Message";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.UseMnemonic = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(127, 262);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(78, 35);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SendBtn
            // 
            this.SendBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.Location = new System.Drawing.Point(30, 262);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(78, 35);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Black;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox.Location = new System.Drawing.Point(30, 80);
            this.textBox.MaxLength = 84;
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(175, 107);
            this.textBox.TabIndex = 3;
            this.textBox.TextChanged += new System.EventHandler(this.MsgTxt_TextChanged);
            // 
            // MsgBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.MsgBoxPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBox";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MsgBoxPanel.ResumeLayout(false);
            this.MsgBoxPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.CheckBox BallonTipOptn;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.Button ExitButton;
        internal System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Panel MsgBoxPanel;
        internal System.Windows.Forms.TextBox textBox;
        internal System.Windows.Forms.Label Examples;
    }
}