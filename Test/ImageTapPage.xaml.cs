using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class ImageTapPage : ContentPage
    {
        public ImageTapPage()
        {
            InitializeComponent();
        }

        void OnImageTapped(object sender, EventArgs e)
        {
            var img = (Image)sender;
            img.Opacity = 0.75;
            Device.StartTimer(TimeSpan.FromMilliseconds(100)
                , () =>
                {
                    img.Opacity = 1;
                    return false;
                });
            lbl.Text = string.Format("Rendered size:{0} * {1}", img.Width, img.Height);
        }
    }
}
