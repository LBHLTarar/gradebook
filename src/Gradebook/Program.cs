using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("The Secret");
            book.AddGrade(4.6);
            book.AddGrade(5.8);
            
            // List of double 
            var grades = new List<double>(){2.3, 6.4, 7.1} ;
            grades.Add(38.5);

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades)
            {  
                lowGrade = Math.Min(number,lowGrade);
                highGrade = Math.Max(number,highGrade);
                result += number/grades.Count;
            }
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}
