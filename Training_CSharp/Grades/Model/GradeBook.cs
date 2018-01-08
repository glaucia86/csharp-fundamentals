using System.Collections.Generic;

namespace Grades.Model
{
    public class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
           grades.Add(grade);
        }

        List<float> grades = new List<float>();
    }
}
