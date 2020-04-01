using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    class Program
    {
        /*
         * IntList/Vector
         * LinkedList
         * BST Tree
         * Hash Table
        */
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();
            // Task4();
            // Task5();
            // Task6();
            // Task7();
            // Task8();
            // Task9();
            // Task10();
            // Task11();
            // Task12();
            // Task13();
            // Task14();
            // Task15();
            // Task16();
            // Task17();
            // Task18();
            // Task19();
            // Task20();
            // Task21();
            // Task22();
            // Task23();
            // Task24();
            // Task25();
            // Task26();
            // Task27();
            // Task28();
            // Task29();
            // Task30();
            // Task31();
            // Task39();
            Task40();
            // Task41();

            Console.ReadLine();
        }

        static void Task41()
        {
            // LinkedList
            var linkedList = new LinkedList();
            linkedList.AddFirst(10);
            linkedList.AddFirst(11);
            linkedList.AddFirst(4);
            linkedList.AddFirst(7);
            var value = linkedList.GetValue(1);
            var count = linkedList.Count;

            linkedList.ForEach(x => Console.WriteLine(x));

            for (var i = 0; i < linkedList.Count; i += 1)
            {
                Console.WriteLine(linkedList.GetValue(i));
            }
        }

        // Implement IntList
        static void Task40()
        {
            IntList list = new IntList();

            list.Add(4);
            list.Add(55);
            list.Add(6);
            list.Add(68);
            list.Add(3);
            list.Add(6);
            list.Add(8);
            // list.Remove(6);
            // list.Contains(6);
            // list.Max();
            // list.Min();
            // list.Sum();
            // list.IndexOf(22);
            // list.Reverse();
            // list.Insert(4, 35);
            // list.RemoveAll();
            // list.Sort();
            list.BubbleSort();
            //var index1 = list.IndexOf(value => value > 3);
            //var indexEven = list.IndexOf(x => x % 2 == 0);

            //var even = list.Filter(x => x % 2 == 0);
            /*
            bool condition(int x)
            {
                return x % 2 == 0;
            }
            var even = list.Filter(condition);
            var doubled = list.Transform(x => x * 2);

            for (var i = 0; i < doubled.Count; i += 1)
             {
             Console.WriteLine(doubled.GetValue(i));
             }*/

            for (var i = 0; i < list.Count; i += 1)
            {
              Console.WriteLine(list.GetValue(i));
            }
            //Console.Write(list.Count);

            //Console.WriteLine(list.Contains(6));
            //Console.WriteLine(list.Max());
            //Console.WriteLine(list.Min());
            //Console.WriteLine(list.Sum());
            //Console.WriteLine(list.IndexOf(22));
        }

        static void Task39()
        {

            Dog[] dogs = new Dog[3];
            dogs[0] = new BigDog("Barbos", 4, 30);
            dogs[1] = new Dog("Bara", 5);
            dogs[2] = new Dog("Sara", 3);

            dogs[1].MakeFriend(dogs[0]);

            for (int i = 0; i < dogs.Length; i += 1)
            {
                dogs[i].ShowInfo();
            }
        }


        static void Task31()
        {
            int[] numbers = ReadIntArray();
            int count = 0;

            for (int i = 0; i < numbers.Length; i += 1)
            {
                int m = numbers[i];
                for (int j = i; j < numbers.Length; j += 1)
                {
                  //  bool e = false;
                    if (m != numbers[j] && i != j)
                    {
                      //  e = true;
                        count += 1;
                    }
              
                }
            }
             

            Console.Write(count);
        }

        // Find identical numbers
        static void Task30()
        {
            int[] numbers = ReadIntArray();
            bool p = false;

            for (int i = 0; i < numbers.Length; i += 1)
            {
               int m = numbers[i];
                for (int j = 0; j < numbers.Length; j += 1)
                {
                    if (m == numbers[j] && i != j)
                    {
                        p = true;
                    }
                }
            }
            Console.Write(p);
        }

        //Increase/decrease type of array
        static void Task29()
        {
            int[] numbers = ReadIntArray();

            bool p = false;
            bool k = false;
            for (int i = 0; i < numbers.Length - 1; i += 1)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    p = true;
                }
                
                else if (numbers[i] > numbers[i + 1])
                {
                    k = true;
                }
            }
            if (p == true && k != true)
            {
                Console.Write("Vozr");
            }
            else if (k == true && p != true)
            {
                Console.Write("Ubyv");
            }
            else if (k == true && p == true)
            {
                Console.Write("Mix");
            }
        }

        // Min sum of two nearstanding numbers in array
        static void Task28()
        {
            int[] numbers = ReadIntArray();

            int min = numbers[0] + numbers[1];
            int index = 0;
            for (int i = 1; i < numbers.Length - 1; i += 1)
            {
                if (numbers[i] + numbers[i + 1] < min)
                {
                    min = numbers[i] + numbers[i + 1];
                    index = i;
                }
            }
            Console.Write(index);
            Console.WriteLine(index + 1);

        }

        // The least even number in array
        static void Task27()
        {
            int[] numbers = ReadIntArray();
            // min is equal to maximum possible value in 32bit
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i += 1)
            {
                if (numbers[i] < min && numbers[i] % 2 == 0)
                {
                    min = numbers[i];
                }
            }
            Console.Write(min);
        }

        // Sum of odd numbers in array, which are less than 11
        static void Task26()
        {
            int[] numbers = ReadIntArray();
            int oddsum = 0;
            for (int i = 0; i < numbers.Length; i += 1)
            {
                if (numbers[i] % 2 != 0 && numbers[i] < 11)
                {
                    oddsum = numbers[i] + oddsum;
                }
            }
            Console.Write(oddsum);

        }

        // Even numbers in array
        static void Task25()
        {
            int[] numbers = ReadIntArray();
            int evencount = 0;
            for (int i = 0; i < numbers.Length; i += 1)
            {
                if (numbers[i] % 2 == 0)
                {
                    evencount += 1;
                }
            }
            Console.Write(evencount);
        }

        static void Task24()
        {
            int p = CreateRandomInt();
            int tries = 0;
            Console.WriteLine("Try to guess number.");
 
            while (tries < 3)
            {
                int k = ReadInt();
                if (p == k)
                {
                    Console.WriteLine("Right Number");
                    return;
                }
                else if (p < k)
                {
                    Console.WriteLine("Made up number is less.");
                }
                else if (p > k)
                {
                    Console.WriteLine("Made up number is more.");
                }
                tries += 1;
            }
            Console.Write(p);
        }

        // Return Index of number[i] = x
        static void Task23()
        {
            Console.Write("Number to search in array:");
            int x = ReadInt();
            int[] numbers = ReadIntArray();
            int index = Contains(numbers, x);

            Console.Write(index);
        }

        // Contains number x 
        static void Task22()
        {
            Console.Write("Number to search in array:");
            int x = ReadInt();
            int[] numbers = ReadIntArray();
            int index = Contains(numbers, x);
            if (index > 0)
            {
                Console.Write("Contains x");
            }
            else
            {
                Console.Write("Does not contain x");
            }

        }

        // Reverse array
        static void Task21()
        {

            int[] numbers = ReadIntArray();

            int[] result = Reverse(numbers);


            for (int i = 0; i < result.Length; i += 1)
            {
                Console.WriteLine(result[i]);
            }
        }

        // Removing one int out from array
        static void Task20()
        {
            int[] numbers = ReadIntArray();


            int[] result = Remove(numbers, 1);


            for (int i = 0; i < result.Length; i += 1)
            {
                Console.WriteLine(result[i]);
            }
        }

        
        // Increase second half of array by 1
        static void Task19()
        {
            int[] numbers = ReadIntArray();

            for(int i = numbers.Length / 2; i < numbers.Length ; i += 1 )
            {
                numbers[i] += 1;
            }
        }

        // Min in array
        static void Task18()
        {
            int[] numbers = ReadIntArray();
            int min = 0;
            for (int i = 0; i < numbers.Length; i +=1)
            {
                if(i == 0)
                {
                    min = numbers[i];
                    continue;
                }

                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.Write(min);

        }

        // Sum of numbers in array
        static void Task17()
        {
            int[] numbers = ReadIntArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i += 1)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        // Creation of array with random numbers
        static void Task16()
        {
            int[] numbers = CreateRandomIntArray();

            for (int i = 0; i < numbers.Length; i += 1)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // Even numbers from array
        static void Task15()
        {
            int[] numbers = ReadIntArray();
            
            for (int i = 0; i < numbers.Length; i += 1)
            {
                if(numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i]);
                }
                
            }
        }

        // Triforce made of *
        static void Task14()
        {
            int p = 20;
            int m = 1;
            while (p >= 11)
            {
                RepeatString(p, " ");
                RepeatString(m, "*");
                Console.WriteLine();
                p -= 1;
                m += 2;
            }
            int t = 1;
            int b = m - 2;
            while (p >= 1)
            {
                
                RepeatString(p, " ");
                RepeatString(t, "*");
                RepeatString(b, " ");
                RepeatString(t, "*");
                Console.WriteLine();
                p -= 1;
                t += 2;
                b -= 2;
            }
        }

        // Triangle made of *
        static void Task13()
        {
            int p = 20;
            int m = 1;
            while (p >= 0)
            {
                RepeatString(p, " ");
                RepeatString(m, "*");
                Console.WriteLine();
                p -= 1;
                m += 2;
            }
        }

        // W made of *
        static void Task12()
        {
            int p = 5;
            int k = 1;

            Console.Write("*");
            RepeatString(p, " ");
            Console.Write("*");
            RepeatString(p, " ");
            Console.WriteLine("*");
            p -= 2;

            RepeatString(k, " ");
            Console.Write("*");
            RepeatString(p, " ");
            Console.Write("*");
            RepeatString(k, " ");
            Console.Write("*");
            RepeatString(p, " ");
            Console.WriteLine("*");
            p -= 2;
            k += 1;

            RepeatString(k, " ");
            Console.Write("*");
            RepeatString(p, " ");

            k += 1;
            Console.Write("*");
            RepeatString(k, " ");
            Console.Write("*");
            RepeatString(p, " ");
            Console.WriteLine("*");

            RepeatString(k, " ");
            Console.Write("*");

            k += 2;
            RepeatString(k, " ");
            Console.WriteLine("*");

        }

        // \ made of *
        static void Task11()
        {
            int m = 0;
            int k = 0;

            while (m < 12)
            {
                m += 1;
                int i = 0;

                string str1 = " ";
                string str2 = Figure(k, m, str1);
                Console.Write (str2);
                Console.Write("*\n");

            }

        }
       
        // Number of signs in line is equal to number of line
       static void Task10()
        {
            int m = 0;
                                 
            while (m < 5)
            {
                m += 1;
                int k = 1;
                string str1 = "0";
                string str2 = Figure(k, m, str1);
                Console.Write(str2);
                Console.Write("\n");

            }
        }

        // Multiplication table
        static void Task9()
        {
            int m = 1;
            int k = 0;
            int p = m * k;
            
            while (m <= 10)
            {
                
                while (k < 10)
                {
                    k += 1;
                    p = m * k;
                    Console.Write(p);
                    Console.Write(" ");
                }
                m += 1;
                k = 0;
                Console.Write("\n");
            }
           
        }
       
        // Sum of all integers inside entered number
        static void Task8()
        {
            int m = ReadInt();
            int k = 1;
            int p = 1;
            int j = SumN(m, k, p);
            Console.WriteLine(j);
        }

        // if sum 2 out of 3 nimbers is equal to 3d number
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
        }

        // Same numbers
        static void Task6()
        {
            int m = ReadInt();
            int k = ReadInt();
            int p = ReadInt();

            string statement = Statement(m, k, p);

            Console.WriteLine(statement);

        }

        // Positve numbers
        static void Task5()
        {
            int m = ReadInt();
            int k = ReadInt();
            int p = ReadInt();

            int positivenum = PosNum(m, k, p);

            Console.WriteLine(positivenum);
        }

        // Max sum 2 out of 3 numbers
        static void Task4()
        {
            int m = ReadInt();
            int k = ReadInt();
            int p = ReadInt();

            int summax = SumMax(m, k, p);
            Console.WriteLine(summax);
        }

        // Month name according to month number
        static void Task3()
        {
            Console.WriteLine("What is the month now?");
            int month = ReadInt();
            Console.Write("It is ");

            if (month == 1)
            {
                Console.WriteLine("January");
            }
            else if (month == 2)
            {
                Console.WriteLine("February");
            }
            else if (month == 3)
            {
                Console.WriteLine("March");
            }
            else if (month == 4)
            {
                Console.WriteLine("April");
            }
            else if (month == 5)
            {
                Console.WriteLine("May");
            }
            else if (month == 6)
            {
                Console.WriteLine("June");
            }
            else if (month == 7)
            {
                Console.WriteLine("July");
            }
            else if (month == 8)
            {
                Console.WriteLine("August");
            }
            else if (month == 9)
            {
                Console.WriteLine("September");
            }
            else if (month == 10)
            {
                Console.WriteLine("October");
            }
            else if (month == 11)
            {
                Console.WriteLine("November");
            }
            else if (month == 12)
            {
                Console.WriteLine("December");
            }
        }

        // Draw rectangle
        static void Task2()
        {
            int width = ReadInt();
            int height = ReadInt();
            int j = 0;

            while (j < height)
            {
                j += 1;
                int i = 0;
                while (i < width)
                {
                    i += 1;
                    Console.Write("*");
                }
                Console.Write("\n");
            }

        }

        // Max of 3 integers
        static void Task1()
        {
           
            int m = ReadInt();
            int k = ReadInt();
            int p = ReadInt();

            int max = Max(m, k, p);
            Console.WriteLine(max);
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
                count += 1;
            }
            if (i2 >= 0)
            {
                count += 1;
            }
            if (i3 >= 0)
            {
                count += 1;
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
                i3 += 1;
                i2 = i2 + i3;
            }
            return i2;
        }
        static string Figure(int i1, int i2, string str1)
        {
            while (i1 < i2)
            {
                i1 += 1;
                Console.Write(str1);
            }
            return str1;
        }
        static void RepeatString(int i1, string i2)
        {
            int i = 0;
            while (i < i1)
            {
                Console.Write(i2);
                i += 1;
            }
        }

        static int[] ReadIntArray()
        {
            Console.Write("Enter array size: ");
            int count = ReadInt();
            
            int[] numbers = new int[count];
            for(int i = 0; i < count; i += 1)
            {
                numbers[i] = ReadInt();
            }

            return numbers;
        }

        static int[] CreateRandomIntArray()
        {
            Console.Write("Enter array size: ");
            int count = ReadInt();

            int[] numbers = new int[count];
            for(int i = 0; i < count; i += 1)
            {
                numbers[i] = CreateRandomInt();
            }

            return numbers;
        }

        static Random random = new Random();
        static int CreateRandomInt()
        {
            return random.Next(100);
        }
        static int[] Remove(int[] array, int indexToRemove)
        {
            int[] result = new int[array.Length - 1];
            for (int i = 0; i < array.Length; i += 1)
            {
                if (i < indexToRemove)
                {
                    // copy
                    result[i] = array[i];
                }
                else if (i > indexToRemove)
                {
                    // copy -1
                    result[i - 1] = array[i];

                }
                else
                {
                    // do nothing
                }
            }
            return result;
        }

        static int[] Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i += 1)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;

                /*
                int x = 5;
                int y = 6;

                int z = x;
                x = y;
                y = z;
                */
            }
            return array;
        }
        static int Contains(int[] array, int compareInt)
        {
            for (int i = 0; i < array.Length; i += 1)
            {
                if (array[i] == compareInt)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
