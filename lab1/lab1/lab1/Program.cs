using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace lab1.Classes
{
    class Program
    {
        
        static void GetAllUsers(List<User> users)
        {
            Console.WriteLine("Вивести всiх користувачiв");
            var result = from user in users select user;

            foreach(var row in result)
            {
                Console.WriteLine(row.ToString());
            }
        }

        static void Main(string[] args)
        {
            //питання для тестів
            var questionMath1 = new Question {
                QuestionText = "1+2?",
                Variants = new List<string> { "1", "4", "5" },
                CorrectAnswer = "3"
            };
            var questionMath2 = new Question
            {
                QuestionText = "10*2?",
                Variants = new List<string> { "15", "4", "45" },
                CorrectAnswer = "20"
            };
            var questionMath3 = new Question
            {
                QuestionText = "1000-7?",
                Variants = new List<string> { "900", "999", "950" },
                CorrectAnswer = "993"
            };


            var questionBio1 = new Question
            {
                QuestionText = "Який орган відповідає за перекачування крові в організмі людини?",
                Variants = new List<string> { "Печінка", "Серце", "Легені" },
                CorrectAnswer = "Серце"
            };

            var questionBio2 = new Question
            {
                QuestionText = "Яка речовина надає листю зелений колір?",
                Variants = new List<string> { "Хлоропласт", "Хлорофіл", "Глюкоза" },
                CorrectAnswer = "Хлорофіл"
            };

            var questionBio3 = new Question
            {
                QuestionText = "Хто з цих тварин є ссавцем?",
                Variants = new List<string> { "Крокодил", "Кит", "Черепаха" },
                CorrectAnswer = "Кит"
            };


            var questionAstro1 = new Question
            {
                QuestionText = "Яка планета Сонячної системи є найбільшою?",
                Variants = new List<string> { "Марс", "Юпітер", "Земля" },
                CorrectAnswer = "Юпітер"
            };

            var questionAstro2 = new Question
            {
                QuestionText = "Як називається найближча до нас зірка (окрім Сонця)?",
                Variants = new List<string> { "Альфа Центавра", "Полярна зірка", "Сіріус" },
                CorrectAnswer = "Альфа Центавра"
            };

            var questionAstro3 = new Question
            {
                QuestionText = "Що є причиною зміни пір року на Землі?",
                Variants = new List<string> { "Зміна відстані від Землі до Сонця", "Нахил земної осі", "Гравітація Місяця" },
                CorrectAnswer = "Нахил земної осі"
            };


            //тести
            var testMath = new Test
            {
                Name = "Тест з математики",
                Questions = new List<Question> { questionMath1, questionMath2, questionMath3 },
                PassingGrade = 50.0
            };

            var testBio = new Test
            {
                Name = "Тест з біології",
                Questions = new List<Question> { questionBio1, questionBio2, questionBio3 },
                PassingGrade = 35.0
            };

            var testAstro = new Test
            {
                Name = "Тест з астрономії",
                Questions = new List<Question> { questionAstro1, questionAstro2, questionAstro3 },
                PassingGrade = 60.0
            };

            //курси
            var courseMath = new Course
            {
                Name = "Математичний курс",
                Test = testMath,
                Students = new List<User>()
            };


            var courseBio = new Course
            {
                Name = "Бiлогiчний курс",
                Test = testMath,
                Students = new List<User>()
            };


            var courseAstro = new Course
            {
                Name = "Астрономiчний курс",
                Test = testMath,
                Students = new List<User>()
            };

            //список користувачів
            var users = new List<User>
            {
                new User
                {
                    Name = "Iван",
                    AverageGrade = 45,
                    AttendancePercentage = 90,
                    TestResults = new Dictionary<Course, double> { { courseMath, 0 }, { courseAstro, 0 } }
                },

                new User
                {
                    Name = "Аня",
                    AverageGrade = 60,
                    AttendancePercentage = 85,
                    TestResults = new Dictionary<Course, double> { { courseBio, 50 }, { courseAstro, 30 } }
                },

                new User
                {
                    Name = "Микола",
                    AverageGrade = 70,
                    AttendancePercentage = 95,
                    TestResults = new Dictionary<Course, double> { { courseMath, 0 }, { courseBio, 0 } }
                },

                new User
                {
                    Name = "Марина",
                    AverageGrade = 40,
                    AttendancePercentage = 80,
                    TestResults = new Dictionary<Course, double> { { courseAstro, 0 } }
                }
            };

            //додаємо студентів у список пройденого ними курсу
            foreach(var user in users)
            {
                foreach(var course in user.TestResults.Keys)
                {
                    course.Students.Add(user);
                    user.CompletedCourses.Add(course);
                }
            }

            GetAllUsers(users);
            
        }
    }
}