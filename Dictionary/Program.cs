using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            
            AdYas.Add("berna", 22);
            AdYas.Add("Melis", 25);
            AdYas.Add("Sıla", 15);
            AdYas.Add("kader", 29);
            Console.WriteLine(AdYas.Count);
           

            MyDictionary<string, int> AdYas2 = new MyDictionary<string, int>();
            AdYas2.Add("berna", 22);
            AdYas2.Add("melis", 33);
            Console.WriteLine(AdYas2.Count);


        }
        
    }
    class MyDictionary<K,V>
    {
        V[] _array;
        K[] _array2;
        V[] tempArray;
        K[] tempArray2;

        public MyDictionary()//Constructor
        {
            _array = new V[0];
            _array2 = new K[0];
                
        }
        public void Add(K item,V items)//ekleme yapar
        {
            tempArray = _array;
            tempArray2 = _array2;
            _array = new V[_array.Length+1];
            _array2 = new K[_array2.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
                _array2[i] = tempArray2[i];
            }
            _array[_array.Length - 1] = items;
            _array2[_array2.Length - 1] = item;
        }
        
        public int Count// değerleri sayar 
        {
            get { return _array2.Length; }
 
        }
   

    }
}
