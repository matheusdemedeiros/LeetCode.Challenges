using BenchmarkDotNet.Running;

namespace LeetCode.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var challenge = new Challenges.ContainerWithMostWater.Challenge();
#if RELEASE
            var summary = BenchmarkRunner.Run<Challenges.ContainerWithMostWater.Challenge>();
#endif
            var sw = System.Diagnostics.Stopwatch.StartNew();
            challenge.RunMy();
            var elapsedMy = sw.ElapsedMilliseconds;
            Console.WriteLine($"MySolution elapsed time: {elapsedMy} ms");

            sw.Restart();
            challenge.RunBest();
            var elapsedBest = sw.ElapsedMilliseconds;
            Console.WriteLine($"BestSolution elapsed time: {elapsedBest} ms");
            Console.ReadLine();
        }
    }
}