using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find the sum of the two numbers:
            //
            //int n1, n2;
            //Console.WriteLine("Enter the first no:");
            //n1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second no:");
            //n2 = Convert.ToInt32(Console.ReadLine());
            //
            //Console.WriteLine($"The sum of two numbers is : {n1 + n2} ");

            //----------------------------------------------------------------------------


            //Find if the no is odd or even:
            //
            //int num, reminder; 
            //Console.WriteLine("Please enter a number");
            //num = Convert.ToInt32(Console.ReadLine());
            //reminder = num % 2;
            //if (reminder == 0)
            //{ Console.WriteLine($"The number {num} is even "); }
            //else { Console.WriteLine($"The number {num} is odd "); }

            //------------------------------------------------------------------------------------

            //To find the greatest from the three input numbers:
            //
            //int n1, n2, n3; int greatest;
            //Console.WriteLine("Enter the first number :");
            //n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number :");
            //n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the third number :");
            //n3 = Convert.ToInt32(Console.ReadLine());
            //
            //if (n1 > n2 && n1 > n3)
            //{
            //    greatest = n1;
            //}
            //else if (n2 > n1 && n2 > n3)
            //{
            //    greatest = n2;
            //}
            //else 
            //{
            //    greatest = n3;
            //}
            //Console.WriteLine($"The greatest number is: {greatest} ");

            //-------------------------------------------------------------------------------------

            //To find the Lowest from the three input numbers:
            //
            //int n1, n2, n3, Lowest;
            //Console.WriteLine("Enter the first number :");
            //n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number :");
            //n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the third number :");
            //n3 = Convert.ToInt32(Console.ReadLine());
            //
            //if (n1 < n2 && n1 < n3) { Lowest = n1; }
            //else if (n2 < n1 && n2 < n3) { Lowest = n2; }
            //else;
            //{
            //    Lowest = n3;
            //
            //}
            //Console.WriteLine($"The lowest number is : {Lowest}");

            //-----------------------------------------------------------------------------------

            //Write a program that asks the user to enter marks of six subjects and then calculates the grade of the student.
            //
            //int m1, m2, m3, m4, m5, m6, per, obtainMarks; string grade;
            //Console.WriteLine("please enter the marks of subject 1 out of 100:");
            //m1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the marks of subject 2 out of 100:");
            //m2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the marks of subject 3 out of 100:");
            //m3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the marks of subject 4 out of 100:");
            //m4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the marks of subject 5 out of 100:");
            //m5 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the marks of subject 6 out of 100:");
            //m6 = Convert.ToInt32(Console.ReadLine());
            //
            //obtainMarks = m1 + m2 + m3 + m4 + m5 + m6;
            //per = obtainMarks * 100 / 600;
            //
            //if (per >= 90) { grade = "A+"; }
            //else if (per >=80 && per < 90) { grade = "A";}
            //else if (per >= 70 && per < 80) { grade = "B"; }
            //else if (per >= 60 && per < 70) { grade = "C"; }
            //else if (per >= 50 && per < 60) { grade = "D"; }
            //else if (per >= 40 && per < 50) { grade = "E"; }
            //else { grade = "F"; }
            //
            //Console.WriteLine($"Your percentage is : {per}");
            //Console.WriteLine($"Your grade is : {grade}");
            //
            //-----------------------------------------------------------------------------------

            //Q6.Write a program to input the maximum and minimum temperature of a day, calculate the average temperature,
            //and determine the weather condition.
            //
            //int maxt, mint, averaget; string wcondition;
            //Console.WriteLine("enter the max temp of the day: ");
            //maxt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the min temp of the day: ");
            //mint = Convert.ToInt32(Console.ReadLine());
            //
            //averaget = maxt / 2 + mint / 2;
            //if (averaget >= 45) { wcondition = "very hot"; }
            //else if (averaget > 35 && averaget < 45) { wcondition = "hot"; }
            //else if (averaget < 10 && averaget > 0) { wcondition = "hot"; }
            //else if (averaget <= 0) { wcondition = "very cold"; }
            //else { wcondition = "normal"; }
            //
            //Console.WriteLine($"The average temperature is : {averaget} ");
            //Console.WriteLine($"The weather condition is : {wcondition} ");



            //-----------------------------------------------------------------------------------

            //Q7.Write a program that asks the user to enter the expenses of 5 days, calculates the total and average
            //expense, and then uses an if statement to check whether the week was expensive or not.

            //int e1, e2, e3, e4, e5, totale, avge; string weekcond;
            //Console.WriteLine("Please enter the expense of day 1 if your monthly pocket money is approx 80000:");
            //e1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the expense of day 2 if your monthly pocket money is approx 80000:");
            //e2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the expense of day 3 if your monthly pocket money is approx 80000:");
            //e3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the expense of day 4 if your monthly pocket money is approx 80000:");
            //e4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the expense of day 5 if your monthly pocket money is approx 80000:");
            //e5 = Convert.ToInt32(Console.ReadLine());
            //
            //totale = e1 + e2 + e3 + e4 + e5;
            //avge = totale / 5;
            //
            //if (totale >= 2000) { weekcond = "the week was too expansive"; }
            //else if (totale >= 1900 && totale < 2000) { weekcond = "expansive"; }
            //else if (totale < 1900 && totale > 1500) { weekcond = "Good"; }
            //else if (totale <= 1500) { weekcond = "the week was too good"; }
            //else { weekcond = "normal"; }
            //
            //Console.WriteLine($"Your average expense was: {avge} ");
            //Console.WriteLine($"Your total expense was: {totale} ");
            //Console.WriteLine($"Your that week was: {weekcond} ");



            int vehicle, role, time, bhr = 0, repeat;
            int hours;
            double disc = 0, surcharge = 0, bill, totaldisc = 0, chargedamount, totalsurcharge;
            Console.WriteLine("BUKC PARKING MANAGEMENT SYSTEM\n");
            do
            {
                do
                {
                    Console.WriteLine("Enter one of the valid option according to your vehicle type:\n1 for Car\n2 for Motorbike\n3 for Truck");
                    vehicle = Convert.ToInt32(Console.ReadLine());
                    switch (vehicle)
                    {
                        case 1:
                            bhr = 50;
                            break;
                        case 2:
                            bhr = 30;
                            break;
                        case 3:
                            bhr = 80;
                            break;
                        default:
                            Console.WriteLine("Select A Valid Vehicle Type!\n");
                            break;
                    }
                } while (vehicle != 1 && vehicle != 2 && vehicle != 3);
                string vtype = vehicle switch
                {
                    1 => "Car",
                    2 => "Motorbike",
                    3 => "Truck"
                };
                do
                {
                    Console.WriteLine("Enter one of the valid option according to your type of user:\n1 for Director\n2 for Faculty\n3 for Staff\n4 for Visitor");
                    role = Convert.ToInt32(Console.ReadLine());
                    switch (role)
                    {
                        case 1:
                            disc = 1;
                            break;
                        case 2:
                            disc = 0.02;
                            break;
                        case 3:
                            disc = 0.05;
                            break;
                        case 4:
                            disc = 0;
                            break;
                        default:
                            Console.WriteLine("Select A Valid User Type!\n");
                            break;
                    }
                } while (role != 1 && role != 2 && role != 3 && role != 4);
                do
                {
                    Console.WriteLine("Enter one of the valid option according to time of parking:\n1 for Day\n2 for Night");
                    time = Convert.ToInt32(Console.ReadLine());
                    switch (time)
                    {
                        case 1:
                            surcharge = 0.2;
                            break;
                        case 2:
                            surcharge = -0.2;
                            break;
                        default:
                            Console.WriteLine("Select A Valid Time!\n");
                            break;
                    }
                } while (time != 1 && time != 2);
                Console.WriteLine("Enter number of hours the vehicle was parked (Minimum 1):");
                hours = Convert.ToInt32(Console.ReadLine());
                bill = bhr * hours;
                totaldisc = (bill * disc);
                totalsurcharge = bill * surcharge;
                chargedamount = bill - totaldisc + totalsurcharge;
                if (role == 1)
                {
                    disc = disc + chargedamount;
                    chargedamount = 0;
                }
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("                INVOICE");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Vehicle Type          : {vtype}");
                Console.WriteLine($"Base Hour Rate        : PKR {bhr}");
                Console.WriteLine($"Hours Parked          : {hours} Hours");
                Console.WriteLine($"Time Surcharge        : {totalsurcharge:f2}");
                Console.WriteLine($"Actual Billing Amount : PKR {bill:f2}");
                Console.WriteLine($"Discount Amount       : PKR {totaldisc:f2}");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Total Charged Amount : PKR {chargedamount:f2}");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("\nIs a new vehicle arriving:\n1 for Yes\n2 for No");
                repeat = Convert.ToInt32(Console.ReadLine());
            } while (repeat == 1);
            Console.WriteLine("Thanks for using BUKC PMS.");


            /*Fibonnaci Till  10
             int a = 0, b = 1, i, sum = 0;
            do
            {
                sum = a + b;
                if (sum <= 10)
                    Console.Write(sum + "  ");
                a = b;
                b = sum;
            } while (sum <= 10);*/
        }
    }
}



