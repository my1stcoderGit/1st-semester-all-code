using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] array = new int[20];
            //Console.WriteLine($"Indexes\tValues");
            //for (int i = 0; i < array.Length; i++)
            //{
            //   array[i] = i * 5;
            //   Console.WriteLine($"{i}\t{array[i]}");
            //}

            //=================================================================================================

            //int k = 0; int j=0; int n;
            //Console.WriteLine("Please enter the length of 1st array:");
            //int l1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the length of 2nd array:");
            //int l2 = Convert.ToInt32(Console.ReadLine());
            //if (l1 != l2) { Console.WriteLine("They are not equal"); }
            //else
            //{
            //    int[] array1 = new int[l1];
            //    int[] array2 = new int[l2];
            //
            //    for (int i = 0; i < l1; i++)
            //    {
            //        Console.WriteLine($"Enter the value of index {i} of 1st array:");
            //        array1[i] = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine($"Enter the value of index {i} of 2nd array:");
            //        array2[i] = Convert.ToInt32(Console.ReadLine());
            //        if (array1[i] != array2[i])
            //        {
            //            Console.WriteLine("They are Not equal");
            //            k = 0;
            //            break;
            //        }
            //        else { n = 1; }
            //        j = n * k;
            //
            //    }
            //    if (j == 1) { Console.WriteLine("Both are equal"); }
            //
            //}
            //===========================================================================================================================

            //                                      PARACTICE

            //int[] array = { 1,4,5,6,3,5};

            // Finding highest and lowest by using Max & Min method.

            //int highest = array.Max();
            //int lowest = array.Min();
            //Console.WriteLine(highest );
            //Console.WriteLine(lowest);

            //List<int> numbers = new List<int> { 1, 2, 3, 4 };
            //
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            // Finding highest and lowest by using foreach loop.

            // int highest = array[0];
            // int lowest = array[0];
            //
            // foreach (int num in array)
            // {
            //     if(num > highest)
            //     {
            //         highest = num;
            //     }
            //     if (num < lowest)
            //     {
            //         lowest = num;
            //     }
            // }
            // Console.WriteLine(highest);
            // Console.WriteLine(lowest);



            //==========================================================================================================

            //int[] temp = new int[7];
            //Console.WriteLine("Please enter the temperature of day 1");
            //temp[0] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the temperature of day 2");
            //temp[1] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the temperature of day 3");
            //temp[2] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the temperature of day 4");
            //temp[3] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the temperature of day 5");
            //temp[4] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the temperature of day 6");
            //temp[5] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the temperature of day 7");
            //temp[6] = Convert.ToInt32(Console.ReadLine());
            //
            //double average = (temp[0] + temp[1] + temp[2] + temp[3] + temp[4] + temp[5] + temp[6])/7;
            //Console.WriteLine($"The average temperature is {average}.");
            //
            //int highest = temp[0];
            //int lowest = temp[0];
            //foreach (int num in temp)
            //{
            //    if (num > highest)
            //    {
            //        highest = num; 
            //    }
            //    if (num < lowest)
            //    {
            //        lowest = num;
            //    }
            //}
            //Console.WriteLine($"Highest temperature is {highest} and lowest temperature is {lowest}.");
            //Console.WriteLine("The list of the days which have temperature above average is given as under:");
            //int i = 1;
            //foreach (int j in temp)
            //{
            //    if (j > average)
            //    {
            //        Console.WriteLine($"Day {i}");
            //        i++;
            //    }
            //}
            //
            //
            //=========================================================================================================================




            // 1ST METHOD

            //int[] integers = new int[6];
            //Console.WriteLine("Please enter the integer 1:");
            //integers[0] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the integer 2:");
            //integers[1] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the integer 3:");
            //integers[2] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the integer 4:");
            //integers[3] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the integer 5:");
            //integers[4] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the integer 6:");
            //integers[5] = Convert.ToInt32(Console.ReadLine());
            //
            //Console.WriteLine("The elements in reverse order:");
            //Console.WriteLine(integers[5]);
            //Console.WriteLine(integers[4]);
            //Console.WriteLine(integers[3]);
            //Console.WriteLine(integers[2]);
            //Console.WriteLine(integers[1]);
            //Console.WriteLine(integers[0]);

            // 2ND METHOD

            //int[] integers = new int[6];
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine($"Enter the integer {i}:");
            //    integers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 5; i >= 0; i--)
            //{
            //    Console.WriteLine(integers[i]);
            //}


            //================================================================================================================

            int[] numbers = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"Please enter the number {i}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        Console.WriteLine($"{numbers[i]} is duplicate at indexes {i} & {j} ");
                    }
                }
            }













        }
    }
    
}
