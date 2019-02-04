using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ConsoleApp
{
    class AllColllection
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("--------------------Array List------------------");
            ArrayList arryList = new ArrayList();
            arryList.Add("Parth Roy");
            arryList.Add(100);
            arryList.Add(true);
            arryList.Add(1.2);
            arryList.Add(1235468790);
            
            for (int i = 0; i < arryList.Count; i++)
            {
                Console.WriteLine("data :- "+arryList[i] + "\tdata type: -" + arryList[i].GetType());
            }
            Console.WriteLine();
            foreach (Object obj in arryList)
            {
                Console.WriteLine("data :- " + obj + "\tdata type: -" + obj.GetType());
            }
            Console.WriteLine("Array List Capacity :- "+arryList.Capacity);
            
            
            Console.WriteLine("\n\n----------------------Hash Table--------------------");
            Hashtable hashTable = new Hashtable();
            hashTable.Add("name", "Parth Roy");
            hashTable.Add("id", 123456879);
            hashTable.Add("status", true);
            ICollection keys = hashTable.Keys;
            Console.WriteLine();
           foreach (Object obj in keys)
            {
                Console.WriteLine("key :- " + obj + "\tdata :- " + hashTable[obj] + "\tdata type: -" + hashTable[obj].GetType() + "\n" + hashTable[obj].GetHashCode());
            }
         //  Console.WriteLine(hashTable.GetHashCode());

           int[] a={10,20,30,40,50};
            
           Console.WriteLine("\n\n----------------------Shorted Table--------------------");
           SortedList sortedList = new SortedList();
           sortedList.Add("name", "Parth Roy");
           sortedList.Add("id", 123456879);
           sortedList.Add("status", true);
           sortedList.Add("3","Parth Roy");
           sortedList.Add("4",100);
           sortedList.Add("5",true);
           sortedList.Add("6",1.2);
           sortedList.Add("7",1235468790);
           sortedList.Add("8", a);
           ICollection skeys = sortedList.Keys;
           Console.WriteLine();
           foreach (Object obj in skeys)
           {
               Console.WriteLine("key :- " + obj + "\tdata :- " + sortedList[obj] + "\tdata type: -" + sortedList[obj].GetType() );
           }
            Console.ReadLine();
        }
    }
}
