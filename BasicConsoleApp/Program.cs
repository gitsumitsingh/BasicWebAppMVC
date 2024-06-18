// See https://aka.ms/new-console-template for more information

using BasicClassLibrary;
using BasicConsoleApp.DesignPattern._1Creational;
using BasicConsoleApp.WrapperMaths;

//Console.WriteLine("Welcome to oops basic concepts");


class Program
{
    static void Main()
    {
        #region Dictionary & Deligate Action method
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
        #endregion

        #region Abstraction Real World Example
        ////Abstraction Real World Example
        //SavingsAccount johnsSavings = new SavingsAccount("SA123456", "John Doe");
        //johnsSavings.Deposit(1000);
        //johnsSavings.Withdraw(200);
        //johnsSavings.AddInterest();
        //johnsSavings.DisplayBalance();
        //CurrentAccount janesCurrent = new CurrentAccount("CA654321", "Jane Smith");
        //janesCurrent.Deposit(500);
        //janesCurrent.Withdraw(1000);
        //janesCurrent.DisplayBalance();
        #endregion

        #region Extension Method
        ////Extension Method
        //MathThirdParty obj = new MathThirdParty();
        //Console.WriteLine(obj.Add(20, 10));
        //Console.WriteLine(obj.Multiply(20, 10));
        //Console.WriteLine(obj.Subtract(20, 10)); //Extension Method
        //Console.WriteLine(obj.Divide(20, 10)); //Extension Method
        //obj.M1();
        //obj.M2();
        //obj.M3();
        //obj.M4(); //Extension Method
        //obj.M5("Method Name: M5"); //Extension Method
        ////Console.WriteLine(obj.M1);
        #endregion

        #region Simple Singleton
        ///*
        // * Assuming Singleton is created from employee class
        // * we refer to the GetInstance property from the Singleton class
        // */
        //Singleton fromEmployee = Singleton.GetInstance;
        //fromEmployee.PrintDetails("From Employee");
        ///*
        // * Assuming Singleton is created from student class
        // * we refer to the GetInstance property from the Singleton class
        // */
        //Singleton fromStudent = Singleton.GetInstance;
        //fromStudent.PrintDetails("From Student");
        #endregion

        #region SingletonWithoutSealed
        ///*
        //  * Assuming SingletonWithoutSealed is created from student class
        //  * we refer to the GetInstance property from the SingletonWithoutSealed class
        //  */
        //SingletonWithoutSealed fromStudent = SingletonWithoutSealed.GetInstance;
        //fromStudent.PrintDetails("From Student");
        ///*
        //* Assuming SingletonWithoutSealed is created from employee class
        //* we refer to the GetInstance property from the SingletonWithoutSealed class
        //*/
        //SingletonWithoutSealed fromEmployee = SingletonWithoutSealed.GetInstance;
        //fromEmployee.PrintDetails("From Employee");

        //Console.WriteLine("-------------------------------------");
        ///*
        // * Instantiating SingletonWithoutSealed from a derived class. This violates SingletonWithoutSealed pattern principles.
        // */
        //SingletonWithoutSealed.DerivedSingletonWithoutSealed derivedObj = new SingletonWithoutSealed.DerivedSingletonWithoutSealed();
        //derivedObj.PrintDetails("From Derived");
        #endregion

        #region SingletonThreadSafe
        ////SingletonThreadSafe
        //Parallel.Invoke(
        //    () => PrintStudentdetails(),
        //    () => PrintEmployeeDetails()
        //    );
        //Console.ReadLine();
        #endregion

        #region LazySingleton

        #endregion






        Console.ReadKey();
    }


    private static void PrintEmployeeDetails()
    {
        /*
         * Assuming SingletonThreadSafe is created from employee class
         * we refer to the GetInstance property from the SingletonThreadSafe class
         */
        SingletonThreadSafe fromEmployee = SingletonThreadSafe.GetInstance;
        fromEmployee.PrintDetails("From Employee");
    }

    private static void PrintStudentdetails()
    {
        /*
        * Assuming SingletonThreadSafe is created from student class
        * we refer to the GetInstance property from the SingletonThreadSafe class
        */
        SingletonThreadSafe fromStudent = SingletonThreadSafe.GetInstance;
        fromStudent.PrintDetails("From Student");
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


/*
you can write static void Main() line outside the Program class also like below and comment class Program
https://github.com/SonicTheCat/CSharp-OOP-Basics/blob/master/03.Working%20With%20Abstraction%20-%20Lab/03.StudentSystem/StudentSystem.cs
Console.WriteLine("Please Enter type, name, age & grade like below Eg.");
Console.WriteLine("Create Raj 28 5");
Console.WriteLine("Show Raj");
StudentSystem studentSystem = new StudentSystem();

string input;
while ((input = Console.ReadLine()) != "Exit")
{
    studentSystem.ParseCommand(input);
}
*/

/*
 Shortcuts
 Collapse All: ctrl+M+A
 */
