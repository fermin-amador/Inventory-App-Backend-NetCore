using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class ProductInventorySnaphot
    {
        public int Id { get; set; }
        public DateTime SnapshotTime { get; set; }
        public int QuantityOnHand { get; set; }
        public Product Product { get; set; }

    }
}
