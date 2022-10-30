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



        }
    }
}