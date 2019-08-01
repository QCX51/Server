using System.Windows.Forms;
using Classes;
using System;
using TCPSocket;

namespace Forms
{
    internal partial class Settings : Form
    {

        internal Settings()
        {

            InitializeComponent();
            CloseButton.Click += new EventHandler(
                delegate (object o, EventArgs e) { DialogResult = DialogResult.No; });
        }
        
        private void Config_Load(object sender, EventArgs e)
        {
            PtNo.Text = AppData.IPEndPoint.PtNo.ToString();
            IPvX.Text = Network.IPv4;
            PriceValue.Value = AppData.Pricing.Price;
            MinimumValue.Value = AppData.Pricing.Minimum;
            StartPriceValue.Value = AppData.Pricing.Start;
        }

        private void PtNo_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int Port = int.TryParse(PtNo.Text.Trim(), out Port) ? Port
                : random.Next(AppData.Default.MIN_PORT_NO, AppData.Default.MAX_PORT_NO);
            PtNo.Text = Port.ToString(); random = null;
        }

        private void PtNo_Validated(object sender, EventArgs e)
        {
            PtNo.Text = (int.TryParse(PtNo.Text.Trim(), out int Port) && Port >= AppData.Default.MIN_PORT_NO)
                ? Port.ToString() : AppData.Default.MIN_PORT_NO.ToString();
            if (Port < AppData.Default.MIN_PORT_NO)
            { ShowWarningMsg(string.Format("Port number must be greater or equal than {0}", PtNo.Text)); }
            PtNo.Text = (int.TryParse(PtNo.Text.Trim(), out Port) && Port < AppData.Default.MAX_PORT_NO)
                ? Port.ToString() : AppData.Default.MAX_PORT_NO.ToString();
            if (Port > AppData.Default.MAX_PORT_NO)
            { ShowWarningMsg(string.Format("Port number must be less or equal than {0}", PtNo.Text)); }
        }

        private void ShowWarningMsg(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            UserName.Text = UserName.Text.Trim(); Password.Text = Password.Text.Trim();
            if (UserName.Text == "" && Password.Text.Length > 0) { ShowWarningMsg("Username could not be empty."); return; }
            if (Password.Text == "" && UserName.Text.Length > 0) { ShowWarningMsg("Password could not be empty."); return; }
            if (UserName.Text.Length > 0 && UserName.Text.Length < 5) { ShowWarningMsg("Username must contain at least 5 characters"); return; }
            if (Password.Text.Length > 0 && Password.Text.Length < 7) { ShowWarningMsg("Password must contain at least 7 characters"); return; }
            if (UserName.Text != "" && Password.Text != "") { Registry.SetKeyData(UserName.Text, Password.Text); }
            Registry.SavePricing(PriceValue.Value, MinimumValue.Value, StartPriceValue.Value);
            Registry.SaveIPEndPoint(Convert.ToInt32(PtNo.Text));
            System.Threading.Tasks.Task.Factory.StartNew(new Action(() => SendSettingsToClient()));
            TCPServer.Start(AppData.IPEndPoint.PtNo);
            DialogResult = DialogResult.OK;
        }

        private void SendSettingsToClient()
        {
            //for (int Index = 0; Index < TcpServer.SockList.Count; Index++)
            //{ TcpServer.UpdateClientData(TcpServer.SockList[Index]); }
        }
    }
}

