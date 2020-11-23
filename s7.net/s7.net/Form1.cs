using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using System.Xml;
using System.IO;

namespace s7.net
{

    public partial class Form1 : Form
    {
        private XmlDocument doc = new XmlDocument();
        XmlNodeList xmlnode;
        
     

        private Plc plc = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }



        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetNames(typeof(CpuType));

            string ip = null;
            string cpuSelect = null;
            string rack = null;
            string slot = null;
            FileStream fs = new FileStream("Data.xml", FileMode.Open, FileAccess.Read);
            doc.Load(fs);
            xmlnode = doc.GetElementsByTagName("Config");
            ip = xmlnode[0].ChildNodes.Item(0).InnerText.Trim();
            cpuSelect = xmlnode[0].ChildNodes.Item(1).InnerText.Trim();
            rack = xmlnode[0].ChildNodes.Item(2).InnerText.Trim();
            slot = xmlnode[0].ChildNodes.Item(3).InnerText.Trim();

            textBox1.Text = ip;
            comboBox1.SelectedItem = cpuSelect;
            textBox2.Text = rack;
            textBox3.Text = slot;

            CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), comboBox1.SelectedValue.ToString());
            plc = new Plc(cpu, textBox1.Text, Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text));

            try
            {
                plc.Open();
            }
            catch (Exception)
            {
                textBox6.Text = "Timeout";
                textBox6.ForeColor = Color.White;
                textBox6.BackColor = Color.Red;
            }

            if (plc.IsConnected)
            {
                textBox6.Text = "Connected";
                textBox6.ForeColor = Color.White;
                textBox6.BackColor = Color.Green;


            }

        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), comboBox1.SelectedValue.ToString());
            plc = new Plc(cpu, textBox1.Text, Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text));

            try
            {
                plc.Open();
            }
            catch (Exception)
            {
                textBox6.Text = "Timeout";
                textBox6.ForeColor = Color.White;
                textBox6.BackColor = Color.Red;
            }

            if (plc.IsConnected)
            {
                textBox6.Text = "Connected";
                textBox6.ForeColor = Color.White;
                textBox6.BackColor = Color.Green;


            }

            //object result1 = plc.Read("DB1.DBW0");
            //textBox4.Text = string.Format("{0}", result1.ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Close();
            }
            catch (Exception)
            {
                textBox6.Text = "Timeout";
                textBox6.ForeColor = Color.White;
                textBox6.BackColor = Color.Red;
            }

            if (!plc.IsConnected)
            {
                textBox6.Text = "Disconnected";
                textBox6.ForeColor = Color.Gray;
                textBox6.BackColor = Color.White;
            }
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            //string address = textBox7.Text;
            //object result = plc.Read(address);
            object result = plc.Read("DB1.DBW0");
            textBox5.Text = string.Format("{0}", result.ToString());
        }

        private void button_Write_Click(object sender, EventArgs e)
        {
            //string address = textBox7.Text;
            object newValue = textBox4.Text.ToString();

            //plc.Write(address, newValue);
            plc.Write("DB1.DBW0", newValue);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //string address = textBox7.Text;
            object newValue = textBox4.Text;

            //plc.Write(address, newValue);
            plc.Write("DB1.DBW0", newValue);
            object result = plc.Read("DB1.DBW0");
            textBox4.Text = string.Format("{0}", result.ToString());
        }

    }
}
