using planetsInfo.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace planetsInfo.converters
{
    class FilterParamsCreator : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new FilterAstroParams_M()
            {
                from = values[0] != null && values[0] != DependencyProperty.UnsetValue ? (DateTime)(values[0]) : FilterAstroParams_M.DefaultFrom,
                until = values[1] != null && values[1] != DependencyProperty.UnsetValue ? (DateTime)(values[1]) : FilterAstroParams_M.DefaultUntil,
                min_diameter = values[2] != null && values[2] != DependencyProperty.UnsetValue ? float.Parse((string)values[2]) : FilterAstroParams_M.DefaultMinDiameter,
                max_diameter = values[3] != null && values[3] != DependencyProperty.UnsetValue ? float.Parse((string)values[3]) : FilterAstroParams_M.DefaultMaxDiameter,
                isDengarouse = values[4] != null && values[4] != DependencyProperty.UnsetValue ? (bool?)values[4] : FilterAstroParams_M.DefaultIsDengarous
            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
