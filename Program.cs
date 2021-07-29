using System;
using System.Collections.Generic;
using Balta.ContentContext;

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


            foreach (var article in articles)
            {
                System.Console.WriteLine("-----------------------------------------");
                System.Console.WriteLine(article.Title);
                System.Console.WriteLine(article.Url);
                System.Console.WriteLine(article.Id);
            }

        }
    }
}
