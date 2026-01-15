using System;

class Program
{
    static void Main(string[] args)
    {
        /* 1.Write a c# program that will calculate the discount of a departmental store. The departmental 
 store has two types of customers:  
      1) Non-Registered customers  
      2) Registered customers  

 For registered customers, they are offering 5% discount if their monthly transaction is more than 
 Rs.100000 (use loop to calculate the total monthly amount) and 5.5% discount if their monthly 
 transaction is more than Rs.200000, otherwise they will get a discount of 3.5%.  

 For non-registered customers a 2% discount is available if the transaction amount is more than 
 50,000. */





           /* Console.WriteLine("=== Departmental Store Discount Calculator ===");
            Console.Write("Are you a registered customer? (yes/no): ");
            string customerType = Console.ReadLine().ToLower();


            if (customerType == "yes")
            {
                Console.Write("Enter number of transactions: ");
                int numTransactions = Convert.ToInt32(Console.ReadLine());
                decimal totalAmount = 0;

                for (int i = 1; i <= numTransactions; i++)
                {
                    Console.Write($"Enter transaction {i} amount (Rs.): ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    totalAmount += amount;
                }

                decimal discount = 0;
                if (totalAmount > 200000)
                    discount = 5.5m;
                else if (totalAmount > 100000)
                    discount = 5m;
                else
                    discount = 3.5m;

                decimal discountAmount = (totalAmount * discount) / 100;
                decimal finalAmount = totalAmount - discountAmount;

                Console.WriteLine($"\nTotal Monthly Transaction: Rs.{totalAmount}");
                Console.WriteLine($"Discount Rate: {discount}%");
                Console.WriteLine($"Discount Amount: Rs.{discountAmount}");
                Console.WriteLine($"Final Amount: Rs.{finalAmount}");
            }
            else
            {
                Console.Write("Enter transaction amount (Rs.): ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                decimal discount = amount > 50000 ? 2m : 0m;
                decimal discountAmount = (amount * discount) / 100;
                decimal finalAmount = amount - discountAmount;

                Console.WriteLine($"\nTransaction Amount: Rs.{amount}");
                Console.WriteLine($"Discount Rate: {discount}%");
                Console.WriteLine($"Discount Amount: Rs.{discountAmount}");
                Console.WriteLine($"Final Amount: Rs.{finalAmount}");
            }

    /*   2.Write a C# program that will manage patient records. By using loops and array it will take 
    input about patient’s details (name, age, symptoms) and display the details of all patients 
    admitted.        */

           /*Console.WriteLine("\t=== Patient Records Management ===");
           Console.Write("Enter number of patients: ");
           int numPatients = Convert.ToInt32(Console.ReadLine());

           string[] patientNames = new string[numPatients];
           int[] patientAges = new int[numPatients];
           string[] patientSymptoms = new string[numPatients];

           for (int i = 0; i < numPatients; i++)
           {
               Console.WriteLine($"Enter details for patient {i + 1}:");
               Console.Write("Name: ");
               patientNames[i] = Console.ReadLine();

               Console.Write("Age: ");
               patientAges[i] = Convert.ToInt32(Console.ReadLine());

               Console.Write("Symptoms: ");
               patientSymptoms[i] = Console.ReadLine();
           }

           Console.WriteLine("\n=== Patient Details ===\n");
           for (int i = 0; i < numPatients; i++)
           {
               Console.WriteLine($"Patient {i + 1}:");
               Console.WriteLine($"Name: {patientNames[i]}");
               Console.WriteLine($"Age: {patientAges[i]}");
               Console.WriteLine($"Symptoms: {patientSymptoms[i]}");
           }

   /*  3.You are supposed to develop a C# application that will implement a medication reminder 
   system that allows users to input medication schedules. Use loops to display reminders for 
   each medication.    */

        /*Console.WriteLine("\t=== Medication Reminder System ===");
         Console.Write("Enter number of medications: ");
         int numMedications = Convert.ToInt32(Console.ReadLine());

         string[] medicationNames = new string[numMedications];
         string[] medicationTimes = new string[numMedications];
         string[] medicationDosages = new string[numMedications];

         for (int i = 0; i < numMedications; i++)
         {
             Console.WriteLine($"Enter details for medication {i + 1}:");
             Console.Write("Medication Name: ");
             medicationNames[i] = Console.ReadLine();

             Console.Write("Time to take (HH:MM): ");
             medicationTimes[i] = Console.ReadLine();

             Console.Write("Dosage: ");
             medicationDosages[i] = Console.ReadLine();
         }

         Console.WriteLine("\t=== Medication Reminders ===");
         for (int i = 0; i < numMedications; i++)
         {
             Console.WriteLine($"Reminder {i + 1}:");
             Console.WriteLine($"Medication: {medicationNames[i]}");
             Console.WriteLine($"Time: {medicationTimes[i]}");
             Console.WriteLine($"Dosage: {medicationDosages[i]}\n");
         }

 /*   4.write a program that will generate the following output  
 Chapter 1 
   Section 1.1 
   Section 1.2 
   Section 1.3 
   Section 1.4 
   Section 1.5 

 Chapter 2 
   Section 2.1 
   Section 2.2 
   Section 2.3 
   Section 2.4 
   Section 2.5 

 Chapter 3 
   Section 3.1 
   Section 3.2 
   Section 3.3 
   Section 3.4 
   Section 3.5     */

           /* for (int chapter = 1; chapter <= 3; chapter++)
            {
                Console.WriteLine($"Chapter {chapter}");
                for (int section = 1; section <= 5; section++)
                {
                    Console.WriteLine($"  Section {chapter}.{section}");
                }
                Console.WriteLine();
            }

/*   5. Multiply Array1 with Array2 and stores its result in Array3. Apply matrix rules for multiplication 
    [RowN * ColN]. [Using loop]        */

        int[,] array1 = { { 3, 4, 5 }, { 6, 7, 9 }, { 5, 6, 8 } };

        int[,] array2 = { { 6, 4, 2, 4 }, { 5, 2, 3, 7 }, { 7, 6, 4, 8 } };

        int[,] array3 = new int[3, 4];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                array3[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    array3[i, j] = array3[i, j] + array1[i, k] * array2[k, j];
                }
            }
        }

        Console.WriteLine("Result of Array1 x Array2:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(array3[i, j] + "\t");
            }
            Console.WriteLine();
        }


    }
    }

