

Console.Write("What is your age? ");
bool isValid = int.TryParse(Console.ReadLine(), out int age);
Console.WriteLine($@"You will be {age + 25} years old in 25 years.");
Console.WriteLine($@"You were {age - 25} years old 25 years ago.");


