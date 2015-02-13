using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good_Night.Model
{
    public class SleepEvent : INotifyPropertyChanged
    {
        public int SleepEventId { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string Date { get; set; }
        public int MorningFeels { get; set; }
        public int DayFeels { get; set; }

        public SleepEvent()
        {
            // Place holder   
        }

        public SleepEvent(int SleepHours, int SleepMinutes, string SleepDate, int Morning, int Day)
        {
            this.Hours = SleepHours;
            this.Minutes = SleepMinutes;
            this.Date = SleepDate;
            this.MorningFeels = Morning;
            this.DayFeels = Day;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
