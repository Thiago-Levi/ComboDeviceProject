using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboDeviceProject.Entitites
{
    internal class ComboDevice : Device, IPrinter, IScanner
    {
        public ComboDevice(int serialNUmber) : base(serialNUmber)
        {
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine($"Processing --> {doc}");
        }
        public void Print(string doc)
        {
            Console.WriteLine($"Printer --> {doc}");
        }
        public string Scan()
        {
            return "Scanning... ";
        }
    }
}
