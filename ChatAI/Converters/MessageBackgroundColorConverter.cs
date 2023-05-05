using System.Globalization;

namespace ChatAI.Converters;

public class MessageBackgroundColorConverter : IValueConverter
{
    [Obsolete]
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (!(value is bool isIncoming))
            return Color.FromHex("#CBDCCB");

        return isIncoming ? Color.FromHex("#D3D3D3") : Color.FromHex("#007AFF");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
