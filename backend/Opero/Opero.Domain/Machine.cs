using System;
using System.Collections.Generic;
using System.Text;

namespace Opero.Domain
{
    public class Machine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsRunning { get; set; }
        public List<WorkOrder> WorkOrders { get; set; } = [];

        public Machine(int id, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
            }

            ID = id;
            Name = name;
            IsRunning = false;
        }

        public void Deactivate() => IsRunning = false;
    }
}
