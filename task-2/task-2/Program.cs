using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Line = Console.ReadLine();
            Console.WriteLine(VowelLetter(Line));
        }
        static int VowelLetter(string Line)      // vowel letters in english lang.
        {
            int count = 0;
            for (int i = 0; i < Line.Length; i++)
            {
                //check both uppercase and lowercase letters
                if (Line[i] == 'a' || Line[i] == 'A' || Line[i] == 'e' || Line[i] == 'E' || Line[i] == 'i' || Line[i] == 'I' || Line[i] == 'o' || Line[i] == 'O' || Line[i] == 'u' || Line[i] == 'U' || Line[i] == 'y' || Line[i] == 'Y')
                    count++;
            }
            return count;
        }
    }
}
