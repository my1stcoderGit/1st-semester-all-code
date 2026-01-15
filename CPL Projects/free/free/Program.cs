using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace free
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Order of square matrix");
            int ord = Convert.ToInt32(Console.ReadLine());
            for (int rows = 1; rows <= ord; rows++)
            {
                for (int cols = rows; cols < rows + ord; cols++)
                {

                    Console.Write(cols + " ");
                }
                Console.WriteLine();
            }



            //for (int row = 5; row >= 1; row--)
            //{
            //    for (int space = 5; space > row; space--)
            //    { Console.Write(" "); }
            //    for (in star = 1; star <= 3; star++)
            //    { Console.Write("*"); }
            //    Console.WriteLine();
        }
    }
}

