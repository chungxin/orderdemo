using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSale.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string CustId { get; set; }

        public string CustName { get; set; }

        public DateTime?orderDate { get; set; }


    }
}