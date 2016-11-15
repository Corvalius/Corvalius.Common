﻿using System;
using System.Windows;
using System.Windows.Data;

namespace Corvalius.Converters
{
    public sealed class BoolToVisibilityConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is bool)
            {
                return ((bool)value) ? (Visibility.Visible) : (Visibility.Collapsed);
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Visibility)
            {
                return ((Visibility)value == Visibility.Visible) ? true : false;
            }
            else
            {
                return false;
            }
        }

        #endregion IValueConverter Members
    }
}