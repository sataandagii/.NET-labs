using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class Attendance
    {
        public User User { get; set; }//користувач
        public Course Course { get; set; }//курс
        public DateTime Date { get; set; }//дата відвідування
    }
}
