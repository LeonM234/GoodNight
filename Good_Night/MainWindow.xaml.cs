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
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DataButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void HoursComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("1 hour");
            data.Add("2 hours");
            data.Add("3 hours");
            data.Add("4 hours");
            data.Add("5 hours");
            data.Add("6 hours");
            data.Add("7 hours");
            data.Add("8 hours");
            data.Add("9 hours");
            data.Add("10 hours");
            data.Add("11 hours");
            data.Add("12 hours");
            data.Add("13 hours");
            data.Add("14 hours");
            data.Add("15 hours...seriously?");

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
            List<string> data = new List<string>();
            data.Add("0 minutes");
            data.Add("10 minutes");
            data.Add("20 minutes");
            data.Add("30 minutes");
            data.Add("40 minutes");
            data.Add("50 minutes");

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
            // store hours slept
            var hours = Convert.ToInt32(HoursComboBox.SelectedValue);
            // store minutes slept
            var minutes = Convert.ToInt32(MinutesComboBox.SelectedValue);
            // store date of sleep
            string date = DatePicker.SelectedDate.ToString();
            // store morning feels
            var morning = Convert.ToInt32(MorningSlider.Value);
            // store day feels
            var day = Convert.ToInt32(DaySlider.Value);
            repo.Add(new SleepEvent(hours, minutes, date, morning, day));
        }
    }
}
