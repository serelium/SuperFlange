using SuperFlange.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SuperFlange.Converters
{
    public class TypeToStringTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is Type type)
            {
                if (type == typeof(float) || type == typeof(double) || type == typeof(decimal))
                    return StringType.Decimal;

                if (type == typeof(int) || type == typeof(long) || type == typeof(ulong))
                    return StringType.Numerical;
            }

            return StringType.All;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
