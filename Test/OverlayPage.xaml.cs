using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class OverlayPage : ContentPage
    {
        public OverlayPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            var time = DateTime.Now;
            var duration = TimeSpan.FromSeconds(5);
            Device.StartTimer(TimeSpan.FromSeconds(0.1), () =>
                {
                    overlay.IsVisible = true;
                    var progress = (DateTime.Now - time).TotalMilliseconds / duration.TotalMilliseconds;
                    prg.Progress = progress;
                    var cont = progress < 1;
                    if (!cont)
                        overlay.IsVisible = false;
                    return cont;
                });
        }
    }
}
