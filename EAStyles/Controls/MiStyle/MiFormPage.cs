using EAStyles.Utilitys.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace EAStyles.Controls.MiStyle
{
    class MiFormPage : Page
    {
        public static readonly DependencyProperty FormContentProperty = 
            ElementBase.Property<MiFormPage, Form>("FormContentProperty", null);
        public Form FormContent
        {
            get
            {
                return (Form)GetValue(FormContentProperty);
            }
            set
            {
                SetValue(FormContentProperty, value);
            }
        }
    }
}
