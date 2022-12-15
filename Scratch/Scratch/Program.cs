// formatting
Console.WriteLine($"{Math.PI}");
Console.WriteLine($"{Math.PI:0.000}");
Console.WriteLine($"{0006942000:#.##}");

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