using System;
using System.Collections.Generic;

namespace ClientsOrdersManager.Data
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? ServiceId { get; set; }
        public double? Amount { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Client Client { get; set; }
        public virtual Service Service { get; set; }
    }
}
