using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class PlatformBitmapPage : ContentPage
    {
        public PlatformBitmapPage()
        {
            InitializeComponent();
            img.Source = ImageSource.FromFile(
                Device.OnPlatform<string>("ios.png"
                , "icon.png", "Asserts/appicon.png"));
            img.SizeChanged += img_SizeChanged;
        }

        void img_SizeChanged(object sender, EventArgs e)
        {
            lbl.Text = string.Format("Rendered size = {0} * {1}", img.Width, img.Height);
        }
    }
}
