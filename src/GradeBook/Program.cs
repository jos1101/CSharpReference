using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("James' Gradebook");
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            Console.WriteLine($"The average grade is {book.AverageGrade()}\nTheLowestGrade is {book.LowestGrade()}\nThe Highest Grade is {book.HighestGrade()}");
            
        }
    static void OnGradeAdded(object sender, EventArgs e)
    {
        System.Console.WriteLine("A grade was added");
    }
    }
}
