using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            // accept two numbers from user & ask for operation
            // 1 add , 2 sub , 3 multiply  4 div  5  mod
            // based on user selection display the output
            Console.WriteLine("1. for Eng");
            Console.WriteLine("2. for Hindi");
            Console.WriteLine("3. for Marathi");
            Console.WriteLine("select your option");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("You have selected Eng lang");
                break;
                case 2:
                    Console.WriteLine("You have selected Hindi lang");
                break;
                case 3:
                    Console.WriteLine("You have selected Marathi lang");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
