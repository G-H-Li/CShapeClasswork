using System;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input a positive num:\n>>");
                int num = Convert.ToInt32(Console.ReadLine());
                if(num <=1)
                {
                    Console.WriteLine("Number should beyond 1!");
                }

                GetPrime(num);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void GetPrime(int lNum)
        {
            bool[] mark = new bool[lNum + 1];
            for (int i = 2; i <= lNum; i++)
            {
                mark[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(lNum); i++)
            {
                if (mark[i] == true)
                {
                    for (int j = i; j * i <= lNum; j++)
                    {
                        mark[i * j] = false;
                    }
                }
            }

            int k = 0;
            for (int i = 2; i <= lNum; i++)
            {
                if (mark[i] == true)
                {
                    k++;
                    Console.Write(i + " ");
                    if (k % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
