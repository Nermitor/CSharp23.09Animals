using System;
using System.IO;

namespace CSharp23._09Animals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ApeCreator apeCreator = new ApeCreator();
            CatCreator catCreator = new CatCreator();
            StreamReader streamReader = new StreamReader(@"C:\Users\dmaty\RiderProjects\CSharp23.09Animals\test.txt");
            
            Test(ref apeCreator, ref catCreator, ref streamReader);
        }

        public static void Test(ref ApeCreator apeCreator, ref CatCreator catCreator, ref StreamReader streamReader)
        {
            const int linesCount = 4;

            string[] names = new string[linesCount];
            int[] inds = new int[linesCount];
            
            for (int i = 0; i < linesCount; i++)
            {
                string[] nameWithNumber = streamReader.ReadLine()?.Split();

                names[i] = nameWithNumber[1];
                inds[i] = Convert.ToInt32(nameWithNumber[0]);
            }
            
            Console.WriteLine("Животные кошачьего типа:");
            foreach (var catAnimal in catCreator.GetZoo(inds, names))
            {
                Console.WriteLine(catAnimal.GetInfo());
            }
            
            Console.WriteLine("\nЖивотные обезьяннего типа:");
            foreach (var apeAnimal in apeCreator.GetZoo(inds, names))
            {
                Console.WriteLine(apeAnimal.GetInfo());
            }
        }
    }
}