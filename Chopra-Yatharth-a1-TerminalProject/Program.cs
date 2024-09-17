using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Hi User, you have come to a fork and have 2 options: either take Road T or Road M. Please enter 'T' or 'M': ");
        string userChoice = Console.ReadLine().ToUpper(); // this is the first user choice for road town and mountain

        // used bool to see if the user chose road T or M
        bool isTown = (userChoice == "T");
        bool isMountain = (userChoice == "M");

        if (isTown)
        {
            Console.WriteLine("You have chosen the road to the Town and have ended up there.");
        }
        else if (isMountain)
        {
            Console.WriteLine("You have chosen the road to the Mountain and have ended up there.");
        }
        else
        {
            Console.WriteLine("Invalid choice! Please try again.");
        }

        // second choice asking the user for the other roads
        Console.Write("Now User, since you chose that road do you want to go to the Road M, or continue your journey on Road C or Road R: ");
        string secondChoice = Console.ReadLine().ToUpper(); // Second choice to roads mountains, caves and river

        if (secondChoice == "M")
        {
            Console.WriteLine("Alright then, you have chosen the road to the Mountain and have ended up there.");
        }
        else if (secondChoice == "C")
        {
            Console.WriteLine("You have chosen the road to the Caves and now can explore them.");
        }
        else if (secondChoice == "R")
        {
            Console.WriteLine("You chose the road to the River and can relax for the time being.");
        }
        else
        {
            Console.WriteLine("Invalid choice! Please try again.");
        }

        // third choice asking the user for the other roads
        Console.Write("Now User, after building up the adventure which road you want to take now, Road M/T, or continue your journey on Road CS: ");
        string thirdChoice = Console.ReadLine().ToUpper(); // third choice to roads mountains, town and countryside

        if (thirdChoice == "M")
        {
            Console.WriteLine("Alright then, you have chosen the road to the Mountain and have ended up there.");
        }
        else if (thirdChoice == "T")
        {
            Console.WriteLine("You have chosen the road to the Town and now can go back.");
        }
        else if (thirdChoice == "CS")
        {
            Console.WriteLine("You chose the road to the Countryside and can enjoy your peace in the meadows.");
        }
        else
        {
            Console.WriteLine("Invalid choice! Please try again.");
        }

        // fourth choice asking the user for the other roads
        Console.Write("Now User, you are the end of the adventure and if you want to go back you can otherwise continue to your journey. Road T, M, C, R, CS or Road N: ");
        string fourthChoice = Console.ReadLine().ToUpper(); // fourth choice to either now finally go back or no

        if (fourthChoice == "M")
        {
            Console.WriteLine("Alright then, you have chosen the road to the Mountain and have ended up there.");
        }
        else if (fourthChoice == "T")
        {
            Console.WriteLine("You have chosen the road to the Town and now can go back.");
        }
        else if (fourthChoice == "CS")
        {
            Console.WriteLine("You chose the road to the Countryside and can enjoy your peace in the meadows.");
        }
        else if (fourthChoice == "R")
        {
            Console.WriteLine("You chose the road to the River and can relax for the time being.");
        }
        else if (fourthChoice == "C")
        {
            Console.WriteLine("You chose the road to the Caves and can explore them.");
        }
        else if (fourthChoice == "N")
        {
            Console.WriteLine("You have entered Nether and now have to fight the final boss, Good Luck!.");
        }
        else
        {
            Console.WriteLine("Invalid choice! Please try again.");
        }
    }
}