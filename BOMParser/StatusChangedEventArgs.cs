using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BOMParser
{
    public class StatusChangedEventArgs:EventArgs
    {
        public string Status;

        public StatusChangedEventArgs(string value)
        {
            // TODO: Complete member initialization
            this.Status = value;
        }
    }
}
