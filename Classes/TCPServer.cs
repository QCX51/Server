using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Runtime.Serialization;

namespace TCPSocket
{
    /// <summary>
    /// Copyright (C) Alain Eus. Rivera
    /// </summary>
    public static class TCPServer
    {
        #region Public Global Delegate
        public delegate void OnDataAvailableHandler(Socket TCPClient, byte[] data);
        public delegate void OnSocketCloseHandler(Socket TCPServer, Socket TCPClient);
        public delegate void OnSocketConnectedHandler(Socket TCPServer, Socket TCPClient);
        public delegate void OnSendFileProgressHandler(float Progress);
        public delegate void OnProgressCompleteHandler();
        public delegate void OnProgressErrorHandler(Exception exception);
        #endregion
        #region Public Global Events
        public static event OnSocketConnectedHandler OnSocketConnected =
            delegate (Socket TcpServer, Socket TcpClient)
            {
                BeginAccept();
                TcpSockets.Add(TcpClient);
                Queue.Add(TcpClient, new Queue());
                BeginReceive(TcpClient);
            };
        public static event OnSocketCloseHandler OnSocketClose =
            delegate (Socket TCPServer, Socket TCPClient)
            {
                if (!TcpSockets.Contains(TCPClient)) return;
                TcpSockets?.Remove(TCPClient);
                do { Queue.Remove(TCPClient); }
                while (Queue.ContainsKey(TCPClient));
                TCPClient?.Close();
                TCPClient = null;
            };
        public static event OnDataAvailableHandler OnDataAvailable;
        public static event OnSendFileProgressHandler OnSendFileProgress;
        public static event OnProgressCompleteHandler OnProgressComplete;
        public static event OnProgressErrorHandler OnProgressError;
        #endregion
        #region Private Global Variables
        private static Socket TcpServer = null;
        private static string SocketGuid { get; set; } = Guid.NewGuid().ToString();
        private static readonly BinaryFormatter BinFormatter = new BinaryFormatter();
        private static string CancelToken { get; set; }
        #endregion
        #region Public Global Vars
        public static List<Socket> TcpSockets = new List<Socket>();
        private static Dictionary<Socket, Queue> Queue = new Dictionary<Socket, Queue>();
        #endregion
        /// <summary>
        /// Start listening for incoming connections on a specific port
        /// </summary>
        /// <param name="PtNo">Port number</param>
        /// <exception cref="SocketException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static void Start(int PtNo)
        {
            if (Socket.OSSupportsIPv6) { Start(IPAddress.IPv6Any, PtNo); }
            else if (Socket.OSSupportsIPv4) { Start(IPAddress.Any, PtNo); }
        }
        /// <summary>
        /// Start listening for incoming connections
        /// </summary>
        /// <param name="IPvX">Server IPv4|IPv6 Address</param>
        /// <param name="PtNo">Server Port number</param>
        /// <exception cref="SocketException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool Start(IPAddress IPvX, int PtNo)
        {
            if (TcpServer?.IsBound == true)
            {
                TcpServer?.Close();
                TcpServer = null;
                Thread.Sleep(100);
            }
            TcpServer = new Socket(SocketType.Stream, ProtocolType.Tcp)
            {
                DualMode = true,
                ExclusiveAddressUse = true,
                LingerState = new LingerOption(false, 0),
                SendTimeout = 0,
                ReceiveTimeout = 0,
                NoDelay = true,
                Ttl = 255,
                UseOnlyOverlappedIO = false,
                ReceiveBufferSize = 500000,
                SendBufferSize = 500000
            };
            try
            {
                IPEndPoint IPEP;
                IPEP = new IPEndPoint(IPvX, PtNo);
                TcpServer.Bind(IPEP);
                TcpServer.Listen(-1);
                Task.Run(() => BeginAccept());
                return true;
            }
            catch (Exception ex)
            {
                TcpServer?.Close();
                TcpServer = null;
                Trace($"TcpServerEx: {ex.Message}");
                return false;
            }
        }

        private static void BeginAccept()
        {
            AsyncCallback AsCallBack = new AsyncCallback(EndAccept);
            try { TcpServer.BeginAccept(AsCallBack, TcpServer); }
            catch (Exception ex) { Trace($"BeginAcceptEx: {ex.Message}"); }
        }

        private static void EndAccept(IAsyncResult IAsResult)
        {
            if (TcpServer?.IsBound != true) { return; }
            try { OnSocketConnected?.Invoke(TcpServer, TcpServer.EndAccept(IAsResult)); }
            catch (Exception ex) { Trace($"EndAcceptEx: {ex.Message}"); }
        }

        public static void SendFile(this Socket TcpSocket, string[] Files)
        {
            new Thread(() =>
            {
                try
                {
                    NetworkStream stream = new NetworkStream(TcpSocket);
                    BufferedStream buffered = new BufferedStream(stream);
                    
                    foreach (string file in Files)
                    {
                        byte[] buffer = new byte[1000000];
                        FileStream fs = File.OpenRead(file);
                        while (fs.Read(buffer, 0, buffer.Length) > 0)
                        { Trace("position: " + fs.Position); }
                    }
                    /*
                    FStream FS = new FStream(Files, 500000);
                    foreach (byte[] data in FS.ReadFiles())
                    {
                        if (CancelToken == FS.ID) { break; }
                        Classes.XMLReader.SendFileData(TcpSocket, FS);
                        //Thread.Sleep(300);
                    }
                    */
                }
                catch (Exception ex)
                {
                    OnProgressError?.Invoke(ex);
                    Trace($"SendFileEx: {ex.Message}");
                }
            }).Start();
        }

        public static void Send(Socket TcpSocket, object ObjectGraph)
        {
            try
            {
                if (TcpSocket?.Connected != true) { return; }
                using (var NetStream = new NetworkStream(TcpSocket, false))
                using (var Buffered = new BufferedStream(NetStream, 256000))
                { BinFormatter.Serialize(Buffered, ObjectGraph); }
            }
            catch (Exception ex)
            {
                Trace($"SendEx: {ex.Message}");
            }
        }

        public static async void BeginSend(Socket TcpSocket)
        {
            try
            {
                if (TcpSocket?.Connected != true) { return; }
                byte[] XmlData = new byte[0];
                NetworkStream NetStream = new NetworkStream(TcpSocket);
                using (MemoryStream MemStream = new MemoryStream(XmlData))
                { BinFormatter.Serialize(NetStream, MemStream); }
                Thread.Sleep(TimeSpan.FromSeconds(1D));
                await Task.Run(new Action(() => BeginSend(TcpSocket)));
            }
            catch (Exception ex)
            { Trace($"BeginSendEx: {ex.Message}"); }
        }

        private static async void BeginReceive(Socket TcpSocket)
        {
            try
            {
                byte[] buffer = new byte[0]; object ObjectGraph;
                TcpSocket.Receive(buffer, 0, 0, SocketFlags.None);
                using (var NetStream = new NetworkStream(TcpSocket, false))
                using (var Buffered = new BufferedStream(NetStream, 256000))
                { ObjectGraph = BinFormatter.Deserialize(Buffered); }
                GetStreamType(ObjectGraph, TcpSocket);
                await Task.Run(() => BeginReceive(TcpSocket));
            }
            catch (Exception ex)
            {
                OnSocketClose?.Invoke(TcpServer, TcpSocket);
                Trace($"BeginReceiveEx: {ex.Message}");
            }
        }

        private static void GetStreamType(object StreamType, Socket TcpSocket)
        {
            if (StreamType is MemoryStream)
            {
                using (MemoryStream ms = StreamType as MemoryStream)
                { OnDataAvailable?.Invoke(TcpSocket, ms.ToArray()); }
            }
            if (StreamType is string)
            {
                if (Guid.TryParse(StreamType as string, out Guid result))
                { CancelToken = result.ToString(); }
            }
        }

        private static void WriteLogFile(string LogText)
        {
            string FilePath; FileStream LogFile;
            FilePath = Path.Combine(Path.GetTempPath(), $"{AppDomain.CurrentDomain.FriendlyName}.log");
            try { LogFile = File.Open(FilePath, FileMode.Append, FileAccess.Write); }
            catch (Exception Ex) { Trace($"LogFile: {Ex.Message}"); return; }
            LogText = LogText + Environment.NewLine;
            byte[] LogBytes = Encoding.ASCII.GetBytes(LogText);
            LogFile.Write(LogBytes, 0, LogBytes.Length);
            LogFile.Close();
        }

        private static void Trace(string message)
        {
            foreach (System.Diagnostics.TraceListener debugger in System.Diagnostics.Debug.Listeners)
            { debugger.WriteLine(message); }
        }
    }
}