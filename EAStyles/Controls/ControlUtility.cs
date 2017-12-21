using EAStyles.Controls.MiStyle;
using System.ComponentModel;
using System.Windows;

namespace EAStyles.Controls
{
    public class ControlUtility
    {
        /// <summary>
        /// 刷新样式
        /// </summary>
        /// <param name="control"></param>
        public static void Refresh(FrameworkElement control)
        {
            if (control == null)
            {
                return;
            }
            //正在运行的状态
            if (!DesignerProperties.GetIsInDesignMode(control))
            {
                if (control.IsLoaded)
                {
                    SetColor(control);
                }
                else
                {
                    control.Loaded += delegate { SetColor(control); };
                }
            }
        }

        static void SetColor(FrameworkElement control)
        {
            Window mw = Window.GetWindow(control) is MiWindow ? Window.GetWindow(control) as MiWindow : null;
            if (mw != null)
            {
                if (control is MiTabControl)
                {
                    (control as MiTabControl).BorderBrush = mw.BorderBrush.Clone();
                }
                if (control is MiTabItem)
                {
                    (control as MiTabItem).Background = mw.BorderBrush.Clone();
                }
                if (control is MiButton)
                {
                    (control as MiButton).Background = mw.BorderBrush.Clone();
                }
                if (control is MiToggleButton)
                {
                    (control as MiToggleButton).Background = mw.BorderBrush.Clone();
                }
                //if (control is DMTitleMenu)
                //{
                //    (control as DMTitleMenu).Background = mw.BorderBrush;
                //}
                //if (control is DMTitleMenuItem)
                //{
                //    (control as DMTitleMenuItem).Background = mw.BorderBrush;
                //}
                //if (control is DMMenuItem)
                //{
                //    (control as DMMenuItem).Background = mw.BorderBrush;
                //}
                //if (control is DMContextMenu)
                //{
                //    (control as DMContextMenu).Background = mw.BorderBrush;
                //}
                //if (control is DMTextBox)
                //{
                //    (control as DMTextBox).BorderBrush = mw.BorderBrush;
                //}
                //if (control is DMButton)
                //{
                //    (control as DMButton).Background = mw.BorderBrush;
                //}
                //if (control is DMMenuTabControl)
                //{
                //    (control as DMMenuTabControl).BorderBrush = mw.BorderBrush;
                //}
                //if (control is DMRichTextBox)
                //{
                //    (control as DMRichTextBox).MouseMoveThemeBorderBrush = mw.BorderBrush;
                //}
                //if (control is DMCanvasGrid)
                //{
                //    if ((control as DMCanvasGrid).IsApplyTheme)
                //        (control as DMCanvasGrid).Background = new RgbaColor(mw.BorderBrush).OpaqueSolidColorBrush;
                //}
                //if (control is DMColorPicker)
                //{
                //    (control as DMColorPicker).BorderBrush = mw.BorderBrush;
                //}
            }
        }
    }
}