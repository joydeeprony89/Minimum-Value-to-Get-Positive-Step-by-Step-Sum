using System;

namespace Minimum_Value_to_Get_Positive_Step_by_Step_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] {-3, 2, -3 , 4 , 2 };
            Console.WriteLine(MinStartValue(nums));
        }

        static int MinStartValue(int[] nums)
        {
            int sum = 0;
            int max = 1;
            foreach(int n in nums)
            {
                sum += n;
                if(sum < 0)
                {
                    max = Math.Max(max, 1 + Math.Abs(sum));
                }
            }
            return max;
        }
    }
}
