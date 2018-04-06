using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KCBLevel
{
    public class routerInfo
    {
        public string MACAddress = "";
        public int signalStrength = 0;
        public routerInfo(string MacAddress,int signalStrength)
        {
            this.MACAddress = MacAddress;
            this.signalStrength = signalStrength;
        }
    }
}
