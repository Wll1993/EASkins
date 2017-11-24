using System.Windows;
using System.Windows.Media;

namespace EAWpfSkins.Themes
{
    public class Theme
    {
        public static void Switch(Visual pVisual)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(pVisual); i++)
            {
                Visual childVisual = (Visual)VisualTreeHelper.GetChild(pVisual, i);
                if (childVisual != null)
                {
                    Controls.Utility.Refresh(childVisual as FrameworkElement);
                    Switch(childVisual);
                }
            }
        }
    }
}
