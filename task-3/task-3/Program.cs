using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 1, 0, -4, 1, 7, 9, 0, 7, 9, -4, 3, 8 };           // min = -4     max = 9
            if(Arr.Length>0)
                ReplaceMinMax(Arr);             // ReplaceMinMaxAll(Arr)
            else
                Console.WriteLine("Nothing in array");
            foreach (int item in Arr)
            {
                Console.Write(item + " ");
            }
        }


        /// <summary>
        /// Replace only first min and first max
        /// </summary>
        /// <param name="Arr"></param>
        static void ReplaceMinMax(int[] Arr)
        {
            int mini = 0, maxi = 0;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] < Arr[mini])
                    mini = i;
                else if (Arr[i] > Arr[maxi])
                    maxi = i;
            }
            //change min and max
            Arr[maxi] = Arr[maxi] + Arr[mini];
            Arr[mini] = Arr[maxi] - Arr[mini];
            Arr[maxi] = Arr[maxi] - Arr[mini];
        }



        /// <summary>
        /// Replace All min with max
        /// </summary>
        /// <param name="Arr"></param>
        static void ReplaceMinMaxAll(int[] Arr)
        {
            int min = Arr[0], max = Arr[0];

            foreach (int item in Arr)
            {
                if (item > max)
                    max = item;
                else if (item < min)
                    min = item;
            }

            for (int i = 0; i < Arr.Length; i++)    
            {
                if (Arr[i] == min)
                    Arr[i] = max;
                else if(Arr[i] == max)              // we use "else" for don't replace an element twice.
                    Arr[i] = min;
            } 
        }
    }
}
