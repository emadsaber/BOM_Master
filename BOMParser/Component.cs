using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BOMParser
{
    class Component
    {
        internal string SerialNumber { set; get; }
        internal string PCB_Name { set; get; }
        internal string Type { set; get; }
        internal string Code { set; get; }
        internal string SewedyPartNumber { set; get; }
        internal string PartRef { set; get; }
        internal string Description { set; get; }
        internal string Quantity { set; get; }
        internal string Manufacturer { set; get; }
    }
}
