namespace Visitor
{
    public class HolidayMaker : IVisitor
    {
        private string _value;


        public string Value
        {
            get
            {
                return _value;
            }
            private set
            {
                _value = value;
            }
        }
        public void Visit(Zoo zoo)
        {
            _value = "Слон в зоопарке";
        }

        public void Visit(Cinema cimena)
        {
            _value = "Кино - Властелин колец";
        }

        public void Visit(Circus circus)
        {
            _value = "Лекция по кибер безу";
        }
    }
}