using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Moduls.ManagerProcesses dw = new Moduls.ManagerProcesses();
            dw.NumberService();
            Console.ReadLine();
        }
    }
}
