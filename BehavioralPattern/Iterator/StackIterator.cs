namespace Iterator
{
    public class StackIterator
    {
        private DataStack _dataStack;
        private int _index;

        public StackIterator(DataStack dataStack)
        {
            _dataStack = dataStack;
            _index = 0;
        }

        public static StackIterator operator ++(StackIterator stackIterator)
        {
            stackIterator._index++;
            return stackIterator;
        }

        public int Get() // Возвращает значение элемента поля датастэк по его индексу
        {
            if (_index < _dataStack.Length)
                return _dataStack.Items[_index];
            return 0;
        }

        public bool IsEnd() //возвращает тру в случае конца стека
        {
            return _index != _dataStack.Length + 1;
        }
    }
}