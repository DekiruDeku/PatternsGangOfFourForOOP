using System;
using System.Collections.Generic;

namespace Builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Jack", 100),
                new Worker("Ron", 95),
                new Worker("Jarold", 120)
            };
            
            var builder = new ReportBuilder(workers);
            var director = new ReportDirector(builder);
            
            director.BuildFullReport();
            var report = builder.GetReport();

            Console.WriteLine(report);
            Console.ReadKey();

        }
    }
}