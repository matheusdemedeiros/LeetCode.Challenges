using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.Strings.LongestSubstringWithoutRepeatingCharacters
{
    [MemoryDiagnoser]
    public class Challenge
    {
        public List<string> Inputs { get; set; }
        public Challenge()
        {
            Inputs = new List<string>
            {
                "dvdf",       // esperado: 3 ("vdf") - 
                "abba",       // esperado: 2 ("ab" ou "ba") -
                "tmmzuxt",    // esperado: 5 ("mzuxt") - 
                "p@ssw0rd!",  // esperado: 6 ("sw0rd!") - 
                "abcdeafghij",// esperado: 10 ("bcdeafghij") - 
                "anviaj",      // esperado: 5 ("nviaj") - 
                "abcabcbb",   // esperado: 3 ("abc")
                "bbbbb",      // esperado: 1 ("b")
                "",           // esperado: 0
                "a",          // esperado: 1 ("a")
                "au",         // esperado: 2 ("au")
                "aab",        // esperado: 2 ("ab")
                "  ",         // esperado: 1 (" ")
                "abcdefg",    // esperado: 7 ("abcdefg")
            };
        }

        [Benchmark]
        public void RunMy()
        {
            var solution = new MySolution(Inputs);
            solution.Run();
        }

        [Benchmark]
        public void RunBest()
        {
            var solution = new BestSolution(Inputs);
            solution.Run();
        }
    }
}
