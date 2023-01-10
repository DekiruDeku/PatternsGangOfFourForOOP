using System;

namespace Proxy
{
    public struct Order
    {
        private Guid _id;
        private string? _name;
        private int _status;

        public Order(string name, int status)
        {
            _id = new Guid();
            _status = status;
            _name = name;
        }

        public Guid id
        {
            get
            {
                return _id;
            }
        }
        
        public string? Name 
        {
            get
            {
                return _name;
            }
        }
        
        public int Status 
        {
            get
            {
                return _status;
            }
        }
    }
}