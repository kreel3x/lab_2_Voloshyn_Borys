using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace zadanie_1
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
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> test = new MyList<int>();
            test.Add(5);
            test.Add(55);
            test.Add(55);
            Console.WriteLine(test[2]);
            Console.WriteLine(test.Count);



            //List<int> test1 = new List<int>();
            //test1.Add(5);
            //Console.WriteLine(test1[0]);
            //Console.WriteLine(test1.Capacity);

            //ArrayList a = new ArrayList(2);
            //a.Add(4);
            //a.Add("2442");
            //Console.WriteLine(a[0]);
            //Console.WriteLine(a[1]);




        }
    }
}
