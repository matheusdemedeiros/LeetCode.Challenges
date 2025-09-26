using System.Text;

namespace LeetCode.ConsoleApp.Challenges.Hashtables.LetterCombinationsOfPhoneNumber
{
    public class MySolution
    {
        public string Input { get; set; }

        public MySolution(string input)
        {
            Input = input;
        }

        public List<string> Run()
        {
            var digits = Input;
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>() { };
            }

            var keyMap = new Dictionary<string, List<string>>
            {
                { "2", new List<string>() { "a", "b", "c" } },
                { "3", new List<string>() { "d", "e", "f" } },
                { "4", new List<string>() { "g", "h", "i" } },
                { "5", new List<string>() { "j", "k", "l" } },
                { "6", new List<string>() { "m", "n", "o" } },
                { "7", new List<string>() { "p", "q", "r", "s" } },
                { "8", new List<string>() { "t", "u", "v" } },
                { "9", new List<string>() { "w", "x", "y", "z" } }
            };

            if (digits.Length == 1)
            {
                return keyMap[digits];
            }

            var digitsArray = digits.ToArray();
            var combinations = new List<string>();
            var sb = new StringBuilder();

            Backtrack(combinations, keyMap, digits, 0, sb);

            return combinations;
        }

        private void Backtrack(List<string> combinations, Dictionary<string, List<string>> keyMap, string digits, int index, StringBuilder path)
        {
            if (index == digits.Length)
            {
                combinations.Add(path.ToString());
                return;
            }

            var digit = digits[index].ToString();
            var letters = keyMap[digit];
            foreach (var letter in letters)
            {
                path.Append(letter);
                Backtrack(combinations, keyMap, digits, index + 1, path);
                path.Remove(path.Length - 1, 1);
            }
        }
    }
}
