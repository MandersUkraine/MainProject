using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace manders_v2.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult All()
        {
            return View();
        }
        public ActionResult Catalogs()
        {
            return View();
        }
        public ActionResult Paints()
        {
            return View();
        }
        public ActionResult Wallpapers()
        {
            return View();
        }
        public ActionResult Plinth()
        {
            return View();
        }
        public ActionResult Textile()
        {
            return View();
        }
        public ActionResult William_Howard(string id)
        {

            return View((object) id);
        }
        public ActionResult Farrow_and_Ball(string id)
        {
            return View((object) id);
        }

        public ActionResult Little_Greene(string id)
        {
            return View((object) id);
        }
        public ActionResult Sanderson(string id)
        {
            return View((object)id);
        }

    }
}
