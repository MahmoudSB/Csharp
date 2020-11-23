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

namespace Duvali_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Page ConnectionPage = new Connection();
        Page MonitorPage = new Monitor();
        Page ControlPage = new Control();
        Page TrendsPage = new Trends();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MainFrame.Height = MainStackPanel.ActualHeight - 50 - 2;
        }

        private void btnConnectionPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = ConnectionPage;

            btnConnectionPage.IsEnabled = false;
            btnMonitorPage.IsEnabled = true;
            btnControlPage.IsEnabled = true;
            btnTrendsPage.IsEnabled = true;

            btnConnectionPage.Height = btnConnectionPage.IsEnabled ? 46 : 55;
            btnMonitorPage.Height = btnMonitorPage.IsEnabled ? 42 : 55;
            btnControlPage.Height = btnControlPage.IsEnabled ? 42 : 55;
            btnTrendsPage.Height = btnTrendsPage.IsEnabled ? 42 : 55;
        }

        private void btnMonitorPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = MonitorPage;

            btnConnectionPage.IsEnabled = true;
            btnMonitorPage.IsEnabled = false;
            btnControlPage.IsEnabled = true;
            btnTrendsPage.IsEnabled = true;

            btnConnectionPage.Height = btnConnectionPage.IsEnabled ? 42 : 55;
            btnMonitorPage.Height = btnMonitorPage.IsEnabled ? 42 : 55;
            btnControlPage.Height = btnControlPage.IsEnabled ? 42 : 55;
            btnTrendsPage.Height = btnTrendsPage.IsEnabled ? 42 : 55;
        }

        private void btnControlPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = ControlPage;

            btnConnectionPage.IsEnabled = true;
            btnMonitorPage.IsEnabled = true;
            btnControlPage.IsEnabled = false;
            btnTrendsPage.IsEnabled = true;

            btnConnectionPage.Height = btnConnectionPage.IsEnabled ? 42 : 55;
            btnMonitorPage.Height = btnMonitorPage.IsEnabled ? 42 : 55;
            btnControlPage.Height = btnControlPage.IsEnabled ? 42 : 55;
            btnTrendsPage.Height = btnTrendsPage.IsEnabled ? 42 : 55;
        }

        private void btnTrendsPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = TrendsPage;

            btnConnectionPage.IsEnabled = true;
            btnMonitorPage.IsEnabled = true;
            btnControlPage.IsEnabled = true;
            btnTrendsPage.IsEnabled = false;

            btnConnectionPage.Height = btnConnectionPage.IsEnabled ? 42 : 55;
            btnMonitorPage.Height = btnMonitorPage.IsEnabled ? 42 : 55;
            btnControlPage.Height = btnControlPage.IsEnabled ? 42 : 55;
            btnTrendsPage.Height = btnTrendsPage.IsEnabled ? 42 : 55;
        }
    }
}
