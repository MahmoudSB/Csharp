using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
using System.Xml;
using System.IO;
using S7.Net.Types;
using System.Windows.Media;
using System.Windows.Controls;

namespace WpfApp1
{
    static class gFuncs
    {
        static public void plcWrite(string addr, object value, TextBox TB)
        {
            try
            {
                gVars.plc.Write(addr, value);

                TB.Text = "Write Ok";
                TB.Background = Brushes.Green;
                TB.Foreground = Brushes.White;
            }
            catch (Exception)
            {

                TB.Text = "Write Error";
                TB.Background = Brushes.Red;
                TB.Foreground = Brushes.White;
            }
        }

        static public object plcRead(string addr, TextBox TB)
        {
            object plcReturned = new object();

            try
            {
                plcReturned = gVars.plc.Read(addr);

                TB.Text = "Read Ok";
                TB.Background = Brushes.Green;
                TB.Foreground = Brushes.White;
            }
            catch (Exception)
            {
                TB.Text = "Read Error";
                TB.Background = Brushes.Red;
                TB.Foreground = Brushes.White;
            }

            return plcReturned;
        }


    }

}
