namespace LeetCode.ConsoleApp.Challenges.Hashtables.LetterCombinationsOfPhoneNumber
{
    using System.Text;

    public class BestSolution
    {
        public string Input { get; set; }

        public BestSolution(string input)
        {
            Input = input;
        }

        public List<string> Run()
        {
            var phoneMap = new Dictionary<char, string>
            {
                { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" },
                { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" }
            };

            string digits = Input;
            var result = new List<string>();
            if (string.IsNullOrEmpty(digits)) return result;

            Backtrack(digits, 0, new StringBuilder(), result, phoneMap);

            return result;
        }

        private void Backtrack(string digits, int index, StringBuilder caminho, List<string> resultado, Dictionary<char, string> phoneMap)
        {
            if (index == digits.Length)
            {
                resultado.Add(caminho.ToString());
                return;
            }

            string letras = phoneMap[digits[index]];
            foreach (var letra in letras)
            {
                caminho.Append(letra);
                Backtrack(digits, index + 1, caminho, resultado, phoneMap);
                caminho.Length--; // desfaz a última letra (backtrack)
            }
        }
    }

}
