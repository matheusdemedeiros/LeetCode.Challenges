using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.LongestCommonPrefix
{
    public class Challenge
    {
        public List<string[]> Inputs { get; set; }

        public Challenge()
        {
            Inputs = new List<string[]>();

            Inputs.Add(new string[] { "aabbcc", "aabb", "", "aa" });   // esperado: ""
            Inputs.Add(new string[] { "flower", "flow", "flight" }); // esperado: "fl"
            Inputs.Add(new string[] { "dog", "racecar", "car" });   // esperado: ""
            Inputs.Add(new string[] { "interspecies", "interstellar", "interstate" }); // esperado: "inters"
            Inputs.Add(new string[] { "throne", "dungeon" });       // esperado: ""
            Inputs.Add(new string[] { "throne", "throne" });        // esperado: "throne"
            Inputs.Add(new string[] { "a" });                       // esperado: "a"
            Inputs.Add(new string[] { "cir", "car" });             // esperado: "c"
            Inputs.Add(new string[] { "ab", "a" });                // esperado: "a"
            Inputs.Add(new string[] { "aabbcc", "aabb", "aa" });   // esperado: "aa"
            Inputs.Add(new string[] { "abab", "aba", "abc" });     // esperado: "ab"
            Inputs.Add(new string[] { "c", "c" });                     // esperado: "c"
            Inputs.Add(new string[] { "reflower", "flow", "flight" }); // esperado: ""

        }

        [Benchmark]
        public void RunMy()
        {
            foreach (var input in Inputs)
            {
                var solution = new MySolution2(input);
                var result = solution.Run();
                Console.WriteLine($"Input: [{string.Join(", ", input)}] => Longest Common Prefix: '{result}'");
            }
        }

        [Benchmark]
        public void RunBest()
        {
            var solution = new BestSolution();
            solution.Run();
        }
    }
}
