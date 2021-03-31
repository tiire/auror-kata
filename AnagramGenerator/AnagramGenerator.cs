using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Generator
{
    public class AnagramGenerator
    {
        public IEnumerable<string> GetAnagrams(IEnumerable<string> wordList, string word)
        {
            string normalisedWord = word.ToLower().Trim();
            string sortedWord = String.Concat(normalisedWord.OrderBy(c => c));
            foreach (string w in wordList)
            {
                string normalisedDictWord = w.ToLower().Trim();
                if (normalisedDictWord != normalisedWord && String.Concat(normalisedDictWord.OrderBy(c => c)).ToLower() == sortedWord)
                {
                    yield return w;
                }
            }
        }

    }
}