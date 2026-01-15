using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        /*                                                      NOTES
                                                               
         
         So there are total four keywords for exception handling in c#
        1. try{doubted code .....}
        2. throw new <AnyExceptionClassWhichYouWillUseInCatch>(" exception message ");       // so your this manual exception will be added to that particular exception class. System.Exception class is recommended b/c it is the base class of all the system exceptions.
        3. catch (exception <excvarname>){ code to execute on this exception .... }
        4. finally { some mandatory code at last like completion meassege etc ... }
         */











        /*

         Lab Tasks/Practical Work

          1. Write a program that asks the user for a number and then calculates the square root of that number.
          If the user enters a negative number, handle the exception and display "Error: Cannot compute
          square root of a negative number."*/



        //static double sqrCalculator(int number)
        //{
        //    return Math.Sqrt(number);
        //}

        //static void Main(string[] args)
        //{
        //    int n = 0;
        //    try
        //    {
        //        Console.WriteLine("please enter a number:");
        //         n = int.Parse(Console.ReadLine());
        //        if (n < 0)
        //        {
        //            throw new Exception("Error: Cannot compute square root of a negative number.");
        //        }
        //        else
        //        {
        //            double result = sqrCalculator(n);
        //            Console.WriteLine("The square root of " + n +" is " +result + ".");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Program is end.");
        //    }

        //}





        /*

          2. Write a program that initializes an array of 5 integers. Ask the user to input an index to retrieve a
            value from the array. If the user enters a non-integer value for the index, catch the
            InputMismatchException and print an error message. If the user enters an invalid index (outside
            the array bounds), catch the ArrayIndexOutOfBoundsException. In the finally block, print "End of
            array access operation."*/






        //static void Main(string[] args)
        //{
        //    int[] integers = { 5, 4, 6, 7, 1 };      
        //    try
        //    {
        //        Console.WriteLine("Please to enter the index to get the value:");
        //        int ind = int.Parse(Console.ReadLine());
        //            Console.WriteLine($"The value at index {ind} is {integers[ind]}");


        //    }
        //    catch(System.Exception exc)               // In C#, System.Exception is the base class for all exceptions. It is part of the System namespace and is the as NullReferenceException, DivideByZeroException, IndexOutOfRangeException, etc.
        //    {
        //        Console.WriteLine(exc.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("End of array access operation.");
        //    }
        //}








        /*

3. Create a program that asks the user to input a temperature in Fahrenheit and converts it to Celsius.
If the input is not a valid number or the temperature is below absolute zero, handle the exception
with an error message. Allow the user to try again after an error.
*/

        public static double tempconv(double fahtemp)
        {
            return (fahtemp - 32) * (5.0 / 9.0);
        }



        static void Main(string[] args)
        {
            bool issuccess;
            do
            {
                try
                {
                    Console.WriteLine("Please enter the temperature in fahrenheit:");
                    double fah = double.Parse(Console.ReadLine());
                    if (fah < -459.67)
                    {
                        throw new System.Exception("The tempurature you entered is below the absolute temperature.");
                    }
                    double result = tempconv(fah);
                    Console.WriteLine($"Your temperature in celcius is {result}.");
                    issuccess = true;

                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    issuccess = false;
                }
            }
            while (issuccess == false);

        }










    }
}
