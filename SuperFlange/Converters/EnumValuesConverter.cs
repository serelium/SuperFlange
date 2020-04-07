using SuperFlange.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SuperFlange.Converters
{
    public class EnumValuesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Type enumType = value as Type;
            List<string> enumValues = new List<string>();

            foreach(var enumValue in Enum.GetValues(enumType))
            {
                enumValues.Add(enumValue.ToString().SplitCamelCase());
            }

            return enumValues;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
