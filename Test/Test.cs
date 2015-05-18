using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

            MainPage = new ClassHierarchyPage();
        }

        public string ResultText
        {
            get;
            set;
        }

        protected override void OnStart()
        {
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

