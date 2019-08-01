using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Classes;

namespace Forms
{
    public partial class Monitor : Form
    {
        public Monitor()
        {
            InitializeComponent();
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
            this?.Close();
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            Server.UpdateMonitorWindow += UpdateScreenWindow;
            FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Server.UpdateMonitorWindow -= UpdateScreenWindow;
        }

        private void UpdateScreenWindow(object sender, string AppGUID, string ImgData)
        {
            if (IsDisposed || ImgData?.Length <= 0) { return; }
            else if (Name != AppGUID || ImgData is null ) return;
            byte[] ImageData; //this.CreateGraphics().Dispose();
            try { ImageData = Convert.FromBase64String(ImgData); }
            catch { return; }
            try { ImageData = GZip.Decompress(ImageData); }
            catch { return; }
            using (Graphics g = this.CreateGraphics())
            using (MemoryStream ms = new MemoryStream(ImageData))
            { g.DrawImage(Image.FromStream(ms), 1, 1 + ControlBox.Height); }
        }
    }
}
