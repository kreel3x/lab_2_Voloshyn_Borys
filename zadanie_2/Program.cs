using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class MyDictionary<K, V>
    {
        K[] myKeyDictionary;
        V[] myValDictionary;
        int counterForCountProp = 0;


        public MyDictionary()
        {
            myKeyDictionary = new K[0];
            myValDictionary = new V[0];
        }
        public void Add(K key, V value)
        {
            counterForCountProp++;
            K[] temp_Key = myKeyDictionary;
            V[] temp_Val = myValDictionary;
            myKeyDictionary = new K[myKeyDictionary.Length + 1];
            myValDictionary = new V[myValDictionary.Length + 1];
            for (int i = 0; i < temp_Key.Length; i++)   // kakto tak
            {
                myKeyDictionary[i] = temp_Key[i];
            }
            for (int i = 0; i < temp_Val.Length; i++)   // kakto tak
            {
                myValDictionary[i] = temp_Val[i];
            }
            foreach (var item in myKeyDictionary)
            {
                if (item.Equals(key))
                {
                    throw new ArgumentException("An item with the same key has already been added.");
                }
            }
            myKeyDictionary[myKeyDictionary.Length - 1] = key;
            myValDictionary[myValDictionary.Length - 1] = value;
            

        }
        public V this[K key]
        {
            get
            {
                for (int i = 0; i < myKeyDictionary.Length; i++)
                {
                    if (myKeyDictionary[i].Equals(key))
                    {
                        return myValDictionary[i];
                    }
                }
                throw new KeyNotFoundException();
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
            MyDictionary<int, string> test = new MyDictionary<int, string>();
            test.Add(5, "ststa");
            //test.Add(5, "ststa"); ===> Exeption(An item with the same key has already been added.)
            Console.WriteLine(test.Count);

            //Dictionary<int, string> test1 = new Dictionary<int, string>();
            //test1.Add(5, "525423");
            //test1.Add(5, "525423");

            //Console.WriteLine(test1[6]);




        }
    }
}
