using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Properties.ContainsKey("ResultText"))
            {
                ResultText = Convert.ToString(Properties["ResultText"]);
            }

            MainPage = new DynamicStylePage();
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
