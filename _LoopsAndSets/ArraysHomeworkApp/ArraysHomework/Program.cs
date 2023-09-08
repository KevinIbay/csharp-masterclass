

string[] names = new string[] { "Allen", "Steve", "Ray" };

Console.WriteLine("Input a number between 1-3: ");
string selectInputText = Console.ReadLine();



if (int.TryParse(selectInputText, out int selectInput) && 
    selectInput >= 0 && 
    selectInput <= names.Length)
{
    Console.WriteLine($"The name you selected is: {names[selectInput - 1]}");
}
else
{
    Console.WriteLine("Invalid input.");
}
