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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for RW.xaml
    /// </summary>
    public partial class RW : Page
    {
        public RW()
        {
            InitializeComponent();
        }

        private void Button_Click_Read(object sender, RoutedEventArgs e)
        {

            try
            {
                ////The first way to read: not suggested because reads one by one
                //var varBool = false;
                //var varInt = 0;
                //var varReal = 0.0;
                //varBool = (bool)gVars.plc.Read("DB1.DBX0.0");
                //varInt = ((ushort)gVars.plc.Read("DB1.DBW2.0")).ConvertToShort();
                //varReal = ((uint)gVars.plc.Read("DB1.DBD4.0")).ConvertToFloat();
                //TB_Bool.Text = varBool.ToString();
                //TB_Int.Text = varInt.ToString();
                //TB_Real.Text = varReal.ToString();

                //// The second way to read
                //var DB1_Bytes = gVars.plc.ReadBytes(DataType.DataBlock, 1, 0, 8);
                ////var DB1_Bytes = (byte[])gVars.plc.Read(DataType.DataBlock, 1, 0, VarType.Byte, 8);
                //bool varBool = DB1_Bytes[0].SelectBit(0);
                //int varInt = S7.Net.Types.Int.FromByteArray(DB1_Bytes.Skip(2).Take(2).ToArray());
                //double varReal = S7.Net.Types.Double.FromByteArray(DB1_Bytes.Skip(4).Take(4).ToArray());
                //TB_Bool.Text = varBool.ToString();
                //TB_Int.Text = varInt.ToString();
                //TB_Real.Text = varReal.ToString();


                // The Third way to read: using DB1.cs class. it reads a single db at a time
                var db1 = new DB1();
                gVars.plc.ReadClass(db1, 1);
                TB_Bool.Text = db1.B.ToString();
                TB_Int.Text = db1.I.ToString();
                TB_Real.Text = db1.R.ToString();

                textBox6.Text = "Read OK";
                textBox6.Background = Brushes.Green;
                textBox6.Foreground = Brushes.White;

                //// 4th way reading multiple variables at a time.
                //List<DataItem> dataItems = new List<DataItem>
                //{
                //    new DataItem(){DataType = DataType.DataBlock, DB= 1, Count=8,},
                //    new DataItem(){DataType = DataType.DataBlock, DB= 2, Count=8,}
                //};
                //gVars.plc.ReadMultipleVars(dataItems);
                //var DB1_Bytes = dataItems[0].Value as byte[];
                //var DB2_Bytes = dataItems[1].Value as byte[];
                //bool varBool = DB1_Bytes[0].SelectBit(0);
                //int varInt = S7.Net.Types.Int.FromByteArray(DB1_Bytes.Skip(2).Take(2).ToArray());
                //double varReal = S7.Net.Types.Double.FromByteArray(DB1_Bytes.Skip(4).Take(4).ToArray());
                //TB_Bool.Text = varBool.ToString();
                //TB_Int.Text = varInt.ToString();
                //TB_Real.Text = varReal.ToString();

            }
            catch (Exception)
            {

                textBox6.Text = "Read Error";
                textBox6.Background = Brushes.Red;
                textBox6.Foreground = Brushes.White;

                TB_Bool.Text = null;
                TB_Int.Text = null;
                TB_Real.Text = null;
            }

        }

        private void Button_Click_Write(object sender, RoutedEventArgs e)
        {
            try
            {
                //// 1st way: write directly in address
                //gVars.plc.Write("DB1.DBX0.0", true);
                //gVars.plc.Write("DB1.DBW2.0", (short)-56);
                //gVars.plc.Write("DB1.DBD4.0", -67.46);

                // second way: using arrays
                byte[] DB1_Bytes = new byte[8];

                S7.Net.Types.Boolean.SetBit(DB1_Bytes[0], 0); // DB1.DBX0.0, "ClearBit" for reset
                S7.Net.Types.Int.ToByteArray((short)-45).CopyTo(DB1_Bytes, 2); // DB1.DBW2.0
                S7.Net.Types.Double.ToByteArray((double)-4.15).CopyTo(DB1_Bytes, 4); // DB1.DBD4.0

                gVars.plc.WriteBytes(DataType.DataBlock, 1, 0, DB1_Bytes);

                textBox6.Text = "Write OK";
                textBox6.Background = Brushes.Green;
                textBox6.Foreground = Brushes.White;
            }
            catch (Exception)
            {
                textBox6.Text = "Write Error";
                textBox6.Background = Brushes.Red;
                textBox6.Foreground = Brushes.White;
            }
        }

        private void EnterHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                gFuncs.plcWrite("DB1.DBW2.0", Convert.ToInt16(TB_Int.Text), textBox6);
                
            }

        }

        private void LeaveHandler(object sender, RoutedEventArgs e)
        {
            gFuncs.plcWrite("DB1.DBW2.0", Convert.ToInt16(TB_Int.Text), textBox6);
        }

        private void tbBoolEnterHndeler(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {
                gFuncs.plcWrite("DB1.DBX0.0", Convert.ToBoolean(TB_Bool.Text), textBox6);
            }

        }

        private void tbBoolLeaveHndeler(object sender, RoutedEventArgs e)
        {
            gFuncs.plcWrite("DB1.DBX0.0", Convert.ToBoolean(TB_Bool.Text), textBox6);
        }

        private void tbRealEnterHndeler(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return)
                {
                    gFuncs.plcWrite("DB1.DBD4.0", Convert.ToDouble(TB_Real.Text), textBox6);
                }
            }
            catch (Exception)
            {
                textBox6.Text = "Write Error";
                textBox6.Background = Brushes.Red;
                textBox6.Foreground = Brushes.White;

                TB_Real.Text = ((uint)gFuncs.plcRead("DB1.DBD4.0", textBox6)).ConvertToFloat().ToString();
            }
        }

        private void tbRealLeaveHndeler(object sender, RoutedEventArgs e)
        {
           
            try
            {
                gFuncs.plcWrite("DB1.DBD4.0", Convert.ToDouble(TB_Real.Text), textBox6);

                textBox6.Text = "Write OK";
                textBox6.Background = Brushes.Green;
                textBox6.Foreground = Brushes.White;
            }
            catch (Exception)
            {
                textBox6.Text = "Write Error";
                textBox6.Background = Brushes.Red;
                textBox6.Foreground = Brushes.White;
                object plcResu = gFuncs.plcRead("DB1.DBD4.0", textBox6);
                TB_Real.Text = ((uint)plcResu).ConvertToFloat().ToString();
            }
        }

        private void Button_Click_toggle(object sender, RoutedEventArgs e)
        {
            bool varBool = (bool)gFuncs.plcRead("DB1.DBX0.0", textBox6);

            varBool = varBool ^ true;
            gFuncs.plcWrite("DB1.DBX0.0", varBool, textBox6);

            if (varBool) { pb_toggle.Background = Brushes.Green; } else { pb_toggle.Background = Brushes.LightGray; }

            varBool = (bool)gFuncs.plcRead("DB1.DBX0.0", textBox6);
            TB_Bool.Text = varBool.ToString();
        }

        private void Button_MD_mome(object sender, MouseButtonEventArgs e)
        {
            gFuncs.plcWrite("DB1.DBX0.0", Convert.ToBoolean("true"), textBox6);

            var varBool = false;
            varBool = (bool)gFuncs.plcRead("DB1.DBX0.0", textBox6);
            TB_Bool.Text = varBool.ToString();
        }

        private void Button_MU_mome(object sender, MouseButtonEventArgs e)
        {
            gFuncs.plcWrite("DB1.DBX0.0", Convert.ToBoolean("false"), textBox6);

            var varBool = false;
            varBool = (bool)gFuncs.plcRead("DB1.DBX0.0", textBox6);
            TB_Bool.Text = varBool.ToString();
        }



    }


}
