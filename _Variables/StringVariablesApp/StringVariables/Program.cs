

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Kevin";
lastName = "Ibay";
//filePath = "C:\\Temp\\Demo";
// String literal uses @ symbol
filePath = @"C:\Temp\Demo";
//firstName = "123";

//Console.WriteLine(firstName + " " + lastName);

// String interpolation uses $ symbol
Console.WriteLine($"Hello {firstName} {lastName}");
Console.WriteLine(filePath);

// @ and $ symbols can be combined
string testString = $@"The file for {firstName} is at C:\SampleFiles";

Console.WriteLine(testString);

