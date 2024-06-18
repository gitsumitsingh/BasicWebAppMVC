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
    public sealed class SingletonThreadSafe
    {
        private static int counter = 0;
        private static readonly object obj = new object();
        /*
        * Private constructor ensures that object is not
        * instantiated other than with in the class itself
        */
        private SingletonThreadSafe()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static SingletonThreadSafe instance = null;
        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static SingletonThreadSafe GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new SingletonThreadSafe();
                    }
                }
                return instance;
            }
        }
        /*
         * Public method which can be invoked through the SingletonThreadSafe instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
