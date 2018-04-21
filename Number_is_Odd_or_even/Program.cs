using System;

namespace Number_is_Odd_or_even
{
    class Program
    {
        enum Num { odd ,even}
        static void Main(string[] args)
        {
            string str;
            do
            {
                Console.WriteLine("Enter The Number");
                double num = double.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The Number is {Num.even}");
                }
                else
                {
                    Console.WriteLine($"The Number is {Num.odd} ");
                }
                Console.WriteLine("Try Agin ? Y/N ");
                str = Console.ReadLine();
            } while (str.Trim().ToLower() == "y");
          
       
        }
    }
}
