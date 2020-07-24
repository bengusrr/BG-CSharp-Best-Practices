using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Capturing a number of people´s names
// Loop through and say hi to them

namespace ConsoleUI
{
    class Program
    {
        private static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            //SetUpSampleData();

            //GreatAllThePeople();

            //StringDemoMethod();     // string builder speed test

            Console.ReadLine();
        }

        private static void SetUpSampleData()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm" });
            people.Add(new Person { FirstName = "Jill", LastName = "Jones" });
        }

        private static void StringDemoMethod()
        {
            string s = "";
            StringBuilder sb = new StringBuilder();

            Console.WriteLine(DateTime.Now.ToLongTimeString());

            for (int i = 0; i < 100000; i++)
            {
                //s += "Hi ";       // it takes aprox. 10 seconds
                sb.Append("Hi ");   // with string builder, it takes 1 second
            }

            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }


        private static void GreatAllThePeople()
        {
            foreach (var person in people)
            {
                if (person.FirstName == "Tim")
                {
                    Console.WriteLine($"Hello Mr. { person.LastName }");
                    Console.WriteLine("How are you doing?");
                }
                else
                {
                    Console.WriteLine($"Hello { person.FirstName } { person.LastName }");
                }
                    
            }
        }
    }
}
