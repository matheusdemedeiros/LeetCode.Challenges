namespace LeetCode.ConsoleApp.Challenges.Arrays.MedianOfTwoSortedArrays
{
    public class MySolution2
    {
        public int[] Input1 { get; }
        public int[] Input2 { get; }

        public MySolution2(int[] input1, int[] input2)
        {
            Input1 = input1;
            Input2 = input2;
        }

        public void Run()
        {
            var median = GetMedian();
            Console.WriteLine(median);
        }

        private double GetMedian()
        {
            var totalLength = Input1.Length + Input2.Length;
            if (totalLength == 0) { return 0; }

            var midIndex = totalLength / 2;
            var isOdd = totalLength % 2 != 0;
            var merged = SortArrays(totalLength, midIndex);
            double median = 0;

            if (isOdd)
            {
                median = merged[midIndex];
            }
            else
            {
                median = (merged[midIndex] + merged[midIndex - 1]) / 2.0;
            }

            return median;
        }

        private int[] SortArrays(int totalLength, int midIndex)
        {
            int i = 0, j = 0, count = 0;
            int[] merged = new int[midIndex + 1];
            while (count <= midIndex)
            {
                int? elementInput1 = i < Input1.Length ? Input1[i] : null;
                int? elementInput2 = j < Input2.Length ? Input2[j] : null;

                if (!elementInput1.HasValue && elementInput2.HasValue)
                {
                    merged[count] = elementInput2.Value;
                    j++;
                    count++;
                    continue;
                }

                if (elementInput1.HasValue && !elementInput2.HasValue)
                {
                    merged[count] = elementInput1.Value;
                    i++;
                    count++;
                    continue;
                }

                if (elementInput1 == elementInput2 || elementInput1 < elementInput2)
                {
                    merged[count] = elementInput1.Value;
                    i++;
                }
                else
                {
                    merged[count] = elementInput2.Value;
                    j++;
                }
                count++;
            }

            return merged;
        }
    }
}