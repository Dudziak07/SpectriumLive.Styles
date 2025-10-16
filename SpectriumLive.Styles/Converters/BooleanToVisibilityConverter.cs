﻿using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SpectriumLive.Styles.Converters;

[ValueConversion(typeof(bool), typeof(Visibility))]
public class BooleanToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => (value is bool b && b) ? Visibility.Visible : Visibility.Collapsed;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => value is Visibility v && v == Visibility.Visible;
}
