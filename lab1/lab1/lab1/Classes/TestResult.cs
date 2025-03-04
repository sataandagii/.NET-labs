using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class TestResult
    {
        public Test Test { get; set; }//посилання на тест
        public double Score { get; set; }//результат проходження
        public DateTime CompletedDate { get; set; }//дата складання
    }
}
