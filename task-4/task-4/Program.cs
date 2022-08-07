using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 1, -4, 0, 71, 90, 11, -6, 0, 23, 84 };
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Found(Arr, Num))
                Console.WriteLine("Element found in array");
            else
                Console.WriteLine("Element not found in given array");
        }

        static bool Found(int[] Arr, int num)
        {
            foreach (int item in Arr)
            {
                if (item == num)
                    return true;
            }
            return false;
        }
    }
}
