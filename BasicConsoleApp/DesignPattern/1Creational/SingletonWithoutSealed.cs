using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.DesignPattern._1Creational
{
    /*
     *  Sealed restricts the inheritance
     */
    public class SingletonWithoutSealed
    {
        private static int counter = 0;
        private static object obj = new object();
        /*
        * Private constructor ensures that object is not
        * instantiated other than with in the class itself
        */
        private SingletonWithoutSealed()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static SingletonWithoutSealed instance = null;
        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static SingletonWithoutSealed GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonWithoutSealed();
                return instance;
            }
        }
        /*
         * Public method which can be invoked through the SingletonWithoutSealed instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        /*
         * By removing sealed keyword we can inherit the SingletonWithoutSealed and instantiate multiple objects
         * This violates SingletonWithoutSealed design principles.
         */
        public class DerivedSingletonWithoutSealed : SingletonWithoutSealed
        {
        }
    }
}
