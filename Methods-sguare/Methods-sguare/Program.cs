using System;

namespace Methods_sguare
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
             
            SguareTop(input);
            if (input % 2 == 0)
            {
                for (int i = 0; i < input / 2; i++)
                {
                    SguareMid(input);
                }
            }
            else
            {
                for (int i = 0; i <= input / 2; i++)
                {
                    SguareMid(input);
                }
            }
            SguareTop(input);
        }
        static void SguareTop(int n) {
            Console.WriteLine(new string('-', n*2));
        }
        static void SguareMid(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }
    }
}
