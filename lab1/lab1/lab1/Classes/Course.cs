using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab1.Classes
{
    public class Course
    {
        public string Name { get; set; }
        public Test Test { get; set; }
        public List<User> Students { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
