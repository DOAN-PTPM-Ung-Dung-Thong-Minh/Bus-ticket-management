using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite_QL_VeXe.Models;

namespace WebSite_QL_VeXe.Controllers
{
    public class KhachHangController : Controller
    {
        DB_BanvexekhachDataContext db = new DB_BanvexekhachDataContext();
        // GET: KhachHang
        public ActionResult TrangChu()
        {
            List<TuyenXe> a = db.TuyenXes.ToList();
            return View(a);
        }

        public ActionResult GioiThieu()
        {
            return View();
        }

        public ActionResult LienHe()
        {
            return View();
        }

        public ActionResult ThongTinCaNhan()
        {
            return View();
        }

        [HttpPost]

        public ActionResult ThongTinCaNhan(FormCollection col)
        {

            string cccd = col["cccd"];
            List<KhachHang> lst = db.KhachHangs.ToList();
            if (!string.IsNullOrEmpty(cccd))
            {
                lst = lst.Where(l => l.CCCD == cccd).ToList();
            }
            return View("ThongTinCaNhan", lst);
        }
        // Sửa Thông tin cá nhân
        public ActionResult Sua_ThongTinCaNhan(String id)
        {
            KhachHang kh = db.KhachHangs.Where(row => row.CCCD == id).FirstOrDefault();
            return View(kh);
        }
        [HttpPost]
        public ActionResult Sua_ThongTinCaNhan(KhachHang kh)
        {
            KhachHang KH = db.KhachHangs.FirstOrDefault(row => row.CCCD == kh.CCCD);
            if (KH == null)
            {
                ModelState.AddModelError("Error", "Không có dữ liệu");
                return View();
            }
            else
            {
                Session["tenKH"] = kh.TenKH;
                KH.TenKH = kh.TenKH;
                KH.SDT = kh.SDT;
                KH.NgaySinh = kh.NgaySinh;

                db.SubmitChanges();
                return View("TrangChu");
            }
        }


        // Đổi mật khẩu
        public ActionResult Doi_MatKhau(String id)
        {
            KhachHang kh = db.KhachHangs.Where(row => row.CCCD == id).FirstOrDefault();
            return View(kh);
        }
        [HttpPost]
        public ActionResult Doi_MatKhau(KhachHang kh)
        {
            KhachHang KH = db.KhachHangs.FirstOrDefault(row => row.CCCD == kh.CCCD);
            if (KH == null)
            {
                ModelState.AddModelError("Error", "Không có dữ liệu");
                return View();
            }
            else
            {
                KH.Password_kh = kh.Password_kh;
                db.SubmitChanges();

                return ThongTinCaNhan();
            }
        }


        // Lich Su Mua Ve

        public ActionResult LichSuMuaVe(string id)
        {
            KhachHang kh = db.KhachHangs.Where(row => row.CCCD == id).FirstOrDefault();
            Session["cccd"] = kh.CCCD;
            Session["tenKH"] = kh.TenKH;
            var query = from vx in db.VeXes
                        join khach in db.KhachHangs on vx.CCCD equals khach.CCCD
                        where vx.CCCD == Session["cccd"]
                        select new
                        {
                            vx.MaChuyen,
                            vx.NgayDi,
                            vx.ViTri,
                            kh.TenKH,
                            kh.SDT
                        };

            var veXeList = query.ToList().Select(vx => new VeXe
            {
                MaChuyen = vx.MaChuyen,
                NgayDi = vx.NgayDi,
                ViTri = vx.ViTri,
                KhachHang = new KhachHang
                {
                    TenKH = vx.TenKH,
                    SDT = vx.SDT
                }
            }).ToList();
            return View(veXeList);
        }

    }
}