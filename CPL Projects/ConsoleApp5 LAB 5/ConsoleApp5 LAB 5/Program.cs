using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_LAB_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int code;
           // Console.WriteLine("Please enter the code:");
           // code = Convert.ToInt32(Console.ReadLine());
           //
           // switch (code)
           // {
           //     case 1:
           //         Console.WriteLine("Standard method:");
           //         Console.WriteLine(" Your delivery time is 3 to 7 days.");
           //         break;
           //     case 2:
           //         Console.WriteLine("Express method:");
           //         Console.WriteLine(" Your delivery time is 1 to 2 days.");
           //         break;
           //     case 3:
           //         Console.WriteLine("Overnight method:");
           //         Console.WriteLine(" Your delivery time is next day.");
           //         break;
           //     default:
           //         Console.WriteLine("Invalid code");
           //         break;
           //                      }
            //-------------------------------------------------------------------------------------------------------------------------------------------

            // int num1, num2; char opera;
            // Console.WriteLine("Please enter the first number:");
            // num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Please enter the second number:");
            // num2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine ("Please enter the operator:");
            // opera = Convert.ToChar(Console.ReadLine());
            //
            // switch (opera)
            // {
            //     case '+':
            //         Console.WriteLine( $"The answer is : { num1 + num2}" );
            //         break;
            //
            //     case '*':
            //         Console.WriteLine($"The answer is : { num1 * num2}");
            //         break;
            //
            //     case '-':
            //         int res = num1 - num2;
            //         if (res < 0) { Console.WriteLine($"The answer is : {res * -1}"); }
            //         
            //         break;
            //
            //     case '/':
            //         if (num2 == 0) { Console.WriteLine($"The answer is infinity"); }
            //         else
            //         { Console.WriteLine($"The answer is : {num1 / num2}"); }
            //         break;
            // }
            //-----------------------------------------------------------------------------------------------------------------------------------------------

            // Console.WriteLine("Please enter the year:");
            // int year = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Please enter the month:");
            // int month = Convert.ToInt32(Console.ReadLine());
            //
            //
            // switch (month)
            // {
            //     case 1:
            //         Console.WriteLine("There are 31 days in this month");
            //         break;
            //     case 2:
            //         int rem = year % 400;
            //         if (rem == 0)
            //         { Console.WriteLine("There are 29 days in this month"); }
            //         else
            //         {
            //             Console.WriteLine("There are 28 days in this month");
            //         }
            //         break;
            //     case 3:
            //         Console.WriteLine("There are 31 days in this month");
            //         break;
            //     case 4:
            //         Console.WriteLine("There are 30 days in this month");
            //         break;
            //     case 5:
            //         Console.WriteLine("There are 31 days in this month");
            //         break;
            //     case 6:
            //         Console.WriteLine("There are 30 days in this month");
            //         break;
            //     case 7:
            //         Console.WriteLine("There are 31 days in this month");
            //         break;
            //     case 8:
            //         Console.WriteLine("There are 30 days in this month");
            //         break;
            //     case 9:
            //         Console.WriteLine("There are 31 days in this month");
            //         break;
            //     case 10:
            //         Console.WriteLine("There are 30 days in this month");
            //         break;
            //     case 11:
            //         Console.WriteLine("There are 31 days in this month");
            //         break;
            //     case 12:
            //         Console.WriteLine("There are 30 days in this month");
            //         break;
            //     default:
            //         Console.WriteLine("invalid input");
            //         break;
            // }


            //==================================================================================================================

            //Console.WriteLine("Please enter your no of units:");
            //int units = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter rate per unit:");
            //int rate = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please write d if you are domestic , i for industrial and c for commercial:");
            //char type = Convert.ToChar(Console.ReadLine());
            //type = char.ToLower(type);
            //
            //switch (type)
            //{
            //    case 'd':
            //        Console.WriteLine($"Your bill is {(units * rate ) +500 }");
            //        break;
            //    case 'i':
            //        Console.WriteLine($"Your bill is {(units * rate ) +1000 }");
            //        break;
            //    case 'c':
            //        Console.WriteLine($"Your bill is {(units * rate ) +5000}");
            //        break;
            //}


            //===================================================================================================================


            //Console.WriteLine("Please select a shape by entering a letter (C for Circle, R for Rectangle, T for Triangle, S for Sphere, P for Pyramid, H for Hexagon)");
            //char shape = Convert.ToChar(Console.ReadLine());
            //shape = Char.ToLower(shape);
            //
            //switch (shape)
            //{
            //    case 'c':
            //        Console.WriteLine("Please enter the radius of the circle: ");
            //        int r = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine($"The area of shape is {Math.PI * Math.Pow(r, 2)}");
            //        break;
            //    case 'r':
            //        Console.WriteLine("Please enter the breadth of the Rectangle: ");
            //        int b = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Please enter the length of the Rectangle: ");
            //        int l = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine($"The area of shape is {l * b}");
            //        break;
            //    case 't':
            //        Console.WriteLine("Please enter the height of the triangle: ");
            //        int h = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Please enter the length of the triangle: ");
            //        int Tl = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine($"The area of shape is {1 / 2 * Tl * h}");
            //        break;
            //    case 's':
            //        Console.WriteLine("Please enter the lenth of the square: ");
            //        int sl = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine($"The area of shape is {Math.Pow(sl, 2)}");
            //        break;
            //    case 'p':
            //
            //        Console.Write("Enter side length of the base (a): ");
            //        double a = double.Parse(Console.ReadLine());
            //
            //        Console.Write("Enter slant height (l): ");
            //        double pl = double.Parse(Console.ReadLine());
            //        double B = a * a;
            //        double P = 4 * a;
            //        double LSA = 0.5 * P * pl;
            //        double TSA = LSA + B;
            //
            //        Console.WriteLine($"Lateral Surface Area = {LSA}");
            //        Console.WriteLine($"Total Surface Area = {TSA}");
            //
            //
            //
            //        break;
            //    case 'h':
            //        Console.WriteLine("Please enter the side length of hexagon: ");
            //        int s = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine($"The area of shape is {3 / 2 * Math.Sqrt(3) * Math.Pow(s, 2)}");
            //        break;
            //    }
            //




            }
        }
    }
