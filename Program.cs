using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Practice
{
    class Program
    {
        Random generator = new Random();
        static void Main(string[] args)
        {
            Random generator = new Random();
            //string[] names = new string[2];

            //names[0] = "Jack Carlson";

            //names[1] = "Cole Cantwell";

            //for (int i = 0; i < names.Length; i++)
            //    Console.WriteLine("Item number " + i + ": " + names[i]);

            int randomNum;

            int[] numbers = new int[30];
            foreach (int i in numbers)
            {
                randomNum = generator.Next(0, 101);
                Console.Write(randomNum + " ");
                for ()
            }
            



            Console.ReadLine();
        }
    }
}
