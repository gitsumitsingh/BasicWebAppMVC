// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Welcome to oops basic concepts");

class Program
{
    static void Main()
    {
        ////Dictionary & Deligate Action method
        //Console.WriteLine("Please Enter type, name, age & grade like below Eg.");
        //Console.WriteLine("Create John 28 5");
        //Console.WriteLine("Show John");
        //StudentSystem studentSystem = new StudentSystem();

        //string input;
        //while ((input = Console.ReadLine()) != "Exit")
        //{
        //    studentSystem.ParseCommand(input);
        //}


        //Abstraction Real World Example
        SavingsAccount johnsSavings = new SavingsAccount("SA123456", "John Doe");
        johnsSavings.Deposit(1000);
        johnsSavings.Withdraw(200);
        johnsSavings.AddInterest();
        johnsSavings.DisplayBalance();
        CurrentAccount janesCurrent = new CurrentAccount("CA654321", "Jane Smith");
        janesCurrent.Deposit(500);
        janesCurrent.Withdraw(1000);
        janesCurrent.DisplayBalance();
        Console.ReadKey();




    }
}


/*
 * You can run the project in terminal by right clicking Solution Explorer => Open in Terminal
 * To check dot net version in cmd run
dotnet --version

–to create a console application
dotnet new console

–to build & run
dotnet build
dotnet run

 */

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