using Methods;

//MathShortcuts.Add(5, 3);

//string name = ConsoleMessages.GetUsersName();

//ConsoleMessages.SayHi(name);

//double[] vals = new double[] { 2, 5, 6, 21, 52, 98};

//MathShortcuts.AddAll(vals);


//ConsoleMessages.SayGoodBye(); 

//(string, string) fullName = ConsoleMessages.GetFullName();
//var fullName = ConsoleMessages.GetFullName();

// Discard character is _
// Discard ignores a return type
(string firstName, _) = ConsoleMessages.GetFullName();

Console.WriteLine($"First name: {firstName}");
//Console.WriteLine($"First name: {lastName}");
