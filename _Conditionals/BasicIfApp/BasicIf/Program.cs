


Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName != null && firstName.ToLower() == "kevin")
{
    Console.WriteLine("Hello Mr. Ibay");
}
else
{
    Console.WriteLine($"Hello {firstName}");
}
Console.WriteLine("End of program.");