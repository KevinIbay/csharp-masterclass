

Console.WriteLine("What is your name?");
string? name = Console.ReadLine();

if (name.ToLower() == "tim")
{
    Console.WriteLine("Welcome Professor Tim.");
}
else
{
    Console.WriteLine($"Welcome {name}.");
}




