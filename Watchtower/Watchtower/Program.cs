/* TODO:
 * [x] Prompt and store user's input for x coordinate
 * [x] Prompt and store user's input for y coordinate
 * [x] Implement logic deciding the direction an enemy is coming from
 */

// prompt and store user input
Console.Write("Input enemy coordinate x: ");
int enemyCoordinateX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input enemy coordinate y: ");
int enemyCoordinateY = Convert.ToInt32(Console.ReadLine());

// logic deciding enemy direction
string enemyDirection = "";
if (enemyCoordinateX < 0 && enemyCoordinateY > 0)
    enemyDirection = "northwest!";
else if (enemyCoordinateX == 0 && enemyCoordinateY > 0)
    enemyDirection = "north.";
else if (enemyCoordinateX > 0 && enemyCoordinateY > 0)
    enemyDirection = "northeast!";
else if (enemyCoordinateX < 0 && enemyCoordinateY == 0)
    enemyDirection = "west!";
else if (enemyCoordinateX > 0 && enemyCoordinateY == 0)
    enemyDirection = "east!";
else if (enemyCoordinateX < 0 && enemyCoordinateY < 0)
    enemyDirection = "southwest!";
else if (enemyCoordinateX == 0 && enemyCoordinateY < 0)
    enemyDirection = "south!";
else if (enemyCoordinateX > 0 && enemyCoordinateY < 0)
    enemyDirection = "southeast!";

// print enemy direction
if (enemyCoordinateX == 0 && enemyCoordinateY == 0)
    Console.WriteLine("The enemy is here!!!");
else
    Console.WriteLine("The enemy is approaching from the " + enemyDirection);