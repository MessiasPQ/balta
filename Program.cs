using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;
using Balta.NotificationContext;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre POO", "Programação orientada a objetos"));
            articles.Add(new Article("Artigo sobre C#", "Linguagem de programação"));
            articles.Add(new Article("Artigo sobre .NET", "Framework"));

            // foreach (var article in articles)
            // {
            //     System.Console.WriteLine("-----------------------------------------");
            //     System.Console.WriteLine(article.Title);
            //     System.Console.WriteLine(article.Url);
            //     System.Console.WriteLine(article.Id);
            // }


            var courses = new List<Course>();
            var coursePOO = new Course("Artigo sobre POO", "POO");
            var courseAspNet = new Course("Artigo sobre AspNet", "AspNet");
            courses.Add(courseAspNet);
            courses.Add(coursePOO);

            var careers = new List<Career>();
            var careerPOO = new Career("Especialista POO", "Especialista-POO");
            var careerItem = new CareerItem(1, "Começando por aqui.", "aqui", coursePOO);
            var careerItem2 = new CareerItem(2, "Terminando por aqui", "null", courseAspNet);
            careerPOO.Items.Add(careerItem2);
            careerPOO.Items.Add(careerItem);
            careers.Add(careerPOO);

            foreach (var career in careers)
            {
                System.Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    System.Console.WriteLine($"{item.Order} - {item.Title}");
                    System.Console.WriteLine(item.Course?.Title);
                    System.Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var studente = new Student();
                studente.CreateSubscription(payPalSubscription);
            }
        }
    }
}
