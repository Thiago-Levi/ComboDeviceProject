using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboDeviceProject.Entitites
{
    internal abstract class Device
    {
        public int SerialNumber { get; set; }
        public Device(int serialNumber) { SerialNumber = serialNumber; }

        public abstract void ProcessDoc(string doc);
    }
}
