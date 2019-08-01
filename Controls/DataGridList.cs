using System;
using System.Drawing;
using System.Windows.Forms;
using TCPSocket;

namespace Classes
{
    internal partial class DataGridList : DataGridView
    {
        internal DataGridList()
        {
            this.SuspendLayout();
            this.Margin = new Padding(0);
            this.BackgroundColor = Color.Black;
            this.GridColor = Color.DodgerBlue;
            this.TopLeftHeaderCell.Style.BackColor = this.BackgroundColor;
            this.EnableHeadersVisualStyles = false;
            this.Font = new Font(SystemFonts.MessageBoxFont.FontFamily, 11F, FontStyle.Regular);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.AdjustedTopLeftHeaderBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            this.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            this.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            this.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            this.ScrollBars = ScrollBars.Both;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.EditMode = DataGridViewEditMode.EditOnEnter;
            this.AutoSize = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.AllowDrop = true;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToOrderColumns = true;
            this.ColumnHeadersVisible = true;
            this.ColumnHeadersHeight = 45;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RowHeadersVisible = true;
            this.RowHeadersWidth = 30;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ReadOnly = true;
            this.MultiSelect = false;
            this.ShowCellToolTips = true;
            this.Dock = DockStyle.Fill;
            this.ResumeLayout(false);
        }

        protected override void OnDragDrop(DragEventArgs e)
        {
            base.OnDragDrop(e);
            if (e.Effect == DragDropEffects.Move)
            {
                Point point = this.PointToClient(new Point(e.X, e.Y));
                int RowIndex = this.HitTest(point.X, point.Y).RowIndex;
                if (RowIndex >= 0)
                {
                    DataGridViewRow row;
                    row = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                    this.Rows.Remove(row);
                    this.Rows.Insert(RowIndex, row);
                    row.Selected = true;
                }
            }
        }

        protected override void OnDragEnter(DragEventArgs e)
        {
            base.OnDragEnter(e);
            if (this.SelectedRows.Count > 0)
            {  e.Effect = DragDropEffects.Move; }
        }

        protected override void OnDragOver(DragEventArgs e)
        {
            base.OnDragOver(e);
            if (this.SelectedRows.Count == 1)
            {
                Point point = this.PointToClient(new Point(e.X, e.Y));
                int rowIndex = this.HitTest(point.X, point.Y).RowIndex;
                if (rowIndex < 0) { return; }
                this.Rows[rowIndex].Selected = true;
            }
        }

        protected override void OnCellMouseDown(DataGridViewCellMouseEventArgs e)
        {
            base.OnCellMouseDown(e);
            if (this.SelectedRows.Count == 1 && e.ColumnIndex == -1)
            {
                DataGridViewRow row = this.SelectedRows[0];
                this.DoDragDrop(row, DragDropEffects.Move);
            }
        }

        /*
        protected override void OnDragLeave(EventArgs e)
        {
            base.OnDragLeave(e);
            IsMouseDown = false;
        }

        protected override void OnCellMouseMove(DataGridViewCellMouseEventArgs e)
        {
            base.OnCellMouseMove(e);
            if (this.SelectedRows.Count == 1 && e.ColumnIndex == -1 && IsMouseDown)
            {
                rw = this.SelectedRows[0];
                IsMouseDown = false;
                this.DoDragDrop(rw, DragDropEffects.Move);
            }
        }
        protected override void OnCellMouseUp(DataGridViewCellMouseEventArgs e)
        {
            base.OnCellMouseUp(e);
            //IsMouseDown = false;
        }
        */

        internal void AddColumn(string Caption, bool Resizable,
            int Width, DataGridViewAutoSizeColumnMode SizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() => AddColumn(Caption, Resizable, Width)));
                return;
            }
            DataGridViewColumn Column_0 = new DataGridViewButtonColumn
            {
                DefaultCellStyle = CellStyle()
            };
            Column_0.HeaderCell.Style = ColumnHeaderStyle();
            Column_0.HeaderText = Caption;
            Column_0.Name = Column_0.HeaderText;
            Column_0.ReadOnly = true;
            Column_0.Frozen = false;
            Column_0.DividerWidth = 1;
            Column_0.Width = Width;
            Column_0.FillWeight = Column_0.Width;
            Column_0.MinimumWidth = Column_0.Width;
            Column_0.SortMode = DataGridViewColumnSortMode.Programmatic;
            Column_0.AutoSizeMode = SizeMode;
            Column_0.Resizable = Resizable ? DataGridViewTriState.True : DataGridViewTriState.False;
            Column_0.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Columns.Add(Column_0);
            Column_0.HeaderCell.SortGlyphDirection = SortOrder.None;
        }

        internal DataGridViewRow AddRow(
            string DeviceNo,
            string HostName,
            string UserName,
            string IP,
            string Mac,
            string TimeUsed,
            string TimeLeft)
        {
            DataGridViewCell Cell_0 = new DataGridViewTextBoxCell { Value = DeviceNo };
            DataGridViewCell Cell_1 = new DataGridViewTextBoxCell { Value = HostName };
            DataGridViewCell Cell_2 = new DataGridViewTextBoxCell { Value = UserName };
            DataGridViewCell Cell_3 = new DataGridViewTextBoxCell { Value = IP };
            DataGridViewCell Cell_4 = new DataGridViewTextBoxCell { Value = Mac };
            DataGridViewCell Cell_5 = new DataGridViewTextBoxCell { Value = TimeUsed };
            DataGridViewCell Cell_6 = new DataGridViewTextBoxCell { Value = TimeLeft };
            DataGridViewCell[] cells = { Cell_0, Cell_1, Cell_2, Cell_3, Cell_4, Cell_5, Cell_6 };
            DataGridViewRow NewRow = new DataGridViewRow();
            NewRow.Cells.AddRange(cells);
            UpdateRows(NewRow);
            return NewRow;
        }

        private void UpdateRows(DataGridViewRow NewRow)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateRows(NewRow)));
                return;
            }
            this.Rows.Add(NewRow);
            NewRow.HeaderCell.Style = RowHeaderStyle();
            NewRow.DefaultCellStyle = CellStyle();
            NewRow.Frozen = false;
            NewRow.ReadOnly = false;
            NewRow.Height = 30;
            NewRow.MinimumHeight = NewRow.Height;
            NewRow.DividerHeight = 1;
            NewRow.HeaderCell.Tag = string.Empty;
            NewRow.HeaderCell.Value = string.Empty;
            NewRow.Resizable = DataGridViewTriState.False;
            NewRow.ContextMenuStrip = RowContextMenu();
            NewRow.Selected = false;
            NewRow.ContextMenuStrip.Opened += OnContextMenuOpened;
        }

        private void OnDropDownItemClicked(object sender, ToolStripItemClickedEventArgs evt)
        {
            using (Forms.TimeBox timeBox = new Forms.TimeBox())
            {
                if (timeBox.ShowDialog() == DialogResult.OK)
                { SendToSelectedRows(evt.ClickedItem.Tag.ToString(), Forms.TimeBox.Time.ToString()); }
            }
        }

        private void OnToolStripItemClicked(object sender, EventArgs Args)
        {
            using (Forms.TimeBox timeBox = new Forms.TimeBox())
            {
                if (timeBox.ShowDialog() == DialogResult.OK)
                { SendToSelectedRows(((ToolStripMenuItem)sender).Tag.ToString(), Forms.TimeBox.Time.ToString()); }
            }
        }

        private void OpenNewMonitor(object Socket, string Caption, string ID)
        {
            AppData.UserData.CommandID = AppData.Command.SENDIMAGE;
            AppData.UserData.Arguments = "true";
            XMLReader.SendXmlData(Socket);
            Forms.Monitor monitor = new Forms.Monitor()
            {
                Name = ID,
                Tag = ID,
                Text = Caption
            };
            monitor.StatusBox.Text = $"{Caption}";
            Animator animator = new Animator();
            animator.Addcontrol(monitor, monitor.StatusBox);
            animator.Addcontrol(monitor, monitor.ControlBox);
            monitor.FormClosing += new FormClosingEventHandler(
                delegate (object o, FormClosingEventArgs e)
                {
                    AppData.UserData.CommandID = AppData.Command.SENDIMAGE;
                    AppData.UserData.Arguments = "false";
                    XMLReader.SendXmlData(Socket);
                    using (Form fm = o as Form) {}
                });
            monitor.CloseBtn.Click += new EventHandler(
                delegate (object o, EventArgs e) { monitor?.Close(); });
            monitor.Show();
        }

        private void ShowMonitorWindow(object sender, EventArgs evt)
        {
            if (SelectedRows.Count > 0)
            {
                bool ShowMonitor = true;
                FormCollection forms = Application.OpenForms;
                for (int Index = 0; Index < forms.Count; Index++)
                {
                    Form form = forms[Index];
                    if ((bool)form?.IsDisposed) continue;
                    if (!(form.Tag is null) && form.Tag.Equals(SelectedRows[0].HeaderCell.Value))
                    { ShowMonitor = false; form.BringToFront(); break; }
                }
                if (ShowMonitor)
                {
                    OpenNewMonitor(SelectedRows[0].HeaderCell.Tag,
                            SelectedRows[0].Cells[1].Value.ToString(),
                            SelectedRows[0].HeaderCell.Value.ToString());
                }
            }
        }

        private void ShowCommandForm(object sender, EventArgs evt)
        {
            using (Forms.MsgBox msgbox = new Forms.MsgBox())
            {
                msgbox.Title.Text = "Command";
                msgbox.BallonTipOptn.Enabled = false;
                msgbox.BallonTipOptn.Visible = false;
                msgbox.Examples.Enabled = true;
                msgbox.Examples.Visible = true;
                if (msgbox.ShowDialog().Equals(DialogResult.OK))
                { SendToSelectedRows(AppData.Command.EXECUTE, msgbox.textBox.Text); }
            }
        }

        private void ShowMessageForm(object sender, EventArgs evt)
        {
            using (Forms.MsgBox msgbox = new Forms.MsgBox())
            {
                msgbox.Title.Text = "Message";
                msgbox.Examples.Enabled = false;
                msgbox.Examples.Visible = false;
                msgbox.BallonTipOptn.Enabled = true;
                msgbox.BallonTipOptn.Visible = true;
                DialogResult DiagResult = msgbox.ShowDialog();
                string Args = msgbox.textBox.Text + "|" + Environment.MachineName;
                if (DiagResult == DialogResult.OK && msgbox.BallonTipOptn.Checked)
                { SendToSelectedRows(AppData.Command.BALLOONTIP, Args); }
                else if (DiagResult == DialogResult.OK)
                { SendToSelectedRows(AppData.Command.MESSAGEBOX, Args); }
            }
        }

        private void SendToSelectedRows(string Command, string Args)
        {
            foreach (DataGridViewRow Row in this.SelectedRows)
            {
                AppData.UserData.CommandID = Command;
                AppData.UserData.Arguments = Args;
                XMLReader.SendXmlData(Row.HeaderCell.Tag);
            }
        }

        private void SendFileToSelectedRows(string[] FileNames)
        {
            foreach (DataGridViewRow Row in this.SelectedRows)
            {
                System.Net.Sockets.Socket socket =
                    Row.HeaderCell.Tag as System.Net.Sockets.Socket;
                TCPServer.SendFile(socket, FileNames);
            }
        }

        private void OnContextMenuOpened(object sender, EventArgs e)
        {
            ContextMenuStrip RowMenu = (ContextMenuStrip)sender;
            foreach (DataGridViewRow Row in this.SelectedRows)
            {
                Row.Selected = false;
            }
            foreach (DataGridViewRow Row in this.Rows)
            {
                if (Row.ContextMenuStrip.Equals(RowMenu))
                {
                    Row.Selected = true;
                    RowMenu = null;
                    break;
                }
            }
        }

        private void GetFiles(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog()
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = true,
                RestoreDirectory = true,
                Title = "Select File(s)",
                Filter = "All Files|*.*"
            };
            DialogResult result = Dialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            { SendFileToSelectedRows(Dialog.FileNames); }
        }

        private ContextMenuStrip RowContextMenu()
        {
            ToolStripMenuItem MenuItem1 = new ToolStripMenuItem("Time");
            MenuItem1.DropDownItems.Add("Set");
            MenuItem1.DropDownItems[0].Tag = AppData.Command.TIMER;
            MenuItem1.DropDownItems.Add("Add");
            MenuItem1.DropDownItems[1].Tag = AppData.Command.UPDATE;
            MenuItem1.DropDownItemClicked += OnDropDownItemClicked;

            ToolStripMenuItem MenuItem2 = new ToolStripMenuItem("Send");
            MenuItem2.DropDownItems.Add("Message");
            MenuItem2.DropDownItems[0].Tag = AppData.Command.MESSAGEBOX;
            MenuItem2.DropDownItems[0].Click += ShowMessageForm;
            MenuItem2.DropDownItems.Add("Command");
            MenuItem2.DropDownItems[1].Tag = AppData.Command.EXECUTE;
            MenuItem2.DropDownItems[1].Click += ShowCommandForm;
            MenuItem2.DropDownItems.Add("File(s)");
            MenuItem2.DropDownItems[2].Tag = AppData.Command.SENDFILE;
            MenuItem2.DropDownItems[2].Click += GetFiles;

            ToolStripMenuItem MenuItem3 = new ToolStripMenuItem("Power");
            MenuItem3.DropDownItems.Add("Shut down");
            MenuItem3.DropDownItems[0].Tag = AppData.Command.SHUTDOWN;
            MenuItem3.DropDownItems.Add("Restart");
            MenuItem3.DropDownItems[1].Tag = AppData.Command.RESTART;
            MenuItem3.DropDownItems.Add("Sleep");
            MenuItem3.DropDownItems[2].Tag = AppData.Command.SLEEP;
            MenuItem3.DropDownItems.Add("Hibernate");
            MenuItem3.DropDownItems[3].Tag = AppData.Command.HIBERNATE;
            MenuItem3.DropDownItemClicked += OnDropDownItemClicked;

            ToolStripMenuItem MenuItem5 = new ToolStripMenuItem("Show");
            MenuItem5.DropDownItems.Add("Monitor");
            MenuItem5.DropDownItemClicked += ShowMonitorWindow;

            ToolStripMenuItem MenuItem4 = new ToolStripMenuItem("Sign out");
            MenuItem4.Click += new EventHandler(OnToolStripItemClicked);
            MenuItem4.Tag = AppData.Command.SIGNOUT;

            ContextMenuStrip RowMenu = new ContextMenuStrip();
            RowMenu.Items.AddRange(new ToolStripItem[] { MenuItem1, MenuItem2, MenuItem3, MenuItem5, MenuItem4 });
            return RowMenu;
        }

        private DataGridViewCellStyle RowHeaderStyle()
        {
            return new DataGridViewCellStyle()
            {
                Padding = new Padding(0),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.Orange,
                Font = new Font(SystemFonts.MessageBoxFont.FontFamily, 10F, FontStyle.Regular),
                ForeColor = Color.Orange,
                Format = "",
                NullValue = 0,
                SelectionBackColor = BackColor,
                SelectionForeColor = BackColor,
                WrapMode = DataGridViewTriState.False
            };
        }
        private DataGridViewCellStyle CellStyle()
        {
            return new DataGridViewCellStyle()
            {
                Padding = new Padding(0),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.Black,
                ForeColor = Color.DodgerBlue,
                Font = new Font(SystemFonts.MessageBoxFont.FontFamily, 10F, FontStyle.Regular),
                Format = "",
                NullValue = 0,
                SelectionBackColor = Color.DarkBlue,
                SelectionForeColor = Color.White
            };
        }
        private DataGridViewCellStyle ColumnHeaderStyle()
        {
            return new DataGridViewCellStyle()
            {
                Padding = new Padding(0),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.Black,
                Font = new Font(SystemFonts.MessageBoxFont.FontFamily, 11F, FontStyle.Bold),
                ForeColor = Color.DeepSkyBlue,
                Format = "",
                NullValue = 0,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = Color.Black,
                WrapMode = DataGridViewTriState.False
            };
        }
    }
}
