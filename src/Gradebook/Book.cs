using System.Collections.Generic;

namespace Gradebook
 {
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        } 
        static public void AddGrade(double grade)
        {
            grades.Add(grade);
        } 
 
        static private List<double> grades;
        private string name; 
    }

 }  