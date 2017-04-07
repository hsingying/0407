using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0317.Areas.Order.Controllers
{
    public class OrderController : Controller
    { // GET: Order/Order
        /// <summary>
        /// 訂單管理系統
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //Models.OrderService orderService = new Models.OrderService();
            //ViewBag.data = orderService.GetOrders();
            //ViewBag.test= "1";
            List<SelectListItem> custData = new List<SelectListItem>();
            custData.Add(new SelectListItem()
            {
                Text = "叡揚資訊",
                Value = "1"
            });
            custData.Add(new SelectListItem()
            {
                Text = "網軟資訊",
                Value = "2"
            });
            ViewBag.custData = custData;
            return View();
        }
        /// <summary>
        /// 新增訂單的畫面
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertOrder()
        {
            return View();
        }
        /// <summary>
        /// 新增訂單存檔的action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            //ViewBag.Desc1 = "我是viewbag";
            //ViewData["Desc2"] = "我是viewdata";
            //TempData["Desc3"] = "我是tempdata";
            Models.OrderService orderService = new Models.OrderService();
            orderService.InsertOrder(order);
            return View("Index");
            //return RedirectToAction("index");

        }

        [HttpGet()]
        public JsonResult TestJson()
        {
            //var result = new Models.Order();
            //result.CustId = "GSS";
            //result.CustName = "叡揚資訊";
            var result = new Models.Order() { CustId = "GSS", CustName = "叡揚資訊" };
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}