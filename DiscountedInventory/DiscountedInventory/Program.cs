/* TODO:
 * [x] Print the menu shown in the text
 * [x] Ask user to enter a number from the menu
 * [x] Use a switch statement or expression to output the menu item's cost
 * [] Modify program to ask user for name after inputting menu choice
 * [] If the inputted name is the same as the user's IRL name, halve costs
 */

/* Prices (gold):
 * Rope - 10
 * Torches - 15
 * Climbing Equipment - 25
 * Clean Water - 1
 * Machete - 20
 * Canoe - 200
 * Food Supplies - 1
 */

Console.WriteLine("The following items are available: ");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

Console.Write("What item do you want to see the price of? ");
int menuChoice = Convert.ToInt16(Console.ReadLine());

Console.Write("What is your name? ");
string customerName = Console.ReadLine();

string menuItem = menuChoice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "Unknown"
};

// think about data types and whether we're losing information    
float menuItemCost = menuChoice switch 
{
    1 => 10,
    2 => 15,
    3 => 25 ,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => 0
};

// use of compound assignment operator and separating logic
if (customerName == "Programmer")
{
    menuItemCost /= 2;
    Console.WriteLine("Ah, let me repay you for your favor, half off!");
}

// ideally tell the user the item and its cost
Console.WriteLine($"[{menuItem}] will cost you [{menuItemCost}] gold.");