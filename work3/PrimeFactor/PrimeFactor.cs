using System;

namespace PrimeFactor
{
    class PrimeFactor
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input a positive integer number\n>>");
                int num = Convert.ToInt32(Console.ReadLine());
                String result = GetPrimeFactor(num);
                if(result != "")
                {
                    Console.WriteLine(result);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static String GetPrimeFactor(int lNum)
        {
            String result = "";
            if (lNum <= 1)
            {
                Console.WriteLine("Num should be positive integer and beyond 1!");
            }
            else
            {
                int i = 2;
                while (lNum > 1)
                {
                    if (lNum % i == 0)
                    {
                        lNum /= i;
                        result = result + i + " ";
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return result;
        }
    }
}
