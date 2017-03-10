using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eSale.Models
{
    public class OrderServer
    {
        public void InsertOrder()
        {

        }
        public void DeleteOrderById()
        {

        }
        public void UpdateOrder()
        {

        }
        public Models.Order GetOrderById(string id)
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName = "hi";
            return result;

        }
        public List<Models.Order>GetOrders()
        {
            return new List<Order>();
        }
    }
}