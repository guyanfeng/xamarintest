using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test
{
    public partial class DynamicSourcePage : ContentPage
    {
        public DynamicSourcePage()
        {
            InitializeComponent();

            Resources = new ResourceDictionary();
            Resources.Add("currentTime", "this is not a time string");

            var pal = new StackLayout();

            var lbl = new Label();

            lbl.SetDynamicResource(Label.TextProperty, "currentTime");
            lbl.HorizontalOptions = LayoutOptions.Center;
            lbl.VerticalOptions = LayoutOptions.Center;
            pal.Children.Add(lbl);

            Content = pal;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    Resources["currentTime"] = DateTime.Now.ToString("T");
                    return true;
                });
        }
    }
}

