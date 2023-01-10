namespace Prototype
{
    public class Sheep : IAnimal, IClone
    {
        private string _name;

        public Sheep()
        {
            
        }
        
        private Sheep(Sheep sheep)
        {
            _name = sheep.Name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public IAnimal Clone() //По факту это и есть весь прототип мы просто берем и делаем метод возвращающий сам себя XD
        {
            return new Sheep(this);
        }
    }
}