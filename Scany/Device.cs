using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scany
{
    public class Device
    {
        public string ip;
        public string mac;
        public string firstconnect;
        public string lastconnect;

        public Device(string i, string m, string f, string l)
        {
            ip = i;
            mac = m;
            firstconnect = f;
            lastconnect = l;
        }
    }
}
