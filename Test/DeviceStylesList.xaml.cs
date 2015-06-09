using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Test
{
    public partial class DeviceStylesList : ContentPage
    {
        public DeviceStylesList()
        {
            InitializeComponent();

            var styles = new[]{
                new {style=(Style)null, name="No Style whatsoever"},
                new {style=Device.Styles.BodyStyle, name="Body Style"},
                new {style=Device.Styles.TitleStyle, name="Title Style"},
                new {style=Device.Styles.SubtitleStyle, name="Subtitle Style"},
                new 
                {style = new Style(typeof(Label))
                    {
                        BaseResourceKey = Device.Styles.SubtitleStyleKey,
                        Setters = 
                        {
                            new Setter()
                            {
                                Property = Label.TextColorProperty,
                                Value = Color.Accent
                            },
                            new Setter()
                            {
                                Property = Label.FontAttributesProperty,
                                Value = FontAttributes.Italic
                            }
                        }
                    },name="newSubtitle Style"
                },
                new {style=Device.Styles.CaptionStyle, name="Caption Style"},
                new {style=Device.Styles.ListItemTextStyle, name="ListItemText Style"},
                new {style=Device.Styles.ListItemDetailTextStyle, name="ListItemDetailText Style"}
            };
            foreach (var style in styles)
            {
                pal.Children.Add(new Label
                    {
                        Text = style.name,
                        Style = style.style
                    });
            }
        }
    }
}
