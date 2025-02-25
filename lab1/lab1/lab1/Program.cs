using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем несколько вариантов вопросов для тестов
            var question1 = new Question { QuestionText = "2 + 2?", Variants = new List<string> { "3", "4", "5" }, CorrectAnswer = "4" };
            var question2 = new Question { QuestionText = "3 * 3?", Variants = new List<string> { "6", "9", "12" }, CorrectAnswer = "9" };

            // Создаем тесты
            var test1 = new Test { Name = "Математика", Questions = new List<Question> { question1, question2 }, PassingGrade = 50 };

            // Создаем курсы
            var course1 = new Course { Name = "Математика", Test = test1, Students = new List<User>() };

            // Создаем пользователей
            var user1 = new User { Name = "Иван", AverageGrade = 45, AttendancePercentage = 90, TestResults = new Dictionary<Course, double> { { course1, 0 } } };
            var user2 = new User { Name = "Аня", AverageGrade = 60, AttendancePercentage = 85, TestResults = new Dictionary<Course, double> { { course1, 50 } } };
            var user3 = new User { Name = "Коля", AverageGrade = 70, AttendancePercentage = 95, TestResults = new Dictionary<Course, double> { { course1, 0 } } };
            var user4 = new User { Name = "Марина", AverageGrade = 40, AttendancePercentage = 80, TestResults = new Dictionary<Course, double> { { course1, 0 } } };

            // Пересчитываем средний балл для каждого пользователя
            user1.CalculateAverageGrade();
            user2.CalculateAverageGrade();
            user3.CalculateAverageGrade();
            user4.CalculateAverageGrade();

            // Добавляем студентов в курсы
            course1.Students.Add(user1);
            course1.Students.Add(user2);
            course1.Students.Add(user3);
            course1.Students.Add(user4);

            // Создаем список пользователей для запроса
            var users = new List<User> { user1, user2, user3, user4 };

            //запрос
            var result = users.Where(user => user.AttendancePercentage > 80); //&& user.TestResults.All(r => r.Value == 0)).ToList();

            // Выводим результат
            foreach (var user in result)
            {
                Console.WriteLine($"Пользователь: {user.Name}, Посещаемость: {user.AttendancePercentage}%, Средний балл: {user.AverageGrade}%");
            }

        }
    }
}