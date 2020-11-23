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
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Data.xaml
    /// </summary>
    public partial class Graph : Page
    {
        

        public Graph()
        {
            InitializeComponent();
        }

        private void GridLoad(object sender, RoutedEventArgs e)
        {
            var bytes1 = ((byte[])gFuncs.plcReadByte(6, 72, 12, TB_Status));
            gVars.OF = S7.Net.Types.String.FromByteArray(bytes1.Skip(0).Take(12).ToArray());

            var bytes2 = ((byte[])gFuncs.plcReadByte(6, 84, 18, TB_Status));
            gVars.artigo = S7.Net.Types.String.FromByteArray(bytes2.Skip(0).Take(18).ToArray());

            var bytes3 = ((byte[])gFuncs.plcReadByte(6, 42, 14, TB_Status));
            gVars.nuc = S7.Net.Types.String.FromByteArray(bytes3.Skip(0).Take(14).ToArray());

            gVars.qty = gFuncs.plcRead("DB6.DBD134.0", TB_Status).ToString();
            gVars.inicio_hh = gFuncs.plcRead("DB6.DBB126.0", TB_Status).ToString();
            gVars.inicio_mm = gFuncs.plcRead("DB6.DBB127.0", TB_Status).ToString();
            gVars.velocity = gFuncs.plcRead("DB11.DBW42.0", TB_Status).ToString();
            gVars.qtyTurno = gFuncs.plcRead("DB11.DBD32.0", TB_Status).ToString();
            gVars.qtyFalta = gFuncs.plcRead("DB11.DBD0.0", TB_Status).ToString();

            TB_of.Text = gVars.OF;
            TB_IniHH.Text = gVars.inicio_hh;
            TB_IniMM.Text = gVars.inicio_mm;
            TB_artigo.Text = gVars.artigo;
            TB_nuc.Text = gVars.nuc;
            TB_qty.Text = gVars.qty;
            TB_Velocity.Text = gVars.velocity;
            TB_QtyT.Text = gVars.qtyTurno;
            TB_qtyF.Text = gVars.qtyFalta;
        }

        private void PB_ReadClickHandler(object sender, RoutedEventArgs e)
        {
            var bytes1 = ((byte[])gFuncs.plcReadByte(6, 72, 12, TB_Status));
            gVars.OF = S7.Net.Types.String.FromByteArray(bytes1.Skip(0).Take(12).ToArray());

            var bytes2 = ((byte[])gFuncs.plcReadByte(6, 84, 18, TB_Status));
            gVars.artigo = S7.Net.Types.String.FromByteArray(bytes2.Skip(0).Take(18).ToArray());

            var bytes3 = ((byte[])gFuncs.plcReadByte(6, 42, 14, TB_Status));
            gVars.nuc = S7.Net.Types.String.FromByteArray(bytes3.Skip(0).Take(14).ToArray());

            gVars.qty = gFuncs.plcRead("DB6.DBD134.0", TB_Status).ToString();
            gVars.inicio_hh = gFuncs.plcRead("DB6.DBB126.0", TB_Status).ToString();
            gVars.inicio_mm = gFuncs.plcRead("DB6.DBB127.0", TB_Status).ToString();
            gVars.velocity = gFuncs.plcRead("DB11.DBW42.0", TB_Status).ToString();
            gVars.qtyTurno = gFuncs.plcRead("DB11.DBD32.0", TB_Status).ToString();
            gVars.qtyFalta = gFuncs.plcRead("DB11.DBD0.0", TB_Status).ToString();

            TB_of.Text = gVars.OF;
            TB_IniHH.Text = gVars.inicio_hh;
            TB_artigo.Text = gVars.artigo;
            TB_nuc.Text = gVars.nuc;
            TB_qty.Text = gVars.qty;
            TB_Velocity.Text = gVars.velocity;
            TB_QtyT.Text = gVars.qtyTurno;
            TB_qtyF.Text = gVars.qtyFalta;
        }

        private void tb_OFEnterHndeler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                byte[] Bytes = new byte[9];
                S7.Net.Types.String.ToByteArray(TB_of.Text, 9).CopyTo(Bytes, 0);
                gFuncs.plcWriteBytes(6, 72, Bytes, TB_Status);
            }
        }

        private void tb_OFLeaveHndeler(object sender, RoutedEventArgs e)
        {
            byte[] Bytes = new byte[9];
            S7.Net.Types.String.ToByteArray(TB_of.Text, 9).CopyTo(Bytes, 0);
            gFuncs.plcWriteBytes( 6, 72, Bytes, TB_Status);
        }

        private void tb_ArtigoEnterHndeler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                byte[] Bytes = new byte[18];
                S7.Net.Types.String.ToByteArray(TB_artigo.Text, 18).CopyTo(Bytes, 0);
                gFuncs.plcWriteBytes(6, 84, Bytes, TB_Status);
            }
        }

        private void tb_ArtigoLeaveHndeler(object sender, RoutedEventArgs e)
        {
            byte[] Bytes = new byte[18];
            S7.Net.Types.String.ToByteArray(TB_artigo.Text, 18).CopyTo(Bytes, 0);
            gFuncs.plcWriteBytes(6, 84, Bytes, TB_Status);
        }

        private void tb_nucEnterHndeler(object sender, KeyEventArgs e)
        {
            byte[] Bytes = new byte[14];
            S7.Net.Types.String.ToByteArray(TB_nuc.Text, 14).CopyTo(Bytes, 0);
            gFuncs.plcWriteBytes(6, 42, Bytes, TB_Status);
        }

        private void tb_nucLeaveHndeler(object sender, RoutedEventArgs e)
        {
            byte[] Bytes = new byte[14];
            S7.Net.Types.String.ToByteArray(TB_nuc.Text, 14).CopyTo(Bytes, 0);
            gFuncs.plcWriteBytes(6, 42, Bytes, TB_Status);
        }
    }


}
