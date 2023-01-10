namespace Builder
{
    public class Worker
    {
        private string _name;
        private decimal _money;

        public Worker(string name, decimal money)
        {
            _name = name;
            _money = money;
        }
        
        public string Name => _name;
        public decimal Money => _money;
    }
}