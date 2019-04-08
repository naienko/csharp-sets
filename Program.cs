using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Civic");
            Showroom.Add("s2000");
            Showroom.Add("Fiero");
            Showroom.Add("Enclave");

            Console.WriteLine($"How many? {Showroom.Count}");

            Showroom.Add("Civic");

            foreach (string model in Showroom) {
                Console.WriteLine($"{model}");
            }
            Console.WriteLine($"How many? {Showroom.Count}");

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("del Sol");
            UsedLot.Add("Seville");

            Console.WriteLine("Added some cars ... ");
            Showroom.UnionWith(UsedLot);
            foreach (string model in Showroom) {
                Console.WriteLine($"{model}");
            }
            
            Console.WriteLine("Sold one ... ");
            Showroom.Remove("del Sol");
            foreach (string model in Showroom) {
                Console.WriteLine($"{model}");
            }

            Console.WriteLine("Found a junkyard");
            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Fiero");
            Junkyard.Add("Camaro");
            Junkyard.Add("Firebird");
            Junkyard.Add("del Sol");
            Junkyard.Add("Seville");

            Console.WriteLine("In the junkyard ... ");
            foreach (string model in Junkyard) {
                Console.WriteLine($"{model}");
            }

            Console.WriteLine("In both ... ");
            HashSet<string> clone = new HashSet<string>(Showroom);
            clone.IntersectWith(Junkyard);
            foreach (string model in clone) {
                Console.WriteLine($"{model}");
            }

            Console.WriteLine("Bought the junkyard!");
            Showroom.UnionWith(Junkyard);
            foreach (string model in Showroom) {
                Console.WriteLine($"{model}");
            }

            Console.WriteLine("Don't want a del Sol!");
            Showroom.Remove("del Sol");
            foreach (string model in Showroom) {
                Console.WriteLine($"{model}");
            }
        }
    }
}
