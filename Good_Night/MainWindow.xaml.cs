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

namespace Good_Night
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DataButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void MorningMoodButton_Click(object sender, RoutedEventArgs e)
        {
            // When morning mood button clicked
            // Either disable other buttons or only allow one radio button
            // at a time to be "filled"
        }
    }
}
