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
           // Models.OrderServer orderService = new Models.OrderServer();
           // var order = orderService.GetOrderById("111");
           // ViewBag.CustId = order.CustId;

       
            return View();
        }

        public ActionResult InsertOrder()
        {
            return View();
        }
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            ViewBag.Desc1 = "我是viewbag";
            ViewData["Desc2"] = "我是viewdata";
            TempData["Desc3"] = "我是Tempdata";

            return RedirectToAction("Index");
        }
    [HttpGet()]
       public JsonResult TestJson()
        {

            var result = new Models.Order()
            {
                CustId = "GSS",
                CustName = "hi"
            };
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }



	}
}