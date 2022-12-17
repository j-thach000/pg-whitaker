/* TODO:
 * [x] Allow the first user (pilot) to enter a number, inputPilot
 * [x] Prompt user input again if inputPilot < 0 and inputPilot > 100
 * [x] Clear the screen once the user gives valid input
 * [x] Allow the second user (hunter) to enter a number, inputHunter
 * [x] Indicate whether the hunter's guess was too high, too low, or correct
 * [x] Repeat the process until the unter's guess is correct and then exit
 */

// do while loops are good for efficient input validation
int inputPilot;
do
{
    Console.Write("Pilot, enter a number between 0 and 100: ");
    inputPilot = Convert.ToInt32(Console.ReadLine());
}
while (inputPilot < 0 || inputPilot > 100);

Console.Clear();

// input validation with logic printing feedback
Console.WriteLine("Hunter, guess the number.");
int inputHunter;
do
{
    Console.Write("What is your next guess? ");
    inputHunter = Convert.ToInt32(Console.ReadLine());
    if (inputHunter < inputPilot)
        Console.WriteLine($"{inputHunter} is too low.");
    else if (inputHunter > inputPilot)
        Console.WriteLine($"{inputHunter} is too high.");
    else
        Console.WriteLine("You guessed the number!");
}
while (inputHunter != inputPilot);