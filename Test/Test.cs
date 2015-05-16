using System;

using Xamarin.Forms;

namespace Test
{
    public class App : Application
    {
        public App()
        {
            if (Properties.ContainsKey("ResultText"))
            {
                ResultText = Convert.ToString(Properties["ResultText"]);
            }

            MainPage = new MonkeyTapWithSound();
        }

        public string ResultText
        {
            get;
            set;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            Properties["ResultText"] = ResultText;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

