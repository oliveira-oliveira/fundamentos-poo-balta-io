using System;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        public static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre POO", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .Net", "dotnet"));

            foreach (var item in articles)
            {
                System.Console.WriteLine(item.Id);
                System.Console.WriteLine(item.Title);
                System.Console.WriteLine(item.Url);
            }

        }
    }
}


