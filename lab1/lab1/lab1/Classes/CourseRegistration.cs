using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
    public class CourseRegistration
    {
        public User User { get; set; }// Посилання на користувача
        public Course Course { get; set; }// Посилання на курс
        public List<TestResult> TestResults { get; set; }// Результати тестів
        public double CompletionPercentage { get; set; }// Відсоток проходження курсу
    }
}
