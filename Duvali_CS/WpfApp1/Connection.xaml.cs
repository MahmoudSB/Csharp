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
        public Connection()
        {
            InitializeComponent();
        }

        private void LoadConn(object sender, RoutedEventArgs e)
        {
            string[] cpus = Enum.GetNames(typeof(CpuType));

            foreach (string item in cpus) { comboBox1.Items.Add(item); }


            if (gVars.doc.ChildNodes.Count == 0)
            {
                gVars.doc.Load(gVars.fs);
            }

            gVars.xmlnode = gVars.doc.GetElementsByTagName("Machine");
            gVars.ip = gVars.xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
            gVars.cpuSelect = gVars.xmlnode[0].ChildNodes.Item(1).InnerText.Trim();
            gVars.rack = gVars.xmlnode[0].ChildNodes.Item(2).InnerText.Trim();
            gVars.slot = gVars.xmlnode[0].ChildNodes.Item(3).InnerText.Trim();

            textBox1.Text = gVars.ip;
            comboBox1.SelectedItem = gVars.cpuSelect;
            textBox2.Text = gVars.rack;
            textBox3.Text = gVars.slot;

            if (gVars.firstLoad )
            {
                imConn.Source = new BitmapImage(new Uri(gVars.DisconnPicAddr));
                gVars.firstLoad = false;
            }
        }

        private void PB_ConnectClickHandler(object sender, RoutedEventArgs e)
        {
            Connect();
        }

        private void PB_DisconnectClickHandler(object sender, RoutedEventArgs e)
        {
            Disconnect();
        }

        private void PB_RefreshClickHandler(object sender, RoutedEventArgs e)
        {
            gVars.xmlnode = gVars.doc.GetElementsByTagName("Machine");
            gVars.ip = gVars.xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
            gVars.cpuSelect = gVars.xmlnode[0].ChildNodes.Item(1).InnerText.Trim();
            gVars.rack = gVars.xmlnode[0].ChildNodes.Item(2).InnerText.Trim();
            gVars.slot = gVars.xmlnode[0].ChildNodes.Item(3).InnerText.Trim();

            textBox1.Text = gVars.ip;
            comboBox1.SelectedItem = gVars.cpuSelect;
            textBox2.Text = gVars.rack;
            textBox3.Text = gVars.slot;

        }

        private void PB_SaveClickHandler(object sender, RoutedEventArgs e)
        {
            gVars.xmlnode = gVars.doc.GetElementsByTagName("Machine");
            gVars.xmlnode[0].ChildNodes.Item(0).InnerText = textBox1.Text;
            gVars.xmlnode[0].ChildNodes.Item(1).InnerText = comboBox1.SelectedItem.ToString();
            gVars.xmlnode[0].ChildNodes.Item(2).InnerText = textBox2.Text;
            gVars.xmlnode[0].ChildNodes.Item(3).InnerText = textBox3.Text;
        }

        private void Image_imConnClickUpHandler(object sender, MouseButtonEventArgs e)
        {
            if (gVars.plc.IsConnected)
            {
                Disconnect();
            }
            else
            {
                Connect();
            }
        }

        private void Connect()
        {
            gVars.ip = textBox1.Text;
            gVars.cpuSelect = comboBox1.SelectedItem.ToString();
            gVars.rack = textBox2.Text;
            gVars.slot = textBox3.Text;

            gVars.plc = new Plc(gVars.cpu, gVars.ip, Convert.ToInt16(gVars.rack), Convert.ToInt16(gVars.slot));

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

            if (gVars.plc.IsConnected)
            {
                textBox6.Text = "Connected";
                textBox6.Background = Brushes.Green;
                textBox6.Foreground = Brushes.White;
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
                imConn.Source = new BitmapImage(new Uri(gVars.DisconnPicAddr));
            }
        }
    }
}
