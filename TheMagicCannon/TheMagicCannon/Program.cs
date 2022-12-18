/* TODO:
 * [x] Write a program that prints values of 1 - 100
 * 
 * [x] Determine if the loop iteration activates the fire gem (3)
 * [x] Change the color of the output if the fire gem activates
 * 
 * [x] Determine if the loop iteration activates the electric gem (5)
 * [x] Change the color of the output if the electric gem activates
 * 
 * [x] Determine if the loop iteration activates both gems (3 and 5)
 * [x] Change the color of the output if both gems activate
 * 
 */

for (int cannonTimesCranked = 1; cannonTimesCranked <= 100; cannonTimesCranked++)
{
    string cannonBlastType;

    if (cannonTimesCranked % 3 == 0 && cannonTimesCranked % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        cannonBlastType = "Combined!";
    }
    else if (cannonTimesCranked % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        cannonBlastType = "Fire";
    }
    else if (cannonTimesCranked % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        cannonBlastType = "Electric";
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        cannonBlastType = "Normal";
    }
        
    Console.WriteLine($"{cannonTimesCranked}: {cannonBlastType}");
}