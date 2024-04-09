using System;
using System.Collections.Generic;

namespace PureAirPro.DBContext
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderAddress { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public DateTime? OrderDate { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
