using System;

namespace StudyProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // creating an array
            int[] nums = Enumerable.Range(1, 15).ToArray();

            static int binarySearch(int[] numbers, int item)
            {
                int low = 0;
                int high = numbers.Length - 1;

                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    int guess = numbers[mid];
                    if (guess == item)
                    {
                        return mid;
                    } else if (guess > item)
                    {
                        high = mid - 1;
                    } else
                    {
                        low = mid + 1;
                    }
                }

                return 0;

            }

            Console.WriteLine(binarySearch(nums, 5));
        }

    }
}