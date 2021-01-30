using System;
using System.Collections.Generic;
namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(10,"Lionel Messi");
            dictionary.Add(7,"Cristiano Ronaldo");
            dictionary.Add(11,"Mesut Özil");
            dictionary.Add(1,"Manuel Neuer");
           
        }
    }
}
