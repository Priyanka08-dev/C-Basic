using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your name");
            string myname = Console.ReadLine();
            Console.WriteLine(myname);
            Console.WriteLine("Enter your Age");
            int myage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myage);
            string result = (myage >= 20) ? "eligible to vote" : "Not";
            Console.WriteLine(result);
            if (myage >= 18)
            {
                Console.WriteLine("Eligible to vote");
            }
            else {
                Console.Write("not eligible");
            }
        }
    }
}
