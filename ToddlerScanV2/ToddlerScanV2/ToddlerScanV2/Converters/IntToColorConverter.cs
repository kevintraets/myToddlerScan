using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using ToddlerScanV2.Constants;

namespace ToddlerScanV2.Converters
{
    public class IntToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                int grade = Int32.Parse(value.ToString());
                if (grade >= Constant.HighGrade)
                {
                    return Constant.HighGradeColor;
                }
                return Constant.LowGradeColor;
            }catch (Exception e)
            {
                return Constant.AlfaNumericColor;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
