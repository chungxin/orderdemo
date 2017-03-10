using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSale.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        public ActionResult Index()
        {
            Models.OrderServer orderService =new Models.OrderServer();
            var order = orderService.GetOrderById("111");
            ViewBag.CustId = order.CustId;
            ViewBag.CustName = order.CustName;

            return View();
        }
	}
}