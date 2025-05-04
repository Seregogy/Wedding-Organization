using System;
using Windows.UI.Xaml;

namespace Wedding_Organization.Helpers
{
    public static class StringToVisibilityConverter
    {
        public static Visibility ToVisibility(this string value)
        {
            if (value.Equals("Да", StringComparison.CurrentCultureIgnoreCase)) return Visibility.Visible;

            return Visibility.Collapsed;
        }
    }
}
