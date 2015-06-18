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

            });
        
        public string Text { get; set; }
        [TypeConverter(typeof(FontSizeConverter))]
        public double FontSize { get; set; }
        public bool IsChecked { get; set; }
        public CheckBoxView()
        {
            InitializeComponent();
        }

        void OnCheckBoxTapped(object sender, EventArgs e)
        {
            
        }
    }
}
