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
            // nesting of loop
            //*
            //**
            //***
            //*****
            // for loop

            for (int i = 1; i <=4; i++) // row
            {
                for (int j =1; j <=i; j++) // column
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
            }
        }
    }
}
