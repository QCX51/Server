using System;

namespace Classes
{
    [Serializable]
    [System.Xml.Serialization.XmlRoot("XmlData")]
    public class XMLData
    {
        [System.Xml.Serialization.XmlElement("AppData")]
        public APPData AppData { get; set; }
        [System.Xml.Serialization.XmlElement("UserData")]
        public USRDATA UserData { get; set; }
        [System.Xml.Serialization.XmlElement("TimeData")]
        public TIMEDATA TimeData { get; set; }
        [System.Xml.Serialization.XmlElement("CmdData")]
        public CMDDATA CmdData { get; set; }
        [System.Xml.Serialization.XmlElement("ImgData")]
        public IMGData ImgData { get; set; }
        [System.Xml.Serialization.XmlText]
        public string Copyright { get; set; }

        public class IMGData
        {
            [System.Xml.Serialization.XmlText]
            public string Value { get; set; }
        }

        public class APPData
        {
            [System.Xml.Serialization.XmlAttribute("AppID")]
            public string AppID { get; set; }
            [System.Xml.Serialization.XmlAttribute("AppGUID")]
            public string AppGUID { get; set; }
            [System.Xml.Serialization.XmlAttribute("AppName")]
            public string AppName { get; set; }
        }

        public class COMPANY
        {
            [System.Xml.Serialization.XmlAttribute("Name")]
            public string Name { get; set; }
            [System.Xml.Serialization.XmlAttribute("Message")]
            public string Message { get; set; }
        }

        public class USRDATA
        {
            [System.Xml.Serialization.XmlAttribute("UserName")]
            public string UserName { get; set; }
            [System.Xml.Serialization.XmlAttribute("HostName")]
            public string HostName { get; set; }
            [System.Xml.Serialization.XmlAttribute("MAC")]
            public string MAC { get; set; }
            [System.Xml.Serialization.XmlAttribute("IP")]
            public string IP { get; set; }
        }

        public class KEYDATA
        {
            [System.Xml.Serialization.XmlAttribute("UserName")]
            public string UserName { get; set; }
            [System.Xml.Serialization.XmlAttribute("Password")]
            public string Password { get; set; }
            [System.Xml.Serialization.XmlAttribute("UserGUID")]
            public string UserGUID { get; set; }
        }

        public class CMDDATA
        {
            [System.Xml.Serialization.XmlAttribute("ID")]
            public string ID { get; set; }
            [System.Xml.Serialization.XmlAttribute("Args")]
            public string Args { get; set; }
        }

        public class TIMEDATA
        {
            [System.Xml.Serialization.XmlAttribute("TimeUsed")]
            public int TimeUsed { get; set; }
            [System.Xml.Serialization.XmlAttribute("TimeLeft")]
            public int TimeLeft { get; set; }
            [System.Xml.Serialization.XmlAttribute("FullTime")]
            public int FullTime { get; set; }
        }
    }
}