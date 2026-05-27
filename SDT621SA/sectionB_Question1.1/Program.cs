Console.Write("Welcome to the structure of a C# program demo!\nEnter your name:");
string name = Console.ReadLine()!;
if(name.Length != 0)
{
    Console.WriteLine($"Hello {name}!");
Console.WriteLine("Program Structure Demonstrated:\n1. using System : imports functionality\n2. namespace : imports functionality\n3. class Program : container for code\n4. Main() : entry point of program\n5. Comments : explain logic and documentation\n\nProgram executed successfully.");
}
else
{
    Console.WriteLine("A name must be entered");
}
