using System.Linq;
using System.Text;

namespace Wedding_Organization.Helpers
{
    public static class NumberDigitsSplitter
    {
        public static string SplitDigits(this int value, int groupSize = 3)
        {
            var strValue = value.ToString();
            var stringBuilder = new StringBuilder();
            
            int index = 0;
            while (value > 0)
            {
                if (index != 0 && index % 3 == 0)
                    stringBuilder.Append(" ");

                stringBuilder.Append(value % 10);
                value /= 10;
                
                index++;
            }

            return string.Join("", stringBuilder.ToString().Reverse());
        }
    }
}