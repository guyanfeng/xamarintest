using System;
using Xamarin.Forms;

namespace Test
{
    /// <summary>
    /// 可以设置 FontSize 为 Point
    /// </summary>
    public class AltLabel : Label
    {
        public static readonly BindableProperty PointFontSizeProperty = BindableProperty.Create("PointFontSize",
                                                                            typeof(double), typeof(AltLabel), 8.0,
                                                                            BindingMode.OneWay, null, OnPointFontSizeChanged);

        public double PointFontSize
        {
            get { return (double)GetValue(PointFontSizeProperty); }
            set { SetValue(PointFontSizeProperty, value); }
        }

        static void OnPointFontSizeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var lbl = (AltLabel)bindable;
            lbl.OnPointFontSizeChanged((double)oldValue, (double)newValue);
        }

        void OnPointFontSizeChanged(double old_value, double new_value)
        {
            set_point_size(new_value);
        }

        void set_point_size(double point)
        {
            FontSize = Device.OnPlatform(160, 160, 240) * point / 72;
        }
    }
}

