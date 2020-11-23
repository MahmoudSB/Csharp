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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Page ConnPage = new Connection();
        Page RWPage = new RW();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClickRW(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = RWPage;
            pbRW.Background = Brushes.Green;
            pbRW.Foreground = Brushes.White;
            pbConn.Background = Brushes.LightGray;
            pbConn.Foreground = Brushes.Black;
        }

        private void ButtonClickConn(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = ConnPage;
            pbConn.Background = Brushes.Green;
            pbConn.Foreground = Brushes.White;
            pbRW.Background = Brushes.LightGray;
            pbRW.Foreground = Brushes.Black;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = ConnPage;
            pbConn.Background = Brushes.Green;
            pbConn.Foreground = Brushes.White;
            pbRW.Background = Brushes.LightGray;
            pbRW.Foreground = Brushes.Black;
        }

    }
}
