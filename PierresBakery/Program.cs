using System;
using PierresBakery.Models;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Pierre's Bakery!");
        Console.WriteLine("Would you like to order Bread or Pastries Today? Please type 'Bread' to order Bread, 'Pastries' to order Pastries or 'both' if you would like to order both");
       CustomerChoosing();
    }
        static void CustomerChoosing()
        {
            string userChoice = Console.ReadLine();
            if (userChoice == "Bread" || userChoice == "bread")
            {
                Console.WriteLine("Please enter the amount of bread loaves you would like to order.");
                Console.WriteLine("Bread loaves are currently buy 2 get one free!");
                string amountOrdered = Console.ReadLine();
                int loaves = int.Parse(amountOrdered);
                Bread newBread = new Bread(loaves);
                Console.WriteLine("You've Ordered " + newBread.LoavesOrder + " loaves of bread");
                Console.WriteLine("The total price for your loaves of bread is $" + newBread.TotalPrice);
                Console.WriteLine("");
                Console.WriteLine("Would you like to order more? Please type 'Bread' to order Bread, 'Pastries' to order Pastries or 'both' if you would like to order both, or enter 'checkout' to end the transaction");
                string CustomerOption = Console.ReadLine();
                if (CustomerOption == "Checkout" || CustomerOption == "checkout");
                {
                    Checkout(newBread);
                }
            }
        }
    static void Checkout(Bread newBread)
    {
        Console.WriteLine("Your total checkout price for loaves of bread is: $" + newBread.TotalPrice);

    }
    static void Chosebread()
    {
        
    }
    
}