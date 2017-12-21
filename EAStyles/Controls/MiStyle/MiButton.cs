using EAStyles.Utilitys.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace EAStyles.Controls.MiStyle
{
    

    public class MiButton : ButtonBase
    {
        public static readonly DependencyProperty MiTitleButtonStyleProperty = ElementBase.Property<MiTitleButton, ButtonStyle>("MiTitleButtonStyleProperty", ButtonStyle.None);

        public ButtonStyle MiTitleButtonStyle { get { return (ButtonStyle)GetValue(MiTitleButtonStyleProperty); } set { SetValue(MiTitleButtonStyleProperty, value); } }

        public MiButton()
        {
            //EAStyles.Controls.ControlUtility.Refresh(this);
        }

        static MiButton()
        {
            //ElementBase.DefaultStyle<MiTitleButton>(DefaultStyleKeyProperty);
        }

        public enum ButtonStyle
        {
            None,
            StyleOne,
            StyleTwo
        }
    }
}
