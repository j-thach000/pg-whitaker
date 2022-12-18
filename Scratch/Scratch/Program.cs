/* [x] declare an array
 * [x] access an element
 * [x] change an element in an array
 * [x] get the length of an array
 * [x] get the last value in an array
 * [x] create an array whose elements are a copy of a range of elements
 * [x] create a prepopulated array
 * [x] given an array of integers, find the minimum value
 * [] given an array of integers, calculate the average of the values
 */

// * [] given an array of integers, calculate the average of the values
int[] example = new int[] { 69, 420, 123, 1, 6, 3, 2, 5 };
int sum = 0;
for (int index = 0; index < example.Length; index++)
    sum += example[index];
Console.WriteLine($"Average of array elements: {sum / example.Length}");

/* #### 12/17/22

// * [] given an array of integers, find the minimum value
int[] example = new int[] { 69, 420, 123, 1, 6, 3, 2, 5 };
int min = example[0];
for (int i = 0; i < example.Length; i++)
{
    Console.WriteLine($"Current min element: {min}");
    if (example[i] < min) min = example[i];
}
Console.WriteLine($"Array's min element: {min}");

// array syntax
int[] scores = new int[10];
Console.WriteLine(scores[0]);
scores[0] = 5;
Console.WriteLine(scores[0]);
Console.WriteLine(scores.Length);
scores[9] = 123;
Console.WriteLine(scores[9]);
scores[^1] = 500;
Console.WriteLine(scores[^1]);
scores[8] = 456;
int[] lastTwoScores = scores[8..];
for (int i = 0; i < lastTwoScores.Length; i++)
    Console.WriteLine(lastTwoScores[i]);
string[] authorsTwo = new string[2] { "Murakami", "Dostoevsky" };
for (int i = 0; i < authorsTwo.Length; i++) Console.WriteLine(authorsTwo[i]);
string[] directorsUnlimited = new string[] { "Tarantino" };
for (int i = 0; i < directorsUnlimited.Length; i++) Console.WriteLine(directorsUnlimited[i]); 

Console.WriteLine("[Asterisk Grid Creator]");
Console.Write("Rows   : ");
int totalRows = Convert.ToInt16(Console.ReadLine());
Console.Write("Columns: ");
int totalColumns = Convert.ToInt16(Console.ReadLine());

for (int currentRow = 1; currentRow <= totalRows; currentRow++)
{
    for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// multiplication table of 1-10
for (int a = 1; a <= 10; a++)
    for (int b = 1; b <= 10; b++)
        Console.WriteLine($"{a} * {b} = {a * b}");

 int x = 1;
while (x <= 5)
{
    Console.WriteLine(x);
    x++;
}

// while loop (variable must have value assigned for boolean exp to evaluate)
int playersNumber = -1; 

while (playersNumber < 0 || playersNumber > 10)
{
    Console.Write("Enter a number between 0 and 10: ");
    string playerResponse = Console.ReadLine();
    playersNumber = Convert.ToInt16(playerResponse);     
}

// do while loop (variable assigned via body statements)
int playersNumber;
do
{
    Console.Write("Enter a number between 0 and 10: ");
    string playerResponse = Console.ReadLine();
    playersNumber = Convert.ToInt16(playerResponse);
}
while (playersNumber < 0 || playersNumber > 10);

// for loop


// int x = 1;
// while (x <= 5)
// {
//    Console.WriteLine(x);
//    x++;
// }

for (int x = 1; x <=5; x++) Console.WriteLine(x);
 * 
 */

/* #### 12/16/22
// switch expression version
Console.WriteLine("Avast, matey! What be ye desire?");
Console.WriteLine("1 - Rest");
Console.WriteLine("2 - Pillar the port");
Console.WriteLine("3 - Set sail");
Console.WriteLine("4 - Release the Kraken");
Console.WriteLine("What be the plan, Captain?");

int choice = Convert.ToInt16(Console.ReadLine());

string response = choice switch
{
    1 => "Ye rest and recover your health.",
    2 => "Raiding the port town got ye 50 gold doubloons.",
    3 => "The wind is at your back; the open horizon ahead.",
    4 => "'Tis but a baby Kraken, but still eats toy boats.",
    _ => "Apologies. I do not know that one."
};

Console.WriteLine(response);


// switch statement version
Console.WriteLine("Avast, matey! What be ye desire?");
Console.WriteLine("1 - Rest");
Console.WriteLine("2 - Pillar the port");
Console.WriteLine("3 - Set sail");
Console.WriteLine("4 - Release the Kraken");
Console.WriteLine("What be the plan, Captain?");

int choice = Convert.ToInt16(Console.ReadLine());

switch (choice) // provides more optimal code (easier to read and maintainable)
{
    case 1:
        Console.WriteLine("Ye rest and recover your health.");
        break;
    case 2:
        Console.WriteLine("Raiding the port town got ye 50 gold doubloons.");
        break;
    case 3:
        Console.WriteLine("The wind is at your back; the open horizon ahead.");
        break;
    case 4:
        Console.WriteLine("'Tis but a baby Kraken, but still eats toy boats.");
        break;
    default:
        Console.WriteLine("Apologies. I do not know that one.");
        break;

}

// if else version
Console.WriteLine("Avast, matey! What be ye desire?");
Console.WriteLine("1 - Rest");
Console.WriteLine("2 - Pillar the port");
Console.WriteLine("3 - Set sail");
Console.WriteLine("4 - Release the Kraken");
Console.WriteLine("What be the plan, Captain?");

int choice = Convert.ToInt16(Console.ReadLine());

if (choice == 1)
    Console.WriteLine("Ye rest and recover your health.");
else if (choice == 2)
    Console.WriteLine("Raiding the port town got ye 50 gold doubloons.");
else if (choice == 3)
    Console.WriteLine("The wind is at your back; the open horizon ahead.");
else if (choice == 4)
    Console.WriteLine("'Tis but a baby Kraken, but still eats toy boats.");
else Console.WriteLine("Apologies. I do not know that one.");

 */

/* #### 12/14/22
 *  
// Write method
Console.Write("Buh don't jump to the next line.");
Console.WriteLine(" This should still continue on the same line.");
Console.Write("What is your name? ");
string username = Console.ReadLine();
Console.WriteLine("Ah, I see.");

// ReadKey method
Console.WriteLine("Press any key to continue...");
Console.ReadKey(true); // no char displayed

// Clear Method
Console.Write("Buh don't jump to the next line.");
Console.WriteLine(" This should still continue on the same line.");
Console.Write("What is your name? ");
string username = Console.ReadLine();
Console.WriteLine("Ah, I see.");
Console.Clear(); // clears the console, ie wiping all text out

Console.Title = "Hello, World!";

// Beep Method
Console.Beep();
Console.Beep(440, 1000); // frequency, duration

// escape sequences
// Console.WriteLine("""; the third " produces an unclosed string literal
// \"" tells the compiler that whatever is in quotes as literals
Console.WriteLine("He said \"Buh.\" and ended it there.");

// String Interpolation
int myFavoriteNumber = 7;
Console.Write("My favorite number is " + myFavoriteNumber + "." + "\n");
Console.WriteLine($"My favorite number is {9 + 10}.");

// Alignment
string name1 = Console.ReadLine();
string name2 = Console.ReadLine();
Console.WriteLine($"#1: {name1, 20}");
Console.WriteLine($"#2: {name2, 20}");
Console.WriteLine($"#1: {name1,-20} - 1");
Console.WriteLine($"#2: {name2,-20} - 2");

// formatting
Console.WriteLine($"{Math.PI}");
Console.WriteLine($"{Math.PI:0.000}"); // unnecessary 0s
Console.WriteLine($"{0006942000:#.##}"); // only displays significant figures

 *
*/

/* #### 12/13/22
 *  
// in C# specifically reading keyboard input only returns string
// need a placeholder variable and then convert to the desired type
Console.Write("What is your favorite number? ");
string favoriteNumberText = Console.ReadLine();
int favoriteNumber = Convert.ToInt32(favoriteNumberText);
Console.WriteLine(favoriteNumber + " is a great number!");
 *
*/



/* #### 12/09/22
 // initial declaration and assignment of username
Console.WriteLine("Input username: ");
string username; // declaring a variable
username = Console.ReadLine(); // assigning a value to a variable
Console.WriteLine("Hi " + username);

// assigning username another value
Console.WriteLine("Input another username: ");
username = Console.ReadLine();
Console.WriteLine("Hi " + username);

// assigning username another value
Console.WriteLine("Input favorite color: ");
string favoriteColor;
favoriteColor = Console.ReadLine();
Console.WriteLine("Your favorite color is " + favoriteColor);

// int data types
int score;
score = 4;
Console.WriteLine(score);
score = 11;
Console.WriteLine(score);
score = -1564;
Console.WriteLine(score);
// wish i knew how to declare some data structure to hold all these ints atm

int a, b, c;
a = b = c = 10;
Console.WriteLine(a + b + c);
*/