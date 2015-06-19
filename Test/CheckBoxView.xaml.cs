using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class CheckBoxView : ContentView
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create<CheckBoxView, string>(
            p => p.Text, null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                var box = (CheckBoxView)bindable;
                box.lblText.Text = newValue;
            });

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create<CheckBoxView, double>(
            p => p.FontSize, Device.GetNamedSize(NamedSize.Default, typeof(Label)), propertyChanged: (bindable, oldValue, newValue) =>
            {
                var box = (CheckBoxView)bindable;
                box.lblText.FontSize = newValue;
                box.lblBox.FontSize = newValue;
            });
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create<CheckBoxView, bool>(
            p => p.IsChecked, false, propertyChanged: (bindable, oldValue, newValue) =>
            {
                var box = (CheckBoxView)bindable;
                box.lblBox.Text = newValue ? "\u2611" : "\u2610";
                if (box.CheckChanged != null)
                {
                    box.CheckChanged(box, newValue);
                }
            });

        public event EventHandler<bool> CheckChanged;

        public string Text
        {
            get{return (string)GetValue(TextProperty);}
            set{SetValue(TextProperty, value);}
        }
        [TypeConverter(typeof(FontSizeConverter))]
        public double FontSize
        {
            get{return (double)GetValue(FontSizeProperty);}
            set{SetValue(FontSizeProperty, value);}
        }
        public bool IsChecked
        {
            get{return (bool)GetValue(IsCheckedProperty);}
            set{SetValue(IsCheckedProperty, value);}
        }
        public CheckBoxView()
        {
            InitializeComponent();
        }

        void OnCheckBoxTapped(object sender, EventArgs e)
        {
            IsChecked = !IsChecked;
        }
    }
}
