using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test
{
    public partial class GetResourceList : ContentPage
    {
        public GetResourceList()
        {
            InitializeComponent();
            var asm = GetType().GetTypeInfo().Assembly;
            var res_list = asm.GetManifestResourceNames();
            foreach (var res in res_list)
            {
                var frame = new Frame
                {
                    OutlineColor = Color.Accent,
                    Padding = new Thickness(10),
                    Content = new Label
                    {
                        Text = res,
                    }
                };
                pal.Children.Add(frame);
            }
        }
    }
}
