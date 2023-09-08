

List<string> namesList = new();
string nameInput;
do
{
    Console.WriteLine("Enter first name(s), enter \"stop\" to stop input: ");
    nameInput = Console.ReadLine();

    if (nameInput.ToLower() != "stop")
    {
        namesList.Add(nameInput);
    }

} while (nameInput.ToLower() != "stop");


foreach (var name in namesList)
{
    Console.WriteLine($"Hello {name}");
}

