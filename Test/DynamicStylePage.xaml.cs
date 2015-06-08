using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class DynamicStylePage : ContentPage
    {
        public DynamicStylePage()
        {
            InitializeComponent();
        }

        void OnBtn1Clicked(object sender, EventArgs e)
        {
            Resources["buttonStyle"] = Resources["buttonStyle1"];
        }

        void OnBtn2Clicked(object sender, EventArgs e)
        {
            Resources["buttonStyle"] = Resources["buttonStyle2"];
        }

        void OnBtn3Clicked(object sender, EventArgs e)
        {
            Resources["buttonStyle"] = Resources["buttonStyle3"];
        }
    }
}
