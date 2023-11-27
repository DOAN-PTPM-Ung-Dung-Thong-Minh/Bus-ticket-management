using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite_QL_VeXe.Models;

namespace WebSite_QL_VeXe.Controllers
{
    public class HomeController : Controller
    {
        DB_BanvexekhachDataContext db = new DB_BanvexekhachDataContext();

        // GET: TrangChu
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

        //=========================Register/Login/Logout======================

        //Dang Nhap Khach Hang
        [HttpGet]
        public ActionResult DangNhapKH()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhapKH(FormCollection col)
        {
            KhachHang kh = db.KhachHangs.FirstOrDefault(a => a.Email == col["email"] && a.Password_kh == col["pswd"]);
            if (kh != null)
            {
                Session["kh"] = kh;
                Session["tenKH"] = kh.TenKH;
                Session["emailKH"] = kh.Email;
                Session["SDT"] = kh.SDT;
                Session["ngaysinh"] = kh.NgaySinh;
                Session["cccd"] = kh.CCCD;
                return RedirectToAction("TrangChu", "KhachHang");
            }
            else
            {
                ModelState.AddModelError("myError", "Invalue email and password.");
            }
            return View();
        }

        //Dang Ky Khach Hang
        public ActionResult DangKyKH()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangKyKH(FormCollection col)
        {

            string dateString = col["dkyngaysinh"];
            DateTime date;

            string a = col["dkycancuoc"];
            string a1 = col["dkyhoten"];
            string a2 = col["dkysdt"];
            string a3 = col["dkyemail"];
            string a4 = col["dkypassword"];

            KhachHang kh1 = db.KhachHangs.FirstOrDefault(t => t.Email.Contains(col["dkyemail"]));
            KhachHang kh2 = db.KhachHangs.FirstOrDefault(t => t.SDT.Contains(col["dkysdt"]));

            if (a == "" || a1 == "" || a2 == "" || a3 == "" || a4 == "" )
            {
                ModelState.AddModelError("myError", "Vui lòng nhập đầy đủ thông tin");
            }
            else if (kh1 != null || kh2 != null)
            {
                ModelState.AddModelError("myError", "Số đt hoặc email đã được đăng ký");
            }
            else if (a4.Length < 6 || a4.Length > 15)
            {
                ModelState.AddModelError("myError", "Mật khấu từ 6~15 ký tự");
            }
            else if (col["dkypassword"] == col["dkyxacnhanmatkhau"])
            {
                if (DateTime.TryParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {

                    KhachHang KH = new KhachHang();
                    KH.CCCD = col["dkycancuoc"];
                    KH.TenKH = col["dkyhoten"];
                    KH.SDT = col["dkysdt"];
                    KH.Email = col["dkyemail"];
                    KH.Password_kh = col["dkypassword"];
                    KH.NgaySinh = date;

                    db.KhachHangs.InsertOnSubmit(KH);
                    db.SubmitChanges();
                    return RedirectToAction("DangNhapKH", "Home");

                }
                else
                {
                    ModelState.AddModelError("Error", "Ngày sinh không hợp lệ");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Mật khẩu xác nhận sai!");
            }
            return View();
        }

    }
}