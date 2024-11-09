using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.SOLIDPrincipal
{
    public class Printer : IPrinter
    {
        public void Print(IShapes shape)
        {
            Console.WriteLine(shape);
        }
    }
}
