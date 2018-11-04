using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int StudentYear { get; set; }
        public double AverageRating{ get; set;}
        public Student(string name, int age, int studentYear, double averageRating)
        {
            Name = name;
            Age = age;
            StudentYear = studentYear;
            AverageRating = averageRating;
        }
    }
}
