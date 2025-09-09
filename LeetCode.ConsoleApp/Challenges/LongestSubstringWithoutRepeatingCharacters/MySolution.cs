using LeetCode.ConsoleApp.Extensions;

namespace LeetCode.ConsoleApp.Challenges.LongestSubstringWithoutRepeatingCharacters
{
    public class MySolution
    {
        public List<string> Inputs { get; set; }

        public MySolution(List<string> inputs)
        {
            Inputs = inputs;
        }

        public void Run()
        {
            for (int i = 0; i < Inputs.Count; i++)
            {
                var input = Inputs[i];
                var result = LengthOfLongestSubstring(input);
            }
        }

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
