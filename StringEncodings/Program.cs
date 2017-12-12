using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringEncodings
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("StringEncodingsExercise\\Encoding1.csv");
            //CSV collection =  get the csv file and convert it to a collection type, a generic csv class? ;
            //string pubDate = split out the first 
            //string title = split
            //string Authors = split

            Console.WriteLine("| Pub Date    |                       Title | Authors                         |");
            Console.WriteLine("|=============================================================================|");

            foreach (var item in collection)
            {
                Console.WriteLine("|" +pubDate + "         | " +title+ "                 |  " +authors+"               |");
            }
            Console.ReadLine();   
        }
    }

   
}
