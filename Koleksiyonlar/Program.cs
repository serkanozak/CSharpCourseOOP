using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // bu çözüm değil. çünkü heap'te aslında bomboş bir dizi oluşturduk.
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            //isimler2.Add("Engin"); iki şekilde de yazılabilir. 
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker"); // koleksiyonlarda, koleksiyona yeni değer eklemek için Add() metodu kullanılır.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            // Array'lerde dizinin alabileceği eleman sayısı bellidir. daha sonradan eleman eklemeye izin vermez.
            // List bu durumu çözer. Daha esnektir. Add() fonksiyonu ile koleksiyona yeni eleman eklenebilir. 

        }
    }
}
