using System.Collections.Generic;

namespace Grades.Model
{
    public class GradeBook
    {
        public void AddGrade(float grade)
        {
           grades.Add(grade);
        }

        List<float> grades;
    }
}
