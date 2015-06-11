using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class WebBitmapPage : ContentPage
    {
        public WebBitmapPage()
        {
            InitializeComponent();
        }

        void OnBtnClicked(object sender, EventArgs e)
        {
            //DisplayAlert("info", string.Format("w:{0},h:{1}", img.Width, img.Height), "OK");
        }
    }
}
