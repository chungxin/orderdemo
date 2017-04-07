using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSaleService
{
    public class OrderService
    {
        public eSaleModel.Order GetOrderById(string id)
        {
            return new eSaleModel.Order() { CustId = "GSS", CustName = "叡揚資訊", OrderId = "1" };
        }
    }
}
