using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace OEL
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  double currentbalance = 50000.67; int counter = 0;
          //
          //  string pininput = "";
          //  
          //  {
          //      Console.WriteLine("Please enter the correct pin :");
          //      pininput = Console.ReadLine();
          //      if (pininput != "1234")
          //      { Console.WriteLine("You entered wrong pin"); }
          // 
          // 
          //      else
          //      {
          //          Console.WriteLine("Choose the options from From the following:");
          //          Console.WriteLine("1. View Current Balance");
          //          Console.WriteLine("2. Make Deposit");
          //          Console.WriteLine("3. Request Withdrawl");
          //          Console.WriteLine("4. Terminate Session");
          //          String choice = Console.ReadLine();
          // 
          // 
          //          switch (choice)
          //          {
          //              case "View Current Balalce":
          //                  Console.WriteLine(currentbalance);
          //                  break;
          //              case "Make Deposit":
          //                  Console.WriteLine("Please enter the amount:");
          //                  double depamount = Convert.ToDouble(Console.ReadLine());
          //                  currentbalance += depamount;
          //                  Console.WriteLine("Successfully deposited");
          //                  break;
          //              case "Request Withdrawl":
          //                  Console.WriteLine("Please enter the amount:");
          //                  double Withamount = Convert.ToDouble(Console.ReadLine());
          //                  currentbalance -= Withamount;
          //                  break;
          //              case "Terminate Session":
          //                  Console.WriteLine("Exit.");
          //                  break;
          // 
          // 
          //          }
          //          Math.Round(currentbalance, 2);
          //          Console.WriteLine($"Now your current balance is {currentbalance}:");
          //      }
          //  }
          // 
          //



            //======================================================================

            Console.WriteLine("Please enter the value of 1st transaction:");
            double trans1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of 2nd transaction:");
            double trans2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of 3rd transaction:");
            double trans3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of 4th transaction:");
            double trans4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of 5th transaction:");
            double trans5 = Convert.ToDouble(Console.ReadLine());
            double greatest = 0;
            if (trans1 > trans2 && trans1 > trans3 && trans1 > trans4 && trans1 > trans5)
            { Console.WriteLine(greatest == trans1); }
            else if (trans2 > trans1 && trans2 > trans3 && trans2 > trans4 && trans2 > trans5)
            { Console.WriteLine(greatest == trans2); }
            else if (trans3 > trans2 && trans3 > trans1 && trans3 > trans4 && trans3 > trans5)
            { Console.WriteLine(greatest == trans3); }
            else if (trans4 > trans2 && trans4 > trans3 && trans4 > trans1 && trans4 > trans5)
            { Console.WriteLine(greatest == trans4); }
            else if (trans5 > trans2 && trans5 > trans3 && trans5 > trans4 && trans5 > trans1)
            { Console.WriteLine(greatest == trans5); }
            
            Console.WriteLine("This the highest " + greatest);









           
        }
    }
}



