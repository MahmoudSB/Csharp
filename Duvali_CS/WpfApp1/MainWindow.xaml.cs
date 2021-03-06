﻿using System;
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
        Page DataPage = new Data();
        Page ControlPage = new Control();
        Page GraphPage = new Graph();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = ConnPage;
            pbConn.Background = Brushes.Green;
            pbConn.Foreground = Brushes.White;
            pbData.Background = Brushes.LightGray;
            pbData.Foreground = Brushes.Black;
            pbControl.Background = Brushes.LightGray;
            pbControl.Foreground = Brushes.Black;
            pbGraph.Background = Brushes.LightGray;
            pbGraph.Foreground = Brushes.Black;
        }

        private void Grid_Unloaded(object sender, RoutedEventArgs e)
        {
            gVars.fs.Close();
            gVars.plc.Close();
        }

        private void PB_ConnectionClickHandler(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = ConnPage;
            pbConn.Background = Brushes.Green;
            pbConn.Foreground = Brushes.White;
            pbData.Background = Brushes.LightGray;
            pbData.Foreground = Brushes.Black;
            pbControl.Background = Brushes.LightGray;
            pbControl.Foreground = Brushes.Black;
            pbGraph.Background = Brushes.LightGray;
            pbGraph.Foreground = Brushes.Black;
        }

        private void PB_DataClickHandler(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = DataPage;
            pbData.Background = Brushes.Green;
            pbData.Foreground = Brushes.White;
            pbConn.Background = Brushes.LightGray;
            pbConn.Foreground = Brushes.Black;
            pbControl.Background = Brushes.LightGray;
            pbControl.Foreground = Brushes.Black;
            pbGraph.Background = Brushes.LightGray;
            pbGraph.Foreground = Brushes.Black;
        }

        private void PB_ControlClickHandler(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = ControlPage;
            pbConn.Background = Brushes.LightGray;
            pbConn.Foreground = Brushes.Black;
            pbData.Background = Brushes.LightGray;
            pbData.Foreground = Brushes.Black;
            pbControl.Background = Brushes.Green;
            pbControl.Foreground = Brushes.White;
            pbGraph.Background = Brushes.LightGray;
            pbGraph.Foreground = Brushes.Black;
        }

        private void PB_GraphClickHandler(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = GraphPage;
            pbConn.Background = Brushes.LightGray;
            pbConn.Foreground = Brushes.Black;
            pbData.Background = Brushes.LightGray;
            pbData.Foreground = Brushes.Black;
            pbControl.Background = Brushes.LightGray;
            pbControl.Foreground = Brushes.Black;
            pbGraph.Background = Brushes.Green;
            pbGraph.Foreground = Brushes.White;
        }
    }
}
