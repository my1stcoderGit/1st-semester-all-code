using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" What is your name ?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name + " welcome to the program.");



            //int b = 10; int c = 20; int a = 5; int d =30 ; int y = 35; int z = 25; int x = 40;
            //Console.WriteLine(b * c / 2 + a * b / 2 - 3 * a * c*c);
            //Console.WriteLine(9 * a * b - 3 * d * d * 3 * y / 4 + 3 * d * d * a / 4);
            //Console.WriteLine(3 * x * y + 34 * z - x * 3 * y + x * 67 * z);




            //Console.WriteLine("Enter your roll number:");
            //Console.ReadLine();
            //Console.WriteLine("Enter your name:");
            //Console.ReadLine();
            //Console.WriteLine("Enter your marks of CP out of 100:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your marks of CF out of 100:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your marks of AP out of 100:");
            //int c = Convert.ToInt32(Console.ReadLine());
            //int total = a + b + c;
            //Console.WriteLine("Your total marks are: " + (total));
            //Console.WriteLine("Your percentage is: " + (total * 100 / 300) + "%");




            //Console.WriteLine("Please enter the temperature in celsius: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The equivalent temperature in kelvin is:" + (c + 273) + " K");
            //Console.WriteLine("The equivalent temperature in Fahrenheit is:" + (c * 1.8 + 32) + " F");





            Console.WriteLine("Please enter the base of a right-angled triangle:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the perpendicular of a right-angled triangle:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Hypotenuse of that right-angled triangle is :" + (Math.Sqrt(b * b + p * p)));
            Console.WriteLine("");

        }
    }
}
