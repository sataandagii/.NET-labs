using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class User
    {
        public string Name { get; set; }
        public double AverageGrade { get; set; }
        public double AttendancePercentage { get; set; }
        public List<Course> CompletedCourses { get; set; }
        public Dictionary<Course, double> TestResults { get; set; }

        public void CalculateAverageGrade()
        {
            if (TestResults.Count > 0)
            {
                // Средний балл по всем курсам
                AverageGrade = TestResults.Values.Average();
            }
            else
            {
                AverageGrade = 0;
            }
        }
    }
}
