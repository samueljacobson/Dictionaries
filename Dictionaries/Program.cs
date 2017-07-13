using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Twix"},
                {"A2", "Twizzlers"},
                {"A3", "Reeses"},
                {"A4", "Sour Patch Kids"}
            };

            foreach (KeyValuePair<string, string>item in snackMachine)  //to print entire contents
            {
                Console.WriteLine(item);
            }

            foreach(var item in snackMachine)   //not best practice (vague reference to variable)
            {
                Console.WriteLine(item);
            }


            //Using add method
            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Bottled Water");
            drinkMachine.Add(12, "Orange Juice");
            drinkMachine.Add(13, "Fruit Punch");
            drinkMachine.Add(14, "Mountain Dew Code Red");

            Console.WriteLine(drinkMachine.Count);  //displays number of entries in dictionary

            foreach (KeyValuePair<int,string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
                Console.WriteLine(drink.Value);
            }


            //Create a dictionary for a theater coat check with 10 elements
            //The key will be a number and the value will be the coat style
            //Print all elements to console
            Dictionary<int, string> coatCheck = new Dictionary<int, string>
            {
                {1, "peacoat"},
                {2, "raincoat"},
                {3, "trench coat"},
                {4, "parka"},
                {5, "windbreaker"},
                {6, "puffer"},
                {7, "running jacket"},
                {8, "down coat"},
                {9, "fur coat"},
                {10, "leather jacket"}
            };
            foreach (KeyValuePair<int,string> coat in coatCheck)
            {
                Console.WriteLine(coat);
            }

            //Car valet with 10 cars - key is customer last name, value is car make
            //Print all elements to the console
            Dictionary<string, string> carValet = new Dictionary<string, string>();
            carValet.Add("Smith", "Mustang");
            carValet.Add("Davis", "Corvette");
            carValet.Add("Jefferson", "Cadillac");
            carValet.Add("Adams", "Ford");
            carValet.Add("Hancock", "Toyota");
            carValet.Add("Washington", "Chevrolet");
            carValet.Add("Monroe", "Dodge");
            carValet.Add("Madison", "Ferrari");
            carValet.Add("Jackson", "Rolls Royce");
            carValet.Add("Lincoln", "Maserati");
            foreach (KeyValuePair<string,string> car in carValet)
            {
                Console.WriteLine(car);
            }

            //Create a dictionary of 10 zoo animals - key is animal type, value is number of animals
            //Print the animal with the highest quantity to the console
            //Remove the zoo animal with the lowest quantity
            //User should be able to add a new animal if not in dictionary
            Dictionary<string, int> zooAnimals = new Dictionary<string, int>
            {
                {"zebra", 10},
                {"lion", 2},
                {"wolf", 5},
                {"flamingo", 30},
                {"polar bear", 2},
                {"kangaroo", 5},
                {"walrus", 3},
                {"bald eagle", 1},
                {"warthog", 2},
                {"ostrich", 4}
            };
            foreach(KeyValuePair<string,int> animals in zooAnimals)
            {
                List<int> animalPop = new List<int>(animals.Value);
                animalPop.Sort();
                Console.WriteLine(animals.Key[animalPop.Count - 1]);
            }
        }
    }
}
