namespace LeetCode.ConsoleApp.Challenges.LongestSubstringWithoutRepeatingCharacters
{
    public class BestSolution
    {
        public List<string> Inputs { get; set; }

        public BestSolution(List<string> inputs)
        {
            Inputs = inputs;
        }

        public void Run()
        {
            for (int i = 0; i < Inputs.Count; i++)
            {
                var input = Inputs[i];
                var result = LengthOfLongestSubstring(input);
                Console.WriteLine(result);
            }
        }

        public int LengthOfLongestSubstring(string s)
        {
            int left = 0;
            int right = 0;
            int maxLength = 0;
            HashSet<char> charSet = new();

            while (right < s.Length)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    right++;
                    maxLength = Math.Max(maxLength, right - left);
                }
                else
                {
                    charSet.Remove(s[left]);
                    left++;
                }
            }

            return maxLength;
        }
    }
}
