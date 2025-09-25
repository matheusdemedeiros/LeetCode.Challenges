namespace LeetCode.ConsoleApp.Challenges.LongestCommonPrefix
{
    public class MySolution2
    {
        public MySolution2(string[] input)
        {
            Input = input;
        }

        public string[] Input { get; }

        public string Run()
        {
            if (Input.Length == 1)
            {
                return Input[0];
            }

            if (Input.Any(text => text.Equals(string.Empty)))
            {
                return "";
            }

            string prefix = Input[0], originalPrefix = Input[0];
            var maxPrefix = string.Empty;
            var continueTesting = true;
            var count = 0;

            while (continueTesting == true)
            {
                if (count == originalPrefix.Length)
                {
                    break;
                }
                count++;

                prefix = originalPrefix.Substring(0, count);
                var containsPrefix = false;
                foreach (var str in Input)
                {
                    if (!str.StartsWith(prefix))
                    {
                        containsPrefix = false;
                        continueTesting = false;
                        break;
                    }
                    containsPrefix = true;
                }

                if (containsPrefix == true)
                {
                    maxPrefix = prefix;
                }
            }

            return maxPrefix;
        }

    }
}
