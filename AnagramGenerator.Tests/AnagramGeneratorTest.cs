using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AnagramGenerator.Tests
{
    public class AnagramGeneratorTest
    {
        [Fact]
        public void TestWithPredefinedWords()
        {
            var anagramGenerator = new Anagram.Generator.AnagramGenerator();
            List<string> words = new string[] { "hello", "olleh", "someotherword", "lleho", "ok" }.ToList();
            IEnumerable<string> anagrams = anagramGenerator.GetAnagrams(words, "llohe");
            List<string> anagramsList = anagrams.ToList();
            anagramsList.Sort();
            List<string> expected = new string[] { "hello", "lleho", "olleh" }.ToList();
            Assert.Equal(expected, anagramsList);
        }
        [Fact]
        public void TestDifferentArrangement()
        {
            var anagramGenerator = new Anagram.Generator.AnagramGenerator();
            List<string> words = new string[] { "hello", "olleh", "someotherword", "lleho", "ok" }.ToList();
            IEnumerable<string> anagrams = anagramGenerator.GetAnagrams(words, "lleho");
            List<string> anagramsList = anagrams.ToList();
            anagramsList.Sort();
            List<string> expected = new string[] { "hello", "olleh" }.ToList();
            Assert.Equal(expected, anagramsList);
        }

        [Fact]

        public void TestCaseInsensitive()
        {
            var anagramGenerator = new Anagram.Generator.AnagramGenerator();
            List<string> words = new string[] { "hello", "OLleh", "someotherword", "lleho", "ok" }.ToList();
            IEnumerable<string> anagrams = anagramGenerator.GetAnagrams(words, "Lleho");
            List<string> anagramsList = anagrams.ToList();
            anagramsList.Sort();
            List<string> expected = new string[] { "hello", "OLleh" }.ToList();
            Assert.Equal(expected, anagramsList);
        }

        [Fact]

        public void TestSpaceRemoval()
        {
            //probably too much as we assume dictionary is correct and clean and command line arguments should be trimmed
            var anagramGenerator = new Anagram.Generator.AnagramGenerator();
            List<string> words = new string[] { " hello", "OLleh ", "someotherword", "lleho", "ok" }.ToList();
            IEnumerable<string> anagrams = anagramGenerator.GetAnagrams(words, " Lleho ");
            List<string> anagramsList = anagrams.ToList();
            anagramsList.Sort();
            List<string> expected = new string[] { " hello", "OLleh " }.ToList();
            Assert.Equal(expected, anagramsList);
        }
    }
}
