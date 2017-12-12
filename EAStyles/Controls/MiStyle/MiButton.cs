using EAStyles.Utilitys.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EAStyles.Controls.MiStyle
{
    public class MiButton : Button
    {
        public MiButton()
        {
            Controls.ControlUtility.Refresh(this);
        }

        static MiButton()
        {
            ElementBase.DefaultStyle<MiButton>(DefaultStyleKeyProperty);
        }
    }
}
