using System;
using PierresBakery.Models;



class Program
{
    static void Main()
    {
        // Intial Gretting and running customers first input to choose a branch
        Console.WriteLine("Welcome to Pierre's Bakery!");
        Console.WriteLine("Would you like to order Bread or Pastries Today? Please type 'Bread' to order Bread, 'Pastries' to order Pastries or 'both' if you would like to order both");
        CustomerChoosing();
        
    }
    static void CustomerChoosing()
    {
        // Intitalizing Bread and Pastry objects so they can be updated if the user inputs more than once
        int loaves = 0;
        int pastries = 0;
        Bread newBread = new Bread(loaves);
        Pastry newPastry = new Pastry(pastries);
        string userChoice = Console.ReadLine();

        // Intial Branch to each function
        if (userChoice == "Bread" || userChoice == "bread")
        {
            ChooseBread(newBread, newPastry);
        }
        else if
        (userChoice == "Pastries" || userChoice == "pastries")
        {
            ChoosePastry(newBread, newPastry);
        } else if (userChoice == "Both" || userChoice == "both")
        {
            ChooseBoth(newBread, newPastry);
        }
    }

    //Must take both bread and pastry objects as parameters so the user can choose to order bread or pastries multiple times
    static void ChooseBread(Bread newBread, Pastry newPastry)
    {
        Console.WriteLine("Please enter the amount of bread loaves you would like to order.");
        Console.WriteLine("Bread loaves are currently buy 2 get one free!");
        string amountOrdered = Console.ReadLine();
        int loaves = int.Parse(amountOrdered);
        newBread.LoavesOrder = loaves;

        //Updating totalprice to be displayed
        newBread.TotalLoaves += loaves;
        newBread.GetBreadTotalPrice();
        Console.WriteLine("You've Ordered " + newBread.LoavesOrder + " loaves of bread");
        Console.WriteLine("The total price for your loaves of bread is $" + newBread.TotalPrice);
        Console.WriteLine("");
        Console.WriteLine("Would you like to order more? Please type 'Bread' to order Bread, 'Pastries' to order Pastries or 'both' if you would like to order both, or enter 'checkout bread' if you ordered only bread, otherwise enter 'checkout'");

        // Branching so user can input multiple times
        string CustomerOption = Console.ReadLine();
        if (CustomerOption == "Checkout Bread" || CustomerOption == "checkout bread")
        {
            CheckoutBread(newBread);
        } else if (CustomerOption == "Checkout" || CustomerOption == "checkout")
        {
            Checkout(newBread, newPastry);
        }
        else if (CustomerOption == "Bread" || CustomerOption == "bread")
        {
            ChooseBread(newBread, newPastry);
        } else if (CustomerOption == "Pastries" || CustomerOption == "pastries")
        {
            ChoosePastry(newBread, newPastry);
        }
    }

    static void ChoosePastry(Bread newBread, Pastry newPastry)
    {
        Console.WriteLine("Please enter the amount of pastries you would like to order.");
        Console.WriteLine("Pastries are currently buy 3 get one free!");
        string amountOrdered = Console.ReadLine();
        int pastries = int.Parse(amountOrdered);
        newPastry.PastryOrder = pastries;
        newPastry.TotalPastries += pastries;
        newPastry.GetPastryTotalPrice();
        Console.WriteLine("You've Ordered " + newPastry.PastryOrder + " pastries");
        Console.WriteLine("The total price for your pastries is $" + newPastry.PastryTotalPrice);
        Console.WriteLine("");
        Console.WriteLine("Would you like to order more? Please type 'Bread' to order Bread, 'Pastries' to order Pastries or 'both' if you would like to order both, or enter 'checkout pastries' if you ordered only bread, otherwise enter 'checkout'");
        string CustomerOption = Console.ReadLine();
        if (CustomerOption == "Checkout Pastries" || CustomerOption == "checkout pastries")
        {
            CheckoutPastry(newPastry);
        } else if (CustomerOption == "Checkout" || CustomerOption == "checkout")
        {
            Checkout(newBread, newPastry);
        }
        else if (CustomerOption == "Bread" || CustomerOption == "bread")
        {
            ChooseBread(newBread, newPastry);
        } else if (CustomerOption == "Pastries" || CustomerOption == "pastries")
        {
            ChoosePastry(newBread, newPastry);
        }
    }

    static void ChooseBoth(Bread newBread, Pastry newPastry)
    {
        Console.WriteLine("Please enter the amount of bread you would like to order.");
        Console.WriteLine("Bread loaves are currently buy 2 get one free!");
        string amountOrdered = Console.ReadLine();
        int loaves = int.Parse(amountOrdered);
        newBread.LoavesOrder = loaves;
        newBread.TotalLoaves += loaves;
        newBread.GetBreadTotalPrice();
        Console.WriteLine("You've Ordered " + newBread.LoavesOrder + " loaves of bread");
        Console.WriteLine("The total price for your loaves of bread is $" + newBread.TotalPrice);
        Console.WriteLine("Please enter the amount of pastries you would like to order.");
        Console.WriteLine("Pastries are currently buy 3 get one free!");
        string pastriesAmountOrdered = Console.ReadLine();
        int pastries = int.Parse(pastriesAmountOrdered);
        newPastry.PastryOrder = pastries;
        newPastry.TotalPastries += pastries;
        newPastry.GetPastryTotalPrice();
        Console.WriteLine("You've Ordered " + newPastry.PastryOrder + " pastries");
        Console.WriteLine("The total price for your pastries is $" + newPastry.PastryTotalPrice);
        Console.WriteLine("Would you like to order more? Please type 'Bread' to order Bread, 'Pastries' to order Pastries or 'both' if you would like to order both, or enter 'checkout' to end the transaction");
        string CustomerOption = Console.ReadLine();
        if (CustomerOption == "Checkout" || CustomerOption == "checkout")
        {
            Checkout(newBread, newPastry);
        } else if (CustomerOption == "Checkout Bread" || CustomerOption == "checkout bread")
        {
            CheckoutBread(newBread);
        }
        else if (CustomerOption == "Bread" || CustomerOption == "bread")
        {
            ChooseBread(newBread, newPastry);
        } else if (CustomerOption == "Pastries" || CustomerOption == "pastries")
        {
            ChoosePastry(newBread, newPastry);
        }

    }

    //Checkout shows final price and ends the program
    static void Checkout(Bread newBread, Pastry newPastry)
    {
        Console.WriteLine("Your total checkout price for loaves of bread is: $" + newBread.TotalPrice);
        Console.WriteLine("Your total checkout price for Pastries is: $" + newPastry.PastryTotalPrice);
    }
      static void CheckoutBread(Bread newBread)
    {
       Console.WriteLine("Your total checkout price for loaves of bread is: $" + newBread.TotalPrice);
    }
    static void CheckoutPastry(Pastry newPastry)
    {
        Console.WriteLine("Your total checkout price for Pastries is: $" + newPastry.PastryTotalPrice);
    }
  
}
