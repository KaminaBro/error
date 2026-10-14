using MyAvaloniaApp.Data.Converters;
using Avalonia.Media.Imaging;
using System;
using System.Globalization;
using System.IO;

namespace MyAvaloniaApp.Converters
{
    public class PathToBitmapConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object parametr, CultureInfo culture)
        {
            if(value is string path && File.Exists(Environment.CurrentDirectory + "\\bin\\Image\\Import" + path))
            {
                return new Bitmap(Enviroment.CurrentDirectory+"\\bin\\Images\\Import");

            }
            return new Bitmap(Environment.CurrentDirectory+"\\Images\\Import\\picture.png");
        }
    
    public object? ConvertBack(object? value, Type targetType, object parametr, CultureInfo culture)
    {
        throw new NotImplementedException();

    }
    }
}