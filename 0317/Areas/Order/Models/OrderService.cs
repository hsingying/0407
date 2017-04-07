using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace _0317.Areas.Order.Models
{
    public class OrderService
    {
        /// <summary>
        /// 取得DB連線字串
        /// </summary>
        /// <returns></returns>
        private string GetDBConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString.ToString();
        }
        /// <summary>
        /// 新增訂單
        /// </summary>
        /// <param name="order"></param>
        public void InsertOrder(Models.Order order)
        {
 

        }
        /// <summary>
        /// 依照id取得訂單資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id)
        {
            //
        }
        /// <summary>
        /// 條件搜尋訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrderByCondition()
        {
            return new List<Order>();
        }
        /// <summary>
        /// 依照id刪除訂單
        /// </summary>
        public void DeleteOrderById()
        {

        }
        /// <summary>
        /// 依照id更新訂單
        /// </summary>
        public void UpdateOrderById()
        {

        }
        
        ///<summary>
        ///取得訂單
        /// </summary>
        ///<returns></returns>
        public List<Models.Order> GetOrders()
        {
            List<Models.Order> result = new List<Order>();
            result.Add(new Order() { CustId = "GSS", CustName = "叡揚資訊", EmpId = 1 ,EmpName = "王小明", Orderdate = DateTime.Parse("2015/11/08") });
            result.Add(new Order() { CustId = "NPOIS", CustName = "網軟資訊",EmpId = 2 ,EmpName = "李小華", Orderdate = DateTime.Parse("2015/11/01") });
            return result;
        }
        
    }
}