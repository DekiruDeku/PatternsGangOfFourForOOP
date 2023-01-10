namespace Flyweight
{
    // Самый простой способо запомнить и понять разницу - класс ссылочный тип, Struct - нет
    public struct Shared
    {
        private string _company;
        private string _position;

        public Shared(string company, string position)
        {
            _company = company;
            _position = position;
        }

        public string Comapny
        {
            get
            {
                return _company;
            }
        }

        public string Position
        {
            get
            {
                return _position;
            }
        }
    }
}