using System;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
                throw new ArgumentException();

            word1 = Regex.Replace(word1, @"[^0-9a-zA-Z]+", "");
            word2 = Regex.Replace(word2, @"[^0-9a-zA-Z]+", "");

            var word1CharArray = word1.Trim().ToLower().ToCharArray();
            var word2CharArray = word2.Trim().ToLower().ToCharArray();

            Array.Sort(word1CharArray);
            Array.Sort(word2CharArray);

            for (int i = 0; i < word1CharArray.Length; i++)
            {
                if (word1CharArray[i] != word2CharArray[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
