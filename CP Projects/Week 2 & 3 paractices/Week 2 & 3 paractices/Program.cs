using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Week_2___3_paractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7. Write a C# progrma for the random numbers between 1 & 10?

            //Random random = new Random();
            //int random_number = random.Next(1, 11);
            //Console.WriteLine("The random number b/w 1 & 10 is:" + random_number);


            //=================================================================================================

            // 8. Write a program for the toss of two countries and also ask winner to choose what it wants ?

            //Console.WriteLine("Choose your country:");
            //string country = Console.ReadLine();
            //Random random = new Random();
            //int toss = random.Next(0, 2);
            //Console.WriteLine("Select 1 for head & 0 for tail");
            //int guess = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The toss is :" + toss + ".");
            //if (guess == 0 && toss == 0) { Console.WriteLine("Conratulations you won"); }
            //else if (guess == 1 && toss == 1) { Console.WriteLine("Conratulations you won"); }
            //else { Console.WriteLine("You loss"); }






            //=======================================================================================================

            // 9. Generate a random number between 1 & 6 for the runs of next ball and then ask the user
            // how much runs will be obtained in the next ball?

            //Random random1 = new Random();
            //int runs = random1.Next(1, 7);
            //Console.WriteLine("Guess the runs for the next ball:");
            //int guess = Convert.ToInt32(Console.ReadLine());
            //if (guess == runs) { Console.WriteLine("Congraulations you won."); }
            //else if (guess != runs) { Console.WriteLine("Sorry but you loss."); }
            //Console.WriteLine("So the runs obtained in the next ball is:" + runs + ".");




            //========================================================================================================

            // 10. Generate a simple calculator which peforms basic +, - . * , / calculations by using if /else statements?

            // int num1 , num2 , result = 000000  ; char opera;
            // Console.WriteLine("Please enter the first number: ");
            // num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Please enter the second number: ");
            // num2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Please enter the operator: ");
            // opera = Convert.ToChar(Console.ReadLine());
            //
            // if (opera == '+')
            // { result = num1 + num2;
            //     Console.WriteLine("Your answer is " + result + ".");
            // }
            // else if (opera == '-') 
            // {   result = num1 - num2;
            //     if (result < 0) 
            //     { result = result * -1;
            //         Console.WriteLine("Your answer is " + result + ".");
            //     }
            //
            // }
            // else if (opera == '/') 
            // { if (num2 == 0)
            //     { Console.WriteLine("Infinite Answer."); }
            //     else
            //     {
            //         result = num1 / num2;
            //         Console.WriteLine("Your answer is " + result + ".");
            //     }
            // }
            // else { Console.WriteLine("invalid input."); }




            //=========================================================================================================

            //11. Generate a simple calculator which peforms basic +, - . * , / calculations by using switch case statements?

            //int num1, num2, result ; char opera;
            //Console.WriteLine("Please enter the first number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the second number: ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the operator: ");
            //opera = Convert.ToChar(Console.ReadLine());
            //
            //
            //switch (opera)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine(($"Your result is: {result}"));
            //        break;
            //    case '-':
            //        result = num1 - num2 ;
            //        if (result < 0) { result = result * -1; }
            //        Console.WriteLine($" Your ansmer is: {result}");
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine($"Your answer is: {result}");
            //        break;
            //    case '/':
            //        if (num2 == 0) { Console.WriteLine("Infine answer"); }
            //        result = num1 / num2;
            //        Console.WriteLine(($"Your answer is: {result}"));
            //        break;
            //    default: Console.WriteLine("Invalid Input.");
            //        break;
            //}

            //==========================================================================================================

            //12. Write a C Sharp Program Which gives the discount of 2% to the retailer , 1% to the registered customer
            //and no discount to the random customer.

            // Console.WriteLine("Please enter your buying amount:");
            // int amount = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Please enter 1 , 2 and 3 if you are retailer, register customer and random customer respectively:");
            // int Custype = Convert.ToInt32(Console.ReadLine());
            //
            // switch (Custype)
            // {
            //     case 1: Console.WriteLine("You got 2 % discount and your total amount is:" + (amount - amount * 2 / 100)); break;
            //     case 2: Console.WriteLine("You got 1 % discount and your total amount is:" + (amount + amount * 1 / 100)); break;
            //     case 3: Console.WriteLine("You got no discount so your total amount is:"); break;
            // }






            //Similarly write a C Sharp Program for 3% discount of all three customers .

            //Console.WriteLine("Please enter your buying amount:");
            //int amount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter 1 , 2 and 3 if you are retailer, register customer and random customer respectively:");
            //int Custype = Convert.ToInt32(Console.ReadLine());
            //
            //switch (Custype)
            //{
            //    case 1: 
            //    case 2: 
            //    case 3:
            //        Console.WriteLine("You got 3 % discount and your total amount is:" + (amount - amount * 3 / 100));
            //        break;
            //}





            //13. Write a program that verifies MVS Membership verification system based on the following conditions this year must be >= 10 
            // OR / AND We abound must be >= 50000. If Both of these / anyone condition are / is true Display MVS verified otherwise 
            //display MVS not verified.







            //14. Write a program that uses a for loop to print any word 10 times. After the loop finishes display the message done printing.
            //And then ask user if he want to continue or not. Also write a simple program using while.

            //char rep;
            //do
            //{
            //    for (int no = 0; no <= 10; no++) 
            //    { Console.WriteLine("Hallo word"); }
            //    Console.WriteLine();
            //    Console.WriteLine("Done printing.");
            //    Console.WriteLine("If you want to continue then press y , if no then press n.");
            //    rep = Convert.ToChar(Console.ReadLine()); char.ToLower(rep);
            //    if  ( rep == 'n')
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("The program is end");
            //    }
            //}
            //
            //while (rep == 'y' || rep =='Y');
            //
            //
            //
            //char rep;
            //Console.WriteLine("If you want to print hallo word 10 times than press y if not then press n.");
            //rep = Convert.ToChar (Console.ReadLine());
            //rep = char.ToLower (rep);
            //if (rep == 'n')
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("The program is end");                               // Also we can do it by using while (true) and break inside the loop on any condition.
            //}                                                                          // which is more simple , easy and efficient.
            //while (rep == 'y')                                                       
            //{
            //    for (int count = 0; count < 10; count++)
            //    {
            //        Console.WriteLine("Hallo word");
            //    }
            //
            //    Console.WriteLine("If you want to print hallo word 10 times than press y if not then press n.");
            //    rep = Convert.ToChar(Console.ReadLine()); rep = char.ToLower(rep);
            //    if (rep == 'n')
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("The program is end");
            //    }
            //}




            //15. Take input for the monthly expense of a year Add calculate average monthly expenses using for loop and give
            //the expression for that year by comparing average expense to the salary.









            //16. Write a program for the progress of three classes in mid exams using while loop .include only 5 students of each class


















            //17. Write a program using a while loop that repeatedly asks the user to enter a number and checks whether the number is even
            //or odd. After each check asked the user if they want to enter another number.If the user types 'y' the loop continues otherwise
            //the program stops.


            //int even = 0 , odd=0;  char reply;
            //
            //
            //
            //do
            //{
            //    Console.WriteLine("Please enter any number:");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num % 2 == 0) { even++; }
            //    else if (num % 2 != 0) { odd++; }
            //    Console.WriteLine($"Total Even are {even} , Total odd are {odd}");
            //    Console.WriteLine();
            //    Console.WriteLine("If you want to continue press y.");
            //    reply = Convert.ToChar(Console.ReadLine());
            //    reply = Char.ToLower(reply);
            //}
            //while (reply == 'y');
            //
            //Console.WriteLine("The program is ended.");
            //Console.WriteLine($"And the total Even are {even} , Total odd are {odd}");



           



        }
    }
}
