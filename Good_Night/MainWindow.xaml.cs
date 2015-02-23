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
using Good_Night.Model;
using Good_Night.Repository;
using Good_Night;

namespace Good_Night
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static SleepEventRepository repo = new SleepEventRepository();

        public MainWindow()
        {
            InitializeComponent();
            HoursSleptList.DataContext = repo.Context().SleepEvents.Local;
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DataButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void HoursComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<int> data = new List<int>();
            data.Add(1);
            data.Add(2);
            data.Add(3);
            data.Add(4);
            data.Add(5);
            data.Add(6);
            data.Add(7);
            data.Add(8);
            data.Add(9);
            data.Add(10);
            data.Add(11);
            data.Add(12);
            data.Add(13);
            data.Add(14);
            data.Add(15);

            // Get the ComboBox reference.
            var hourscombobox = sender as ComboBox;

            // Assign the ItemsSource to the List.
            hourscombobox.ItemsSource = data;

            // Make the 8 hours default selected.
            hourscombobox.SelectedIndex = 7;
        }

        private void HoursComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the ComboBox.
            var hourscomboBox = sender as ComboBox;

            // Set SelectedItem as Window Title.
            string value = hourscomboBox.SelectedItem as string;
            this.Title = "Selected: " + value;
        }

        private void MinutesComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<int> data = new List<int>();
            data.Add(0);
            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(40);
            data.Add(50);

            var minutescombobox = sender as ComboBox;

            minutescombobox.ItemsSource = data;

            minutescombobox.SelectedIndex = 0;
        }

        private void MinutesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var minutescomboBox = sender as ComboBox;

            string value = minutescomboBox.SelectedItem as string;
            this.Title = "Selected: " + value;
        }

        private void MorningMoodButton_Click(object sender, RoutedEventArgs e)
        {
            // When morning mood button clicked
            // Either disable other buttons or only allow one radio button
            // at a time to be "filled"
        }

        public void Submit_Click(object sender, RoutedEventArgs e)
        {
            var hours = Convert.ToInt32(HoursComboBox.SelectionBoxItem);
            var minutes = Convert.ToInt32(MinutesComboBox.SelectionBoxItem);
            string date = DatePicker.SelectedDate.ToString();
            var morning = Convert.ToInt32(MorningSlider.Value);
            var day = Convert.ToInt32(DaySlider.Value);
            repo.Add(new SleepEvent(hours, minutes, date, morning, day));
        }
    }
}
