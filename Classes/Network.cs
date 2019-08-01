using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Serialization;
using System.Net.WebSockets;

namespace Classes
{

    internal sealed class Network
    {

        internal static bool InternetAccess()
        {
            if (!NetworkInterface.GetIsNetworkAvailable()) { return false; }
            IPStatus Status;
            try { Status = new Ping().Send("www.google.com", 3000).Status; }
            catch { Status = IPStatus.DestinationHostUnreachable; }
            try { Status = new Ping().Send("www.facebook.com", 3000).Status; }
            catch { Status = IPStatus.DestinationHostUnreachable; }
            try { Status = new Ping().Send("www.youtube.com", 3000).Status; }
            catch { Status = IPStatus.DestinationHostUnreachable; }
            if (Status != IPStatus.Success) { return false; } else { return true; }
        }

        internal static WebClient webClient = new WebClient();
        public static LocationData GetLocation
        {
            get
            {
                XmlRootAttribute xRoot = new XmlRootAttribute()
                { ElementName = "Response" };
                string XMLData;
                try { XMLData = webClient.DownloadString("http://freegeoip.net/xml/"); }
                catch { return new LocationData(); }
                XmlSerializer Serializer = new XmlSerializer(typeof(LocationData), xRoot);
                using (XmlReader xmlReader = XmlReader.Create(new System.IO.StringReader(XMLData)))
                {
                    try { return Serializer.Deserialize(xmlReader) as LocationData; }
                    catch { return new LocationData(); }
                }
            }
        }

        internal static string GatewayIPAddress
        {
            get
            {
                NetworkInterface[] NetInterfaces;
                try { NetInterfaces = NetworkInterface.GetAllNetworkInterfaces(); }
                catch { return AppData.Default.IPV4; }
                foreach (NetworkInterface NetInterface in NetInterfaces)
                {
                    switch (NetInterface.OperationalStatus)
                    {
                        case OperationalStatus.Up:
                            if (!NetInterface.IsReceiveOnly)
                            {
                                GatewayIPAddressInformationCollection GIPIC;
                                GIPIC = NetInterface.GetIPProperties().GatewayAddresses;
                                return NetInterface.GetPhysicalAddress().ToString();
                            }
                            break;
                    }
                            if (!NetInterface.IsReceiveOnly && NetInterface.OperationalStatus.Equals(OperationalStatus.Up))
                    { return NetInterface.GetIPProperties().GatewayAddresses[0].Address.ToString(); }
                }
                return AppData.Default.IPV4;
            }
        }

        internal static string PhysicalAddress
        {
            get
            {
                NetworkInterface[] NetInterfaces;
                try { NetInterfaces = NetworkInterface.GetAllNetworkInterfaces(); }
                catch { return AppData.Default.MAC; }
                foreach (NetworkInterface NetInterface in NetInterfaces)
                {
                    NetInterface.Supports(NetworkInterfaceComponent.IPv6);
                    switch (NetInterface.NetworkInterfaceType)
                    {
                        case NetworkInterfaceType.Ethernet:
                            break;
                        case NetworkInterfaceType.Wireless80211:
                            break;
                    }
                    switch (NetInterface.OperationalStatus)
                    {
                        case OperationalStatus.Up:
                            if (!NetInterface.IsReceiveOnly)
                            { return NetInterface.GetPhysicalAddress().ToString(); }
                            break;
                        case OperationalStatus.Down:
                            break;
                        case OperationalStatus.Testing:
                            break;
                        case OperationalStatus.Unknown:
                            break;
                        case OperationalStatus.Dormant:
                            break;
                        case OperationalStatus.NotPresent:
                            break;
                        case OperationalStatus.LowerLayerDown:
                            break;
                        default:
                            break;
                    }
                    
                }
                return AppData.Default.MAC;
            }
        }

        /// <exception cref="NetworkInformationException"></exception>
        internal static bool IsPortAvailable(int Port)
        {
            IPEndPoint[] IPEP; IPGlobalProperties IPGP;
            IPGP = IPGlobalProperties.GetIPGlobalProperties();
            IPEP = IPGP.GetActiveTcpListeners();
            foreach (var TCPConInfo in IPEP)
            { if (TCPConInfo.Port.Equals(Port)) return false; }
            IPEP = IPGP.GetActiveUdpListeners();
            foreach (var TCPConInfo in IPEP)
            { if (TCPConInfo.Port.Equals(Port)) return false; }
            return true;
        }

        internal static string IPv4
        {
            get
            {
                IPHostEntry IPHE;
                try { IPHE = Dns.GetHostEntry(Dns.GetHostName()); }
                catch { return AppData.Default.IPV4; }
                foreach (IPAddress IP in IPHE.AddressList)
                { if (IP.ToString().Contains(".")) { return IP.ToString(); } }
                return AppData.Default.IPV4;
            }
        }
        internal static string IPv6
        {
            get
            {
                IPHostEntry IPHE;
                try { IPHE = Dns.GetHostEntry(Dns.GetHostName()); }
                catch { return AppData.Default.IPV6; }
                foreach (IPAddress IP in IPHE.AddressList)
                { if (IP.ToString().Contains(":")) { return IP.ToString(); } }
                return AppData.Default.IPV6;
            }
        }

        internal static bool IPvX(string HostName, out string IPvX)
        {
            IPHostEntry IPHE;
            IPvX = Socket.OSSupportsIPv6 ? AppData.Default.IPV6 : AppData.Default.IPV4;
            try { IPHE = Dns.GetHostEntry(HostName); }
            catch {  return false; }
            foreach (IPAddress IP in IPHE.AddressList)
            {
                IPvX = IP.ToString();
                if (!IP.IsIPv6LinkLocal && !IP.IsIPv6Teredo && IP.ToString().Contains(":"))
                { return true; }
                else if (!IP.IsIPv6LinkLocal && IP.ToString().Contains("."))
                { return true; }
            }
            return false;
        }

        internal static string IPvX()
        {
            IPHostEntry IPHE; string IPvX;
            IPvX = Socket.OSSupportsIPv6 ? AppData.Default.IPV6 : AppData.Default.IPV4;
            try { IPHE = Dns.GetHostEntry(Dns.GetHostName()); }
            catch { return IPvX; }
            foreach (IPAddress IP in IPHE.AddressList)
            {
                if (!IP.IsIPv6LinkLocal && !IP.IsIPv6Teredo && IP.ToString().Contains(":"))
                { IPvX = IP.ToString(); break; }
                else if (!IP.IsIPv6LinkLocal && IP.ToString().Contains("."))
                { IPvX = IP.ToString(); break; }
            }
            return IPvX;
        }
    }

    [Serializable]
    public class LocationData
    {
        public string IP { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string TimeZone { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string MetroCode { get; set; }
    }

}
