using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.MedianOfTwoSortedArrays
{
    [MemoryDiagnoser]
    public class Challenge
    {
        public int[] Input1 { get; set; }
        public int[] Input2 { get; set; }

        public Challenge()
        {
            //// Exemplo 2
            Input1 = new int[] { 1, 2 };
            Input2 = new int[] { 3, 4 };
            //// Output esperado: 2.5   (pois a combinação é [1,2,3,4])
        }

        [Benchmark]
        public void RunMy()
        {
            var inputs = new List<(int[], int[])>()
            {
                (new int[] { 1, 3 }, new int[] { 2 }),                   // Exemplo 1 → Output esperado: 2.0
                (new int[] { 1, 2 }, new int[] { 3, 4 }),                // Exemplo 2 → Output esperado: 2.5
                (new int[] { 0, 0 }, new int[] { 0, 0 }),                // Exemplo 3 → Output esperado: 0.0
                (new int[] { }, new int[] { 1 }),                        // Exemplo 4 → Output esperado: 1.0
                (new int[] { 2 }, new int[] { }),                        // Exemplo 5 → Output esperado: 2.0
                (new int[] { 1, 2, 5, 7 }, new int[] { 3, 4, 6, 8, 9 }), // Exemplo 6 → Output esperado: 5.0
                (new int[] { -5, -3, -1, 0 }, new int[] { 1, 2, 3, 4, 5 }) // Exemplo 7 → Output esperado: 1.0
            };

            foreach (var (input1, input2) in inputs)
            {
                var solution = new MySolution2(input1, input2);
                solution.Run();
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
