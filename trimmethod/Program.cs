using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trimmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string with a random zero in it");
            string line = Console.ReadLine();                              //user inputs string

            trim(line);                                                   //calls trim method using user input from above
        }

        //Trim method
        static void trim(string x)
        {
            string y = "";
            
            char[] unwanted = new char[]{'0','1', '2', '3', '4', '5', '6', '7', '8', '9' }; 

            if(x.Contains('0'))
            {
                y = x.Trim(unwanted);           //trims specific chars from char array 
                Console.WriteLine(y);           //prints the modified string  
            }
            else
            {
                Console.WriteLine("This string is OK!");
            }
            return;
        }
    }
}
