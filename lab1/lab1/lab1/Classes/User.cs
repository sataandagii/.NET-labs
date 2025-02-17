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
    }
}
