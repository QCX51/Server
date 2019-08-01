using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using TCPSocket;

namespace Classes
{
    public static class XMLReader
    {
        private static readonly XmlSerializer XmlSerializer = new XmlSerializer(typeof(XMLData));

        private static XmlWriterSettings XmlWSettings
        {
            get
            {
                return new XmlWriterSettings
                {
                    Async = true,
                    Encoding = System.Text.Encoding.Unicode,
                    CloseOutput = true,
                    Indent = true,
                    OmitXmlDeclaration = true,
                    ConformanceLevel = ConformanceLevel.Auto,
                    WriteEndDocumentOnClose = true,
                    NewLineHandling = NewLineHandling.Entitize
                };
            }
        }

        private static XmlReaderSettings XmlRSettings
        {
            get
            {
                return new XmlReaderSettings
                {
                    Async = true,
                    CloseInput = true,
                    IgnoreComments = true,
                    ValidationType = ValidationType.DTD,
                    ValidationFlags = System.Xml.Schema.XmlSchemaValidationFlags.None,
                    ConformanceLevel = ConformanceLevel.Auto,
                    DtdProcessing = DtdProcessing.Parse
                };
            }
        }

        internal static XMLData ReadXML(byte[] XmlData)
        {
            using (MemoryStream MemStream = new MemoryStream(XmlData))
            using (XmlReader XmlReader = XmlReader.Create(MemStream, XmlRSettings))
            { return XmlSerializer.Deserialize(XmlReader) as XMLData; }
        }

        internal static void SendFileData(object TcpSocket, FStream fs)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (XmlWriter XW = XmlWriter.Create(stream, XmlWSettings))
                {
                    XW.WriteStartDocument();
                    XW.WriteStartElement("XmlData");
                    XW.WriteComment("...:::Copyright (c) QCX51:::...");
                    XW.WriteString(AppData.DataTypeID.Files);

                    XW.WriteStartElement("FileData");
                    XW.WriteAttributeString("SUID", $"{fs.ID}");
                    XW.WriteAttributeString("Name", $"{fs.FileName}");
                    XW.WriteAttributeString("SLen", $"{fs.Length}");
                    XW.WriteAttributeString("SPos", $"{fs.Position}");
                    XW.WriteAttributeString("FLen", $"{fs.File.Length}");
                    XW.WriteAttributeString("FPos", $"{fs.File.Position}");
                    XW.WriteAttributeString("ICnt", $"{fs.Items.Count}");
                    XW.WriteAttributeString("ILen", $"{fs.Items.Length}");
                    XW.WriteAttributeString("DLen", $"{fs.File.Buffer.Length}");
                    XW.WriteBase64(fs.File.Buffer, 0, fs.File.Buffer.Length);
                    XW.WriteEndElement();

                    XW.WriteEndElement();
                    XW.WriteEndDocument();
                }
                TCPServer.Send((System.Net.Sockets.Socket)TcpSocket, stream);
            }
        }

        internal static void SendXmlData(object TcpSocket)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (XmlWriter XW = XmlWriter.Create(stream, XmlWSettings))
                {
                    XW.WriteStartDocument();
                    XW.WriteStartElement("XmlData");
                    XW.WriteComment("...:::Copyright(c) QCX51:::...");
                    XW.WriteString(string.Empty);

                    XW.WriteStartElement("AppData");
                    XW.WriteAttributeString("AppID", $"{Registry.GetAppID()}");
                    XW.WriteAttributeString("AppGUID", Forms.Server.AppGuid);
                    XW.WriteAttributeString("AppName", "Server");
                    XW.WriteString(string.Empty);
                    XW.WriteEndElement();

                    XW.WriteStartElement("Company");
                    XW.WriteAttributeString("Title", $"{AppData.Company.StatusMessage}");
                    XW.WriteAttributeString("Status", $"{AppData.Company.MessageTitle}");
                    XW.WriteAttributeString("DenyUnlock", $"{AppData.Company.DenyUnlock}");
                    XW.WriteString(string.Empty);
                    XW.WriteEndElement();

                    XW.WriteStartElement("UserData");
                    XW.WriteAttributeString("UserName", System.Environment.UserName);
                    XW.WriteAttributeString("HostName", System.Net.Dns.GetHostName());
                    XW.WriteAttributeString("Mac", Network.PhysicalAddress);
                    XW.WriteAttributeString("IP", Network.IPvX());
                    XW.WriteString(string.Empty);
                    XW.WriteEndElement();

                    XW.WriteStartElement("KeyData");
                    XW.WriteAttributeString("UserName", AppData.Security.UserName);
                    XW.WriteAttributeString("Password", AppData.Security.Password);
                    XW.WriteAttributeString("UserGUID", AppData.Security.UserGUID);
                    XW.WriteString(string.Empty);
                    XW.WriteEndElement();

                    XW.WriteStartElement("CmdData");
                    XW.WriteAttributeString("ID", AppData.UserData.CommandID);
                    XW.WriteAttributeString("Args", AppData.UserData.Arguments);
                    XW.WriteString(string.Empty);
                    XW.WriteEndElement();

                    XW.WriteEndElement();
                    XW.WriteEndDocument();
                }
                TCPServer.Send((System.Net.Sockets.Socket)TcpSocket, stream);
            }
        }

        public static void ReadXMLData(byte[] XmlData)
        {
            using (MemoryStream MS = new MemoryStream(XmlData))
            using (XmlReader XR = XmlReader.Create(MS, XmlRSettings))
            {
                while (XR.Read())
                {
                    switch (XR.NodeType)
                    {
                        case XmlNodeType.Attribute:
                            break;
                        case XmlNodeType.Element:
                            if (XR.Name.Equals("FileData"))
                            {
                                int Chunksize = int.Parse(XR.GetAttribute(""));
                                byte[] Data = new byte[Chunksize];
                                XR.ReadElementContentAsBinHex(Data, 0, Chunksize);
                                //AppData.UserData.ServerMsg = xmlReader.GetAttribute("Message");
                            }
                            break;
                        case XmlNodeType.Text:
                            break;
                        case XmlNodeType.XmlDeclaration:
                            break;
                        case XmlNodeType.ProcessingInstruction:
                            break;
                        case XmlNodeType.Comment:
                            break;
                        case XmlNodeType.EndElement:
                            break;
                        case XmlNodeType.DocumentType:
                            break;
                    }
                }
            }
        }
    }
}
