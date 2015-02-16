using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;

namespace TestGood_Night
{
    [TestClass]
    public class UITests
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;

        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\UnitTestProject1\\bin\\Debug\\Good_Night");
            application = Application.Launch(applicationPath);
            window = application.GetWindow(SearchCriteria.ByAutomationId("MainWindow"), InitializeOption.NoCache);

        }

        [TestMethod]
        public void TestZeroState()
        {
            Button home_button = window.Get<Button>("HomeButton");
            Button data_button = window.Get<Button>("DataButton");
            Button lastnight_button = window.Get<Button>("LastNightButton");
            WpfDatePicker date_picker = window.Get<WpfDatePicker>("DatePicker");

            RadioButton morningbutton_1 = window.Get<RadioButton>("MorningButton1");
            RadioButton morningbutton_2 = window.Get<RadioButton>("MorningButton2");
            RadioButton morningbutton_3 = window.Get<RadioButton>("MorningButton3");
            RadioButton morningbutton_4 = window.Get<RadioButton>("MorningButton4");
            RadioButton morningbutton_5 = window.Get<RadioButton>("MorningButton5");
            RadioButton morningbutton_6 = window.Get<RadioButton>("MorningButton6");
            RadioButton morningbutton_7 = window.Get<RadioButton>("MorningButton7");
            RadioButton morningbutton_8 = window.Get<RadioButton>("MorningButton8");
            RadioButton morningbutton_9 = window.Get<RadioButton>("MorningButton9");
            RadioButton morningbutton_10 = window.Get<RadioButton>("MorningButton10");

            RadioButton daybutton_1 = window.Get<RadioButton>("DayButton1");
            RadioButton daybutton_2 = window.Get<RadioButton>("DayButton2");
            RadioButton daybutton_3 = window.Get<RadioButton>("DayButton3");
            RadioButton daybutton_4 = window.Get<RadioButton>("DayButton4");
            RadioButton daybutton_5 = window.Get<RadioButton>("DayButton5");
            RadioButton daybutton_6 = window.Get<RadioButton>("DayButton6");
            RadioButton daybutton_7 = window.Get<RadioButton>("DayButton7");
            RadioButton daybutton_8 = window.Get<RadioButton>("DayButton8");
            RadioButton daybutton_9 = window.Get<RadioButton>("DayButton9");
            RadioButton daybutton_10 = window.Get<RadioButton>("DayButton10");

            Assert.IsTrue(home_button.Enabled);
            Assert.IsTrue(data_button.Enabled);
            Assert.IsTrue(lastnight_button.Enabled);
            Assert.IsTrue(date_picker.Enabled);
            Assert.IsTrue(morningbutton_1.Enabled);
            Assert.IsTrue(morningbutton_2.Enabled);
            Assert.IsTrue(morningbutton_3.Enabled);
            Assert.IsTrue(morningbutton_4.Enabled);
            Assert.IsTrue(morningbutton_5.Enabled);
            Assert.IsTrue(morningbutton_6.Enabled);
            Assert.IsTrue(morningbutton_7.Enabled);
            Assert.IsTrue(morningbutton_8.Enabled);
            Assert.IsTrue(morningbutton_9.Enabled);
            Assert.IsTrue(morningbutton_10.Enabled);
            Assert.IsTrue(daybutton_1.Enabled);
            Assert.IsTrue(daybutton_2.Enabled);
            Assert.IsTrue(daybutton_3.Enabled);
            Assert.IsTrue(daybutton_4.Enabled);
            Assert.IsTrue(daybutton_5.Enabled);
            Assert.IsTrue(daybutton_6.Enabled);
            Assert.IsTrue(daybutton_7.Enabled);
            Assert.IsTrue(daybutton_8.Enabled);
            Assert.IsTrue(daybutton_9.Enabled);
            Assert.IsTrue(daybutton_10.Enabled);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            window.Close();
            application.Close();
        }
    }
}
