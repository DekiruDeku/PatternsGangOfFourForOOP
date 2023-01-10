using System;

namespace Singleton
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // DataBaseHelper dataBaseHelper = new DataBaseHelper(); не получитрся изза ctor private
            DataBaseHelper.GetConnection().InsertData("Wow");
            Console.WriteLine("Вот что внутри кроличьей ямы: " + DataBaseHelper.GetConnection().SelectData());
        }
    }
}