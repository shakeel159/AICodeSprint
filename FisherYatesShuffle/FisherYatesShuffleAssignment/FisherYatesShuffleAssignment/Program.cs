using Algorithms;

namespace FisherYatesShuffleAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string filePath = @"C:\Workspace\Data.txt";
            string[] lines = File.ReadAllLines(filePath);

            lines.DoFisherYatesShuffle(); // text file was already a array so call shuffle mathod to shuffle text

            foreach (string line in lines)
            {
                //Each element will shuffle and print here so the FisherYatesShuffle will be called or used before this point
                //print result here
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}