using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19056509_hw_6.Models;
using PagedList;
using PagedList.Mvc;


namespace u19056509_hw_6.Controllers
{
    public class HomeController : Controller

    {
        private BikeStoresEntities db = new BikeStoresEntities();
        public ActionResult Report()
        {
            int[] Chartdata = new int[]
            {
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 1).ToList().Sum(x => x.quantity),
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 2).ToList().Sum(x => x.quantity),
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 3).ToList().Sum(x => x.quantity),
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 4).ToList().Sum(x => x.quantity),
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 5).ToList().Sum(x => x.quantity),
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 6).ToList().Sum(x => x.quantity),
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 7).ToList().Sum(x => x.quantity),
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 8).ToList().Sum(x => x.quantity),
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 9).ToList().Sum(x => x.quantity),
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 10).ToList().Sum(x => x.quantity),
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 11).ToList().Sum(x => x.quantity),
                db.order_items.Where(x => x.product.category_id == 6 && x.order.order_date.Month == 12).ToList().Sum(x => x.quantity),
            };


            return View(Chartdata);

        }



        public ActionResult Products()
        {
            return View();
        }

        public ActionResult Orders()
        {
            

            return View();
        }
        public ActionResult Orders(int? id, string search, int? i)
        {
           
            return View(db.order_items.Where(x => x.order.order_date.ToString().StartsWith(search) || search == null).ToList().ToPagedList(i ?? 1, 10));
        }
    }
}

        