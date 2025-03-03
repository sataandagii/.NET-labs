using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public List<Course> CompletedCourses { get; set; } = new List<Course>();
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

        public override string ToString()
        {
            return string.Format(@"Iм'я: {0}, Курси: {1}", Name, string.Join(", ", CompletedCourses));
        }
    }
}
