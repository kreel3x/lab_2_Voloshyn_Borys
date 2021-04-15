using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class MyList<T>
    {
        T[] myList;
        public T[] MyListProp
        {
            get
            {
                return myList;
            }
        }
        int counterForCountProp = 0;

        public MyList()
        {
            myList = new T[0];
        }
        public void Add(T value)
        {
            counterForCountProp++;
            T[] temp = myList;
            myList = new T[myList.Length + 1];
            for (int i = 0; i < temp.Length; i++)   // kakto tak
            {
                myList[i] = temp[i];
            }
            myList[myList.Length - 1] = value;


        }
        public T this[int index]
        {
            get
            {
                if (index < counterForCountProp && index >= 0)
                {
                    return myList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public int Count
        {
            get
            {
                return counterForCountProp;
            }
        }
    }
    internal static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list.MyListProp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<double> test = new MyList<double>();
            test.Add(55);
            test.Add(521555);
            test.Add(5521);

            var array = test.GetArray(); // or int[] array = test.GetArray();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
}
