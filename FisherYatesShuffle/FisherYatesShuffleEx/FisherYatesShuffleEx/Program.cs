using Algorithms;
namespace FisherYatesShuffleEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] letters = { "a", "b", "c", "d", "e" };
            //letters.DoFisherYatesShuffle();
            letters.DoFisherYatesAlternateShuffle();
            foreach (string letter in letters)
            {
                Console.Write(letter + " ");
            }
            Console.ReadKey();
        }
    }
}