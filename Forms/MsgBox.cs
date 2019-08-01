
using System;
using System.Windows.Forms;

namespace Forms
{
    internal partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
            ExitButton.Click += new EventHandler(delegate (object o, EventArgs e)
            { DialogResult = DialogResult.No; });
        }

        private string LastText = string.Empty;
        private void MsgTxt_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Lines.Length >= 5) { textBox.Text = LastText; return; }
            LastText = textBox.Text;
        }
        private void ShowErrMsg()
        {
            string msg = " could not be empty";
            MessageBox.Show(Title.Text + msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Trim() == "")
            { textBox.Text = textBox.Text.Trim(); ShowErrMsg(); return; }
            DialogResult = DialogResult.OK;
        }
    }
}
