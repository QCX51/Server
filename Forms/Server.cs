using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;
using Classes;
using TCPSocket;

namespace Forms
{
    internal partial class Server : Form
    {
        internal static DataGridList gridList = new DataGridList();
        public delegate void UpdateMonitorWindowHandler(object sender, string name, string Img);
        public static event UpdateMonitorWindowHandler UpdateMonitorWindow;

        public static string AppGuid
        {
            get
            {
                string GUID;
                try { GUID = Assembly.GetExecutingAssembly().GetCustomAttribute<GuidAttribute>().Value; }
                catch { GUID = Guid.NewGuid().ToString(); }
                return GUID.Replace("-", "").Replace("{", "").Replace("}", "").Replace("\"", "");
            }
        }
        public static string AppName
        {
            get
            {
                string FriendlyName = Application.ExecutablePath;
                return System.IO.Path.GetFileNameWithoutExtension(FriendlyName);
            }
        }
        public static bool IsAdminRole
        {
            get
            {
                using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
                { return new WindowsPrincipal(identity).IsInRole(WindowsBuiltInRole.Administrator); }
            }
        }
        private Point GUILocation
        {
            get
            {
                int PosX = Screen.PrimaryScreen.WorkingArea.Width - Width;
                int PosY = Screen.PrimaryScreen.WorkingArea.Height - Height;
                return new Point(PosX, PosY);
            }
        }

        internal Server()
        {
            InitializeComponent();
            System.Net.NetworkInformation.NetworkChange.NetworkAddressChanged +=
                new System.Net.NetworkInformation.NetworkAddressChangedEventHandler(OnNetworkAddressChanged);
            System.Net.NetworkInformation.NetworkChange.NetworkAvailabilityChanged +=
                new System.Net.NetworkInformation.NetworkAvailabilityChangedEventHandler(OnNetworkAvailabilityChanged);
            gridList.CellDoubleClick += new DataGridViewCellEventHandler(OnCellDoubleClick);
            TCPServer.OnSocketClose += OnSocketClose;
            TCPServer.OnDataAvailable += OnDataAvailable;
            KeyDown += OnFormKeyDown;
        }

        private void OnFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift & e.KeyCode.Equals(Keys.L))
            {
                Invoke(new Action(ShowLoginForm));
            }
        }

        private void ShowLoginForm()
        {
            using (Login login = new Login())
            {
                Animator animator = new Animator();
                animator.Addcontrol(login, login.LoginPanel);

                DialogResult result;
                result = login.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    Invoke(new MethodInvoker(ShowSettingsForm));
                }
            }
        }

        private void ShowSettingsForm()
        {
            using (Settings settings = new Settings())
            {
                settings.ShowDialog();
            }
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            Registry.ReadRegData();
            TCPServer.Start(AppData.IPEndPoint.PtNo);

            gridList.AddColumn("#", false, 10);
            gridList.AddColumn("Hostname", false, 60, DataGridViewAutoSizeColumnMode.Fill);
            gridList.AddColumn("Username", false, 45, DataGridViewAutoSizeColumnMode.Fill);
            gridList.AddColumn("MAC", false, 45, DataGridViewAutoSizeColumnMode.DisplayedCells);
            gridList.AddColumn("IP", false, 45, DataGridViewAutoSizeColumnMode.DisplayedCells);
            gridList.AddColumn("Time Used", false, 45, DataGridViewAutoSizeColumnMode.DisplayedCells);
            gridList.AddColumn("Time Left", false, 45, DataGridViewAutoSizeColumnMode.DisplayedCells);
            Controls.Add(gridList);
            System.Threading.Tasks.Task.Factory.StartNew(new Action(UpdateIPAddressThread));
        }

        private void OnNetworkAddressChanged(object sender, EventArgs args)
        {
            System.Threading.Tasks.Task.Factory.StartNew(new Action(UpdateIPAddressThread));
        }

        private void OnNetworkAvailabilityChanged(object sender, System.Net.NetworkInformation.NetworkAvailabilityEventArgs e)
        {
            System.Threading.Tasks.Task.Factory.StartNew(new Action(UpdateIPAddressThread));
        }

        private void UpdateIPAddressThread()
        {
            Invoke(new Action(() =>
            {
                HostBox.Text = System.Net.Dns.GetHostName();
                IPBox.Text = Network.IPv4;
                PortBox.Text = AppData.IPEndPoint.PtNo.ToString();
            }));
        }

        private string GetTimeFormat(int Time)
        {
            string time = string.Empty;
            decimal S = Math.Floor(Convert.ToDecimal(Time / 1000 % 60));
            decimal H = Math.Floor(Convert.ToDecimal(Time / 3600000 % 24));
            decimal M = Math.Floor(Convert.ToDecimal(Time / 60000 % 60));
            time += $"{(Time > 0 ? H < 10M ? "0" + H : "" + H : "--")}:";
            time += $"{(Time > 0 ? M < 10M ? "0" + M : "" + M : "--")}:";
            time += $"{(Time > 0 ? S < 10M ? "0" + S : "" + S : "--")}";
            return time;
        }

        private void OnSocketClose(System.Net.Sockets.Socket s, System.Net.Sockets.Socket c)
        {
            foreach (DataGridViewRow row in gridList.Rows)
            {
                if (row.HeaderCell.Tag.Equals(c))
                {
                    Trace($"{row.Cells[1].Value} Disconnected..");
                    Invoke(new Action(() => SwitchRowHeaderColor(row, Color.Red)));
                    break;
                }
            }
        }

        private void SwitchRowHeaderColor(DataGridViewRow row, Color RowColor)
        {
            row.HeaderCell.Style.BackColor = RowColor;
            row.HeaderCell.Style.SelectionBackColor = RowColor;
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex >= 0)
            { SortColumn(gridList.Columns[e.ColumnIndex]); return; }
            else if (e.ColumnIndex < 0) { return; }

            DataGridViewRow row = gridList.Rows[e.RowIndex];

            switch (gridList.Rows[e.RowIndex].HeaderCell.Style.BackColor.Name)
            {
                case "Orange":
                    AppData.UserData.CommandID = AppData.Command.STOPWATCH;
                    AppData.UserData.Arguments = "0";
                    XMLReader.SendXmlData(row.HeaderCell.Tag);
                    SwitchRowHeaderColor(row, Color.Lime);
                    break;
                case "Lime":
                    AppData.UserData.CommandID = AppData.Command.CHECKOUT;
                    AppData.UserData.Arguments = "0";
                    XMLReader.SendXmlData(row.HeaderCell.Tag);
                    SwitchRowHeaderColor(row, Color.Orange);
                    break;
                default:
                    break;
            }
        }

        private void OnMouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    ControlBox = true;
                    WindowState = FormWindowState.Normal;
                    Size = new Size(820, 480);
                    break;
                case FormWindowState.Minimized:
                    ControlBox = true;
                    WindowState = FormWindowState.Normal;
                    Size = new Size(820, 480);
                    break;
                case FormWindowState.Normal:
                    ControlBox = false;
                    WindowState = FormWindowState.Maximized;
                    break;
            }
        }

        private void SortColumn(DataGridViewColumn column)
        {
            switch (column.HeaderCell.SortGlyphDirection)
            {
                case SortOrder.Ascending:
                    column.HeaderCell.SortGlyphDirection = SortOrder.Descending;
                    gridList.Sort(column, System.ComponentModel.ListSortDirection.Descending);
                    break;
                case SortOrder.Descending:
                    column.HeaderCell.SortGlyphDirection = SortOrder.None;
                    break;
                case SortOrder.None:
                    column.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                    gridList.Sort(column, System.ComponentModel.ListSortDirection.Ascending);
                    break;
            }
        }

        private void AddNewRow(System.Net.Sockets.Socket TcpSocket, XMLData xml)
        {

            if (gridList.InvokeRequired)
            { gridList.Invoke(new Action(() => AddNewRow(TcpSocket, xml))); return; }

            DataGridViewRow row = gridList.AddRow(
                    "00",
                    xml.UserData.HostName,
                    xml.UserData.UserName,
                    xml.UserData.MAC,
                    xml.UserData.IP,
                    "--:--:--", "--:--:--");
            row.HeaderCell.Tag = TcpSocket;
            row.HeaderCell.Value = xml.AppData.AppID;
            SwitchRowHeaderColor(row, Color.Lime);
        }

        private void UpdateRow(System.Net.Sockets.Socket TcpSocket, DataGridViewRow row, XMLData xml)
        {

            if (gridList.InvokeRequired)
            { gridList.Invoke(new Action(() => UpdateRow(TcpSocket, row, xml))); return; }

            row.Cells[1].Value = xml.UserData.HostName;
            row.Cells[2].Value = xml.UserData.UserName;
            row.Cells[3].Value = xml.UserData.MAC;
            row.Cells[4].Value = xml.UserData.IP;
            row.Cells[5].Value = GetTimeFormat(xml.TimeData.TimeUsed);
            row.Cells[6].Value = GetTimeFormat(xml.TimeData.TimeLeft);

            if ((System.Net.Sockets.Socket)row.HeaderCell.Tag != TcpSocket)
            { ((System.Net.Sockets.Socket)row.HeaderCell.Tag)?.Close(); }
            row.HeaderCell.Tag = TcpSocket;
            row.HeaderCell.Value = xml.AppData.AppID;
            if (xml.CmdData.ID.Equals(AppData.Command.CHECKOUT))
            { SwitchRowHeaderColor(row, Color.Orange); }
            else { SwitchRowHeaderColor(row, Color.Lime); }
        }

        private int IndexOf(object Value)
        {
            foreach (DataGridViewRow row in gridList.Rows)
            {
                if (row.HeaderCell.Value.Equals(Value))
                {
                    return row.Index;
                }
            }
            return -1;
        }

        internal void OnDataAvailable(System.Net.Sockets.Socket TcpSocket, byte[] XmlData)
        {
            XMLData xml;
            try { xml = XMLReader.ReadXML(XmlData); }
            catch (Exception ex) { Trace($"XMLReader: {ex.Message}"); return; }
            UpdateMonitorWindow?.Invoke(this, xml.AppData.AppID, xml.ImgData.Value);
            int Index = IndexOf(xml.AppData.AppID);
            if (Index < 0) { AddNewRow(TcpSocket, xml); }
            else { UpdateRow(TcpSocket, gridList.Rows[Index], xml); }
        }

        public static void Trace(string message)
        {
            foreach (System.Diagnostics.TraceListener debugger in System.Diagnostics.Debug.Listeners)
            { debugger.WriteLine(message); }
        }
    }
}