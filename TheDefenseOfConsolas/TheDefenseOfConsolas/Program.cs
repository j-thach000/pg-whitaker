/* TODO:
 * O Ask user for target row
 * O Ask user for target column
 * - Compute the neighboring rows and columns
 * - Display deployment instructions in a different color
 * O Change window title to be "Defense of Consolas"
 * O Play a sound when results have been computed and displayed
 */

Console.Title = "Defense of Consolas";
Console.Write("Target Row? ");
int targetRow = Convert.ToInt16(Console.ReadLine()); 
Console.Write("Target Column? ");
int targetColumn = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Deploy to:");
int northSquadmateRow = targetRow + 1;
int northSquadmateColumn = targetColumn;
Console.WriteLine($"North Squadmate: ({northSquadmateRow}, {northSquadmateColumn})");
int southSquadmateRow = targetRow - 1;
int southSquadmateColumn = targetColumn;
Console.WriteLine($"South Squadmate: ({southSquadmateRow}, {southSquadmateColumn})");
int westSquadmateRow = targetRow;
int westSquadmateColumn = targetColumn - 1;
Console.WriteLine($"West Squadmate : ({westSquadmateRow}, {westSquadmateColumn})");
int eastSquadmateRow = targetRow;
int eastSquadmateColumn = targetColumn + 1;
Console.WriteLine($"East Squadmate : ({eastSquadmateRow}, {eastSquadmateColumn})");
Console.Beep();