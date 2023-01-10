namespace Iterator
{
    public class DataStack
    {
        private int[] _items = new int[10];
        private int _lenght;

        public DataStack()
        {
            _lenght = -1;
        }

        public DataStack(DataStack dataStack)
        {
            _items = dataStack._items;
            _lenght = dataStack._lenght;
        }

        public int[] Items
        {
            get
            {
                return _items;
            }
        }

        public int Length
        {
            get
            {
                return _lenght;
            }
        }

        public void Push(int value)
        {
            _items[++_lenght] = value;
        }

        public int Pop()
        {
            return _items[_lenght--];
        }
        
        public static bool operator ==(DataStack myStack1,DataStack myStack2)
        {
            StackIterator it1 = new StackIterator(myStack1),
                it2 = new StackIterator(myStack2);

            while (it1.IsEnd() || it2.IsEnd())
            {
                if(it1.Get() != it2.Get()) break;
                it1++;
                it2++;
            }

            return !it1.IsEnd() && !it2.IsEnd();
        }
    
        public static bool operator !=(DataStack myStack1, DataStack myStack2)
        {
            StackIterator it1 = new StackIterator(myStack1),
                it2 = new StackIterator(myStack2);

            while (it1.IsEnd() || it2.IsEnd())
            {
                if(it1.Get() != it2.Get())break;
                it1++;
                it2++;
            }
            return !(!it1.IsEnd() && !it2.IsEnd());
    }

}
}