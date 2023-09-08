

// ask for name

// if Tim welcome as professor

// else welcome as student

// ask until user types "exit"

string name;

do
{
    Console.WriteLine("What is your name?");
    name = Console.ReadLine();
    if (name.ToLower() == "tim")
    {
        Console.WriteLine($"Welcome Professor {name}");
    }
    else
    {
        Console.WriteLine($"Welcome {name}");
    }
}
while (name.ToLower() != "exit");