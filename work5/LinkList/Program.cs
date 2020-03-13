using System;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for(int x=0;x<10;x++)
            {
                list.Add(x);
            }

            list.ForEach(m => Console.WriteLine(m));
            int max = int.MinValue;
            list.ForEach(m=> { if (max < m) max = m; });
            Console.WriteLine($"最大值为：{max}");

            int min = int.MaxValue;
            list.ForEach(m => { if (min > m) min = m; });
            Console.WriteLine($"最小值为：{min}");

            int sum = 0;
            list.ForEach(m => sum += m);
            Console.WriteLine($"总和为：{sum}");
        }
    }
}
