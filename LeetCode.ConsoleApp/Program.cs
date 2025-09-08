namespace LeetCode.ConsoleApp
{
    public static class TextExtensions
    {
        public static bool IsDiferent(this string main, string secondary)
        {
            return !main.Equals(secondary);
        }

        public static bool IsDiferent(this char main, char secondary)
        {
            return !main.Equals(secondary);
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            var inputs = new[]
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


            for (int i = 0; i < inputs.Length; i++)
            {
                var input = inputs[i];
                var result = new Solution().LengthOfLongestSubstring(input);
                Console.WriteLine($"Input: {input}, Output: {result}");
            }

            Console.ReadLine();
        }

        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                if (string.IsNullOrEmpty(s)) return 0;

                if (s.Length == 1) return 1;

                var stringSequences = new Dictionary<int, (int last, int difference)>();
                var analizedChars = new HashSet<char>();

                int i = 0;
                int j = 0;
                while (i < s.Length)
                {
                    j = i + 1;
                    char principalChar = s[i];
                    analizedChars.Clear();
                    if (!analizedChars.Contains(principalChar))
                    {
                        analizedChars.Add(principalChar);
                    }

                    if (!stringSequences.ContainsKey(i))
                    {
                        stringSequences.Add(i, (i, 1));
                    }

                    while (j < s.Length && s[j].IsDiferent(principalChar))
                    {
                        var currentChar = s[j];
                        if (analizedChars.Contains(currentChar))
                        {
                            j++;
                            break;
                        }
                        var tuple = stringSequences[i];
                        tuple.last++;
                        tuple.difference = tuple.last - i + 1;
                        stringSequences[i] = tuple;
                        analizedChars.Add(currentChar);
                        j++;
                    }

                    i++;
                }

                return stringSequences.Max(x => x.Value.difference);
            }
        }
    }
}