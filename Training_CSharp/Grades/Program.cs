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

            // book2 = new GradeBook(); -->> book2 = 75
            var book2 = book; //-->> book2 = [91, 89.9f] 
            book2.AddGrade(75);

            Console.ReadKey();
        }
    }
}
