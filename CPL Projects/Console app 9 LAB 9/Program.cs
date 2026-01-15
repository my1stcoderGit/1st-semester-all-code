using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        1. Write a C# program that takes two matrices from the user. Perform matrix addition, subtraction,
and multiplication on them, and display the results. */


        /*

                // Input matrix dimensions
                Console.Write("Enter number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                Console.Write("Enter number of columns: ");
                int cols = int.Parse(Console.ReadLine());

                int[,] matrix1 = new int[rows, cols];
                int[,] matrix2 = new int[rows, cols];

                // Input first matrix
                Console.WriteLine("Enter elements of first matrix:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix1[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                // Input second matrix
                Console.WriteLine("Enter elements of second matrix:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix2[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                // Matrix Addition
                Console.WriteLine("Matrix Addition:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write((matrix1[i, j] + matrix2[i, j]) + "\t");
                    }
                    Console.WriteLine();
                }

                // Matrix Subtraction
                Console.WriteLine("Matrix Subtraction:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write((matrix1[i, j] - matrix2[i, j]) + "\t");
                    }
                    Console.WriteLine();
                }

                // Matrix Multiplication
                // For multiplication, number of columns in matrix1 must equal rows in matrix2
                Console.WriteLine("Matrix Multiplication:");
                int[,] result = new int[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = 0;
                        for (int k = 0; k < cols; k++)
                        {
                            result[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                        Console.Write(result[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                */





        /*2. Create a C# program that accepts details for N users (where N must be greater than 10), including
        their name, nationality, and eye color. The program should display the most common eye color for
        each nationality. */

        /*    Console.WriteLine("Eye Color Program");
               Console.WriteLine("=================");


               int n;
               Console.Write("Enter number of users (must be more than 10): ");
               n = int.Parse(Console.ReadLine());


               if (n <= 10)
               {
                   Console.WriteLine("Error! Number must be greater than 10.");
                   Console.ReadKey();
                   return;
               }

               // Create arrays to store data
               string[] names = new string[n];
               string[] nationalities = new string[n];
               string[] eyeColors = new string[n];

               // Get user details
               Console.WriteLine("\nEnter details for " + n + " users:");
               Console.WriteLine("--------------------------------");

               for (int i = 0; i < n; i++)
               {
                   Console.WriteLine("\nUser " + (i + 1) + ":");

                   Console.Write("Enter name: ");
                   names[i] = Console.ReadLine();

                   Console.Write("Enter nationality: ");
                   nationalities[i] = Console.ReadLine();

                   Console.Write("Enter eye color: ");
                   eyeColors[i] = Console.ReadLine();
               }

               // Find all different nationalities
               string[] differentNationalities = new string[n];
               int countDifferent = 0;

               for (int i = 0; i < n; i++)
               {
                   string currentNationality = nationalities[i];
                   int found = 0;

                   // Check if we already have this nationality
                   for (int j = 0; j < countDifferent; j++)
                   {
                       if (differentNationalities[j] == currentNationality)
                       {
                           found = 1;
                           break;
                       }
                   }

                   // If not found, add it
                   if (found == 0)
                   {
                       differentNationalities[countDifferent] = currentNationality;
                       countDifferent = countDifferent + 1;
                   }
               }

               Console.WriteLine("\nMost Common Eye Colors:");
               Console.WriteLine("======================");

               // For each nationality, find most common eye color
               for (int i = 0; i < countDifferent; i++)
               {
                   string currentNationality = differentNationalities[i];

                   // Count each eye color for this nationality
                   string[] colors = new string[n];
                   int[] colorCounts = new int[n];
                   int colorIndex = 0;

                   // Look at all users
                   for (int j = 0; j < n; j++)
                   {
                       if (nationalities[j] == currentNationality)
                       {
                           string currentColor = eyeColors[j];
                           int colorFound = 0;
                           int foundAt = -1;

                           // Check if we have this color already
                           for (int k = 0; k < colorIndex; k++)
                           {
                               if (colors[k] == currentColor)
                               {
                                   colorFound = 1;
                                   foundAt = k;
                                   break;
                               }
                           }

                           if (colorFound == 1)
                           {
                               // Color exists, increase count
                               colorCounts[foundAt] = colorCounts[foundAt] + 1;
                           }
                           else
                           {
                               // New color, add it
                               colors[colorIndex] = currentColor;
                               colorCounts[colorIndex] = 1;
                               colorIndex = colorIndex + 1;
                           }
                       }
                   }

                   // Find which color has highest count
                   int maxCount = 0;
                   string mostCommonColor = "";

                   for (int j = 0; j < colorIndex; j++)
                   {
                       if (colorCounts[j] > maxCount)
                       {
                           maxCount = colorCounts[j];
                           mostCommonColor = colors[j];
                       }
                   }

                   Console.WriteLine(currentNationality + ": " + mostCommonColor);
               }

               Console.WriteLine("\nProgram finished. Press any key to exit.");
               Console.ReadKey();
           */





        /*3. Develop a C# program that takes the number of items, their names, prices, and quantities as input from the user. Calculate the total price and apply discounts based on these conditions (use a 2D
        array for input): 
        a. If the user is from Bahria University, apply a 30% discount.
        b. If the total bill is between 50,000 and 100,000, apply a 20% discount.
        c. If the total bill exceeds 100,000, apply a 30% discount. */

      /* 

        Console.Write("Enter 1 if you are from Bahria University, else enter 0: ");
        int isBahria = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of items (max 100): ");
        int numItems = int.Parse(Console.ReadLine());
         string [,] itemname = new string [10,10];
        double [,] price = new double [10,10];
        int [,] quantity = new int [10,10];
        double totalPrice = 0;

        while (true)
        {
            int i =0;
            for ( int j = 0; j < numItems; j++)
            {
            Console.WriteLine($"Enter the {i},{j} item name: ");
            itemname[i,j] = Console.ReadLine();
            Console.WriteLine($"Enter the price of item {i},{j}: ");
            price[i,j] = double.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the quantity of item {i},{j}: ");
            quantity[i,j] = int.Parse(Console.ReadLine());
            totalPrice += price[i,j] * quantity[i,j];
            }
            Console.WriteLine("If there is no more items to add, enter -1 to exit");
            int will = int.Parse(Console.ReadLine());
            if (will == -1)
            {
                break;
            }
        }

        Console.WriteLine($"Total Price before discount: {totalPrice}");
        if (isBahria == 1)
        {
            totalPrice = totalPrice * 0.7;
            Console.WriteLine("30% discount applied for Bahria University student.");
        }
        else if (totalPrice >= 50000 && totalPrice <= 100000)
        {
            totalPrice = totalPrice * 0.8;
            Console.WriteLine("20% discount applied for bill between 50,000 and 100,000.");
        }
        else if (totalPrice > 100000)
        {
            totalPrice = totalPrice * 0.7;
            Console.WriteLine("30% discount applied for bill exceeding 100,000.");
        }
        else if (isBahria == 1 && totalPrice > 100000)
        {
            totalPrice = totalPrice * 0.4;
            Console.WriteLine("60% discount applied for total amount greater than 100000 and also being Bahria University student.");
        }
        else if (isBahria == 1 && totalPrice >= 50000 && totalPrice <= 100000)
        {
            totalPrice = totalPrice * 0.5;
            Console.WriteLine("50% discount applied for total amount between 50000 and 100000 and also being Bahria University student.");
        }
        Console.WriteLine($"Total Price after discount: {totalPrice}");

        */
        



 







        /*4. Write a C# program where the student enters the name of 5 subjects and the respective marks they
        obtained in each. The program should calculate and display the total marks, percentage, and grade.        */

          string[] subjects = new string[5];
          int[] marks = new int[5];
            int totalMarks = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter name of subject {i + 1}: ");
                subjects[i] = Console.ReadLine();
                Console.Write($"Enter marks obtained in {subjects[i]} out of 100: ");
                marks[i] = int.Parse(Console.ReadLine());
                totalMarks += marks[i];
            }
            double percentage = (totalMarks / 500.0) * 100;
            string grade;
            if (percentage >= 90)
            {
                grade = "A";
            }
            else if (percentage >= 80)
            {
                grade = "B";
            }
            else if (percentage >= 70)
            {
                grade = "C";
            }
            else if (percentage >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine($"Total Marks: {totalMarks}/500");
            Console.WriteLine($"Percentage: {percentage}%");
            Console.WriteLine($"Grade: {grade}");


    }
}