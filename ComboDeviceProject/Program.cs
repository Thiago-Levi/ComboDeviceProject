using ComboDeviceProject.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboDeviceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scanner scanner = new Scanner(1);
            scanner.ProcessDoc("docInScanner");
            Console.WriteLine(scanner.Scan());

            Printer printer = new Printer(2);
            printer.ProcessDoc("docInPrinter");
            printer.Print("docInPrinter");


            ComboDevice comboDevice = new ComboDevice(129);
            comboDevice.ProcessDoc("NewDocument");
            comboDevice.Print("DocP");
            Console.WriteLine(comboDevice.Scan()); ;
        }
    }
}
