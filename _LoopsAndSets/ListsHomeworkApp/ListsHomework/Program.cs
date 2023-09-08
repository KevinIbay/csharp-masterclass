

List<string> students = new List<string>();

string studentInput;

do
{
    Console.WriteLine("Enter a student name to add to the class roster.");
    Console.WriteLine("Enter \"exit\" to stop adding names");
    studentInput = Console.ReadLine();

    if (studentInput.ToLower() != "exit")
    {
        students.Add(studentInput);
    }

} while (studentInput.ToLower() != "exit");

Console.WriteLine($"There are {students.Count} students in the class roster.");