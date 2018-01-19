using EAStyles.Utilitys;
using System;
using System.Windows;
using System.Windows.Controls;

namespace EAStyles.Controls.MiStyle
{
    public class MiEfficientDataGrid:DataGrid
    {
        public MiEfficientDataGrid()
        {            
            ResourceDictionary styleRes = new ResourceDictionary();
            styleRes.Source = new Uri("/EAStyles;component/Themes/MiStyle/MiEfficientDataGrid.xaml",
                    UriKind.RelativeOrAbsolute);
            System.Windows.Style dataGridStyle = styleRes["miEffiDataGrid"] as Style;
            this.SetValue(MiEfficientDataGrid.StyleProperty, dataGridStyle);

            ControlUtility.Refresh(this);
        }
    }
}
