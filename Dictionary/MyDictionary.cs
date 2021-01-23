using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{

    class MyDictionary<T,T2>
    {
        T[] id;
        T2[] names;

        public MyDictionary()
        {
            id = new T[0];
            names = new T2[0];
        }
        public void Add(T Id, T2 Name)
        {
            T[] tempArray = id;
            T2[] tempArray2 = names;

            id = new T[id.Length + 1];
            names = new T2[names.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                id[i] = tempArray[i];
                names[i] = tempArray2[i];
                
            }
            id[id.Length - 1] = Id;
            names[names.Length - 1] = Name;
        }
        public int Length
        {
            get { return id.Length; }

        }
    }
}
