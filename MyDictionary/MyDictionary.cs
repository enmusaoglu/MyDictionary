using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] keyArray;
        V[] valueArray;

        public MyDictionary()
        {
            keyArray = new K[0];
            valueArray = new V[0];
        }
        public void Add(K key,V value)
        {
            K[] tempKey = keyArray;
            V[] tempValue = valueArray;
            keyArray = new K[keyArray.Length + 1];
            valueArray = new V[valueArray.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keyArray[i] = tempKey[i];
            }
            keyArray[keyArray.Length - 1] = key;
            for (int j = 0; j < tempValue.Length; j++)
            {
                valueArray[j] = tempValue[j];
            }
            valueArray[valueArray.Length - 1] = value;

            Console.WriteLine("Id : "+key + " Name : " + value);
        }

    }
}

