using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarSets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty HashSet named Showroom that will contain strings.
            //Add four of your favorite car model names to the set.
            //Print to the console how many cars are in your show room.
            //Pick one of the items in your show room and add it to the set again.
            //Print your showroom again, and notice how there's still only one representation of that model in there.
            //Create another set named UsedLot and add two more car model strings to it.
            //Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            //You've sold one of your cars. Remove it from the set with the Remove() method.

            HashSet<string> Showroom = new HashSet<string>();
            HashSet<string> UsedLot = new HashSet<string>();

            Showroom.Add("Insight");
            Showroom.Add("Civic Sedan");
            Showroom.Add("Accord Sedan");
            Showroom.Add("Accord Hybrid");
            Showroom.Add("Accord Hybrid");

            foreach (var car in Showroom)
            {
                Console.WriteLine("All cars in the showroom: " + car);
            }

            UsedLot.Add("Clarity Fuel Cell");
            UsedLot.Add("Clarity Electric");

            StringBuilder myStringBuilder = new StringBuilder();
            Console.WriteLine(myStringBuilder.Append('-', 50)); 

            UsedLot.UnionWith(Showroom);

            UsedLot.Remove("Insight");

            foreach (var car in UsedLot)
            {
                Console.WriteLine("All cars in used lot: " + car);
            }

            Console.WriteLine(myStringBuilder);

            //Now create another HashSet of cars in a variable Junkyard.Someone who owns a junkyard full of old cars has approached you about buying the entire inventory.In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
            //Use the IntersectWith() method to see which cars exist in both the show room and the junkyard.
            //Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
            //Use the Remove() method to remove any cars that you acquired from the junkyard that you want in your showroom.

            HashSet<string> Junkyard = new HashSet<string>();
            HashSet<string> CarsToRemove = new HashSet<string>();

            Junkyard.Add("Nissan GT-R");
            Junkyard.Add("Nissan Altima");
            Junkyard.Add("Civic Sedan");
            Junkyard.Add("Accord Sedan");

            var carsOnlyInJunkYard = Junkyard.Except(Showroom);

            foreach (var car in carsOnlyInJunkYard)
            {
                CarsToRemove.Add(car);
                Console.WriteLine("Cars only in Junkyard: " + car);
            }

            Console.WriteLine(myStringBuilder);

            Showroom.UnionWith(carsOnlyInJunkYard);

            foreach (var car in Showroom)
            {
                Console.WriteLine("All cars in showroom + cars from junkyard: " + car);
            }

            Console.WriteLine(myStringBuilder);

            foreach (var car in CarsToRemove)
            {
                Showroom.Remove(car);
            }

            foreach (var car in Showroom)
            {
                Console.WriteLine("Everything left in the showroom: " + car);
            }

            Console.WriteLine(myStringBuilder);


        }
    }
}
