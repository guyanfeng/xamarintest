using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class RgbSliderPage : ContentPage
    {
        public RgbSliderPage()
        {
            InitializeComponent();
            OnSliderValueChanged(null, null);
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            var sli = (Slider)sender;
            if (sli == sr)
            {
                lr.Text = string.Format("R = {0:X2}", (int)e.NewValue);
            }
            else if (sli == sg)
            {
                lg.Text = string.Format("G = {0:X2}", (int)e.NewValue);
            }
            else if (sli == sb)
            {
                lb.Text = string.Format("B = {0:X2}", (int)e.NewValue);
            }
            var clr = Color.FromRgb((int)sr.Value, (int)sg.Value, (int)sb.Value);
            box.Color = clr;
        }
    }
}
