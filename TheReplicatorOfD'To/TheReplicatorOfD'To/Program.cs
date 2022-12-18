/* TODO:
 * [x] Create an array of length 5
 * [x] Prompt user to input 5 integers 
 * [x] Store 5 integers into an array
 * [x] Create a second array of length 5
 * [x] Copy the values of the first array into the second array
 * [x] Display the contents of both arrays one at a time 
 */

int[] arrayOriginal = new int[5];
for (int i = 0; i < arrayOriginal.Length; i++)
{
    Console.Write("Please enter an integer to store: ");
    arrayOriginal[i] = Convert.ToInt32(Console.ReadLine());
}

int[] arrayCopy = new int[5];
arrayCopy = arrayOriginal[0..]; // start at 0 and copy the rest of the elements

/* more optimal code
 * Array.Copy(source array, destination, length of array)
 * Array.Copy(arrayOriginal, arrayCopy, 5)
 */

Console.WriteLine("Original array contents:");
for (int i = 0; i < arrayOriginal.Length; i++)
{
    Console.Write($"{arrayOriginal[i]} ");
}

Console.WriteLine("\nCopy of original array's contents:");
for (int i = 0; i < arrayCopy.Length; i++)
{
    Console.Write($"{arrayCopy[i]} ");
}