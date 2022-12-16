/* TODO:
 * [x] Take a number as input from user
 * [x] Display the word "Tick" if user input is even
 * [x] Display the word "Tock" if user input is odd
 */

Console.Write("Input: ");
int clockTickTock = Convert.ToInt16(Console.ReadLine());

if (clockTickTock % 2 == 0) Console.WriteLine("Tick");
else                        Console.WriteLine("Tock");