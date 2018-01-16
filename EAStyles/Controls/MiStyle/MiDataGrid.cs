using EAStyles.Utilitys;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EAStyles.Controls.MiStyle
{
    //public class MiDataGrid : DataGrid
    //{
    //    static MiDataGrid()
    //    {
    //        ElementBase.DefaultStyle<MiDataGrid>(DefaultStyleKeyProperty);
    //    }
    //}
    public class MiDataGrid : DataGrid
    {
        public static readonly DependencyProperty FloatProperty = ElementBase.Property<MiDataGrid, bool>("FloatProperty");
        public static readonly DependencyProperty AutoLimitMouseProperty = ElementBase.Property<MiDataGrid, bool>("AutoLimitMouseProperty");
        public static readonly DependencyProperty VerticalMarginProperty = ElementBase.Property<MiDataGrid, Thickness>("VerticalMarginProperty");
        public static readonly DependencyProperty HorizontalMarginProperty = ElementBase.Property<MiDataGrid, Thickness>("HorizontalMarginProperty");

        public bool Float { get { return (bool)GetValue(FloatProperty); } set { SetValue(FloatProperty, value); } }
        public bool AutoLimitMouse { get { return (bool)GetValue(AutoLimitMouseProperty); } set { SetValue(AutoLimitMouseProperty, value); } }
        public Thickness VerticalMargin { get { return (Thickness)GetValue(VerticalMarginProperty); } set { SetValue(VerticalMarginProperty, value); } }
        public Thickness HorizontalMargin { get { return (Thickness)GetValue(HorizontalMarginProperty); } set { SetValue(HorizontalMarginProperty, value); } }

        /// <summary>
        /// Initializes a new instance of the MetroDataGrid class.
        /// </summary>
        public MiDataGrid() : base()
        {
            DefaultStyleKey = typeof(MiDataGrid);
        }

        /// <summary>
        /// Invoked whenever application code or internal processes call ApplyTemplate.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }
}
