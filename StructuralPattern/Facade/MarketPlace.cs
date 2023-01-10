namespace Facade
{
    // По факту и есть фасад, можно также и с интерфейсом использовать
    // есть риск, что он станет божественным обьектом
    
    public class MarketPlace
    {
        private ProvaiderCommunication _provaiderCommunication;
        private Site _site;
        private Database _database;

        public MarketPlace()
        {
            _database = new Database();
            _site = new Site();
            _provaiderCommunication = new ProvaiderCommunication();
        }

        public void ProductReceipt()
        {
            _provaiderCommunication.Recive();
            _site.Placement();
            _database.Insert();
        }

        public void ProductRelise()
        {
            _provaiderCommunication.Payman();
            _site.Delete();
            _database.Delete();
        }
    }
}