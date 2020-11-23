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
    public partial class Data : Page
    {
        

        public Data()
        {
            InitializeComponent();
        }

        private void gridLoaded(object sender, RoutedEventArgs e)
        {
            gVars.ReadFromPlc = new Thread(DataReader);
            gVars.ReadFromPlc.Start();

            const double margin = 10;
            double xmin = margin;
            double xmax = canGraph.Width - margin;
            double ymin = margin;
            double ymax = canGraph.Height - margin;
            const double step = 10;

            // Make the X axis.
            GeometryGroup xaxis_geom = new GeometryGroup();
            xaxis_geom.Children.Add(new LineGeometry(
                new Point(0, ymax), new Point(canGraph.Width, ymax)));
            for (double x = xmin + step;
                x <= canGraph.Width - step; x += step)
            {
                xaxis_geom.Children.Add(new LineGeometry(
                    new Point(x, ymax - margin / 2),
                    new Point(x, ymax + margin / 2)));
            }

            System.Windows.Shapes.Path xaxis_path = new System.Windows.Shapes.Path();
            xaxis_path.StrokeThickness = 1;
            xaxis_path.Stroke = Brushes.Black;
            xaxis_path.Data = xaxis_geom;

            canGraph.Children.Add(xaxis_path);

            // Make the Y ayis.
            GeometryGroup yaxis_geom = new GeometryGroup();
            yaxis_geom.Children.Add(new LineGeometry(
                new Point(xmin, 0), new Point(xmin, canGraph.Height)));
            for (double y = step; y <= canGraph.Height - step; y += step)
            {
                yaxis_geom.Children.Add(new LineGeometry(
                    new Point(xmin - margin / 2, y),
                    new Point(xmin + margin / 2, y)));
            }

            System.Windows.Shapes.Path yaxis_path = new System.Windows.Shapes.Path();
            yaxis_path.StrokeThickness = 1;
            yaxis_path.Stroke = Brushes.Black;
            yaxis_path.Data = yaxis_geom;

            canGraph.Children.Add(yaxis_path);

            // Make some data sets.
            Brush[] brushes = { Brushes.Red, Brushes.Green, Brushes.Blue };
            Random rand = new Random();
            for (int data_set = 0; data_set < 3; data_set++)
            {
                int last_y = rand.Next((int)ymin, (int)ymax);

                PointCollection points = new PointCollection();
                for (double x = xmin; x <= xmax; x += step)
                {
                    last_y = rand.Next(last_y - 10, last_y + 10);
                    if (last_y < ymin) last_y = (int)ymin;
                    if (last_y > ymax) last_y = (int)ymax;
                    points.Add(new Point(x, last_y));
                }

                Polyline polyline = new Polyline();
                polyline.StrokeThickness = 1;
                polyline.Stroke = brushes[data_set];
                polyline.Points = points;

                canGraph.Children.Add(polyline);
            }
        }

        private void gridUnloaded(object sender, RoutedEventArgs e)
        {
            gVars.Thread_end = true;
        }

        private void TB_OFFocusHandler(object sender, RoutedEventArgs e)
        {
            gVars.Thread_end = true;
        }

        private void tb_OFEnterHndeler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            { 
                gVars.Thread_end = true;
                //gVars.ReadFromPlc.Suspend();
                byte[] Bytes = new byte[9];
                S7.Net.Types.String.ToByteArray(TB_of.Text, 9).CopyTo(Bytes, 0);
                gVars.plc.WriteBytes(DataType.DataBlock, 6, 72, Bytes);
                gVars.Thread_end = false;
                gVars.ReadFromPlc = new Thread(DataReader);
                gVars.ReadFromPlc.Start();
            }
        }

        private void tb_ArtigoEnterHndeler(object sender, KeyEventArgs e)
        {

        }

        private void tb_nucEnterHndeler(object sender, KeyEventArgs e)
        {

        }


        private void tb_OFLeaveHndeler(object sender, RoutedEventArgs e)
        {
            gVars.Thread_end = true;
            //gVars.ReadFromPlc.Suspend();
            byte[] Bytes = new byte[9];
            S7.Net.Types.String.ToByteArray(TB_of.Text, 9).CopyTo(Bytes, 0);
            gVars.plc.WriteBytes(DataType.DataBlock, 6, 72, Bytes);
            gVars.Thread_end = false;
            gVars.ReadFromPlc = new Thread(DataReader);
            gVars.ReadFromPlc.Start();
        }

        private void tb_ArtigoLeaveHndeler(object sender, RoutedEventArgs e)
        {

        }

        private void tb_nucLeaveHndeler(object sender, RoutedEventArgs e)
        {

        }




        private void DataReader()
        {

            while (!gVars.Thread_end)
            {
                var bytes1 = ((byte[])gVars.plc.Read(DataType.DataBlock, 6, 72, VarType.Byte, 12));
                gVars.OF = S7.Net.Types.String.FromByteArray(bytes1.Skip(0).Take(12).ToArray());

                var bytes2 = ((byte[])gVars.plc.Read(DataType.DataBlock, 6, 84, VarType.Byte, 18));
                gVars.artigo = S7.Net.Types.String.FromByteArray(bytes2.Skip(0).Take(18).ToArray());

                var bytes3 = ((byte[])gVars.plc.Read(DataType.DataBlock, 6, 42, VarType.Byte, 14));
                gVars.nuc = S7.Net.Types.String.FromByteArray(bytes3.Skip(0).Take(14).ToArray());

                
                gVars.qty = gVars.plc.Read("DB6.DBD134.0").ToString();
                gVars.inicio_hh= gVars.plc.Read("DB6.DBB126.0").ToString();
                gVars.inicio_mm = gVars.plc.Read("DB6.DBB127.0").ToString();

                Dispatcher.Invoke(() =>
                {
                    //TB_Iniomm.Text = gVars.inicio_mm;
                    TB_of.Text = gVars.OF;
                    TB_IniHH.Text = gVars.inicio_hh;
                    TB_artigo.Text = gVars.artigo;
                    TB_nuc.Text = gVars.nuc;
                    TB_qty.Text = gVars.qty;
                });
            }
        }

    }


}
