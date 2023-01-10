namespace Flyweight
{
    public struct Unique
    {
        private string _name;
        private string _passport;

        public Unique(string name, string passport)
        {
            _name = name;
            _passport = passport;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Passport
        {
            get
            {
                return _passport;
            }
        }
    }
}