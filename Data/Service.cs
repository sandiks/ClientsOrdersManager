﻿using System;
using System.Collections.Generic;

namespace ClientsOrdersManager.Data
{
    public partial class Service
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
