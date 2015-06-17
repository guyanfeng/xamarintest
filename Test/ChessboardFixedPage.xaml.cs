using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class ChessboardFixedPage : ContentPage
    {
        int squ_size = 35;
        public ChessboardFixedPage()
        {
            InitializeComponent();
            var layout = new AbsoluteLayout
            {
                BackgroundColor = Color.FromRgb(240, 220, 130),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (((i ^ j) & 1) == 0)
                        continue;
                    var box = new BoxView
                    {
                        Color = Color.FromRgb(0, 64, 0)
                    };
                    var rect = new Rectangle(i * squ_size, j * squ_size, squ_size, squ_size);
                    layout.Children.Add(box, rect);
                }
            }
            Content = layout;
        }
    }
}
