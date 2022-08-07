using System;

namespace MethodsRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumLength(Num));
        }
        static int NumLength(int Num)
        {
            int count = 1;
            if (Num < 0)
                Num *= -1;
            while (Num > 9 || Num < -9)
            {
                count++;
                Num /= 10;
            }
            return count;
        }
    }
}
