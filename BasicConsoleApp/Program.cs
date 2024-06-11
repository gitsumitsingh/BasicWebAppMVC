// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Welcome to oops basic concepts");
/// <summary>
/// you can write static void Main() line outside the Program class also like below and comment class Program
/* https://github.com/SonicTheCat/CSharp-OOP-Basics/blob/master/03.Working%20With%20Abstraction%20-%20Lab/03.StudentSystem/StudentSystem.cs
 * Console.WriteLine("Please Enter type, name, age & grade like below Eg.");
Console.WriteLine("Create Raj 28 5");
Console.WriteLine("Show Raj");
StudentSystem studentSystem = new StudentSystem();

string input;
while ((input = Console.ReadLine()) != "Exit")
{
    studentSystem.ParseCommand(input);
}
*/
/// </summary>

class Program
{
    static void Main()
    {
        Console.WriteLine("Please Enter type, name, age & grade like below Eg.");
        Console.WriteLine("Create Raj 28 5");
        Console.WriteLine("Show Raj");
        StudentSystem studentSystem = new StudentSystem();

        string input;
        while ((input = Console.ReadLine()) != "Exit")
        {
            studentSystem.ParseCommand(input);
        }
    }
}


