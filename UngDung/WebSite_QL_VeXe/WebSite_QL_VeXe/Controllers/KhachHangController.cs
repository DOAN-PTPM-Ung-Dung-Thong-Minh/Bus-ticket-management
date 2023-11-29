using System;
using System.Collections.Generic;
using System.Globalization;
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
            List<ChuyenXe> a = db.ChuyenXes.ToList();
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
            KhachHang kh = db.KhachHangs.FirstOrDefault(row => row.CCCD == id);
            Session["cccd"] = kh.CCCD;
            Session["tenKH"] = kh.TenKH;

            var query = from vx in db.VeXes
                        join khach in db.KhachHangs on vx.CCCD equals khach.CCCD
                        join cx in db.ChuyenXes on vx.MaChuyen equals cx.MaChuyen
                        join tx in db.TuyenXes on cx.MaTuyen equals tx.MaTuyen
                        where vx.CCCD == Session["cccd"].ToString()
                        select new
                        {
                            khach.TenKH,
                            //vx.MaChuyen,
                            cx.TenChuyen,
                            cx.TTXe,
                            vx.NgayDi,
                            vx.ViTri,
                            tx.GiaVe
                        };

            var veXeList = query.ToList().Select(vx => new VeXe
            {
                //MaChuyen = vx.MaChuyen,
                NgayDi = vx.NgayDi,
                ViTri = vx.ViTri,
                TuyenXe = new TuyenXe
                {
                    GiaVe = vx.GiaVe
                },
                KhachHang = new KhachHang
                {
                    TenKH = vx.TenKH
                },
                ChuyenXe = new ChuyenXe
                {
                    TenChuyen = vx.TenChuyen,
                    TTXe = vx.TTXe
                }
            }).ToList();

            return View(veXeList);
        }

        //Xem Chi Tiet Ve
        public ActionResult XemChiTiet(string id)
        {
            ChuyenXe s = db.ChuyenXes.FirstOrDefault(i => i.MaChuyen == id);
            Session["machuyen"] = s.MaChuyen;
            return View(s);
        }
        
        //Dat Ve 
        public ActionResult DatVe()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DatVe(FormCollection col)
        {
            string dateString = col["NgayDi"];
            DateTime date;

            if (DateTime.TryParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {

                VeXe vx = new VeXe();
                vx.CCCD = col["cccd"];
                vx.MaChuyen = col["machuyen"];
                vx.NgayDi = date;
                vx.ViTri = col["vitri"];

                db.VeXes.InsertOnSubmit(vx);
                db.SubmitChanges();
                return View();
            }
            else
            {
                ModelState.AddModelError("Error", "Ngày đặt vé không hợp lệ");
                return View();
            }
        }
        // Tìm kiếm
        public ActionResult TimKiem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult XL_TimKiem(FormCollection fc)
        {
            string diadiem = fc["diadiem"].ToLower();
            List<ChuyenXe> cx = db.ChuyenXes.ToList();
            if (!string.IsNullOrEmpty(diadiem))
            {
                cx = cx.Where(l => l.TenChuyen.ToLower().Contains(diadiem)).ToList();
            }
            return View("TrangChu", cx);

        }



    }
}