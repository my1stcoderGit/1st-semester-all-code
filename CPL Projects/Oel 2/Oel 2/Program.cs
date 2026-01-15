using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oel_2
{
    struct student
    {
        public string name;
        public double percentage;
        public char finalgrade;
    }


    struct submarks
    {
        public int first;
        public int mid;
        public int final;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<submarks> list = new List<submarks>();
            try
            {
                student s = new student();
                Console.WriteLine("Please enter the name of student.");
                s.name = Console.ReadLine();
                for (int i = 0; i <= 0; i++)
                {
                    submarks s1 = new submarks();
                    Console.WriteLine("Pease enter the marks of student in first assessment in subject 1 ");
                    s1.first = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pease enter the marks of student in mid assessment in subject 1");
                    s1.mid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pease enter the marks of student in final assessment in subject 1");
                    s1.final = int.Parse(Console.ReadLine());
                    list.Add(s1);
                    if (s1.first > 100 || s1.mid > 100 || s1.final > 100)
                    {
                        throw new System.Exception("Invalid marks please enter the marks out of 100");
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
