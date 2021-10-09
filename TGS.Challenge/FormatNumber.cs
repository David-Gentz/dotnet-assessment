using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        public string Format(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();

            if (value >= 1000000000)
                throw new ArgumentOutOfRangeException();

            var stringValue = value.ToString();
            var reversedValue = string.Empty;

            for (int i = stringValue.Length - 1; i >= 0; i--)
            {
                reversedValue += stringValue[i];
                var reversedNormalValue = reversedValue.Replace(",", string.Empty);

                if (reversedNormalValue.Length != stringValue.Length && reversedNormalValue.Length % 3 == 0)
                    reversedValue += ",";
            }

            string formattedValue = Reverse(reversedValue);

            return formattedValue;
        }

        public string Reverse(string value)
        {
            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
