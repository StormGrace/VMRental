﻿using System;
using System.Collections.Generic;

namespace vm_rental.Data.Models
{
    public partial class OrderItems
    {
        public int RecId { get; set; }
        public int ProductId { get; set; }
        public int ComponentId { get; set; }
        public int OrderId { get; set; }
        public int OrderedAmount { get; set; }
        public string OrderType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? StartDateExecuted { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndDateExecuted { get; set; }

        public virtual MachineComponent Component { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}