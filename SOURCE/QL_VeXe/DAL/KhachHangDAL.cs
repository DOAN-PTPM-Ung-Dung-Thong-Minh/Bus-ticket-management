using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class KhachHangDAL
    {
        DB_BanvexekhachDataContext db = new DB_BanvexekhachDataContext();

        public List<KhachHang> loadKH()
        {
            return db.KhachHangs.ToList();
        }


        public void themKH(KhachHang kh)
        {
            //string latestID = db.KhachHangs.OrderByDescending(k => k.MaKH).Select(k => k.MaKH).FirstOrDefault();
            //string newID = "KH001"; // Giá trị mặc định
            //if (!string.IsNullOrEmpty(latestID))
            //{
            //    int number = int.Parse(latestID.Substring(2));
            //    number++;
            //    newID = "KH" + number.ToString("D3");
            //}
            bool existKH = db.KhachHangs.Where(k => k.CCCD == kh.CCCD).Count() > 0;
            if (existKH)
            {
                throw new Exception("Khách hàng này đã tồn tại");
            }
            else
            {
                KhachHang newKH = new KhachHang();
                newKH.CCCD = kh.CCCD;
                newKH.TenKH = kh.TenKH;
                newKH.NgaySinh = kh.NgaySinh;
                newKH.DiaChi = kh.DiaChi;
                newKH.Email = kh.Email;
                newKH.Password_kh = kh.Password_kh;
                db.KhachHangs.InsertOnSubmit(newKH);
                db.SubmitChanges();
            }
        }

        public bool ktKH(string makh)
        {
            return db.KhachHangs.Where(k => k.CCCD == makh).Count() > 0;
        }


        //delete customer
        public void xoaKH(string ma)
        {
            KhachHang existKH = db.KhachHangs.Where(k => k.CCCD.Equals(ma)).FirstOrDefault();
            if (existKH == null)
            {
                throw new Exception("Không có thông tin khách hàng này!");
            }
            else
            {
                VeXe vx = db.VeXes.Where(v => v.CCCD.Equals(ma)).FirstOrDefault();
                if (vx != null)
                {
                    throw new Exception("Không thể xóa khách hàng này!");
                }
                else
                {
                    db.KhachHangs.DeleteOnSubmit(existKH);
                    db.SubmitChanges();
                }
            }
        }


        public void capNhatKH(KhachHang kh)
        {
            KhachHang khachHang = db.KhachHangs.Where(k => k.CCCD == kh.CCCD).FirstOrDefault();
            if (khachHang == null)
            {
                throw new Exception("Không có thông tin khách hàng này!");
            }
            else
            {
                khachHang.TenKH = kh.TenKH;
                khachHang.NgaySinh = kh.NgaySinh;
                khachHang.DiaChi = kh.DiaChi;
                khachHang.Password_kh = kh.Password_kh;
                db.SubmitChanges();
            }
        }


        public bool kiemTraTonTai(string makh)
        {
            var DN = db.KhachHangs.Where(k => k.CCCD == makh).Select(k => k);

            if (DN.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool kiemTraTonTaiEmail(string email)
        {
            var DN = db.KhachHangs.Where(k => k.Email == email).Select(k => k);

            if (DN.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IEnumerable<dynamic> loadDataKH()
        {
            return db.KhachHangs.Select(k => new
            {
                MAKH = k.CCCD,
                TENKH = k.TenKH,
                NGSINH = k.NgaySinh,
                DIACHI = k.DiaChi,
                EMAIL = k.Email,
                PASSWORD = k.Password_kh
            });
        }

        public IEnumerable<dynamic> timKiemKH(string makh)
        {
            return db.KhachHangs.Where(k => k.CCCD.Contains(makh)).Select(k => new
            {
                MAKH = k.CCCD,
                TENKH = k.TenKH,
                NGSINH = k.NgaySinh,
                DIACHI = k.DiaChi,
                EMAIL = k.Email,
                PASSWORD = k.Password_kh
            });
        }

        public IEnumerable<dynamic> timKiemKHTheoTen(string tenkh)
        {
            return db.KhachHangs.Where(k => k.TenKH.Contains(tenkh)).Select(k => new
            {
                MAKH = k.CCCD,
                TENKH = k.TenKH,
                NGSINH = k.NgaySinh,
                DIACHI = k.DiaChi,
                EMAIL = k.Email,
                PASSWORD = k.Password_kh
            });
        }
    }
}
