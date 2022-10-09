using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYatesShuffleAssignment
{
    public class Excel
    {
        //"C:\Workspace\src\GitHub\AlgorithmCodePractice\FisherYatesShuffleAssignment\Data.txt.txt"
       

        public void ReadExternalFile()
        {
            //same code doesnt work on seperate method 
            string filePath = @"C:\Workspace\Data.txt";
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                line.ToString();
            }

            //return lines;
        }
        
    }
}
