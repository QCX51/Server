using System.Drawing;
using System.Windows.Forms;

namespace Forms.Controls
{
    public partial class Progress : UserControl
    {
        private int progress = 0;
        public Progress()
        {
            InitializeComponent();
        }

        private void OnControlPaint(object sender, PaintEventArgs e)
        {
            BackColor = Color.Transparent;
            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.RotateTransform(-90);
            //e.Graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            Pen pen = new Pen(Color.DodgerBlue);
            Rectangle rectangle = new Rectangle(0 -Width / 2 + 5, 0-Height / 2 + 5, Width -10, Height - 10);
            e.Graphics.DrawPie(pen, rectangle, 0, this.progress);
            e.Graphics.FillPie(new SolidBrush(Color.DodgerBlue), rectangle, 0, this.progress);
            
            pen = new Pen(Color.LimeGreen);
            rectangle = new Rectangle(0 - Width / 2 + 15, 0 - Height / 2 + 15, Width - 30, Height - 30);
            e.Graphics.DrawPie(pen, rectangle, 0, 360);
            e.Graphics.FillPie(new SolidBrush(Color.LimeGreen), rectangle, 0, 360);

            e.Graphics.RotateTransform(+90);
            StringFormat sf = new StringFormat(StringFormatFlags.NoFontFallback);
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            Font font = new Font(SystemFonts.DialogFont.FontFamily, 24F, FontStyle.Bold);
            string progress = ((int)((this.progress / 360.0) * 100)).ToString();
            e.Graphics.DrawString($"{progress}%", font, new SolidBrush(SystemColors.ControlText), rectangle, sf);
        }
        public void UpdateProgress(int progress)
        {
            this.progress = progress <= 100 ? (int)(progress * 3.6) : 100;
            Invalidate(true);
        }
    }
}
