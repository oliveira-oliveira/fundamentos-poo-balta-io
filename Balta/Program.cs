﻿using System;
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
                System.Console.WriteLine($"{item.Id} - {item.Title} - {item.Url}");
            }

            var courses = new List<Course>();

            var coursePOO = new Course("Fundamentos POO", "fundamentos-poo");
            var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos Asp.Net", "fundamentos-aspent");

            courses.Add(coursePOO);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .Net", "especialista-notnet");
            careers.Add(careerDotNet);

            var careerItem2 = new CareerItem( 2, "Aprenda .Net", "", null);
            var careerItem = new CareerItem( 1, "Comece por aqui", "", null);
            var careerItem3 = new CareerItem( 3, "Aprenda Asp.Net", "", null);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem2);

            foreach (var career in careers)
            {
                System.Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    System.Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }

        }
    }
}


