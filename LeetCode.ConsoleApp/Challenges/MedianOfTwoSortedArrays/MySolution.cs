

namespace LeetCode.ConsoleApp.Challenges.MedianOfTwoSortedArrays
{
    public class MySolution
    {
        public int[] Input1 { get; }
        public int[] Input2 { get; }

        public MySolution(int[] input1, int[] input2)
        {
            Input1 = input1;
            Input2 = input2;
        }

        public void Run()
        {
            var mergedArray = new int[Input1.Length + Input2.Length];
            mergedArray = Input1.Concat(Input2).ToArray();
            var sortedArray = mergedArray.OrderBy(x => x).ToArray();
            var median = GetMedian(sortedArray);

        }

        private double GetMedian(int[] array)
        {
            if(array.Length == 0) { return 0; }

            if (array.Length == 1) { return array[0]; }

            var isPair = array.Length % 2 == 0;

            if (!isPair)
            {
                var result = array[array.Length / 2];

                return result;
            }

            var midRight = array.Length / 2;
            var midLeft = midRight - 1;
            var median = (array[midLeft] + array[midRight]) / 2.0;
            
            return median;
        }
    }
}