using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T> // T'nin anlamı --> bana bir tip ver ve ben süslü parantez içini ona göre yapılandıracağım.
    {
        T[] items;
        //constructor -- bir classın new'lendiğinde çalışan bloğuna constructor denir. 
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // items'ın heap'teki referansını emanet ettik.
                                   // items new'lendiği anda yeni referans numarası alacağından tuttuğu değerlerde gidecek.
                                   // buna engel olmak için temp ile önceki referans numarasını verdik ki, önceki referansta olan değerler saklanabilsin.
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //indeks 0'dan başladığı için length'in 1 eksiği sayısal olarak aynı şeyi verecek.
        }
    }
}

