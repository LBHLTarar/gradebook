using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Lia's Grade Book");
            book.AddGrade(84.6);
            book.AddGrade(78.8);
            book.AddGrade(91.5);
            book.ShowStatistics();
        }
    }
}
