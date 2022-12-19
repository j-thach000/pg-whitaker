/* TODO:
 * [x] Modify the for loop computing an array's minimum to use foreach
 * [x] Modify the for loop computing an array's average to use foreach
 */

// for min
/*
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue;
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < currentSmallest) currentSmallest = array[index];
}
Console.WriteLine(currentSmallest);
 */

// foreach min
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int min = int.MaxValue;
foreach (int currentElement in array)
{
    if (currentElement < min) min = currentElement;
}
Console.WriteLine(min);

// for avg
/*
int[] arrayAverage = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int total = 0;
for (int index = 0; index < array.Length; index++) total += arrayAverage[index];
float average = (float)total / array.Length;
Console.WriteLine(average);
 */

// foreach avg
int[] arrayAverage = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
foreach (int currentElement in arrayAverage)
{
    total += currentElement;
}
float average = (float)total / array.Length;
Console.WriteLine(average);