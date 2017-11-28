﻿using EAStyles.Utility.Element;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EAStyles.Controls.MiStyle
{
    public class MiTabItem : TabItem
    {
        public static readonly DependencyProperty IconProperty = ElementBase.Property<MiTabItem, ImageSource>("IconProperty", null);
        public static readonly DependencyProperty IconMoveProperty = ElementBase.Property<MiTabItem, ImageSource>("IconMoveProperty", null);
        public static readonly DependencyProperty TextHorizontalAlignmentProperty = ElementBase.Property<MiTabItem, HorizontalAlignment>("TextHorizontalAlignmentProperty", HorizontalAlignment.Right);

        public ImageSource Icon { get { return (ImageSource)GetValue(IconProperty); } set { SetValue(IconProperty, value); } }
        public ImageSource IconMove { get { return (ImageSource)GetValue(IconMoveProperty); } set { SetValue(IconMoveProperty, value); } }
        public HorizontalAlignment TextHorizontalAlignment { get { return (HorizontalAlignment)GetValue(TextHorizontalAlignmentProperty); } set { SetValue(TextHorizontalAlignmentProperty, value); } }

        static MiTabItem()
        {
            ElementBase.DefaultStyle<MiTabItem>(DefaultStyleKeyProperty);
        }
    }
}