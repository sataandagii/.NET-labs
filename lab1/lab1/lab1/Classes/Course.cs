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
        public string Title { get; set; }
        public List<Test> Tests { get; set; }//список тестів курсу
        public DateTime CreatedDate { get; set; }//дата створення курсу

    }
}
