// See https://aka.ms/new-console-template for more information

// computes the area of a triangle
Console.WriteLine("[Triangle Area Calculator]");
Console.WriteLine("Enter triangle base length: ");
string base_text = Console.ReadLine();
double length_base = Convert.ToDouble(base_text);
Console.WriteLine("Enter triangle height length: ");
string length_text = Console.ReadLine();
double length_height = Convert.ToDouble(length_text);
double triangle_area = (length_base * length_height) / 2;
Console.WriteLine("Area = " + triangle_area);