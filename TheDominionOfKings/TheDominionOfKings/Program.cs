// See https://aka.ms/new-console-template for more information
/*
 * Todo:
 * Take and store user input for estates, duchies, and provinces
 * Add up user scores from input
 * Display point total to the user
 */

// get and store user input
Console.WriteLine("Enter the total number of estates owned: ");
string estatesOwnedText = Console.ReadLine();
int estatesOwned = Convert.ToInt16(estatesOwnedText);
Console.WriteLine("Enter the total number of duchies owned: ");
string duchiesOwnedText = Console.ReadLine();
int duchiesOwned = Convert.ToInt16(duchiesOwnedText);
Console.WriteLine("Enter the total number of provinces owned: ");
string provincesOwnedText = Console.ReadLine();
int provincesOwned = Convert.ToInt16(provincesOwnedText);

// calculate point totals
int estateValueTotal = 1 * estatesOwned;
int duchyValueTotal = 3 * duchiesOwned;
int provinceValueTotal = 6 * provincesOwned;
int userPointTotal = estateValueTotal + duchyValueTotal + provinceValueTotal;

// print point total
Console.WriteLine("Point total: " + userPointTotal);