using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    static class MyFactory<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }  
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
