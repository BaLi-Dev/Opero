using System;
using System.Collections.Generic;
using System.Text;

namespace Opero.Domain
{
    public class WorkOrder
    {
        public int ID {  get; set; }
        required public string Name { get; set; }
        required public string CreatedBy { get; set; }
        public string? AssignedTo { get; set; }
        public DateTime CreatedAt { get; set; }

        required public Machine Machine { get; set; }

        required public BreakdownReport BreakdownReport { get; set; }
    }
}
