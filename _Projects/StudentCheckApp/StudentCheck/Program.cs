
// Ask for name
Console.WriteLine("What is your first name?");
string? firstName = Console.ReadLine();

// Ask for age
Console.WriteLine("What is your age?");
string? ageInput = Console.ReadLine();

string formattedName;

if (int.TryParse(ageInput, out int age) == false || age <= 0)
{
    Console.WriteLine("You did not enter a valid age.");
    // "return" ends program
    return;
}
if (firstName == null)
{
    return;
}

// If Bob or Sue, address as Professor
if ((age >= 21) && (firstName.ToLower() == "bob" || firstName.ToLower() == "sue"))
{
    formattedName = $"Professor {firstName}";
}
else
{
    formattedName = firstName;
}
// If under 21, recommend wait X years to start class
if (age < 21)
{
    Console.WriteLine($"I recommend you wait {21 - age} years, {formattedName}");
}
else
{
    Console.WriteLine($"Welcome to class {formattedName}");
}


//// if ageInput parses an int then create 'int age' variable
//if (int.TryParse(ageInput, out int age))
//{


//    // If Bob or Sue, address as Professor
//    if ((age >= 21) && (firstName.ToLower() == "bob" || firstName.ToLower() == "sue"))
//    {
//        formattedName = $"Professor {firstName}";
//    }
//    else
//    {
//        formattedName = firstName;
//    }
//    // If under 21, recommend wait X years to start class
//    if (age < 21)
//    {
//        Console.WriteLine($"I recommend you wait {21 - age} years, {formattedName}");
//    }
//    else
//    {
//        Console.WriteLine($"Welcome to class {formattedName}");
//    }

//}
//else
//{
//    Console.WriteLine("You did not enter a valid age.");
//}



