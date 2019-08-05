﻿using System;
using System.Collections.Generic;

namespace vm_rental.Data.Models
{
    public partial class User
    {
        public User()
        {
            ClientDiscountHistory = new HashSet<ClientDiscountHistory>();
            ClientHistory = new HashSet<ClientHistory>();
            ComponentTypeHistory = new HashSet<ComponentTypeHistory>();
            MachineComponentHistory = new HashSet<MachineComponentHistory>();
            MachineHistory = new HashSet<MachineHistory>();
            MachinesUsers = new HashSet<MachinesUsers>();
            Order = new HashSet<Order>();
            ProductHistory = new HashSet<ProductHistory>();
            ProductSupplierHistory = new HashSet<ProductSupplierHistory>();
            UserHistory = new HashSet<UserHistory>();
        }

        public int UserId { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<ClientDiscountHistory> ClientDiscountHistory { get; set; }
        public virtual ICollection<ClientHistory> ClientHistory { get; set; }
        public virtual ICollection<ComponentTypeHistory> ComponentTypeHistory { get; set; }
        public virtual ICollection<MachineComponentHistory> MachineComponentHistory { get; set; }
        public virtual ICollection<MachineHistory> MachineHistory { get; set; }
        public virtual ICollection<MachinesUsers> MachinesUsers { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<ProductHistory> ProductHistory { get; set; }
        public virtual ICollection<ProductSupplierHistory> ProductSupplierHistory { get; set; }
        public virtual ICollection<UserHistory> UserHistory { get; set; }
    }
}
