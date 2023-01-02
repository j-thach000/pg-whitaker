// first attempt
// recursive countdown print
/*
int Countdown(int value)
{
    Console.WriteLine(value);
    if (value == 1) return 1; // close, but just stop on a value that's not
                              // printed
                              // also we can return in void methods to stop
                              // early
    return Countdown(value - 1);
}

Countdown(10);
*/

void Countdown(int value)
{
    // list base case first
    if (value == 0) return;

    Console.WriteLine(value);

    // working towards the base case to end 
    Countdown(value - 1);
}

Countdown(10);