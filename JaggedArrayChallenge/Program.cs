using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayChallenge
{
    class Program
    {
        //Create a jagged array, which contains 3 "friends arrays", in which two family members should be stored
        //Introduce family members from different fammilies to each other via console(3 introductions)

        static void Main(string[] args)
        {
            //My way
            /*string[][] jaggedArray = new string[][];
            //Friend name 1st then family members
            jaggedArray[0] = new string[] { "George", "Sam", "Alex" };
            jaggedArray[1] = new string[] { "Peter", "Michael", "Sally" };
            jaggedArray[2] = new string[] { "Frank", "Daniel", "James" };

         
            Console.Write("Hi, We are {0} and {1}. {2}'s parents.", jaggedArray[0][1], jaggedArray[0][2], jaggedArray[0][0]);
            Console.Write("\nHi, We are {0} and {1}. {2}'s parents.", jaggedArray[1][1], jaggedArray[1][2], jaggedArray[1][0]);
            Console.Write("\nHi, We are {0} and {1}. {2}'s parents.", jaggedArray[2][1], jaggedArray[2][2], jaggedArray[2][0]);
            */
            //Instructors way
            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Michael", "Sandy"},
                new string[]{"Frank", "Claudia"},
                new string[]{ "Andrew", "Tania"}
            };

            Console.WriteLine("Hi {0}, i would like to introduce {1} to you.",friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, i would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, i would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);

            Console.ReadKey();
        }

    }
}
