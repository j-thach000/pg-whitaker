// Build a program with a variable of all fourteen types described
// Assign each of them a value using a literal of the correct type
// Use Console.WriteLine to display the contents of each variable

using System;

Console.WriteLine("[The Variable Shop]");

int type_int = 1;                              // -2,147,483,648  2,147,483,647
short type_short = 29_000;                     // -32,768  32,767
long type_long = 9_000_000_000_000_000_000;    // +/- 9 * 10^18
byte type_byte = 255;                          // 0 - 255
sbyte type_sByte = 127;                        // -128  127
uint type_uint = 4_000_000_000;                // 0  4,294,967,295
ushort type_ushort = 65_000;                   // 0 32,767
ulong type_ulong = 18_000_000_000_000_000_000; // 0 

char type_char = 'a';
string type_string = "buh";

float type_float = 3.5623f; // 7 digits of precision
double type_double = 3.5623; // 15-16 digits of precision
decimal type_decimal = 3.5623m; // 28-29 digits of precision

bool type_bool = true;

Console.WriteLine("int: " + type_int);
Console.WriteLine("short: " + type_short);
Console.WriteLine("long: " + type_long);
Console.WriteLine("sbyte: " + type_sByte);
Console.WriteLine("byte: " + type_byte);
Console.WriteLine("uint: " + type_uint);
Console.WriteLine("ushort: " + type_ushort);
Console.WriteLine("ulong: " + type_ulong);

Console.WriteLine("char: " + type_char);
Console.WriteLine("string: " + type_string);

Console.WriteLine("float: " + type_float);
Console.WriteLine("double: " + type_double);
Console.WriteLine("decimal: " + type_decimal);

// Assign a new literal value for the 14 original variables and then print the
// contents.
Console.WriteLine("[The Variable Shop Returns]");

type_int = 5;                              // -2,147,483,648  2,147,483,647
type_short = 30_000;                     // -32,768  32,767
type_long = 5_000_000_000_000_000_000;    // +/- 9 * 10^18
type_byte = 100;                          // 0 - 255
type_sByte = 24;                        // -128  127
type_uint = 3_000_000_000;                // 0  4,294,967,295
type_ushort = 42_000;                   // 0 60k~
type_ulong = 5_000_000_000_000_000_000; // 0 

type_char = 'z';
type_string = "guh";

type_float = 5.5623f; // 7 digits of precision
type_double = 5.5623; // 15-16 digits of precision
type_decimal = 5.5623m; // 28-29 digits of precision

type_bool = false;

Console.WriteLine("int: " + type_int);
Console.WriteLine("short: " + type_short);
Console.WriteLine("long: " + type_long);
Console.WriteLine("sbyte: " + type_sByte);
Console.WriteLine("byte: " + type_byte);
Console.WriteLine("uint: " + type_uint);
Console.WriteLine("ushort: " + type_ushort);
Console.WriteLine("ulong: " + type_ulong);

Console.WriteLine("char: " + type_char);
Console.WriteLine("string: " + type_string);

Console.WriteLine("float: " + type_float);
Console.WriteLine("double: " + type_double);
Console.WriteLine("decimal: " + type_decimal);