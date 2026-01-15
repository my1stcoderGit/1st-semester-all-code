using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the limits of odd");
            //int lim = Convert.ToInt32(Console.ReadLine());
            //for ( int num = 1; num <= lim; num +=2 ) 
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("Please enter the limits of even");
            // lim = Convert.ToInt32(Console.ReadLine());
            //for (int num = 0; num <= lim; num += 2)
            //{
            //    Console.WriteLine(num);
            //}

            //-----------------------------------------------------
            //Console.WriteLine("Now the first 10 terms of arithmetic series are :");
            //int a1 = -2, n = 10; double d = 2.5, an;
            //
            //for (n = 2; n <= 10; n++)
            //{ 
            //   an = a1 + (n - 1)*d;
            //   Console.WriteLine(an);
            //}
            //
           
            //___________________________________________________________________________
            //Console.WriteLine("Now the first 10 terms of geometric series are :");
            //int a1 = 3, r = 2 , n= 10; double an;
            //
            //for (n = 2; n <= 10; n++)
            //{
            //    an = a1 * Math.Pow(r,n-1);
            //    Console.WriteLine(an);
            //}


            //================================================================================================================

            //int submarks = 0, subject; double tmarks = 0;
            //Console.WriteLine("Enter the number of subjects:");
            //int i = Convert.ToInt32(Console.ReadLine());
            //for (subject = 1; subject <= i; subject++)
            //{
            //
            //    Console.Write("Please enter the marks of subject " + subject + " out of 100: ");
            //    submarks = Convert.ToInt32(Console.ReadLine());
            //
            //    tmarks = tmarks += submarks;
            //}
            //    double fullmarks = i * 100;
            //    double percentage = tmarks / fullmarks * 100;
            //
            //    Console.WriteLine("Your percentage is " + percentage + "%.");
            //
            //if (percentage >= 80 && percentage <= 90) { Console.WriteLine("Your grade is A1"); }
            //else if (percentage >= 70 && percentage <= 80 ){ Console.WriteLine("Your grade is B"); }

            //=============================================================================================================

            //Console.WriteLine("Please enter the no of terms : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //
            //
            //int a = 0, b = 1, c;
            //Console.Write(a + " , ");
            //Console.Write(b + " , ");
            //
            //for (int i = 3; i <= n; i++)
            //{
            //    c = a + b;
            //    Console.Write(c + " , ");
            //    a = b; 
            //    b = c;
            //}

            //====================================================================================================


            //Console.Write("Enter number of rows: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //
            //Console.WriteLine("");
            //Console.WriteLine("Right-angled triangle:");
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)                                 //     j = 1; j <= i; j++
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("");
            //Console.WriteLine("Inverted right-angled triangle:");
            //for (int i = n; i >= 1; i--)                                     //     i = n; i >= 1; i--
            //{
            //    for (int j = 1; j <= i; j++)                                 //     j = 1; j <= i; j++
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("");
            //Console.WriteLine("Pyramid:");
            //for (int i = 1; i <= n; i++)                                     //      i = 1; i <= n; i++
            //{
            //    for (int j = 1; j <= n - i; j++)                             //      j = 1; j <= n - i; j++
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)                         //       k = 1; k <= 2 * i - 1; k++
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("");
            //Console.WriteLine("Diamond:");
            //for (int i = 1; i <= n; i++)                                     //       i = 1; i <= n; i++
            //{
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)                         //       k = 1; k <= 2 * i - 1; k++
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n - 1; i >= 1; i--)                                 //        i = n - 1; i >= 1; i--
            //{
            //    for (int j = 1; j <= n - i; j++)                             //        j = 1; j <= n - i; j++
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)                         //         k = 1; k <= 2 * i - 1; k++
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //==============================================================================================================================================



          
          //     Console.Write("Enter N (less than 20): ");
          //     int N = int.Parse(Console.ReadLine());
          //
          //     if (N <= 0 || N >= 20)
          //     {
          //         Console.WriteLine("Invalid input! N must be between 1 and 19.");
          //         return;
          //     }
          //
          // 
          // for (int i = 1; i <= N; i++)
          // {
          //     int num = i;
          //
          //     
          //     for (int j = 1; j <= N; j++)
          //     {
          //         Console.Write(num + " ");
          //         if (num < 10) 
          //             Console.Write(" ");
          //         num++;
          //     }
          //     Console.WriteLine();
          // }

























        // CF program:
        //int marks = 0, totalmarks = 0, counter = 0;
        //do
        //{
        //    Console.WriteLine(" Enter marks one by one. Enter -1 to finish: ");
        //    marks = Convert.ToInt32(Console.ReadLine());
        //    totalmarks += marks;
        //    counter++;
        //}
        //while (marks != -1);
        //int average = (totalmarks+1) / (counter-1);
        //Console.WriteLine(average);
















    }
}
}


