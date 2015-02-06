﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.BDDfy;

namespace UnitTestProject1
{
    [TestClass]
    public class StoryTests
    {
        private static Window window;
        private static Application application;
        private static Button home_button;
        private static Button data_button;
        private static Button lastnight_button;
        private static WpfDatePicker date_picker;
        private static RadioButton morningbutton_1;
        private static RadioButton morningbutton_2;
        private static RadioButton morningbutton_3;
        private static RadioButton morningbutton_4;
        private static RadioButton morningbutton_5;
        private static RadioButton morningbutton_6;
        private static RadioButton morningbutton_7;
        private static RadioButton morningbutton_8;
        private static RadioButton morningbutton_9;
        private static RadioButton morningbutton_10;
        private static RadioButton daybutton_1;
        private static RadioButton daybutton_2;
        private static RadioButton daybutton_3;
        private static RadioButton daybutton_4;
        private static RadioButton daybutton_5;
        private static RadioButton daybutton_6;
        private static RadioButton daybutton_7;
        private static RadioButton daybutton_8;
        private static RadioButton daybutton_9;
        private static RadioButton daybutton_10;
        private static Button submit_button;

        [ClassInitialize]
        public static void Setup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _context)
        {
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\UnitTestProject1\\bin\\Debug\\Good_Night");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
            home_button = window.Get<Button>("HomeButton");
            data_button = window.Get<Button>("DataButton");
            lastnight_button = window.Get<Button>("LastNightButton");
            date_picker = window.Get<WpfDatePicker>("DatePicker");
            morningbutton_1 = window.Get<RadioButton>("MorningButton1");
            morningbutton_2 = window.Get<RadioButton>("MorningButton2");
            morningbutton_3 = window.Get<RadioButton>("MorningButton3");
            morningbutton_4 = window.Get<RadioButton>("MorningButton4");
            morningbutton_5 = window.Get<RadioButton>("MorningButton5");
            morningbutton_6 = window.Get<RadioButton>("MorningButton6");
            morningbutton_7 = window.Get<RadioButton>("MorningButton7");
            morningbutton_8 = window.Get<RadioButton>("MorningButton8");
            morningbutton_9 = window.Get<RadioButton>("MorningButton9");
            morningbutton_10 = window.Get<RadioButton>("MorningButton10");
            daybutton_1 = window.Get<RadioButton>("DayButton1");
            daybutton_2 = window.Get<RadioButton>("DayButton2");
            daybutton_3 = window.Get<RadioButton>("DayButton3");
            daybutton_4 = window.Get<RadioButton>("DayButton4");
            daybutton_5 = window.Get<RadioButton>("DayButton5");
            daybutton_6 = window.Get<RadioButton>("DayButton6");
            daybutton_7 = window.Get<RadioButton>("DayButton7");
            daybutton_8 = window.Get<RadioButton>("DayButton8");
            daybutton_9 = window.Get<RadioButton>("DayButton9");
            daybutton_10 = window.Get<RadioButton>("DayButton10");
            submit_button = window.Get<Button>("Submit");
        }

        // As a user
        void GivenTheMainWindowIsOpen()
        {
            Assert.IsTrue(window.IsFocussed);
        }

        void WhenHoursComboBoxValueIsSelected()
        {
            // Test that the value has been selected?
        }

        void WhenMinutesComboBoxValueIsSelected()
        {
            // Test that the value has been selected?
        }

        void WhenLastNightButtonIsSelected()
        {
            // Test that the data and date are stored?
        }

        void WhenDatePickerDateIsSelected()
        {
            // Test that the data and date are stored?
        }

        void WhenMorningRadioButtonSelected()
        {
            // Test that only one button is selected
            // Test that the data is stored?
        }

        void WhenDayRadioButtonSelected()
        {
            // Test that only one button is selected
            // Test that the data is stored?
        }

        void WhenSubmitButtonIsSelected()
        {
            // Test that data is submitted?
        }

        void WhenSleepDataTabIsSelected()
        {
            // Test that the view has changed
        }

        [TestMethod]
        public void ExecuteStoryTest()
        {
            this.BDDfy();
        }

        [ClassCleanup]
        public static void TearDown()
        {
            window.Close();
            application.Close();
        }
    }
}
