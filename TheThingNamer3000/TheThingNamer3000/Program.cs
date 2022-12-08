// See https://aka.ms/new-console-template for more information
/*
The program takes in input of a thing's name and one of three descriptors.
Afterwards it prints out the name of it alongside all descriptors.

There was a bug where "of" was displayed twice and the fix was to remove it
in the print statement as opposed to the variable
*/
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // name of the thing
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); // a descriptor for the thing named
string c = "of Doom"; // descriptor
string d = "3000"; // descriptor
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");

