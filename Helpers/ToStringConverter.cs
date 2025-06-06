﻿using System;
using Windows.UI.Xaml.Data;

namespace WeddingOrganization.Helpers
{
    public class ToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return "empty";
        }
    }
}
