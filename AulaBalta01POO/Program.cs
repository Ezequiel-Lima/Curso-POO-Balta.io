using AulaBalta01POO.ContentContext;
using AulaBalta01POO.SubscriptionContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AulaBalta01POO
{
    internal class Program
    {
        static void Main(string[] argd)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre OOP", "csharp"));
            articles.Add(new Article("Artigo sobre OOP", "dotnet"));
            
            //foreach (var article in articles)
            //{
            //    Console.WriteLine(article.Id);
            //    Console.WriteLine(article.Title);
            //    Console.WriteLine(article.Url);
            //}

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos c#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var career = new Career("Especialista . NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem2 = new CareerItem(2, "Aprenda .Net", "", courseAspNet);
            var careerItem3 = new CareerItem(3, "OOP", "", null);
            career.Items.Add(careerItem2);
            career.Items.Add(careerItem3);
            career.Items.Add(careerItem);
            careers.Add(career);

            foreach (var item in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var itemx in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine(itemx.Order + " - " + itemx.Title);
                    Console.WriteLine(itemx.Course?.Title);
                    Console.WriteLine(itemx.Course?.Level);

                    foreach (var notification in itemx.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.Subscriptions.Add(payPalSubscription);

            Console.ReadKey();
        }
    }
}
