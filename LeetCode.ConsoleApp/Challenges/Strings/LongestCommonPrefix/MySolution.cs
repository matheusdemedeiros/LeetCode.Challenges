namespace LeetCode.ConsoleApp.Challenges.Strings.LongestCommonPrefix
{
    public class MySolution
    {
        public MySolution(string[] input)
        {
            Input = input;
        }

        public string[] Input { get; }

        public string Run()
        {
            var firstString = Input[0];
            var prefix = firstString;
            var maxPrefix = string.Empty;
            var continueTesting = true;

            if (Input.Length == 1)
            {
                return firstString;
            }

            if (firstString == string.Empty)
            {
                return "";
            }

            while (continueTesting == true)
            {
                var containsPrefix = false;
                for (int i = 1; i < Input.Length; i++)
                {
                    var currentString = Input[i];
                    containsPrefix = currentString.StartsWith(prefix);

                    if (!containsPrefix)
                    {
                        break;
                    }
                }

                if (containsPrefix == true)
                {
                    maxPrefix = maxPrefix.Length > prefix.Length ? maxPrefix : prefix;
                }

                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix.Length == 0 || (maxPrefix != string.Empty && prefix.Length < maxPrefix.Length))
                {
                    continueTesting = false;
                }
            }

            return maxPrefix;
        }

    }
}
