namespace LeetCode.ConsoleApp.Challenges.LongestCommonPrefix
{
    public class BestSolution
    {
        public string[] Input { get; }
        
        public BestSolution(string[] input)
        {
            Input = input;
        }

        public string Run() {
            if (Input == null || Input.Length == 0)
                return "";

            string prefix = Input[0];

            for (int i = 1; i < Input.Length; i++)
            {
                while (!Input[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") return "";
                }
            }

            return prefix;
        }
    }
}
