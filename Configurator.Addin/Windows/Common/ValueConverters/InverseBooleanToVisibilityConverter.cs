using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Configurator.Addin.Windows.Common.ValueConverters
{
    /// <summary>
    /// Returns Collapsed on true, Visible on false
    /// </summary>
    [ValueConversion(typeof(bool), typeof(Visibility))]
    internal class InverseBooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case null: throw new ArgumentNullException();
                case bool b: return b ? Visibility.Collapsed : Visibility.Visible;
                default: throw new ArgumentException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
