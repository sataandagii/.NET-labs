using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class Test
    {
        public Course Course { get; set; }//курс до якого належить тест
        public List<Question> Questions { get; set; }//список завдань
        public bool isFinalTest { get; set; }//чи є фінальним
    }
}
