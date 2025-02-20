﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExCommonControlsCore.ExControls
{
    public enum EnumTabControlType
    {
        Line,
        Card,
    }
    public class ExTabControl : TabControl
    {
        #region Private属性

        #endregion

        #region 依赖属性定义
        public static readonly DependencyProperty TypeProperty;
        #endregion

        #region 依赖属性set get
        public EnumTabControlType Type
        {
            get { return (EnumTabControlType)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        public object HeaderContent
        {
            get { return (object)GetValue(HeaderContentProperty); }
            set { SetValue(HeaderContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderContentProperty =
            DependencyProperty.Register("HeaderContent", typeof(object), typeof(ExTabControl));


        #endregion

        #region Constructors
        static ExTabControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExTabControl), new FrameworkPropertyMetadata(typeof(ExTabControl)));
            ExTabControl.TypeProperty = DependencyProperty.Register("Type", typeof(EnumTabControlType), typeof(ExTabControl), new PropertyMetadata(EnumTabControlType.Line));
        }
        #endregion

        #region Override方法
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TabItem();
        }
        #endregion

        #region Private方法

        #endregion



        public Brush HeaderPanelBackground
        {
            get { return (Brush)GetValue(HeaderPanelBackgroundProperty); }
            set { SetValue(HeaderPanelBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderPanelBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderPanelBackgroundProperty =
            DependencyProperty.Register("HeaderPanelBackground", typeof(Brush), typeof(ExTabControl), new PropertyMetadata(Brushes.LightCoral));


    }
}
