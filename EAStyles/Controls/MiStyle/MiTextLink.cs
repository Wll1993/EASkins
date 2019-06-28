using EAStyles.Utilitys;
using System;
using System.Windows;
using System.Windows.Controls;

namespace EAStyles.Controls.MiStyle
{
    public class MiTextLink : UserControl
    {
        //public static readonly DependencyProperty ContentProperty = ElementBase.Property<MiTextLink, string>("ContentProperty", "");
        //public string Content { get { return (string)GetValue(ContentProperty); } set { SetValue(ContentProperty, value); } }
        public MiTextLink()
        {
            ResourceDictionary styleRes = new ResourceDictionary();
            styleRes.Source = new Uri("/EAStyles;component/Themes/MiStyle/MiTextLink.xaml",
                    UriKind.RelativeOrAbsolute);
            Style textLinkStyle = styleRes["miTextLink"] as Style;
            this.SetValue(MiTextLink.StyleProperty, textLinkStyle);
            ControlUtility.Refresh(this);
        }
    }
}
