using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using S7.Net;
using System.Xml;
using System.IO;
using S7.Net.Types;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Connection.xaml
    /// </summary>
    public partial class Connection : Page
    {
        //private XmlgVars.document gVars.doc = new XmlgVars.document();
        //gVars.xmlnodeList gVars.xmlnode;
        //FileStream gVars.fs = new FileStream("Data.xml", FileMode.Open, FileAccess.ReadWrite);

        //private Plc plc = null;

        public Connection()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Connect();
        }

        private void Button_Click_Dis(object sender, RoutedEventArgs e)
        {
            Disconnect();
        }


        private void LoadConn(object sender, RoutedEventArgs e)
        {
            string[] cpus = Enum.GetNames(typeof(CpuType));

            foreach (string item in cpus) { comboBox1.Items.Add(item); }

            string ip = null;
            string cpuSelect = null;
            string rack = null;
            string slot = null;
            //FileStream gVars.plc = new FileStream("Data.xml", FileMode.Open, FileAccess.Read);
            if (gVars.doc.ChildNodes.Count == 0)
            {
                gVars.doc.Load(gVars.fs);
            }

            gVars.xmlnode = gVars.doc.GetElementsByTagName("Config");
            ip = gVars.xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
            cpuSelect = gVars.xmlnode[0].ChildNodes.Item(1).InnerText.Trim();
            rack = gVars.xmlnode[0].ChildNodes.Item(2).InnerText.Trim();
            slot = gVars.xmlnode[0].ChildNodes.Item(3).InnerText.Trim();

            textBox1.Text = ip;
            comboBox1.SelectedItem = cpuSelect;
            textBox2.Text = rack;
            textBox3.Text = slot;

            imConn.Source = new BitmapImage(new Uri(gVars.DisconnPicAddr));

        }

        private void UnloadConn(object sender, RoutedEventArgs e)
        {
            //gVars.fs.Close();
        }

        private void Button_Click_Refresh(object sender, RoutedEventArgs e)
        {
            string ip = null;
            string cpuSelect = null;
            string rack = null;
            string slot = null;
            //FileStream gVars.fs = new FileStream("Data.xml", FileMode.Open, FileAccess.Read);
            //gVars.doc.Load(gVars.fs);
            gVars.xmlnode = gVars.doc.GetElementsByTagName("Config");
            ip = gVars.xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
            cpuSelect = gVars.xmlnode[0].ChildNodes.Item(1).InnerText.Trim();
            rack = gVars.xmlnode[0].ChildNodes.Item(2).InnerText.Trim();
            slot = gVars.xmlnode[0].ChildNodes.Item(3).InnerText.Trim();

            textBox1.Text = ip;
            comboBox1.SelectedItem = cpuSelect;
            textBox2.Text = rack;
            textBox3.Text = slot;

        }


        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            //FileStream gVars.fs = new FileStream("Data.xml", FileMode.Open, FileAccess.ReadWrite);
            //gVars.doc.Load(gVars.fs);
            gVars.xmlnode = gVars.doc.GetElementsByTagName("Config");
            gVars.xmlnode[0].ChildNodes.Item(0).InnerText = textBox1.Text;
            gVars.xmlnode[0].ChildNodes.Item(1).InnerText = comboBox1.SelectedItem.ToString();
            gVars.xmlnode[0].ChildNodes.Item(2).InnerText = textBox2.Text;
            gVars.xmlnode[0].ChildNodes.Item(3).InnerText = textBox3.Text;
        }

        private void ClickUp_ImgConn(object sender, MouseButtonEventArgs e)
        {
            Connect();
        }

        private object plcRead(string add)
        {
            try
            {
                return gVars.plc.Read(add);
            }
            catch (Exception)
            {
                textBox6.Text = "Read Error";
                textBox6.Background = Brushes.Red;
                textBox6.Foreground = Brushes.White;
                return 0;
            }
        }

        //private void plcWrite(string add, object value)
        //{
        //    try
        //    {
        //        gVars.plc.Write(add, value);
        //    }
        //    catch (Exception)
        //    {
        //        textBox6.Text = "Write Error";
        //        textBox6.Background = Brushes.Red;
        //        textBox6.Foreground = Brushes.White;
        //    }
        //}

        private void Connect()
        {
            CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), comboBox1.SelectedItem.ToString());
            gVars.plc = new Plc(cpu, textBox1.Text, Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text));

            //CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), "S71200");
            //gVars.plc = new Plc(cpu, "192.168.10.245", 0, 1);

            try
            {
                gVars.plc.Open();
            }
            catch (Exception)
            {
                textBox6.Text = "Timeout";
                MessageBox.Show("Timeout" + Environment.NewLine + " Please check the configuration and the PLC connection.");

                textBox6.Background = Brushes.Red;
                textBox6.Foreground = Brushes.White;
            }

            //var result = plc.Open();
            //if (result != ErrorCode.NoError) { tbError.Text = plc.LastErrorCode + plc.LastErrorString;}

            if (gVars.plc.IsConnected)
            {
                textBox6.Text = "Connected";
                textBox6.Background = Brushes.Green;
                textBox6.Foreground = Brushes.White;
                //imConn.Visibility = Visibility.Visible;
                imConn.Source = new BitmapImage(new Uri(gVars.ConnPicAddr));
            }


        }

        private void Disconnect()
        {
            try
            {
                gVars.plc.Close();
            }
            catch (Exception)
            {
                textBox6.Text = "Timeout";
                textBox6.Background = Brushes.Red;
                textBox6.Foreground = Brushes.White;
            }

            if (!gVars.plc.IsConnected)
            {
                textBox6.Text = "Disconnected";
                textBox6.Background = Brushes.White;
                textBox6.Foreground = Brushes.Gray;
                //imDisConn.Visibility = Visibility.Visible;
                //imConn.Visibility = Visibility.Hidden;
                imConn.Source = new BitmapImage(new Uri(gVars.DisconnPicAddr));
            }
        }
    }
}
