using System;

namespace _20181130_練習
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int[] Ary = new int[] { 12, 9, 6, 2, 4, 1, 11, 8, 3, 5, 7, 10, 13 };

            for(int i =0; i < Ary.Length; i++)
            {
                for(int k = i + 1; k < Ary.Length; k++)
                {
                    if(Ary[i] > Ary[k])
                    {
                        temp = Ary[k];
                        Ary[k] = Ary[i];
                        Ary[i] = temp;
                    }
                }
                Console.WriteLine($"{Ary[i]}");
            }
            Console.Read();

        }
    }
}
