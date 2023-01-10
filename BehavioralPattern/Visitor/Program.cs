using System;
using System.Collections.Generic;

namespace Visitor
{
    internal class Program
    {
        // позволяет создавать новые операции, не меняя
        // классы объектов, над которыми эти операции могут выполняться
        
        // пример построен на посещение отдыхающего
        public static void Main(string[] args)
        {
            List<IPlace> places = new List<IPlace>()
            {
                new Zoo(),
                new Cinema(),
                new Circus()
            };

            foreach (var someplace in places)
            {
                HolidayMaker holidayMaker = new HolidayMaker();
                someplace.Accept(holidayMaker);
                Console.WriteLine(holidayMaker.Value);
            }
        }
    }
}