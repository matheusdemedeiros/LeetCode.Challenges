using BenchmarkDotNet.Attributes;

namespace LeetCode.ConsoleApp.Challenges.ContainerWithMostWater
{
    public class MySolution
    {
        private int[] input;

        public MySolution(int[] input)
        {
            this.input = input;
        }

        public void Run()
        {
            int i = 0, j = input.Length -1;
            int maxArea = 0;

            while (i != j)
            {
                var left = input[i];
                var right = input[j];
                var height = Math.Min(left, right);
                var width = Math.Abs(i - j);
                var area = height * width;

                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (left < right)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

        }
    }
}
