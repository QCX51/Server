using System.Windows.Forms;
using Classes;
using System;
namespace Forms
{

    internal partial class Login : Form
    {

        private const string LOGIN_ERROR_MSG = "Invalid username and/or password";
        private Timer timer = new Timer() { Interval = 3000 };
        private bool CloseForm;

        internal Login()
        {
            InitializeComponent();
            timer.Tick += OnTimerTickEvt;
            TitleLabel.Text = Text.ToLower();
            CancelLnk.Click += new EventHandler(delegate (object o, EventArgs e)
            {
                DialogResult = DialogResult.No;
            });
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled) { timer.Stop(); }
            foreach (string KeyData in Registry.GetKeyData(UserNameBox.Text, PasswordBox.Text))
            {
                if (KeyData.Equals(string.Empty))
                {
                    StatusBox.Text = LOGIN_ERROR_MSG;
                    timer.Start(); CloseForm = false;
                    break;
                }
                else {  CloseForm = true; }
            }
            if (CloseForm) { DialogResult = DialogResult.Yes; }
        }

        private void OnTimerTickEvt(object sender, EventArgs e)
        {
            if (!IsDisposed && StatusBox.InvokeRequired)
            {
                StatusBox.Invoke(new Action(() => StatusBox.Text = string.Empty));
                Invoke(new MethodInvoker(timer.Stop));
            }
            else if (!IsDisposed)
            {
                StatusBox.Text = string.Empty;
                Invoke(new MethodInvoker(timer.Stop));
            }
        }
    }
}

