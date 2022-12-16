using System.Collections;
using System.IO;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array 

            string filePath = @"C:\Workspace\Shifts.txt";

            //takes in elements divided by "," lebaling each from 0 =+;
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                //print out elemets in order as shown in file
                //can be ranzdomized  or selected elements can be printed.
                //searching individual elements can take time and dificult if not sure what to look for.
                Console.WriteLine(line);
            }

            //HashTable Map
            // Maps such as the hash table take up more memory and are unordered
            Hashtable openWith = new Hashtable();

            //Add data into hashtable with 2 parameters that take in Key and Value
            openWith.Add(001, "Mon");
            openWith.Add(002, "Tue");
            openWith.Add(003, "Wed");
            openWith.Add(004, "thur");
            openWith.Add(005, "Fri");
            openWith.Add(006, "Sat");
            openWith.Add(007, "Sun");


            //using foreach statement spit out elements
            //using DictionaryEntry spitout elemts in Alp order
            Console.WriteLine();
            foreach (DictionaryEntry de in openWith)
            {
                //each element in hashtable can be called by key or value optimizing search.
                // each hastabel holds key that can act as a search bar and value wich once given the key has all the information.
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
            // This code reads all lines from a text file with countries and adds them to an array

            //Stack
            //satcks are usefull depending on how one wants ttere data becuase satcks starts from last stored
            //
            Stack myStack = new Stack();
            myStack.Push("Jan");
            myStack.Push("Feb");
            myStack.Push("Mar");
            myStack.Push("Apr");
            myStack.Push("May");
            myStack.Push("Jun");

            foreach (var e in myStack)
            {
                Console.WriteLine(e.ToString());
            }

            //Queue
            //Queue is the opposite of satck and data will be sent out firt come first serve order 
            Queue q = new Queue();
            q.Enqueue("Jul");
            q.Enqueue("Aug");
            q.Enqueue("Sep");
            q.Enqueue("Oct");
            q.Enqueue("Sep");
            q.Enqueue("Oct");
            q.Enqueue("Nove");
            q.Enqueue("Dec");

            foreach (var Q in q)
            {
                Console.WriteLine(Q);
            }

        }
    }
}