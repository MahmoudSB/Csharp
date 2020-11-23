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
    public partial class Control : Page
    {


        public Control()
        {
            InitializeComponent();
        }

        private void GridLoad(object sender, RoutedEventArgs e)
        {
            if (gVars.plc.IsConnected)
            {
                bool varBool = false;

                varBool = (bool)gFuncs.plcRead("DB6.DBX69.1", TB_Status);
                if (varBool)
                {
                    pb_InicioOf.Background = Brushes.Green;
                }
                else
                {
                    pb_InicioOf.Background = Brushes.LightGray;
                }

                varBool = (bool)gFuncs.plcRead("DB6.DBX69.0", TB_Status);
                if (varBool)
                {
                    pb_Ligado.Background = Brushes.Green;
                }
                else
                {
                    pb_Ligado.Background = Brushes.LightGray;
                }

                varBool = (bool)gFuncs.plcRead("DB6.DBX69.2", TB_Status);
                if (varBool)
                {
                    pb_rstCnt.Background = Brushes.Green;
                }
                else
                {
                    pb_rstCnt.Background = Brushes.LightGray;
                }

                varBool = (bool)gFuncs.plcRead("DB6.DBX226.1", TB_Status);
                if (varBool)
                {
                    pb_PrimMetro.Background = Brushes.Green;
                }
                else
                {
                    pb_PrimMetro.Background = Brushes.LightGray;
                }

                varBool = (bool)gFuncs.plcRead("DB6.DBX226.2", TB_Status);
                if (varBool)
                {
                    pb_Revistar.Background = Brushes.Green;
                }
                else
                {
                    pb_Revistar.Background = Brushes.LightGray;
                }
            }
        }

        private void PB_InicioofClickHandler(object sender, RoutedEventArgs e)
        {
            if (gVars.plc.IsConnected)
            {
                bool varBool = (bool)gFuncs.plcRead("DB6.DBX69.1", TB_Status);

                varBool = varBool ^ true;
                gFuncs.plcWrite("DB6.DBX69.1", varBool, TB_Status);

                if (varBool)
                {
                    pb_InicioOf.Background = Brushes.Green;
                }
                else
                {
                    pb_InicioOf.Background = Brushes.LightGray;
                }
            }
        }

        private void PB_LigadoClickHandler(object sender, RoutedEventArgs e)
        {
            if (gVars.plc.IsConnected)
            {
                bool varBool = (bool)gFuncs.plcRead("DB6.DBX69.0", TB_Status);

                varBool = varBool ^ true;
                gFuncs.plcWrite("DB6.DBX69.0", varBool, TB_Status);

                if (varBool)
                {
                    pb_Ligado.Background = Brushes.Green;
                }
                else
                {
                    pb_Ligado.Background = Brushes.LightGray;
                }
            }
        }

        private void PB_rstCntClickHandler(object sender, RoutedEventArgs e)
        {
            if (gVars.plc.IsConnected)
            {
                bool varBool = (bool)gFuncs.plcRead("DB6.DBX69.2", TB_Status);

                varBool = varBool ^ true;
                gFuncs.plcWrite("DB6.DBX69.2", varBool, TB_Status);

                if (varBool)
                {
                    pb_rstCnt.Background = Brushes.Green;
                }
                else
                {
                    pb_rstCnt.Background = Brushes.LightGray;
                }
            }
        }

        private void PB_PrimMetroClickHandler(object sender, RoutedEventArgs e)
        {
            if (gVars.plc.IsConnected)
            {
                bool varBool = (bool)gFuncs.plcRead("DB6.DBX226.1", TB_Status);

                varBool = varBool ^ true;
                gFuncs.plcWrite("DB6.DBX226.1", varBool, TB_Status);

                if (varBool)
                {
                    pb_PrimMetro.Background = Brushes.Green;
                }
                else
                {
                    pb_PrimMetro.Background = Brushes.LightGray;
                }
            }
        }

        private void PB_RevistarClickHandler(object sender, RoutedEventArgs e)
        {
            if (gVars.plc.IsConnected)
            {
                bool varBool = (bool)gFuncs.plcRead("DB6.DBX226.2", TB_Status);

                varBool = varBool ^ true;
                gFuncs.plcWrite("DB6.DBX226.2", varBool, TB_Status);

                if (varBool)
                {
                    pb_Revistar.Background = Brushes.Green;
                }
                else
                {
                    pb_Revistar.Background = Brushes.LightGray;
                }
            }
        }
    }
}
