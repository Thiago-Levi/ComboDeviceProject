using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboDeviceProject.Entitites
{
    internal class Printer : Device, IPrinter
    {
        public Printer(int serialNumber) : base(serialNumber)
        {
        }

        public void Print(string doc)
        {
            Console.WriteLine($"Printing{doc}"); ;
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine($"Processing {doc} - document");
        }
    }
}
