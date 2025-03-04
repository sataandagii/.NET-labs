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
        public List<CourseRegistration> registrations { get; set; }
        public List<Attendance> Attendances { get; set; }
    }
}
