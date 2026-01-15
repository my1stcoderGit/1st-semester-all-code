using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your name");
            //String name = Console.ReadLine();
            //Console.WriteLine("Please enter your Father name");
            //String Fname = Console.ReadLine();
            //Console.WriteLine("Please enter your phone no");
            //int no = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter your designation");
            //String Des = Console.ReadLine();
            //Console.WriteLine("Please enter your date of hiring");
            //DateTime hiring = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("Please enter your salary");
            //int salary = Convert.ToInt32(Console.ReadLine());
            //
            //
            //Console.WriteLine("              YOUR INFORMATION                ");
            //Console.WriteLine("              -----------------               ");
            //Console.WriteLine("                                                  ");
            //Console.WriteLine($"Your name is                        : {name} ");
            //Console.WriteLine($"Your father name is                 : {Fname}");
            //Console.WriteLine($"Your phone no is                    : {no} ");
            //Console.WriteLine($"Your designation is                 : {Des} ");
            //Console.WriteLine($"Your Salary is                      : {salary} ");



            //Console.WriteLine("please enter your product name : ");
            //string pname = Console.ReadLine();
            //Console.WriteLine("please enter your product weight in kg and also should contain more than two decimals : ");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("please enter your product price which also contain more than two decimals : ");
            //double price = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("                                                ");
            //Console.WriteLine("                                                ");
            //Console.WriteLine($" The rounded weight to two decimal place is : {Math.Round( weight , 2)}");
            //Console.WriteLine($" The rounded price to two decimal place is : {Math.Round(price, 2)}");



            //Console.WriteLine("Enter the name of first employ : ");
            //string name1 = Console.ReadLine();
            //Console.WriteLine("Enter the salary of first employ : ");
            //int salary1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the name of second employ : ");
            //string name2 = Console.ReadLine();
            //Console.WriteLine("Enter the salary of second employ : ");
            //int salary2 = Convert.ToInt32(Console.ReadLine());
            //
            //
            //Console.WriteLine("                                        ");
            //Console.WriteLine("                                        ");
            //Console.WriteLine("                        INFORMATION                        ");
            //Console.WriteLine("                       -------------                        ");
            //Console.WriteLine("  {0,20} {1,20}",  " Name "   ,    " Slary ");
            //Console.WriteLine("  {0,20} {1,20}", "  ---- ", "       ----- ");
            //Console.WriteLine( " {0,20} {1,20} ", $" {name1} " , $" {salary1} ");
            //Console.WriteLine( " {0,20} {1,20} ", $" {name2} " , $" {salary2} ");




            //Console.WriteLine("Please enter the first item :");
            //string item1 = Console.ReadLine();
            //Console.WriteLine("Please enter the Second item :");
            //string item2 = Console.ReadLine();
            //Console.WriteLine("Please enter the third item :");
            //string item3 = Console.ReadLine();
            //Console.WriteLine("Please enter the quantity of first item :");
            //int quan1 = int.Parse(Console.ReadLine());                                    
            //Console.WriteLine("Please enter the quantity of Second item :");
            //int quan2 = Convert.ToInt32( Console.ReadLine());                                    
            //Console.WriteLine("Please enter the quantity of third item :");
            //int quan3 = Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Please enter price of the first item :");
            //int price1 = Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Please enter price of the Second item :");
            //int price2 = Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Please enter price of the third item :");
            //int price3 = Convert.ToInt32( Console.ReadLine());
            //
            //
            //
            //
            //
            //Console.WriteLine("  {0,10} {1,10} {2,10} "   ,  " ITEMS "   ,  " QUANTITIES " ,   " PRICE ");
            //Console.WriteLine("---------------------------------------------------------------------------");
            //Console.WriteLine( " {0,10} {1,10} {2,10} "   ,    item1     ,    quan1  ,           price1);
            //Console.WriteLine("---------------------------------------------------------------------------");
            //Console.WriteLine(  "{0,10} {1,10} {2,10} "   ,    item2     ,    quan2  ,           price2  );                               
            //Console.WriteLine("---------------------------------------------------------------------------");
            //Console.WriteLine(  "{0,10} {1,10} {2,10} "   ,    item3     ,    quan3 ,             price3   );   
            //


            Console.WriteLine("                             Date:_________  ");
            Console.WriteLine("             KFC RESTAURANT  ");
            Console.WriteLine("               CASH-BILL  ");
            Console.WriteLine("          Branch : Bahadurabad  ");
            Console.WriteLine("                                                                ");
            Console.WriteLine("  {0,6} {1,12} {2,5} {3,6} {4,8} "  ,  "S.N"  , "Name of item"  , "Qty"  , "Rate"    ,  "Amount" );
            Console.WriteLine("  {0,6} {1,12} {2,5} {3,6} {4,8} "  ,    1    ,  "water"        ,   4    ,   20      ,    4*20   );
            Console.WriteLine("  {0,6} {1,12} {2,5} {3,6} {4,8} "  ,    2    ,  "Pizzza"       ,   1    ,   1500    ,    1500   );
            Console.WriteLine("  {0,6} {1,12} {2,5} {3,6} {4,8} "  ,    3    ,  "Burger"       ,   1    ,   200     ,    200    );
            Console.WriteLine("  {0,6} {1,12} {2,5} {3,6} {4,8} "  ,    4    ,  "Biryani"      ,   1    ,   350     ,    350    );
            Console.WriteLine("  {0,6} {1,12} {2,5} {3,6} {4,8} "  ,    5    ,  "Rayta"        ,   2    ,   10      ,    10*2   );
            Console.WriteLine($"                               Total     {4 * 20 + 1500 + 200 + 350 + 18 * 2  } " );



        }
    }
}
