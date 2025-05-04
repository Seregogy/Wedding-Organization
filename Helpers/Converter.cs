using System;
using Windows.UI.Xaml;

namespace WeddingOrganization.Helpers
{
    public static class Converter
    {
        public static Visibility ToVisibility(this string value)
        {
            if (value.Equals("Да", StringComparison.CurrentCultureIgnoreCase)) return Visibility.Visible;

            return Visibility.Collapsed;
        }

        public static bool ToBoolean(this Visibility value) =>
            value is Visibility.Visible;
    }
}
