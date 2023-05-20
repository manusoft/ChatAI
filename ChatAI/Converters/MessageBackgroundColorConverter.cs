using System.Globalization;

namespace ChatAI.Converters;

public class MessageBackgroundColorConverter : IValueConverter
{
    [Obsolete]
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (!(value is bool isIncoming))
            return Color.FromHex("#DBDFAA");

        return isIncoming ? Color.FromHex("#B3C890") : Color.FromHex("#DBDFAA");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
