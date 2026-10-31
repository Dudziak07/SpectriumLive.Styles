using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace SpectriumLive.Styles.Converters;

public class MenuArrowVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
        value is MenuItem { Parent: not Menu, HasItems: true } ? Visibility.Visible : Visibility.Collapsed;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotImplementedException();
}
