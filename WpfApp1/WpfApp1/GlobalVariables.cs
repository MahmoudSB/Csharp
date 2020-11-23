using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
using System.Xml;
using System.IO;
using S7.Net.Types;

namespace WpfApp1
{
    static class gVars
    {
        public static Plc plc = null;
        public static XmlDocument doc = new XmlDocument();
        public static XmlNodeList xmlnode;
        public static FileStream fs = new FileStream("Data.xml", FileMode.Open, FileAccess.ReadWrite);

        public static string ConnPicAddr = @"C:\Users\mahmo\Desktop\cs\WpfApp1\connected.png";
        public static string DisconnPicAddr = @"C:\Users\mahmo\Desktop\cs\WpfApp1\Disconnected.png";
        public static string DisconnPicAdr = "C:\\Users\\mahmo\\Desktop\\cs\\WpfApp1\\Disconnected.png";
    }
}
