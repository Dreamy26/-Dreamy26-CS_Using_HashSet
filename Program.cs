using System;
using System.Collections.Generic;

namespace CS_Using_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Hashset");
            string[] names = new string[] // names added to array
            {
                   "mahesh",

                "vikram",

                "mahesh",

                "mayur",

                "suprotim",

                "saket",

                "manish"
            };
            Console.WriteLine("length of Array " + names.Length); // the number of objects to the array, returns 7
            Console.WriteLine(); // adds a empty line

            Console.WriteLine("The Data in Array"); // Adds the heading to the array objects

            foreach (var n in names) // looping through the objects of the array 
            {
                Console.WriteLine(n); // returns the objects one by one under each other
            }
            Console.WriteLine(); // Adds empty line

            // starting HashSet
            HashSet<string> hSet = new HashSet<string>(names);
            Console.WriteLine("Count of Data in HashSet " + hSet.Count); // Count of Data in Hashset: returns: 6 (index based)
            Console.WriteLine();
            Console.WriteLine("Data in HashSet");

            foreach (var n in hSet)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}