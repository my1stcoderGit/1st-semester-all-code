using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPL_Methods___Recursion
{
    internal class Program
    {


        /*             
        Lab Tasks/Practical Work

1. Write a C# program that contains a method IsPalindrome(string input) to check if a given string is
a palindrome, returning true if it is and false otherwise, and in the Main method, take input from
the user and display the result.
         */


        //// Yeh function bool value return karta hai
        //static bool IsPalindrome(string input)
        //{
        //    int n = input.Length;
        //    for (int i = 0; i < n / 2; i++)
        //    {
        //        if (input[i] != input[n - 1 - i])           // actually palindrome is to compare i index with the last - i index but here it is n - 1 - i so why its not n - i because remember that the last index is n - 1 not n 
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
        // static void Main(string[] args)
        //{

        //    Console.WriteLine("Please enter the string which you want to check:");
        //    string inp_string = Console.ReadLine();

        //    // Function call ka result ek local variable 'isPalindromeResult' mein store kiya
        //    bool isPalindromeResult = IsPalindrome(inp_string);

        //    Console.WriteLine("Is Palindrome: " + isPalindromeResult);

        //}






        /*     2. Write a C# program that includes two methods: inputArray() which allows the user to input
    characters into an array, and checkVowelsAtOddPositions() which checks whether the characters
    at odd positions in the array are vowels.
             */





        //public static void Main(string[] args)
        //{
        //    inputArray();
        //    bool result = checkVowelsAtOddPositions();
        //    Console.WriteLine("Is there are vowels at odd positions: " + result);
        //}

        //static int n = 0;
        //static char[] inp_char;

        //static void inputArray()
        //{
        //    Console.Write("How much characters you want to enter? ");
        //    n = Convert.ToInt32(Console.ReadLine());

        //    inp_char = new char[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write("Please enter character " + i + ": ");
        //        inp_char[i] = Console.ReadLine().ToLower()[0];
        //    }
        //}

        //static bool checkVowelsAtOddPositions()
        //{
        //    for (int i = 1; i < n; i += 2)
        //    {
        //        if (inp_char[i] == 'a' || inp_char[i] == 'e' || inp_char[i] == 'i' || inp_char[i] == 'o' || inp_char[i] == 'u')
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}









        /*   3. Write a C# console application where the user selects a shape (rectangle, square, circle, triangle,
  or pentagon) to calculate its area, then inputs the required dimensions, and the program calculates
  and displays the area by calling relevant method for each shape. (Hint: use method over loading)
           */

        //public static double area(double length , double bredth)
        //{
        //    return length * bredth;
        //}
        //public static double area(double radius)
        //{
        //    return Math.PI * Math.Pow(radius, 2);
        //}

        //public static double pentagon(double apothem , double perimeter)
        //{
        //    return 0.5 * apothem * perimeter;
        //}

        //public static void Main(string[] args)
        //{
        //    double result = 0;

        //    Console.WriteLine("write the shape which you want to calculate the area of (square , rectangle , triangle, circle and pentagon).");
        //    string choice = Console.ReadLine();
        //    choice = choice.ToLower();

        //    if (choice == "square" || choice == "rectangle")
        //    {
        //        Console.WriteLine("Please enter the length");
        //        int length = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Please enter the width");
        //        int width = Convert.ToInt32(Console.ReadLine());
        //        result = area(length, width);

        //    }
        //    else if (choice == "triangle" )
        //    {
        //        Console.WriteLine("Please enter the length");
        //        int length = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Please enter the width");
        //        int width = Convert.ToInt32(Console.ReadLine());
        //        result = area(length, width) * 0.5;

        //    }
        //    else if (choice == "circle")
        //    {
        //        Console.WriteLine("Please enter the radius");
        //        int radius = Convert.ToInt32(Console.ReadLine());
        //        result = area(radius);

        //    }
        //    else if (choice == "pentagon")
        //    {
        //        Console.WriteLine("Please enter the perimeter");
        //        int perimeter = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Please enter the apothem");
        //        int apothem = Convert.ToInt32(Console.ReadLine());
        //        result = pentagon(apothem, perimeter);

        //    }
        //    Console.WriteLine("The area is "+result + " sq units");
        //}





        /*   4. Write a C# program that includes a recursive method calculateFactorial() to compute the factorial
  of a given positive integer, where the user inputs the integer, and the method returns the factorial
  result.
           */

        // Recursive method to calculate factorial
        //static long CalculateFactorial(int n)
        //{
        //    if (n == 0 || n == 1)   // Base case
        //        return 1;
        //    else
        //        return n * CalculateFactorial(n - 1);  // Recursive call
        //}

        //static void Main(string[] args)
        //{
        //    Console.Write("Enter a positive integer: ");
        //    int number;

        //    // Validate user input
        //    if (int.TryParse(Console.ReadLine(), out number) && number >= 0)      // tryparse darasal ek exception handling ha yeh pehla khud try kr ke check krta ha ek ya conversion possible ha yaa nahi agr hoti ha to woh true return krta ha our comma ke baad wala variable ma convert kr ke store kr deta ha agr nahi hoti to woh false return kare ga or usa comma ke baad waala variable ma store nahi kare ga. Is tarah yeh error ko handle kr leta ha.


        //    {
        //        long result = CalculateFactorial(number);
        //        Console.WriteLine($"Factorial of {number} is: {result}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input! Please enter a non-negative integer.");
        //    }
        //}







        /*  5. Write a C# program that includes a recursive method sumOfDigits() to compute the sum of the
    digits of a given non-negative integer, where the user inputs the number, and the method returns
    the sum of its digits
          */

     public static int sumofDigits(int number)
        {
            if (number == 0)   // Base case
                return 0;
            else
                return (number % 10) + sumofDigits(number / 10);  // Recursive case       // yahan logic yeh ha keh modulus 10 last digit return krta ha jubkeh division of any number us number ka last digit nikaal deta ha. Our base case ma yeh ha keh jis time number sirf aik digit ka reh jaye ga to woh 10 sa chota ho jaye ga to divide by 10 ki value points ma aay gi jo int ki wajah sa 0 ho jaye gi. So tab yeh zero return kar da ga our dobara recursion nahi kare ga.
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a non - negatie integer:");
            int.TryParse(Console.ReadLine() , out int number );
            if(number < 0)
            {
                Console.WriteLine("Invalid input please enter a non negative integer: ");
            }
            else
            {
                int result = sumofDigits(number);
                Console.WriteLine("The sum of digits is: " + result);
            }

        }



      
    

      


}
}
