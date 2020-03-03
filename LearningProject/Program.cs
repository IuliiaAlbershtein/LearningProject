﻿using System;
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
            // Task2();
            // Task3();
            // Task4();
            // Task5();
            // Task6();
            // Task7();
            Task8();
        }
        static void Task8()
        {
            int m = ReadInt();
            int k = 1;
            int p = 1;
            int j = SumN(m, k, p);
            Console.WriteLine(j);
            Console.ReadLine();
        }
        static void Task7()
        {
            int k = ReadInt();
            int m = ReadInt();
            int p = ReadInt();

            bool statement = SumStatement(k, m, p);
            if (statement == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
        static void Task6()
        {
            int m = ReadInt();
            int k = ReadInt();
            int p = ReadInt();

            string statement = Statement(m, k, p);

            Console.WriteLine(statement);

            Console.ReadLine();

        }
        static void Task5()
        {
            int m = ReadInt();
            int k = ReadInt();
            int p = ReadInt();

            int positivenum = PosNum(m, k, p);

            Console.WriteLine(positivenum);

            Console.ReadLine();
        }
        static void Task4()
        {
            int m = ReadInt();
            int k = ReadInt();
            int p = ReadInt();

            int summax = SumMax(m, k, p);
            Console.WriteLine(summax);
            Console.ReadLine();
        }
        static void Task3()
        {
            Console.WriteLine("What is the month now?");
            int month = ReadInt();
            Console.Write("It is ");

            if (month == 1)
            {
                Console.WriteLine("January");
            }
            else
            if (month == 2)
            {
                Console.WriteLine("February");
            }
            else
            if (month == 3)
            {
                Console.WriteLine("March");
            }
            else
            if (month == 4)
            {
                Console.WriteLine("April");
            }
            else
            if (month == 5)
            {
                Console.WriteLine("May");
            }
            else
            if (month == 6)
            {
                Console.WriteLine("June");
            }
            else
            if (month == 7)
            {
                Console.WriteLine("July");
            }
            else
            if (month == 8)
            {
                Console.WriteLine("August");
            }
            else
            if (month == 9)
            {
                Console.WriteLine("September");
            }
            else
            if (month == 10)
            {
                Console.WriteLine("October");
            }
            else
            if (month == 11)
            {
                Console.WriteLine("November");
            }
            else
            if (month == 12)
            {
                Console.WriteLine("December");
            }
            Console.ReadLine();
        }

        static void Task2()
        {
            int width = ReadInt();
            int height = ReadInt();
            int j = 0;

            while (j < height)
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
        static int Sum(int i1, int i2)
        {
            int sum = i1 + i2;
            return sum;
        }
        static int SumMax(int i1, int i2, int i3)
        {
            int sum1 = Sum(i1, i2);
            int sum2 = Sum(i1, i3);
            int sum3 = Sum(i2, i3);
            if (sum1 > sum2)
            {
                return sum1;
            }
            else
            {
                if (sum2 > sum3)
                {
                    return sum2;
                }
                else
                {
                    return sum3;
                }
            }
        }
        static int PosNum(int i1, int i2, int i3)
        {
            int count = 0;
            if (i1 >= 0)
            {
                count = count + 1;
            }
            if (i2 >= 0)
            {
                count = count + 1;
            }
            if (i3 >= 0)
            {
                count = count + 1;
            }
            return count;
        }
        static string Statement(int i1, int i2, int i3)
        {
            string statement = "NO";
            if (i1 == i2)
            {
                statement = "YES";
            }
            else
            {
                if (i1 == i3)
                {
                    statement = "YES";
                }
                else
                {
                    if (i2 == i3)
                    {
                        statement = "YES";
                    }
                    else
                    {
                        statement = "NO";
                    }
                }
            }
            return statement;
        }
        static bool SumStatement(int i1, int i2, int i3)
        {
            bool statement = false;
            if (i3 == i1 + i2)
            {
                statement = true;
            }
            else
            {
                if (i2 == i1 + i3)
                {
                    statement = true;
                }
                else
                {
                    if (i3 == i2 + i3)
                    {
                        statement = true;
                    }
                    else
                    {
                        statement = false;
                    }
                }
            }
            return statement;
        }
        static int SumN(int i1, int i2, int i3)
        {
            while (i3 < i1)
            {
                i3 = i3 + 1;
                i2 = i2 + i3;
            }
            return i2;
        }
    }
}
