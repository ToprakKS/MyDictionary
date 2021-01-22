using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string> sozluk = new MyDictionary<string>();
            sozluk.Add("Kitap");
            sozluk.Add("Masa");
            sozluk.Add("Laptop");
            sozluk.Add("Defter");
            sozluk.Add("Mouse");
            Console.WriteLine(sozluk.Count);
            


        }
    }

}
