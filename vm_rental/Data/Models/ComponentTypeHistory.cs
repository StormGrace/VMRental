﻿using System;
using System.Collections.Generic;

namespace vm_rental.Data.Models
{
    public partial class ComponentTypeHistory
    {
        public int ComponentTypeHistoryId { get; set; }
        public int ComponentTypeId { get; set; }
        public int CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public byte Splitable { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte IsActive { get; set; }

        public virtual ComponentType ComponentType { get; set; }
        public virtual User CreatedByNavigation { get; set; }
    }
}
