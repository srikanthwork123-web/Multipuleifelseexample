using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multipuleifelseexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IF ELSE IF EXAMPLE STARTED");
            //datatype variablename;  //we called this as variable decalartion
            int score;//variable declartion
            Console.WriteLine("enter score number");//this statement is used to print the data
            score = int.Parse(Console.ReadLine());//this statement is read the data from the commandprompt and assign to score variable
            if (score >= 90)
            {
                Console.WriteLine("You got an A.");
            }
            else if (score >= 80)
            {
                Console.WriteLine("You got a B.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("You got a C.");
            }
            else if (score < 60)
            {
                Console.WriteLine("You  are failed");
            }
            else
            {
                Console.WriteLine("You need to improve your score.");
            }
           
            Console.ReadLine();
        }
    }
}
