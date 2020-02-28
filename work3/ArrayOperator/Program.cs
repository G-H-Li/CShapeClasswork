using System;

namespace ArrayOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //执行输入
                Console.Write("Please input array length:\n>>");
                int length = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[length];
                Console.WriteLine("Please input array number:");
                for(int i=0; i<nums.Length; i++)
                {
                    Console.Write(">>");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                //获取结果
                Console.WriteLine("Max:"+ GetMaxNum(nums));
                Console.WriteLine("Min:" + GetMinNum(nums));
                Console.WriteLine("Average:" + GetAverage(nums));
                Console.WriteLine("Gross:" + GetGross(nums));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static int GetMaxNum(int[] lNum)
        {
            int max = lNum[0];
            foreach(int num in lNum)
            {
               if(num > max)
               {
                    max = num;
               }
            }
            return max;
        }

        static int GetMinNum(int[] lNum)
        {
            int min = lNum[0];
            foreach (int num in lNum)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        static int GetAverage(int[] lNum)
        {
            int average = 0;
            foreach(int num in lNum)
            {
                average += num;
            }
            average /= lNum.Length;
            return average;
        }

        static int GetGross(int[] lNum)
        {
            int gross = 0;
            foreach (int num in lNum)
            {
                gross += num;
            }
            return gross;
        }
    }
}
