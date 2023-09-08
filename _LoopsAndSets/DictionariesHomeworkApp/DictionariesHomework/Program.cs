

Dictionary<int, string> employeeRoster = new Dictionary<int, string>();

employeeRoster[1] = "Derrick Rose";
employeeRoster[3] = "Allen Iverson";
employeeRoster[7] = "Carmelo Anthony";
employeeRoster[8] = "Kobe Bryant";
employeeRoster[13] = "Joakim Noah";
employeeRoster[23] = "Michael Jordan";

Console.WriteLine("Enter an employee ID: ");
string inputText = Console.ReadLine();

int.TryParse(inputText, out int employeeId);

Console.WriteLine($"Employee ID {employeeId}: {employeeRoster[employeeId]}");