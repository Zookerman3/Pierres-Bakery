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
        int loaves = 0;
        int pastries = 0;
        Bread newBread = new Bread(loaves);
        Pastry newPastry = new Pastry(pastries);
        string userChoice = Console.ReadLine();
        if (userChoice == "Bread" || userChoice == "bread")
        {
            ChooseBread(newBread);
        }
        else if
        (userChoice == "Pastries" || userChoice == "pastries")
        {
            ChoosePastry(newPastry, newBread);
        }
    }
    static void ChooseBread(Bread newBread)
    {
        Console.WriteLine("Please enter the amount of bread loaves you would like to order.");
        Console.WriteLine("Bread loaves are currently buy 2 get one free!");
        string amountOrdered = Console.ReadLine();
        int loaves = int.Parse(amountOrdered);
        newBread.LoavesOrder = loaves;
        newBread.TotalLoaves += loaves;
        newBread.GetBreadTotalPrice();
        Console.WriteLine("You've Ordered " + newBread.LoavesOrder + " loaves of bread");
        Console.WriteLine("The total price for your loaves of bread is $" + newBread.TotalPrice);
        Console.WriteLine("");
        Console.WriteLine("Would you like to order more? Please type 'Bread' to order Bread, 'Pastries' to order Pastries or 'both' if you would like to order both, or enter 'checkout' to end the transaction");
        string CustomerOption = Console.ReadLine();
        if (CustomerOption == "Checkout" || CustomerOption == "checkout")
        {
            CheckoutBread(newBread);
        }
        else if (CustomerOption == "Bread" || CustomerOption == "bread")
        {
            ChooseBread(newBread);
        }
    }

    static void ChoosePastry(Pastry newPastry, Bread newBread)
    {
        Console.WriteLine("Please enter the amount of pastries you would like to order.");
        Console.WriteLine("Pastries are currently buy 3 get one free!");
        string amountOrdered = Console.ReadLine();
        int pastries = int.Parse(amountOrdered);
        newPastry.PastryOrder = pastries;
        Console.WriteLine("You've Ordered " + newPastry.PastryOrder + " pastries");
        Console.WriteLine("The total price for your pastries is $" + newPastry.PastryTotalPrice);
        Console.WriteLine("");
        Console.WriteLine("Would you like to order more? Please type 'Bread' to order Bread, 'Pastries' to order Pastries or 'both' if you would like to order both, or enter 'checkout' to end the transaction");
        string CustomerOption = Console.ReadLine();
        if (CustomerOption == "Checkout" || CustomerOption == "checkout")
        {
            CheckoutPastry(newPastry);
        }
        else if (CustomerOption == "Bread" || CustomerOption == "bread")
        {
            ChooseBread(newBread);
        }
    }
    static void Checkout(Bread newBread, Pastry newPastry)
    {
        Console.WriteLine("Your total checkout price for loaves of bread is: $" + newBread.TotalPrice);
        Console.WriteLine("Your total checkout price for Pastries is: $" + newPastry.PastryTotalPrice);
    }
    static void CheckoutPastry(Pastry newPastry)
    {
        Console.WriteLine("Your total checkout price for Pastries is: $" + newPastry.PastryTotalPrice);
    }
    static void CheckoutBread(Bread newBread)
    {
       Console.WriteLine("Your total checkout price for loaves of bread is: $" + newBread.TotalPrice);
    }
}
