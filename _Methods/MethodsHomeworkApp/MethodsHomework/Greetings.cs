using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomework;

internal class Greetings
{
    public static void Welcome()
    {
        Console.WriteLine("Hello, welcome to Greetings App.");
    }

    public static string GetUsersName()
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        return firstName;
    }

    public static void HelloUser(string firstName)
    {
        Console.WriteLine($"Hello {firstName}");
    }
}
