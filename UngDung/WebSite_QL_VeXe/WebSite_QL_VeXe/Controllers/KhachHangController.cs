using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite_QL_VeXe.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        public ActionResult TrangChu()
        {
            return View();
        }


        public ActionResult GioiThieu()
        {
            return View();
        }

        public ActionResult LienHe()
        {
            return View();
        }
    }
}