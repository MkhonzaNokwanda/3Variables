using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _3Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string name;
            string lastname;
            int age;

            //initializing variables
            name = "Kwandenhle";
            lastname = "Mudau";
            age = 5;

            //print to screen
            Console.WriteLine("Hi " + name + " " + lastname);
            Console.WriteLine("You are " + age);

            //Change the values of the variables
            name = "Nono";
            age = 10;

            Console.WriteLine("She never liked her name so she changed it to " + name + " at " + age);
            //freeze to console
            Console.ReadLine();
        }
    }
}
