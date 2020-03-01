using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            Task2();
        }

        static void Task2()
        {
            int width = ReadInt();
            int height = ReadInt();
            int j = 0;

            while(j < height)
            {
                j = j + 1;
                int i = 0;
                while (i < width)
                {
                    i = i + 1;
                    Console.Write("*");
                }
                Console.Write("\n");
            }

           
            
            Console.ReadLine();

        }

        static void Task1()
        {
            // Max of 3 integers
            int m = ReadInt();
            int k = ReadInt();
            int p = ReadInt();

            int max = Max(m, k, p);
            Console.WriteLine(max);


            Console.ReadLine();
        }
        static int ReadInt()
        {
            string str = Console.ReadLine();
            int integer = int.Parse(str);
            return integer;
        }
        static int Max(int i1, int i2)
        {
            if (i1 > i2)
            {
                return i1;
            }
            else
            {
                return i2;
            }
        }

        static int Max(int i1, int i2, int i3)
        {
            int max1 = Max(i1, i2);
            int max2 = Max(max1, i3);
            return max2;
        }
    }
}
