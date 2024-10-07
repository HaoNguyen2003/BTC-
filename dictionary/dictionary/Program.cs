using System;
using System.Collections;

namespace dictionary
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string,string>dic=new Dictionary<string,string>();
            //luu kieu mo rong
            dic.Add("A", "Nguyen");
            dic.Add("B", "Tien");
            dic.Add("C", "Hao");
            //hashtable tung phan tu la dictionaryEntry
            Hashtable ht = new Hashtable();
            ht.Add("A", "Nguyen");
            ht.Add("B", "Tien");
            ht.Add("C", "Hao");
            //luu kieu doi tuong
            foreach(DictionaryEntry entry in ht)
            {
                Console.WriteLine(entry.Key+" "+entry.Value);
            }
            //
            foreach (KeyValuePair<string,string> item in dic)
            {
                Console.WriteLine(item.Key+"  "+item.Value);
                
            }
        }
    }
}