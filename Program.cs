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
            HashSet<string> hSet = new HashSet<string>(names);// HashSet of Type <string>
            Console.WriteLine("Count of Data in HashSet " + hSet.Count); // Count of Data in Hashset: returns: 6 (removes duplicate name)
            Console.WriteLine();
            Console.WriteLine("Data in HashSet");

            foreach (var n in hSet) // looping through array hSet
            {
                Console.WriteLine(n); // returns 6 names, removed duplicate name
            }
            Console.ReadLine(); // user input.. PRESS ENTER

            string[] name1 = new string[]
            {
                 "mahesh","sabnis","manish","sharma","saket","karnik"
            };
            string[] name2 = new string[]
            {
                  "suprotim","agarwal","vikram","pendse","mahesh","mitkari"
            };

            HashSet<string> hSetN1 = new HashSet<string>(name1);
            Console.WriteLine("Data in First HashSet");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
                // after ever element in the array a divider will be present
                Console.WriteLine("_______________________________________________________________");
            }

            HashSet<string> hSetN2 = new HashSet<string>(name2);
            Console.WriteLine("Data in Second HashSet");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Data after Union");

            hSetN1.UnionWith(hSetN2); // UnionWith()Method of hSetN1 passing hSetN2 to hSetN1

            foreach (var n in hSetN1)
            {
                Console.WriteLine(n); // displays hSetN1 after UNION
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Data in HasSet before using ExceptWith()");
            Console.WriteLine("_________________________________");

            HashSet<string> hSetN3 = new HashSet<string>(name1);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");

            hSetN3.ExceptWith(hSetN2);

            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }

            HashSet<string> hSetN4 = new HashSet<string>(name1);
            Console.WriteLine("_________________________________");

            Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");

            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("HashSet 2");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using SymmetricExceptWith");
            Console.WriteLine("_________________________________");

            hSetN4.SymmetricExceptWith(hSetN2); // SymmetricExceptWith is balled on hSetN4 passing hSetN2
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n); // returns with repeated mahesh removed.  
            }


        }
    }
}