
Console.WriteLine("Input a comma-separated list of first names with no spaces:");

string names = Console.ReadLine();

List<string> namesList = names.Split(',').ToList();

for (int i = 0; i < namesList.Count; i++)
{
    Console.WriteLine($"Hello {namesList[i]}");
}

