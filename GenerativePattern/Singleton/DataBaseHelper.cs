using System;

namespace Singleton
{
    public class DataBaseHelper
    {
        private string _data;
        private static DataBaseHelper _dataBaseHelper; // тот самый единственный экземпляр класса

        private DataBaseHelper()
        {
            Console.WriteLine("Подключение к базе данных");
        }

        public static DataBaseHelper GetConnection()
        {
            if (_dataBaseHelper == null)
                _dataBaseHelper = new DataBaseHelper();
            return _dataBaseHelper;
        }

        public string SelectData()
        {
            return _data;
        }

        public string InsertData(string newdata)
        {
            return _data = newdata;
        }
    }
}