/* TODO: 
 * [x] define a method AskForNumber 
 * [x] prompt user for input
 * [x] convert the string to int
 * [x] return the output
 * [x] define a method AskForNumberInRange
 * [x] only have it return if the entered number is between min and max 
 */

int AskForNumber(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    // completely valid as well, we just need a value in a certain range
    int number;
    do
    {
        Console.Write(text);
        number = Convert.ToInt32(Console.ReadLine());
    }
    while (number < min || number > max);

    return number;

    /* since this code is in a function it's okay to set the loop this way
     * as the value returned immediately ends the loop
    while (true)
    {
        Console.Write(text);
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= min || number <= max) return number;
    }
     */
}