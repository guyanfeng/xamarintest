using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Reflection;

namespace Test
{
    public partial class ColorBlockPage : ContentPage
    {
        public ColorBlockPage()
        {
            InitializeComponent();
            foreach (var field in typeof(Color).GetRuntimeFields())
            {
                if (field.IsStatic && field.IsPublic && field.FieldType == typeof(Color))
                {
                    pal.Children.Add(create_frame((Color)field.GetValue(null), field.Name));
                }
            }
        }

        /// <summary>
        /// 创建一个颜色块
        /// </summary>
        /// <returns>Frame 对象</returns>
        /// <param name="clr">颜色.</param>
        /// <param name="name">颜色名称.</param>
        Frame create_frame(Color clr, string name)
        {
            return new Frame()
            {
                OutlineColor = Color.Accent,
                Padding = new Thickness(5),
                Content = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 15,
                    Children =
                    {
                        new BoxView()
                        {
                            Color = clr
                        },
                        new Label()
                        {
                            Text = name,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            FontAttributes = FontAttributes.Bold,
                            HorizontalOptions = LayoutOptions.StartAndExpand,
                            VerticalOptions = LayoutOptions.Center,
                        },
                        new StackLayout()
                        {
                            HorizontalOptions = LayoutOptions.Start,
                            Children =
                            {
                                new Label()
                                {
                                    Text = string.Format("{0:X2}-{1:X2}-{2:X2}",
                                        (int)(255 * clr.R), (int)(255 * clr.G), (int)(255 * clr.B)),
                                },
                                new Label()
                                {
                                    Text = string.Format("{0:F2},{1:F2},{2:F2}",
                                        clr.Hue, clr.Saturation, clr.Luminosity
                                    )
                                }
                            }    
                        }
                    }
                }
            };
        }
    }
}

