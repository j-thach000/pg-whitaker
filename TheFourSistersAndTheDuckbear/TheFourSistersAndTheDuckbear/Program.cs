// See https://aka.ms/new-console-template for more information

/*
 * Todo:  
 * accept user input for integers
 * store and print the amount of eggs for the sisters
 * store and print the amount of eggs for the duckbear
 */

Console.WriteLine("Enter the number of eggs gathered today: ");
string eggsText = Console.ReadLine();
int eggs = Convert.ToInt16(eggsText);
int eggsReceivedBySisters = eggs / 4; // 4 sisters described in challenge
int eggsReceivedByDuckbear = eggs % 4;
Console.WriteLine("Eggs received by sisters: " + eggsReceivedBySisters);
Console.WriteLine("Eggs received by duckbear: " + eggsReceivedByDuckbear);