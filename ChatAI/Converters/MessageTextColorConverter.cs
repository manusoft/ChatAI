using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAI.Converters;

public class MessageTextColorConverter : IValueConverter
{
    [Obsolete]
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (!(value is bool isIncoming))
            return Color.FromHex("#000000");

        return isIncoming ? Color.FromHex("#000000") : Color.FromHex("#FFFFFF");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
