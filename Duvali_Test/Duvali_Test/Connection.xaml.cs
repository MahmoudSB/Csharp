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

namespace Duvali_Test
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


            if (Tags.doc.ChildNodes.Count == 0)
            {
                Tags.doc.Load(Tags.fs);
            }

            Tags.xmlnode = Tags.doc.GetElementsByTagName("Machine");
            Tags.ip = Tags.xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
            Tags.cpuSelect = Tags.xmlnode[0].ChildNodes.Item(1).InnerText.Trim();
            Tags.rack = Tags.xmlnode[0].ChildNodes.Item(2).InnerText.Trim();
            Tags.slot = Tags.xmlnode[0].ChildNodes.Item(3).InnerText.Trim();

            textBox1.Text = Tags.ip;
            comboBox1.SelectedItem = Tags.cpuSelect;
            textBox2.Text = Tags.rack;
            textBox3.Text = Tags.slot;


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
            Tags.xmlnode = Tags.doc.GetElementsByTagName("Machine");
            Tags.ip = Tags.xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
            Tags.cpuSelect = Tags.xmlnode[0].ChildNodes.Item(1).InnerText.Trim();
            Tags.rack = Tags.xmlnode[0].ChildNodes.Item(2).InnerText.Trim();
            Tags.slot = Tags.xmlnode[0].ChildNodes.Item(3).InnerText.Trim();

            textBox1.Text = Tags.ip;
            comboBox1.SelectedItem = Tags.cpuSelect;
            textBox2.Text = Tags.rack;
            textBox3.Text = Tags.slot;

        }

        private void PB_SaveClickHandler(object sender, RoutedEventArgs e)
        {
            Tags.xmlnode = Tags.doc.GetElementsByTagName("Machine");
            Tags.xmlnode[0].ChildNodes.Item(0).InnerText = textBox1.Text;
            Tags.xmlnode[0].ChildNodes.Item(1).InnerText = comboBox1.SelectedItem.ToString();
            Tags.xmlnode[0].ChildNodes.Item(2).InnerText = textBox2.Text;
            Tags.xmlnode[0].ChildNodes.Item(3).InnerText = textBox3.Text;
        }

        private void Image_imConnClickUpHandler(object sender, MouseButtonEventArgs e)
        {
            if (Tags.plc.IsConnected)
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
            Tags.ip = textBox1.Text;
            Tags.cpuSelect = comboBox1.SelectedItem.ToString();
            Tags.rack = textBox2.Text;
            Tags.slot = textBox3.Text;

            Tags.plc = new Plc(Tags.cpu, Tags.ip, Convert.ToInt16(Tags.rack), Convert.ToInt16(Tags.slot));

            try
            {
                Tags.plc.Open();
            }
            catch (Exception)
            {
                textBox6.Text = "Timeout";
                MessageBox.Show("Timeout" + Environment.NewLine + " Please check the configuration and the PLC connection.");

                textBox6.Background = Brushes.Red;
                textBox6.Foreground = Brushes.White;
            }

            if (Tags.plc.IsConnected)
            {
                textBox6.Text = "Connected";
                textBox6.Background = Brushes.Green;
                textBox6.Foreground = Brushes.White;
                
            }
        }

        private void Disconnect()
        {
            try
            {
                Tags.plc.Close();
            }
            catch (Exception)
            {
                textBox6.Text = "Timeout";
                textBox6.Background = Brushes.Red;
                textBox6.Foreground = Brushes.White;
            }

            if (!Tags.plc.IsConnected)
            {
                textBox6.Text = "Disconnected";
                textBox6.Background = Brushes.White;
                textBox6.Foreground = Brushes.Gray;
                
            }
        }
    }
}
