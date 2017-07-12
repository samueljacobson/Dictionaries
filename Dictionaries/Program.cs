﻿using System;
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



        }
    }
}
