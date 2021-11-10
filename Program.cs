using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program will display the N-th term of the Fibonacci sequence
            Console.WriteLine("============FIBONACCI============\n");
            long num1 = 0;
            long num2 = 1;
            long num3 = 0;
            int x;
            Console.Write("Input Number = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1+" "+num2+" ");
            for (int i = 0; i <= x - 2; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3+" ");
                num1 = num2;
                num2 = num3;
            }
            Console.ReadKey();
        }
    }
}