using System.Globalization;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace SpectriumLive.Styles.Converters;
public class MenuPlacementConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var menuItem = value as MenuItem;
        if( menuItem == null )
            return PlacementMode.Bottom;
        if( menuItem.Parent is Menu )
            return PlacementMode.Bottom;

        return PlacementMode.Right;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}

