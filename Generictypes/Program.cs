using System;

namespace Generictypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class MyList<T> where T : class
    {
        
        T[] _list;
        public int Count { get => _list.Length; }
        public MyList(T a)
        {
            _list = new T[0];
        }
        public T this[int index]
        {
            get
            {
                if (index < _list.Length)
                {
                    return _list[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < _list.Length)
                {
                    _list[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public void Add(T value)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[_list.Length - 1] = value;
        }
        public void Remove()
        {
            Array.Resize(ref _list, _list.Length - 1);
        }

    }
}
