using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Please, provide the word and path to the dictionary.");
                return;
            }
            string word = args[0];
            string dictionaryPath = args[1];
            if (!File.Exists(dictionaryPath))
            {
                Console.WriteLine("Dictionary path is not valid.");
                return;
            }
            var anagramGenerator = new Anagram.Generator.AnagramGenerator();
            IEnumerable<string> wordList = File.ReadLines(dictionaryPath);
            IEnumerable<string> anagrams = anagramGenerator.GetAnagrams(wordList, word);
            foreach (string anagram in anagrams)
            {
                Console.WriteLine(anagram);
            }
        }
    }
}
