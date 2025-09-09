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
            }
        }
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            if (s.Length == 1) return 1;

            // TODO: refatorar o mySolution utilizando o conceito de janela deslizante (sliding window)'
            return 0;
        }
    }
}
