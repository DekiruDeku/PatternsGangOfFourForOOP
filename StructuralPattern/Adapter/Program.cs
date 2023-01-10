namespace Adapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Проблема: Есть конкретный класс и нужно чтобы этот класс реализовывал определенный интерфейс, 
            // при этом сам класс менять нельзя
            
            // Есть два варианта реализации Адаптера:
            // 1.Через классы
            // 2.Через экземплаяр
        }
        
        // Есть два варианта реализации Адаптера:
        // 1.Через классы
        class AdapterWithClasses : SendRequest, ISender
        {
            public void Send(string text)
            {
                this.SendRequests(text);
            }
        }
        
        // 2.Через экземплаяр
        class AdapterWithObjectClases : ISender
        {
            private SendRequest _sendRequest = new SendRequest();
            public void Send(string text)
            {
                _sendRequest.SendRequests(text);
            }
        }
    }
}