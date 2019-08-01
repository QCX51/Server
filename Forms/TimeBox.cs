using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class TimeBox : Form
    {
        public static uint Time = 0;
        public TimeBox()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Time = Convert.ToUInt32(Hours.Value * 3600000);
            Time += Convert.ToUInt32(Minutes.Value * 60000);
            Time += Convert.ToUInt32(Seconds.Value * 1000);
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this?.Close();
        }
    }
}
