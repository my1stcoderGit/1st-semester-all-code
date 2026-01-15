using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1st_semester_paractice
{
    //internal class Program
    //{
    //static void Main(string[] args)
    //{
    // SEARCHING AN ARRAY ELEMENT


    //    int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //    Console.WriteLine("PLease enter the num which you want to search:");
    //    int num = int.Parse(Console.ReadLine());
    //    for(int i=0; i<ints.Length; i++)
    //    {
    //        if (ints[i] == num)
    //        {
    //            Console.WriteLine($"That number {num} is found at index {i}");
    //        }
    //        else if (i == ints.Length - 1)
    //        {
    //            Console.WriteLine($"That number {num} doesnot found in this array.");
    //        }
    //    }



    // SORTING AN ARRAY


    //int[] ints = { 10, 2 , 8 ,9 , 7 };

    //try
    //{
    //    int temp = ints[0];
    //    for (int j = 0; j < ints.Length; j++)
    //    {
    //        for (int i = j + 1; i < ints.Length; i++)
    //        {
    //            if (ints[i] < temp)
    //            {
    //                temp = ints[i];
    //            }
    //        }
    //        ints[j] = temp;
    //    }
    //    for (int i = 0; i < ints.Length; i++)
    //    {
    //        Console.WriteLine(ints[i]);
    //    }
    //}
    //catch (System.Exception ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}
    //finally
    //{
    //    Console.WriteLine("The code is completed.");
    //}





    /*
                //NOTE: All arrays , lists and linkedLists are generic (elements should be same datatype) except ArrayList.

                // Simple Static Array
                int[] sim = new int[5];

                // Dense Array
                int[] dense = { 2, 3, 4, 5, 5, 6, };

                // Initialized Array
                int[] initia = new int[] { 1, 2, 3, };

                // Dynamic Array
                int[] dyn = new int[] { };

                // List
                List<int> list = new List<int>();

                // ArrayList
                ArrayList arrayList = new ArrayList();

                // LinkedList
                LinkedList<int> linked_list = new LinkedList<int>();
    */


    //}
    //}


    // STRUCTURE PARACTICE


    //struct mobilephone
    //{
    //    public int id;
    //    public string BrandName;
    //    public int price;
    //}
    //class program
    //{
    //    mobilephone m1;
    //    static void Main(string[] args)
    //    {
    //        List<mobilephone> mobrecord = new List<mobilephone>();
    //        input(mobrecord);
    //        Console.WriteLine("");
    //        display(mobrecord);
    //    }
    //    static void input(List<mobilephone> mobrecord)
    //    {
    //        bool iserror;
    //        do
    //        {
    //            try
    //            {
    //                for (int i = 1; i <= 3; i++)
    //                {
    //                    mobilephone m = new mobilephone();
    //                    Console.WriteLine($"Please enter the mobile ID of mobile {i}.");
    //                    m.id = int.Parse(Console.ReadLine());
    //                    Console.WriteLine($"Please enter the brand name of mobile {i}.");
    //                    m.BrandName = Console.ReadLine();
    //                    Console.WriteLine($"Please enter the price of mobile {i}.");
    //                    m.price = int.Parse(Console.ReadLine());
    //                    mobrecord.Add(m);
    //                    iserror = false;
    //                }
    //                break;
    //            }
    //            catch (System.Exception e)
    //            {
    //                Console.WriteLine(e.Message);
    //                iserror = true;
    //            }
    //        }
    //        while (iserror == true);
    //    }
    //    static void display(List<mobilephone> mobrecord)
    //    {
    //        Console.WriteLine("Mobile Phone Details");
    //        foreach(mobilephone mob in mobrecord)
    //        {
    //            Console.WriteLine($"The mobile id is {mob.id}.");
    //            Console.WriteLine($"The mobile brnad name is {mob.BrandName}.");
    //            Console.WriteLine($"The mobile price is {mob.price}.");
    //        }
    //    }
    //}




    //                                         ENUMERATORS PARACTICE
    // ==========================================================================

    //enum ResultStatus
    //{
    //    pass,
    //    fail,
    //    supply
    //}
    //struct student
    //{
    //    public int id;
    //    public string name;
    //    public ResultStatus resultstatus;
    //}
    //class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        List<student> list = new List<student>();
    //        input(list);
    //        Console.WriteLine("=======PRINTING THE STUDENTS DATA");
    //        output(list);
    //    }

    //    public static void input(List<student> list)
    //    {
    //        for (int i = 0; i < 2; i++)
    //        {
    //            student s = new student();
    //            Console.WriteLine($"Please enter the id of stuent {i + 1}.");
    //            s.id = int.Parse(Console.ReadLine());
    //            Console.WriteLine($"Please enter the name of stuent {i + 1}.");
    //            s.name = Console.ReadLine();
    //            Console.WriteLine($"Please enter the result status of student {i + 1}.");
    //            s.resultstatus = (ResultStatus)Enum.Parse(typeof(ResultStatus), Console.ReadLine().ToLower());
    //            list.Add(s);
    //        }
    //    }
    //    public static void output(List<student> list)
    //    {
    //        for (int i = 0; i < list.Count; i++)
    //        {
    //            Console.WriteLine($"The ID of Student {i + 1} is {list[i].id}");
    //            Console.WriteLine($"The name of Student {i + 1} is {list[i].name}");
    //            Console.WriteLine($"The result status of Student {i + 1 } is {list[i].resultstatus}");
    //            Console.WriteLine($"======================================================================");
    //            Console.WriteLine($"======================================================================");

    //        }

    //    }

    //}



    //                                         ENUMERATORS PARACTICE
    // ==========================================================================




    //class paractice
    //{
    //    enum enumname
    //    {
    //        sandwitch,
    //        pyaz
    //    }
    //    public static void Main(string[] args)
    //    {
    //    enumname variabe = (enumname)Enum.Parse(typeof(enumname), Console.ReadLine());
    //    }
    //}

    //                                         POINTERS PARACTICE
    // ==========================================================================


    //public class pointers
    //{
    //     unsafe public static void Main(string[] args)
    //    {
    //        int marks = 50;

    //            int* ptr;
    //            ptr = &marks;
    //        updatingmarks(ptr);
    //    }

    //    unsafe public static void updatingmarks(int *ptr)
    //    {
    //        *ptr = *ptr + 10;
    //        Console.WriteLine(*ptr);
    //    }
    //}


    //                                         CP PAPER CLO 2 PARACTICE
    // ==========================================================================

    // past paper question
    //class DemoRefandOut
    //{
    //    public static void Main(string[] args ) {
    //        int var1 = 2, var2;
    //        Console.WriteLine( "Original value of var1: {0}", var1 );
    //        Console.WriteLine( "Original value of var 2: uninitialized\n");
    //        CubeRef(ref var1);
    //        CubeOut(out var2 );
    //        Console.WriteLine( "Value of var1 after CubeRef: {0}", var1 );
    //        Console.WriteLine( "Value of var2 after CubeOut: {0}\n", var2);           // \n ka agar string ke shuru ma ho ga to is ka matlab ha keh aik line chor ke woh string likho or agr string ke aakhir ma ho ga to is ka matlab ha is string ke baad aik line choro.
    //        Cube(var1 );
    //        Cube(var2);
    //        Console.WriteLine( "Value of varl after Cube: {0}", var1 );
    //        Console.WriteLine( "Value of var2 after Cube: {0}", var2 );
    //    }
    //    static void CubeRef(ref int cube)
    //                {
    //            cube = cube * cube * cube;
    //    }

    //    static void CubeOut(out int cube)
    //                    {
    //                        cube = 3;
    //                        cube = cube * cube * cube;
    //    }

    //    static void Cube(int cube)
    //                        {
    //                cube = cube * cube * cube;

    //    }
    //}

    //                    Another paractice question form gpt

    //using System;

    //class PracticeRefOut
    //{
    //    public static void Main(string[] args)
    //    {
    //        int a = 5, b;

    //        Console.WriteLine("Original a: {0}", a);
    //        Console.WriteLine("Original b: uninitialized\n");

    //        IncrementRef(ref a);
    //        Console.WriteLine("After IncrementRef: a = {0}\n", a);

    //        DecrementOut(out b);
    //        Console.WriteLine("After DecrementOut: b = {0}\n", b);

    //        DoubleValue(a);
    //        Console.WriteLine("After DoubleValue: a = {0}", a);

    //        DoubleValue(b);
    //        Console.WriteLine("After DoubleValue: b = {0}", b);

    //        SquareRef(ref a);
    //        Console.WriteLine("After SquareRef: a = {0}", a);

    //        SquareOut(out b);
    //        Console.WriteLine("After SquareOut: b = {0}", b);
    //    }

    //    static void IncrementRef(ref int num)
    //    {
    //        num = num + 10;
    //    }

    //    static void DecrementOut(out int num)
    //    {
    //        num = 20;  // out parameter ko initialize karna zaroori hai
    //        num = num - 5;
    //    }

    //    static void DoubleValue(int num)
    //    {
    //        num = num * 2;
    //    }

    //    static void SquareRef(ref int num)
    //    {
    //        num = num * num;
    //    }

    //    static void SquareOut(out int num)
    //    {
    //        num = 4;
    //        num = num * num;       // here reassigning the b so the old value will be overwritten by the new assignment.
    //    }
    //}


    //                    Another paractice question form gpt

    //using System;

    //class AdvancedPractice
    //{
    //    public static void Main(string[] args)
    //    {
    //        int x = 8, y, z;

    //        Console.WriteLine("=== Step 1 ===");
    //        Console.WriteLine("Original x: {0}", x);

    //        // Method 1 - Using ref
    //        ProcessWithRef(ref x);
    //        Console.WriteLine("After ProcessWithRef(ref x): {0}", x);

    //        // Method 2 - Using out
    //        ProcessWithOut(out y);
    //        Console.WriteLine("After ProcessWithOut(out y): {0}", y);

    //        // Method 3 - Mixed
    //        ProcessWithInOut(x, out z);
    //        Console.WriteLine("After ProcessWithInOut(x, out z): {0}", z);

    //        Console.WriteLine("\n=== Step 2 ===");

    //        // Method 4 - Normal parameter
    //        int result1 = CalculateNormal(x);
    //        Console.WriteLine("CalculateNormal(x) returned: {0}", result1);
    //        Console.WriteLine("x is now: {0}", x);

    //        // Method 5 - Using ref
    //        int result2 = CalculateWithRef(ref x);
    //        Console.WriteLine("CalculateWithRef(ref x) returned: {0}", result2);
    //        Console.WriteLine("x is now: {0}", x);

    //        // Method 6 - With multiplier
    //        int result3 = CalculateWithMultiplier(x, 2);
    //        Console.WriteLine("CalculateWithMultiplier(x, 2) returned: {0}", result3);
    //        Console.WriteLine("x is now: {0}", x);

    //        Console.WriteLine("\n=== Final Values ===");
    //        Console.WriteLine($"x: {x}, y: {y}, z: {z}");
    //        Console.WriteLine($"Results: {result1}, {result2}, {result3}");       // ab yahan dekho yahan results dobara print hua hain. Yaad rahe keh aikbar hum kisi function ko kisi variable ma assign kr dain to pehli baar function jo value return kare ga wohi us variable ma store ho jaye gi phir agr us function ke attributes change bhi ho jain to bhi us valiable ki vohi value rahe gi jo function na pehli baar return ki thi or woh variable ma store ho gy thi.
    //    }

    //    // Method 1: Using ref
    //    static void ProcessWithRef(ref int num)
    //    {
    //        num = num + 5;
    //    }

    //    // Method 2: Using out
    //    static void ProcessWithOut(out int num)
    //    {
    //        num = 3;
    //        num = num * 4;
    //    }

    //    // Method 3: Mixed (different name/parameters)
    //    static void ProcessWithInOut(int input, out int output)
    //    {
    //        output = input * 2;
    //    }

    //    // Method 4: Normal parameter
    //    static int CalculateNormal(int num)
    //    {
    //        num = num - 2;
    //        return num * 3;
    //    }

    //    // Method 5: Using ref
    //    static int CalculateWithRef(ref int num)
    //    {
    //        num = num + 10;
    //        return num / 2;
    //    }

    //    // Method 6: With multiplier
    //    static int CalculateWithMultiplier(int num, int multiplier)
    //    {
    //        return num * multiplier;
    //    }
    //}



    //                    Another paractice question of CLO 2


    //struct student
    //{
    //    public int id;
    //    public string name;

    //    public static void hello()
    //    {

    //    }

    //}

    //enum foodtype
    //{
    //    cake,
    //    colddrink,
    //    Biryani
    //}

    /*
             	         Structure (struct)	                                                                     Enumeration (enum)

        Primary Purpose	Groups related data variables into a single unit.	                       Represents a fixed set of named integral constants.
        Members	Can contain fields, properties, methods, and constructors.	                       Contains only a list of named constants.

             WHEN TO USE:
         
         Structure: When you need a lightweight object with few fields (e.g., Point, Student, Book).
         
         Enum: When you have predefined options (e.g., Days, Colors, Status).

             */



    //                                         CP PAPER CLO 3 PARACTICE
    // =========================================================================================================

    /*b)By using 3 single dimension arrays, develop a C# application that will take daily expense detail [10]
      from the user and calculate the total weekly expense of Bahria University Karachi Campus. The
      overall weekly expenses are further categories as Generator's Diesel Expense, Entertainment Expense and Maintenance Expense which are stored in array. Also determine the maximum,
         minimum and average expense in each category.*/





    class clo3
    {
        //    public static void Main(string[] args)
        //    {
        //        int[] diesel = new int[7];
        //        int[] entertainment = new int[7];
        //        int[] maintainance = new int[7];

        //        input( diesel,  entertainmnet,  maintainance);
        //        maxmin( diesel,  entertainment,  maintainance);

        //    }
        //    public static void input( int[] diesel, int[] entertainment, int[] maintainance)
        //    {
        //        int dieseltotal = 0; int entertainmenttotal = 0; int maintainancetotal = 0;
        //        double dieselavg = 0; double entertainmentavg = 0; double maintainanceavg = 0;
        //        for (int i = 0; i < 7; i++)
        //        {
        //            Console.WriteLine($"Please enter the Generator's Diesel Expense of day {i + 1}.");
        //            diesel[i] = int.Parse(Console.ReadLine());
        //            Console.WriteLine($"Please enter the Entertainment Expense of day {i + 1}.");
        //            entertainment[i] = int.Parse(Console.ReadLine());
        //            Console.WriteLine($"Please enter the Maintenance Expense of day {i + 1}.");
        //            maintainance[i] = int.Parse(Console.ReadLine());
        //            dieseltotal += diesel[i];
        //            entertainmenttotal += entertainment[i];
        //            maintainancetotal += maintainance[i];
        //        }
        //        dieselavg = dieseltotal / 7;
        //        entertainmentavg = entertainmenttotal / 7;
        //        maintainanceavg = maintainancetotal / 7;
        //        Console.WriteLine($"Diesel average expanse is {dieselavg}");
        //        Console.WriteLine($"entertainment average expanse is {entertainmentavg}");
        //        Console.WriteLine($"maintainance average expanse is {maintainanceavg}");
        //    }
        //    public static void maxmin( int[] diesel,  int[] entertainment,  int[] maintainance)
        //    {
        //        Console.WriteLine($"Diesel maximum expanse is {diesel.Max()}");
        //        Console.WriteLine($"entertainment maximum expanse is {entertainment.Max()}");
        //        Console.WriteLine($"maintainance maximum expanse is {maintainance.Max()}");

        //        Console.WriteLine($"Diesel minimum expanse is {diesel.Min()}");
        //        Console.WriteLine($"entertainment minimum expanse is {entertainment.Min()}");
        //        Console.WriteLine($"maintainance minimum expanse is {maintainance.Min()}");
        //    }
        //}




        /* Q:- mujah aik baat samajh nahi aay yahan ma na teeno aarays ko call by value kiya ha to inputs to saara input walla method ma ke apna arrays ma hi store honga main method wala array ma to nahi honga na to phir maxmin method ma main method ke arrays ko as attributes dalne pr maxmin method na sahi input kaisa dia !

        Answer: Aapka sawal bahut hi behtareen hai! Ye aksar naye programmers ko confuse karta hai.
                Iska jawab ye hai: C# mein Arrays "Reference Types" hote hain, "Value Types" nahi.
                Jab aap int ya bool ko method mein bhejte hain, to wo Call by Value hota hai (yaani copy jati hai). Lekin jab aap ek Array ko method mein bhejte hain, to technically array ka Reference (memory address) pass hota hai.

         Q:- Sare ke sare collection variables by default reference type Hote Hain kya?

        Answer: Ji haan, bilkul sahi pakda aapne! C# mein sari Collections (Arrays, Lists, Dictionaries, etc.) by default Reference Types hi hoti hain.
               C# mein memory do hisson mein divide hoti hai: Stack aur Heap.
               Value Types (int, bool, double) ki value direct Stack par store hoti hai.
               Reference Types (Arrays, Lists, Classes) ka data Heap par store hota hai, aur Stack par sirf uska address (reference) hota hai.


        */



        //               CLO 3 PART b another paractice question

        /*
         
        By using 3 single dimension arrays, develop a C# application that will take daily expense details for 7 days from the user and calculate the total weekly expense of a University Hostel.

The overall weekly expenses are further categorized as:

                                    Mess Food Expense

                                    Electricity Expense

                                    Cleaning & Maintenance Expense

Each category’s daily expenses must be stored in a separate array.

The program should also determine and display:

                                    Total expense of each category

                                    Maximum expense in each category

                                    Minimum expense in each category

                                    Average expense in each category
         
         */



        public static void Main(string[] args)
        {
            int[] mess = new int[7];
            int[] electricity = new int[7];
            int[] maintainance = new int[7];

            int messtot = 0;
            int electot = 0;
            int maintot = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Please enter the mess expense of day {i + 1}.");
                mess[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Please enter the electricity expense of day {i + 1}.");
                electricity[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Please enter the maintainance expense of day {i + 1}.");
                maintainance[i] = int.Parse(Console.ReadLine());
                messtot += mess[i];
                electot += electricity[i];
                maintot += electot;

            }
            double avgmess = avg(messtot);
            double avgelc = avg(electot);
            double avgmain = avg(maintot);
            Console.WriteLine();
            Console.WriteLine($"The ");
        }
            public static double avg(int total)
        {
            return total / 7;
        }





        






















        /*
         a)
        By using methods, develop C# application that will calculate and generates the monthly electricity [15]
        bill for residential and commercial consumers. The calculation should be based on the following
        formula and rules provided below.
        Formula:
        1) BillingAmt = Unit_charges + Elec_Duty + Icome_Tax + TV_Lin_Fee
        2) Unit_Charges = Units * Per_Unit_cost

                                                           For Residential

        TV License Fee:       Rs. 35/-
        Electricity Duty:    1.5% of billing amount





         */



        //    public static double unitcharges(char type , int units)
        //    {
        //        double perunitcost;
        //       if (type == 'r')
        //        {
        //            if (units < 300)
        //            {
        //                perunitcost = 12.55;
        //            }
        //            else if (units >= 300 && units <= 700)
        //            {
        //                perunitcost = 19.76;
        //            }
        //            else
        //            {
        //                perunitcost = 23.87;
        //            }
        //        }
        //       else
        //        {
        //            if (units < 400)
        //            {
        //                perunitcost = 24.66;
        //            }
        //            else
        //            {
        //                perunitcost = 29.14;
        //            }
        //        }
        //        return units * perunitcost;
        //    }
        //    public static double elecduty(char type, double charges)
        //    {
        //        double duty;
        //        if (type == 'r')
        //        {
        //            duty = charges * 1.5 / 100;
        //        }
        //        else
        //        {
        //            duty = charges * 2 / 100;
        //        }
        //        return duty;
        //    }
        //    public static double incometax(char type, double charges)
        //    {
        //        double incometax;
        //        if (type == 'r')
        //        {
        //            if (charges < 25000)
        //            {
        //                incometax = 0 / 100;
        //            }
        //            else
        //            {
        //                incometax = charges * 7.5 / 100;
        //            }
        //        }
        //        else
        //        {
        //            if (charges < 500)
        //            {
        //                incometax=0 / 100;
        //            }
        //            else if (charges >= 501 && charges <= 20000)
        //            {
        //                incometax = charges * 10 / 100;
        //            }
        //            else
        //            {
        //                incometax = 1950 + (charges * 12 / 100);
        //            }
        //        }
        //        return incometax;
        //    }
        //    public static double billingamount(double charges ,double duty ,double tax , int tvfee)
        //    {
        //        double billingamount = charges + duty + tax + tvfee;
        //        return billingamount;
        //    }



        //    public static void Main( String[] args )
        //    {
        //        int tvfee = 35;
        //        Console.WriteLine("Please enter the number of units:");
        //        int units = int.Parse ( Console.ReadLine() );
        //        Console.WriteLine("Please enter r if you are residential consumer and c for commercial consumer: ");
        //        char type = char.Parse( Console.ReadLine().ToLower() );
        //        double charges = unitcharges(type, units);
        //        double duty = elecduty(type, charges);
        //        double tax = incometax(type, charges);
        //        double amount = billingamount(charges , duty , tax , tvfee);

        //        Console.WriteLine();
        //        Console.WriteLine("====PRINTING BILL====");
        //        Console.WriteLine();
        //        Console.WriteLine($"Unit charges : {charges}");
        //        Console.WriteLine($"Electricity duty : {duty}");
        //        Console.WriteLine($"Income Tax : {tax}");
        //        Console.WriteLine($"TV liscense fee : {tvfee}");
        //        Console.WriteLine($"Billing Amount : {amount}");

        //    }




        //                    ANOTHER QUESTION


















    }



























}
