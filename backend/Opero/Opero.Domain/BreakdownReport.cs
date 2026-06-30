using System;
using System.Collections.Generic;
using System.Text;

namespace Opero.Domain
{
    public enum ErrorType
    {
        Electrical = 1,
        Mechanical = 2,
        Hydraulic = 3,
        Pneumatic = 4,
        Software = 5
    }

    public class BreakdownReport
    {
        public int ID { get; set; }
        required public string Description { get; set; } 

        required public ErrorType ErrorType { get; set; } 

        required public Machine Machine { get; set; }
    }
}
