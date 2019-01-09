using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "홍길동"); h.Add(4, "김길동"); h.Add(2, "정길동"); h.Add(3, "조길동");

            foreach(DictionaryEntry d in h)
            {
                Console.WriteLine($"Key:{d.Key},  Value:{d.Value}");
            }

            SortedList s = new SortedList(h);
            foreach (DictionaryEntry d in s)
            {
                Console.WriteLine($"Key:{d.Key},  Value:{d.Value}");
            }

            Dictionary<int, string> p = new Dictionary<int, string>();
            p.Add(1, "서울"); p.Add(99, "부산"); p.Add(31, "군산");
            foreach (KeyValuePair<int, string> k in p)
            {
                Console.WriteLine($"Key:{k.Key},  Value:{k.Value}");
            }
        }
    }
}
