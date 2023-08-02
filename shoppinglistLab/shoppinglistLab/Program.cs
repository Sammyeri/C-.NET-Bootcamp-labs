//shopping list

//initializing the menu

Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
menu.Add("potatoes", 7.95m);
menu.Add("turnip", 6.55m);
menu.Add("steak", 10.99m);
menu.Add("chicken", 12.99m);
menu.Add("milk", 1.85m);
menu.Add("butter", 2.99m);
menu.Add("eggs", 5.99m);
menu.Add("oranges", 6.32m);


//initializing the order ticket

List<string> order = new List<string>();

bool again = true;
while (again)
{

    //display at least 8 items name and prices

    foreach (KeyValuePair<string, decimal> kvp in menu)
    {
        if(kvp.Key == "potatoes")
        {
            Console.WriteLine($"{kvp.Key}\t {kvp.Value}");
        }
        else
        {
            Console.WriteLine($"{kvp.Key}\t \t {kvp.Value}");
        }
    }

    //ask user to enter item name 

    while (true)
    {
        Console.WriteLine("Please enter an item name");
        string userInput = Console.ReadLine();

        userInput = userInput.Trim().ToLower();

        //if exists display item and price, add to order use list string

        if (menu.ContainsKey(userInput))
        {
            Console.WriteLine($"{menu[userInput]}");
            order.Add(userInput);
            break;
        }
        //if not display error and re-prompt user
        else
        {
            Console.WriteLine($"Sorry, {userInput} is not a valid menu item.");
            continue;
        }
    }

    //ask user if want to add another

    while (true)
    {
        Console.WriteLine("Would you like to add another item to the list? (y/n)");
        ConsoleKeyInfo choice = Console.ReadKey();
        Console.WriteLine(" ");

        if (choice.KeyChar == 'y')
        {
            break;
        }
        else if (choice.KeyChar == 'n')
        {
            again = false;
            break;
        }
        else
        {
            Console.WriteLine($"Sorry, {choice.KeyChar} is not a valid option");
            continue;
        }
    }


    //when they're done adding display items ordered with prices in columns

    decimal total = 0;

    foreach (string item in order)
    {
        Console.WriteLine($"{item} \t{menu[item]}");
        total += menu[item];
    }

    //display sum price of items ordered
    Console.WriteLine($"Total: {total}");
}