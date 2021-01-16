using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();

            MyList<int> myList = new MyList<int>();
            myList.Add(111);
            myList.Add(222);
            myList.Add(333);
            myList.Add(444);
            myList.Add(555);

            Console.WriteLine(myList.Count);
            Console.WriteLine(myList[2]);

            Console.ReadLine();

        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
            
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }

        }

        public T this[int index]
        {
            get
            {
                return _array[index];
            }

            set
            {
                _array[index] = value;
            }
            
        }

    }
}
