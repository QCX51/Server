namespace Forms.Controls
{
    partial class Progress
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Progress
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(256, 256);
            this.MinimumSize = new System.Drawing.Size(32, 32);
            this.Name = "Progress";
            this.Size = new System.Drawing.Size(32, 32);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnControlPaint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
