using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException();

            int totalVowels = 0;
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

            for(int i = 0; i < value.Length; i++)
            {
                if (vowels.Contains(value.ToLower()[i]))
                    totalVowels++;
            }

            return totalVowels;
        }
    }
}
