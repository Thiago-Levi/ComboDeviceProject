using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboDeviceProject.Entitites
{
    internal class Scanner : Device, IScanner
    {
        
        public Scanner(int SerialNumber) : base(SerialNumber)
        {

        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine($"Processing {doc} - document");
        }

        public string Scan()
        {
            return "Scaning........";
        }
    }
}
