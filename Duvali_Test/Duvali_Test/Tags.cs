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

namespace Duvali_Test
{
    static class Tags
    {
        public static XmlDocument doc = new XmlDocument();
        public static XmlNodeList xmlnode;
        public static FileStream fs = new FileStream(@"MyFiles\Data.xml", FileMode.Open, FileAccess.ReadWrite);
        public static bool firstLoad = true;
        public static string ConnPicAddr = @"C:\Users\mahmo\Desktop\cs\Duvali_Test\Duvali_Test\bin\Debug\MyFiles\Images\Connected.png";
        public static string DisconnPicAddr = @"C:\Users\mahmo\Desktop\cs\Duvali_Test\Duvali_Test\bin\Debug\MyFiles\Images\Disconnected.png";
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

        public static string velocity = "";
        public static string qtyTurno = "";
        public static string qtyFalta = "";

    }
}
