using System;
using Grades.Model;

namespace Grades
{
    public class Program
    {
        static void Main(string[] args)
        {
            var book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(89.9f);

            Console.ReadKey();
        }
    }
}
