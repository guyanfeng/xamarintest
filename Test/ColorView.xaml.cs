using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Test
{
    public partial class ColorView : ContentView
    {
        static ColorTypeConverter _converter = new ColorTypeConverter();

        public ColorView()
        {
            InitializeComponent();
        }

        protected string _color_name;

        public string ColorName
        {
            get
            {
                return _color_name;
            }
            set
            {
                var clr = (Color)_converter.ConvertFrom(value);
                lblColorName.Text = value;
                lblColorValue.Text = string.Format("{0:X2}-{1:X2}-{2:X2}",
                    (int)(clr.R * 255),
                    (int)(clr.G * 255),
                    (int)(clr.B * 255));
                box.Color = clr;
            }
        }
    }
}

