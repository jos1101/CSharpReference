using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    // if not public, internal, meaning it can only be used by that project
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public double HighestGrade()
        {
            return grades.Max();
        }
        public double LowestGrade()
        {
            return grades.Min();
        }
        public double AverageGrade()
        {
            return grades.Sum() / grades.Count;
        }
        private List<double> grades;
        public string Name;
    }
}
