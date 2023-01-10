using System.Collections.Generic;

namespace Proxy
{
    public interface IChief
    {
        IDictionary<int, string> GetStatus();

        IEnumerable<Order> GetOrders();
    }
}