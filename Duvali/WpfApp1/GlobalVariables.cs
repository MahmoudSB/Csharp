using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
using System.Xml;
using System.IO;
using S7.Net.Types;
using System.Threading;

namespace WpfApp1
{
    static class gVars
    {

        public static XmlDocument doc = new XmlDocument();
        public static XmlNodeList xmlnode;
        public static FileStream fs = new FileStream("DataBase.xml", FileMode.Open, FileAccess.ReadWrite);
        public static bool firstLoad = true;
        public static string ConnPicAddr = @"C:\Users\mahmo\Desktop\cs\Duvali\connected.png";
        public static string DisconnPicAddr = @"C:\Users\mahmo\Desktop\cs\Duvali\Disconnected.png";
        public static string ip = "192.168.1.1";
        public static string cpuSelect = "S71200";
        public static string rack = "0";
        public static string slot = "0";

        public static CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), cpuSelect);
        public static Plc plc = new Plc(cpu, ip, Convert.ToInt16(rack), Convert.ToInt16(slot));

        public static string OF = "";
        public static string artigo = "";
        public static string nuc = "";
        public static string inicio_hh = "";
        public static string inicio_mm = "";
        public static string qty = "";

        public static Thread ReadFromPlc;

        public static bool Thread_end = false;
    }
}
