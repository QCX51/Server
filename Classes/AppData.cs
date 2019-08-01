using System;

namespace Classes
{
    internal static class AppData
    {
        public static string AppGUID { get; set; } =
            Guid.NewGuid().ToString().Replace("-", "").Replace("{", "").Replace("}", "").Replace("\"", "");
        internal struct Company
        {
            internal static string ProductName
            {
                get;
                set;
            } = "CyberCtrl";
            internal static string CompanyName
            {
                get;
                set;
            } = ProductName;
            internal static string MessageTitle
            {
                get;
                set;
            } = $"Bienvenido a {CompanyName}";
            internal static string StatusMessage
            {
                get;
                set;
            } = "Haz click en el icono de arriba\npara desbloquear el equipo";

            internal static bool DenyUnlock
            {
                get;
                set;
            } = false;
        }
        private static string Password = "//4xADAAMQAxADEAMAAxADAA|//4xADEAMQAxADEAMAA$|//4xADAAMQAxADEAMQAwADEA|"
            + "//4xADEAMQAwADEAMQA$|//4xADAAMAAwADEAMQAwADEA|//4xADAAMQAxADEAMAAxAA$$|//4xADAAMAAxADEAMAAxADAA|//"
            + "4xADEAMQAwADEAMAAwADAA|//4xADAAMAAwADEAMAAxADEA|//4xADEAMQAwADAAMAAxAA$$|//4xADEAMQAxADAAMQAxADAA|"
            + "//4xADEAMQAwADEAMQA$|//4xADAAMQAxADEAMQAwADAA|//4xADEAMQAwADEAMQA$|//4xADEAMQAwADAAMQAwAA$$|//4xAD"
            + "AAMAAxADEAMQAwADEA|//4xADEAMAAxADEAMAAwADAA|//4xADAAMAAxADAAMQAxAA$$|//4xADAAMAAwADEAMQA$|//4xADAA"
            + "MQAxADAAMQAxADEA|//4xADAAMAAwADEAMQAwADAA|//4xADAAMQAxADEAMQAxADEA|//4xADEAMAAwADEAMAAxADEA|//4xAD"
            + "EAMQAwADAAMQAxADEA|//4xADEAMQAwADEAMQA$|//4xADAAMAAxADEAMQAxAA$$|//4xADEAMAAxADEAMQAwAA$$|//4xADEA"
            + "MQAwADAAMQAwADAA|//4xADEAMQAxADEAMQAwADEA|//4xADAAMQAwADEAMAAwADAA|//4xADEAMQAwADEA|//4xADAAMQAxAD"
            + "EA|";
        private static string UserName = "//4xADEAMAAwADEAMAAwADEA|//4xADAAMAAxADEAMQAwADEA|//4xADAAMQAxADEA|//4x"
            + "ADEAMAAwADEAMQA$|//4wAA$$|//4xADAAMAAwADAAMAAwADEA|//4xADEAMQAxADEAMQAwADEA|//4xADAAMQAwADAAMAAwAD"
            + "AA|//4xADEAMAAxADAAMQAwADEA|//4xADEAMAAwADAAMQAxADAA|//4xADEAMAAxADAAMQAxADEA|//4xADAAMAAxADAAMAAw"
            + "ADEA|//4xADAAMAAxADEAMAAxAA$$|//4xADAAMAAwADAAMQAxAA$$|//4xADEAMAAxADEAMQAxADEA|//4xADEAMQAwADEAMQ"
            + "AwAA$$|//4xADEAMAAxADAAMAAxADAA|//4xADEAMQAwADEAMAAxAA$$|//4xADAAMAAxADEAMQA$|//4xADEAMQAwADAAMQAx"
            + "ADEA|//4xADAAMQAxADAAMQAwAA$$|//4xADEAMAAxADAAMAAxAA$$|//4xADAAMQAxADAAMAAwADAA|//4xADAAMQAwADAAMQ"
            + "AxADEA|//4xADAAMQAwADEAMAAxAA$$|//4xADEAMQAwADEAMAA$|//4xADAAMQAxADAAMQAwADEA|//4xADEAMAAxADEAMQAw"
            + "ADAA|//4xADEAMAAwADEAMAAxAA$$|//4xADEAMAAwADAA|//4xADEAMQAwADEAMQA$|//4xADEAMAAwADEAMAAxAA$$|";
        private static string UserGUID = "//4xADEAMQAwADEAMAAxAA$$|//4xADAAMAAwADAAMAA$|//4xADAAMAAwADEAMQAwADEA|"
            + "//4xADAAMAAxADEAMQAwAA$$|//4xADEAMAAxADEAMAAxADEA|//4xADAAMAAwADAAMAAwAA$$|//4xADEAMAAxADAAMAAwADA"
            + "A|//4xADAAMQAwADAAMQA$|//4xADEAMQA$|//4xADEAMAAwADAA|//4xADEAMAAwADAAMAA$|//4xADAAMQAxADEAMQA$|//4"
            + "xADEAMQAwADEA|//4xADAAMQAwADEAMAAwADEA|//4xADEAMQAxAA$$|//4xADEAMQAxADAA|//4xADEAMAAwADAAMQA$|//4x"
            + "ADEAMAAwADEAMQAwADAA|//4xADEAMAAxADAA|//4xADAAMQAxADEAMAAxAA$$|//4xADEAMAAwADEAMAAxADAA|//4xADAAMQ"
            + "AxADAAMQAwADAA|//4xADEAMAAwADAAMQAxADEA|//4xADEAMQAxADAAMAAxADEA|//4xADAAMQAxADEAMAAwADEA|//4xADAA"
            + "MQAwADAAMAAwAA$$|//4xADEAMAAxADAAMAAwADAA|//4xADAAMQAwADAAMQAwADAA|//4xADAAMAAxADAAMAAxADEA|//4xAD"
            + "EAMAAwADAAMAAwADAA|//4xADAAMQAxADAAMQAxAA$$|//4xADEAMQAxADAAMAA$|//4xADAAMQAxADAAMAAxADEA|//4xADAA"
            + "MQAxADEAMAAwADEA|//4xADAAMAAwADEAMAAxAA$$|//4xADAAMAAwADAAMAAxAA$$|//4xADEAMAA$|//4xADAAMAAwADAAMA"
            + "AxADAA|//4xADEAMAAxADAAMAAwADAA|//4xADEAMQAwADEAMQAwADAA|//4xADAAMQAwADEAMAAxAA$$|//4xADEAMAAwADEA"
            + "MQA$|//4xADAAMAAxADAAMAAwADAA|//4xADAAMQAxADAAMAAwADAA|//4xADAAMAAwADEAMQAwADAA|//4xADEAMQAwADAAMA"
            + "AxADAA|//4xADEAMQAwADEAMQA$|//4xADEAMQAwADEAMAA$|//4xADEAMAAxADAAMAAwAA$$|//4xADAAMAAwADAA|//4xADA"
            + "AMAAxADAAMQAxAA$$|//4xADAAMAAxADAAMAAwADEA|//4xADAAMAAwADAA|//4xADEAMQAwADEA|//4xADEAMQAxADEAMQAwA"
            + "A$$|//4xADEAMAAxADAAMAAxADEA|//4xADEAMQAwADEAMAAwADEA|//4xADEAMAAxADEAMAAxADEA|//4xADEAMAAwADEAMQA"
            + "$|//4xADAAMAAxADEAMAAwAA$$|//4xADEAMAAxADAA|//4xADEAMAAxADEAMQAwADEA|//4xADEAMQAwADEAMAAxADEA|//4x"
            + "ADAAMQAwADEAMQAwAA$$|//4xADAAMAAwADEAMQAxADAA|//4xADEAMQAwADEAMAAwADAA|//4xADEAMQAwADEA|//4xADAAMQ"
            + "AwADAAMQAxADAA|//4xADAAMQAxADAAMQA$|//4xADAAMAAxADEAMQAwAA$$|//4xADEAMQAxADAAMAAxADEA|//4xADAAMQAw"
            + "ADEAMAAwADEA|//4xADEAMQAwADAAMQAwAA$$|//4xADAAMAAwADAAMAAwAA$$|//4xADAAMQAxADEAMAAxADAA|//4xADAAMA"
            + "AxAA$$|//4xADAAMQAxADEAMQAwAA$$|//4xADAAMQAxADAAMAAxAA$$|//4xADEAMQAxADAAMAAwAA$$|//4xADAAMQAxADAA"
            + "MAAxAA$$|//4xADEAMAAxADEAMQA$|//4xADAAMAAxADAAMQAxADAA|//4xADAAMQAwADEAMQA$|//4xADAAMQAwADEAMQAxAA"
            + "$$|//4xADEAMQAxADAAMAAxADEA|//4xADEAMAAwADAAMAAxADEA|//4xADEAMQAxADEAMQAwAA$$|//4xADAAMQAwADAAMQAx"
            + "AA$$|//4xADAAMQAxADEAMAAxAA$$|//4xADEAMAAxADAAMAAxADEA|//4xADEAMQAxADAAMAAwAA$$|//4xADEAMAAxADEAMQ"
            + "A$|//4xADEAMAAxADEAMQAxADEA|//4xADAAMAAxADAAMAA$|//4xADEAMQAwADAAMQAwADEA|//4xADEAMAAxADAAMAAxAA$$"
            + "|";

        internal struct DataTypeID
        {
            internal const string Files    = "C7F73BB54D928922C3838BB789EE9FB8A5B1EB37";
            internal const string Settings = "6CE6C512EA433A7FC5C8841628E7696CD0FF7F2B";
            internal const string Security = "F25CE1B8A399BD8621A57427A20039B4B13935DB";
        }

        internal struct Security
        {
            internal static string UserName { get { return AppData.UserName; } set { AppData.UserName = value; } }
            internal static string Password { get { return AppData.Password; } set { AppData.Password = value; } }
            internal static string UserGUID { get { return AppData.UserGUID; } set { AppData.UserGUID = value; } }
        }

        internal struct Command
        {
            internal const string PRICES     = "3F6EF31CFAF226750EED50B6E4E7B419ED9968C4";
            internal const string SIGNOUT    = "DC1649A16C1496DB3E4073BE6A73FAF5121AEAE7";
            internal const string SHUTDOWN   = "E75039654B0D80A398D5EEBE5702911AD429C9AB";
            internal const string HIBERNATE  = "ABE4B589CF03727FDC21C74BE67EEC9F04253F89";
            internal const string RESTART    = "B134BD555A2F6EC5313C1B2A225B2C17F3409351";
            internal const string SLEEP      = "3CAC34E674464C2B62286054CD9A2D2C81149EFC";
            internal const string TIMER      = "9D9CEC22F36FD2BB99D5FE8C4723347BEC202CA5";
            internal const string STOPWATCH  = "15BD6CC6511CCCE656D14B32B337AA165AC636C2";
            internal const string CHECKOUT   = "3AC8E9E58C5ABADDBF9D265D4965B9B8F0A3B787";
            internal const string UPDATE     = "FB91E24FA52D8D2B32937BF04D843F730319A902";
            internal const string BALLOONTIP = "BD17BE2BC4C0DC7ACC703E1B64A299E9A2801D29";
            internal const string MESSAGEBOX = "81EFA52F20BA21BAC9667C66DFF561B537F4CF86";
            internal const string CONTINUE   = "2E02623966F9391FACF6EAEFC8B079ED5B630BEE";
            internal const string EXECUTE    = "6EA36CE8D4940505E9A2C8FEA5DB868CD8B3D440";
            internal const string SECURITY   = "F25CE1B8A399BD8621A57427A20039B4B13935DB";
            internal const string SETTINGS   = "C7F73BB54D928922C3838BB789EE9FB8A5B1EB37";
            internal const string SENDIMAGE  = "6E24B30A48B647EE703D5741EA081DD5D0DDFCCC";
            internal const string SENDFILE   = "2ADDFACB9CAB544F6CCD797A93BD2B9FAAE59753";
        }

        internal struct Pricing
        {
            internal static decimal Price   { get; set; } = 10.00M;
            internal static decimal Extra   { get; set; } = 00.00M;
            internal static decimal Minimum { get; set; } = 05.00M;
            internal static decimal Start   { get; set; } = 00.00M;
        }


        internal struct Timer
        {
            internal static int TimeUsed { get; set; } = 0x00000000;
            internal static int TimeLeft { get; set; } = 0x00000000;
            internal static int FullTime { get; set; } = 0x00000000;
        }

        internal struct Default
        {
            internal const string IPV4        = "127.0.0.1";
            internal const string IPV6        = "::1";
            internal const string IPVX        = "0.0.0.0";
            internal const string MAC         = "000000000000";
            internal const string BSSID       = "000000000000";
            internal const string ESSID       = "SSID1";
            internal const int    PORT        = 4096;
            internal const int    MIN_PORT_NO = 1024;
            internal const int    MAX_PORT_NO = 65535;
        }
        
        internal struct IPEndPoint
        {
            internal static string IPvX = Default.IPV4;
            internal static int    PtNo = Default.PORT;
            /// <summary>returns a random port number from <see cref="Default.MIN_PORT_NO"/> to <see cref="Default.MAX_PORT_NO"/></summary>
            internal static int    Port { get { return new Random().Next(Default.MIN_PORT_NO, Default.MAX_PORT_NO); } }
        }
        
        internal struct Settings
        {
        }

        internal struct UserData
        {
            internal static string CommandID { get; set; } = Command.STOPWATCH;
            internal static string Arguments { get; set; } = $"0";
        }
    }
}
