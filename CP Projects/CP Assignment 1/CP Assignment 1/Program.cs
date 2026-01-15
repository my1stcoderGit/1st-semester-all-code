using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CP_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program that checks if a given number is prime. 

            //Console.WriteLine("Enter the number");
            //int no = Convert.ToInt32(Console.ReadLine());
            //if (no <= 3 && no > 1) { Console.WriteLine("The number is prime"); }
            //else
            //{
            //    int num, rem = 0;
            //    for (num = 2; num <= Math.Sqrt(no); num++)
            //    {
            //
            //        rem = no % num;
            //        if (rem == 0) break;
            //    }
            //    if (rem == 0)
            //    {
            //        Console.WriteLine("The number is not prime.");
            //    }
            //    else if (rem != 0) { Console.WriteLine("The number is prime"); }
            //
            //}




            //2.Write a program that returns the number of days in a given month and year, considering
            //leap years(A year may be a leap year if it is evenly divisible by 4.Years that are divisible
            //by 100(century years such as 1900 or 2000) cannot be leap years unless they are also
            //divisible by 400)). 
            //
            //Console.WriteLine("Please enter the year:");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the month:");
            //int month = Convert.ToInt32(Console.ReadLine());
            //
            //
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("There are 31 days in this month");
            //        break;
            //    case 2:
            //        int rem = year % 400;
            //        if (rem == 0)
            //        { Console.WriteLine("There are 29 days in this month"); }
            //        else
            //        {
            //            Console.WriteLine("There are 28 days in this month");
            //        }
            //        break;
            //    case 3:
            //        Console.WriteLine("There are 31 days in this month");
            //        break;
            //    case 4:
            //        Console.WriteLine("There are 30 days in this month");
            //        break;
            //    case 5:
            //        Console.WriteLine("There are 31 days in this month");
            //        break;
            //    case 6:
            //        Console.WriteLine("There are 30 days in this month");
            //        break;
            //    case 7:
            //        Console.WriteLine("There are 31 days in this month");
            //        break;
            //    case 8:
            //        Console.WriteLine("There are 30 days in this month");
            //        break;
            //    case 9:
            //        Console.WriteLine("There are 31 days in this month");
            //        break;
            //    case 10:
            //        Console.WriteLine("There are 30 days in this month");
            //        break;
            //    case 11:
            //        Console.WriteLine("There are 31 days in this month");
            //        break;
            //    case 12:
            //        Console.WriteLine("There are 30 days in this month");
            //        break;
            //    default :
            //        Console.WriteLine("invalid input");
            //    break;
            //}
            //





            //3.Write a C# program to check whether a triangle can be formed with the given values for 
            //the angles. [Hint: Sum of angle = 180] 


            //Console.WriteLine("Enter the first angle of triangle:");
            //int angle1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second angle of triangle:");
            //int angle2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the third angle of triangle:");
            //int angle3 = Convert.ToInt32(Console.ReadLine());
            //
            //
            //if ( angle1 + angle2 + angle3  == 180)
            //{
            //    Console.WriteLine("Yes the triangle can be formed");
            //}
            //else { Console.WriteLine("NO the triangle cant be formed by these three angles"); }
            //



            //4.Create a program that calculates the Body Mass Index(BMI) and classifies it(underweight,
            //normal, overweight, obese).



            //Console.WriteLine("Please enter your Weight in Kg:");
            //int Weight = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter your height in m:");
            //int height = Convert.ToInt32(Console.ReadLine());
            //
            //int BMI = Weight / height*height;
            //
            //if  (BMI >= 18  && BMI <= 24)
            //{
            //    Console.WriteLine("Its normal");
            //}
            //else if (BMI < 18 )
            //{
            //    Console.WriteLine("Its Underweight");
            //}
            //else if (BMI >= 25 && BMI <= 29)
            //{
            //    Console.WriteLine("Its Overwight");
            //}
            //else if (BMI >= 30)
            //{
            //    Console.WriteLine("Its normal");
            //}




            //5.Write a c# program to check if given triangle is equilateral, isosceles or scalene. 

            //Console.WriteLine("Enter the first side of triangle:");
            //int side1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second side of triangle:");
            //int side2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the third side of triangle:");
            //int side3 = Convert.ToInt32(Console.ReadLine());
            //
            //
            //if (side1 == side2 && side2 == side3 && side3 == side1) { Console.WriteLine("The trianlge is equilateral."); }
            //else if (side1 != side2 && side2 != side3 && side3 != side1) { Console.WriteLine("The trianlge is Scalene."); }
            //else if (side1 == side2 && side2 != side3 && side1 != side3 || side1 != side2 && side2 == side3 && side1 != side3 || side1 != side2 && side2 != side3 && side1 == side3) { Console.WriteLine("The trianlge is isosceles."); }









            //6.Implement a program that checks the balance and allows withdrawal or deposit based on
            //user input.

            //int balance = 50000, withdrawl, deposit ;
            //
            //Console.WriteLine("Write W for withdraw or d for deposit the amount");
            //char will = Convert.ToChar(Console.ReadLine());
            //will = char.ToUpper(will);
            //
            //
            //if (will == 'W')
            //{
            //
            //
            //
            //
            //    Console.WriteLine("Enter the amount which you want to withdraw");
            //    withdrawl = Convert.ToInt32(Console.ReadLine());
            //
            //    if (withdrawl > balance) { Console.WriteLine("sorry you does not have enough balance in your account."); }
            //    else
            //    {
            //        Console.WriteLine("Withdrawl successful");
            //    }
            //
            //}
            //else if (will == 'D')
            //{
            //    Console.WriteLine("Enter the amount which you want to deposit");
            //    deposit = Convert.ToInt32(Console.ReadLine());
            //
            //    if (deposit > 50000) { Console.WriteLine("sorry you does not have enough balance in your account."); }
            //    else
            //    {
            //        Console.WriteLine(" successfully deposited");
            //    }
            //}




            //7.National Defense Finance Corporation, Pakistan has started saving schemes where they are
            //offering two options, one with 5 years fixed deposit where the interest rate is 9.5 %.In
            //second option, client will get monthly interest amount with 7.5 % per year.By using switch
            //statement, write a c# program that will calculate the total amount after 5 years for option one
            //and monthly amount in option 2 for the provided user input amount.


            //double amount, total, monthlyInterest;
            //int option;
            //
            //Console.WriteLine("Choose your option, write 1 for 5 Years Fixed Deposit 9.5% interest per year & 2 for Monthly Interest Scheme 7.5% interest per year ");
            //option = Convert.ToInt32(Console.ReadLine());
            //
            //Console.Write("Enter the amount you want to invest: ");
            //amount = Convert.ToDouble(Console.ReadLine());
            //
            //switch (option)
            //{
            //    case 1:
            //        total = amount + (amount * 9.5 / 100 * 5);
            //        Console.WriteLine($"Total amount after 5 years will be: Rs. {total}");
            //        break;
            //
            //    case 2:
            //        monthlyInterest = (amount * 7.5 / 100) / 12;
            //        Console.WriteLine($"You will get Rs. {monthlyInterest} per month as interest.");
            //        break;
            //
            //    default:
            //        Console.WriteLine("Invalid option! Please select 1 or 2.");
            //        break;
            //}












            //8.Write a program that checks if a given credit card number is valid using the Luhn
            //algorithm.

            //Working of Luhn Algorithm Works
            //a) Starting from the rightmost digit(the check digit), double the value of every
            //second digit.
            //b) If doubling a digit result in a number greater than 9, subtract 9 from the result.
            //c) Sum all the digits(both those that were doubled and those that were not). 
            //d) Check if the total modulo 10 is equal to 0.If it is, the number is valid according to
            //the Luhn formula; otherwise, it is invalid.



            /* Example of luhn algorithm:
             
            Let's take the number 49927398713.                         [ NOTE : the .Length of this num is 11.]
            Double every second digit (starting from the right):
            3 (not doubled)
            1 * 2 = 2
            7 (not doubled)
            8 * 2 = 16 (becomes 1 + 6 = 7)
            9 (not doubled)
            3 * 2 = 6
            2 (not doubled)
            9 * 2 = 18 (becomes 1 + 8 = 9) 
            9 (not doubled)
            4 (not doubled) 
            Sum all the digits:
            3 + 2 + 7 + 7 + 9 + 6 + 2 + 9 + 9 + 4 = 58 
            Check the result:
            58 is not divisible by 10, so the number is invalid.*/


            //int digit, sum = 0;
            //
            //Console.WriteLine("Please enter the credit card number");
            //string no = Console.ReadLine();
            //
            //for (int i = no.Length - 1; i >= 0; i--) 
            //{
            //    digit = Convert.ToInt32(no[i].ToString());
            //
            //    if ((no.Length - i) % 2 == 0)
            //    {
            //        digit *= 2;
            //
            //        if (digit > 9)
            //        {
            //            digit = (digit /10 ) + (digit % 10);
            //        }
            //
            //    }
            //    sum += digit;
            //}
            //if (sum % 10 == 0)
            //{
            //    Console.WriteLine("This is valid credit card");
            //}
            //else if (sum % 10 != 0)
            //{
            //    Console.WriteLine("This is invalid credit card");
            //}
            //

            // Check gpt archive for the explanation of this code.












            //9.By using switch statement, write a c# program to calculate the total hospital bill for tests 
            //performed at PNS Shifa Hospital, Where a discount of 55 % is offered to Naval employees,
            //35 % to students and 45 % for employees of the hospital.

            //Console.WriteLine("Please enter your total bill:");
            //int bill = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please write n if you are naval employee , s for students and h for hospital employees:");
            //char category = Convert.ToChar(Console.ReadLine());
            //category= char.ToLower(category);
            //
            //switch (category)
            //{
            //    case 'n':
            //        Console.WriteLine($"You got 55% discount and your final bill is  {bill - (bill * 55 / 100)}" );
            //        break;
            //    case 's':
            //        Console.WriteLine($"You got 35% discount and your final bill is  {bill - (bill * 35 / 100)}");
            //        break;
            //    case 'h':
            //        Console.WriteLine($"You got 45% discount and your final bill is  {bill - (bill * 45 / 100)}");
            //        break;
            //}



            //10.Write a program that calculates the discount on a purchase based on the amount spent.
            //Use following guidelines
            //a) 0 % discount for purchases less than Rs. 5000
            //b) 2.5 % discount for purchases between Rs. 5000 and Rs. 10000
            //c) 5 % discount for purchases between Rs. 10000 and Rs. 20000
            //d) 7.5 % discount for purchases over Rs. 20000

            //Console.WriteLine("Please enter the amount you spent:");
            //int spentamo = Convert.ToInt32(Console.ReadLine());
            //
            //if (spentamo < 5000 ) { Console.WriteLine("Your discount is 0"); }
            //else if (spentamo > 5000 && spentamo <= 10000) { Console.WriteLine("Your discount is Rs " + spentamo * 2.5 / 100); }
            //else if (spentamo > 10000 && spentamo <= 20000) { Console.WriteLine("Your discount is Rs " + spentamo * 5 / 100); }
            //else if (spentamo > 20000) { Console.WriteLine("Your discount is Rs " + spentamo * 7.5 / 100); }
            //




        }
    }
}

