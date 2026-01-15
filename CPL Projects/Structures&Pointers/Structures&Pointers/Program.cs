using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_Pointers
{

    /*
     1. Design a program that manages the information of 5 employees using structures. The program
should prompt the user to input details for each employee, including their employee ID, name, date
of birth, email, residential address, job title, salary, and other relevant information. After collecting
the data for all 5 employees, the program should save these records and then print the details of
each employee. */


    using System;

    struct Employee
    {
        public int emp_id;
        public string name;
        public string dob;
        public string email;
        public string address;
        public string job_title;
        public float salary;
    }

    class Program
    {
        static void Main()
        {
            Employee[] emp = new Employee[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter details of Employee " + (i + 1));

                Console.Write("Employee ID: ");
                emp[i].emp_id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                emp[i].name = Console.ReadLine();

                Console.Write("Date of Birth: ");
                emp[i].dob = Console.ReadLine();

                Console.Write("Email: ");
                emp[i].email = Console.ReadLine();

                Console.Write("Address: ");
                emp[i].address = Console.ReadLine();

                Console.Write("Job Title: ");
                emp[i].job_title = Console.ReadLine();

                Console.Write("Salary: ");
                emp[i].salary = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("===== EMPLOYEE RECORDS =====");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Employee " + (i + 1));
                Console.WriteLine("ID: " + emp[i].emp_id);
                Console.WriteLine("Name: " + emp[i].name);
                Console.WriteLine("DOB: " + emp[i].dob);
                Console.WriteLine("Email: " + emp[i].email);
                Console.WriteLine("Address: " + emp[i].address);
                Console.WriteLine("Job Title: " + emp[i].job_title);
                Console.WriteLine("Salary: " + emp[i].salary);
            }

            Console.ReadLine();
        }
    }











    /*
     2. Design a program that takes two numbers as input and performs addition, subtraction,
     multiplication, and division on them. The program should use pointers to store and manipulate the
     numbers. After performing the operations, the program should print the values of the numbers, the
     results of the operations, and the memory addresses where the values are stored using pointers. */



    //class Program
    //{
    //    static unsafe void Main()
    //    {
    //        int a, b;

    //        Console.Write("Enter first number: ");
    //        a = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Enter second number: ");
    //        b = Convert.ToInt32(Console.ReadLine());

    //        // pointers
    //        int* p1 = &a;
    //        int* p2 = &b;

    //        int add = *p1 + *p2;
    //        int sub = *p1 - *p2;
    //        int mul = *p1 * *p2;
    //        float div = (float)*p1 / *p2;

    //        Console.WriteLine("--- Values ---");
    //        Console.WriteLine("First number: " + *p1);
    //        Console.WriteLine("Second number: " + *p2);

    //        Console.WriteLine("--- Results ---");
    //        Console.WriteLine("Addition: " + add);
    //        Console.WriteLine("Subtraction: " + sub);
    //        Console.WriteLine("Multiplication: " + mul);
    //        Console.WriteLine("Division: " + div);

    //        Console.WriteLine("--- Memory Addresses ---");
    //        Console.WriteLine("Address of first number: " + (int)p1);
    //        Console.WriteLine("Address of second number: " + (int)p2);

    //        Console.ReadLine();
    //    }
    //}













    /*
    3. Design a program to manage a Grocery Inventory where you need to take information for 5 grocery
    items. The details for each item include item_id, name, category, quantity, price, supplier,
    expiry_date, and other relevant information. The program should save all the records using
    structures and allow the use of pointers to access and manipulate the data. After collecting the
    information for all 5 items, the program should store and display the saved records.
           */


    //struct Grocery
    //{
    //    public int item_id;
    //    public string name;
    //    public string category;
    //    public int quantity;
    //    public float price;
    //    public string supplier;
    //    public string expiry_date;
    //}

    //class Program
    //{
    //    static unsafe void Main()
    //    {
    //        Grocery[] items = new Grocery[5];

    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine("Enter details for item " + (i + 1));

    //            Console.Write("Item ID: ");
    //            items[i].item_id = Convert.ToInt32(Console.ReadLine());

    //            Console.Write("Name: ");
    //            items[i].name = Console.ReadLine();

    //            Console.Write("Category: ");
    //            items[i].category = Console.ReadLine();

    //            Console.Write("Quantity: ");
    //            items[i].quantity = Convert.ToInt32(Console.ReadLine());

    //            Console.Write("Price: ");
    //            items[i].price = Convert.ToSingle(Console.ReadLine());

    //            Console.Write("Supplier: ");
    //            items[i].supplier = Console.ReadLine();

    //            Console.Write("Expiry Date: ");
    //            items[i].expiry_date = Console.ReadLine();
    //        }

    //        Console.WriteLine("===== STORED GROCERY RECORDS =====");

    //        fixed (Grocery* p = items)
    //        {
    //            for (int i = 0; i < 5; i++)
    //            {
    //                Console.WriteLine("Item " + (i + 1));
    //                Console.WriteLine("ID: " + p[i].item_id);
    //                Console.WriteLine("Name: " + p[i].name);
    //                Console.WriteLine("Category: " + p[i].category);
    //                Console.WriteLine("Quantity: " + p[i].quantity);
    //                Console.WriteLine("Price: " + p[i].price);
    //                Console.WriteLine("Supplier: " + p[i].supplier);
    //                Console.WriteLine("Expiry Date: " + p[i].expiry_date);
    //                Console.WriteLine("Memory Address: " + (int)&p[i]);
    //            }
    //        }

    //        Console.ReadLine();
    //    }
    //}















}

