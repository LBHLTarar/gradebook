using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of double
            var grades = new List<double>(){2.3, 6.4, 7.1} ;
            grades.Add(3.5);

            var result = 0.0;

            foreach(var number in grades)
            {
                result += number/grades.Count;
            }
            Console.WriteLine($"The average grade is {result:N2}");


            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!"); 
            }
            else
            {
                Console.WriteLine("Hello");
            }  
        }
    }
}
