using System;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        public static void Main(string[] args)
        {
            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Beginner;
            
            System.Console.WriteLine("Where I'm: "+ course.Level);
        }
    }
}


