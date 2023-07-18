﻿Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
shop.Add("apple", .99m);
shop.Add("banana", .59m);
shop.Add("cauliflower", 1.59m);
shop.Add("dragonfruit", 2.19m);
shop.Add("elderberry", 1.79m);
shop.Add("figs", 2.09m);
shop.Add("grapefruit", 1.99m);
shop.Add("honeydew", 3.49m);

List<string> order = new List<string>();
decimal total = 0.00m;

Console.WriteLine("Welcome to the Shopping List");

bool runProgram = true;
while (runProgram)
{
    foreach (KeyValuePair<string, decimal> kvp in shop)
    {
        Console.WriteLine($"{kvp.Key}, || {kvp.Value}");
    }
    Console.WriteLine("Please enter an item you would like to order: ");
    string fruit = Console.ReadLine();
    if (shop.ContainsKey(fruit))
    {
        decimal cost = shop[fruit];
        Console.WriteLine($"Adding {fruit} to your cart at {cost}");
        order.Add(fruit);

        total = total + cost;

    }
    else
    {
        Console.WriteLine("word doesn't exist");
    }
    Console.WriteLine("Would you like to add an additional item? y/n");
    string choice = Console.ReadLine();
    if (choice == "n")
    {
        runProgram = false;
        Console.WriteLine($"Here is your final order: ");
        foreach (string s in order)
        {
            Console.WriteLine($"{s}    {shop[s]}");         
        }
        decimal average = total / (order.Count);
        decimal avgorder = Math.Round(average, 2);
        Console.WriteLine($"Your total is {total}");
        Console.WriteLine($"The average item price is {avgorder}");
    }
}



Console.ReadLine();