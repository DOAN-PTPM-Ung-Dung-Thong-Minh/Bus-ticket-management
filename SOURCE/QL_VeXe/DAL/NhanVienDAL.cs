using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class NhanVienDAL
    {
        DB_BanvexekhachDataContext db = new DB_BanvexekhachDataContext();
        public bool kiemTraDangNhap(string tk, string mk)
        {
            var DN = db.Nhanviens.Where(nv => nv.MaNV == tk && nv.MatKhau == mk).Select(nv => nv);

            if (DN.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool kiemTraTonTai(string tk)
        {
            var DN = db.Nhanviens.Where(nv => nv.MaNV == tk).Select(nv => nv);

            if (DN.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void themNhanVien(Nhanvien nv)
        {
            bool existsNV = db.Nhanviens.Where(n => n.MaNV == nv.MaNV).Count() > 0;
            bool ktadmin = db.Nhanviens.Where(n => n.MaNV.Equals(nv.MaNV) && n.MaCV == "ADMIN").Count() > 0;
            bool ktnv = db.Nhanviens.Where(n => n.MaNV.Equals(nv.MaNV))
                .Where(n => n.MaCV == "NV").Count() > 0;

            Nhanvien newNV = new Nhanvien();;

            if (existsNV)
            {
                throw new Exception("Mã này đã tồn tại");
            }
            else
            {
                if (ktadmin || ktnv)
                {
                    newNV.MaNV = nv.MaNV;
                    newNV.TenNV = nv.TenNV;
                    newNV.SDT = nv.SDT;
                    newNV.MatKhau = nv.MatKhau;
                    newNV.DiaChiNV = nv.DiaChiNV;
                    newNV.NgaySinhNV = nv.NgaySinhNV;
                    newNV.MaCV = nv.MaCV;
                }
                else
                {
                    newNV.MaNV = nv.MaNV;
                    newNV.TenNV = nv.TenNV;
                    newNV.SDT = nv.SDT;
                    newNV.DiaChiNV = nv.DiaChiNV;
                    newNV.NgaySinhNV = nv.NgaySinhNV;
                    newNV.MaCV = nv.MaCV;
                }
                db.Nhanviens.InsertOnSubmit(newNV);
                db.SubmitChanges();
            }
        }


        public void xoaNhanVien(string ma)
        {
            Nhanvien existsNV = db.Nhanviens.Where(n => n.MaNV.Equals(ma)).FirstOrDefault();
            if (existsNV != null)
            {
                db.Nhanviens.DeleteOnSubmit(existsNV);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Nhân viên này không tồn tại");
            }
        }

        public void suaNhanVien(Nhanvien nv)
        {
            Nhanvien existsNV = db.Nhanviens.Where(n => n.MaNV.Equals(nv.MaNV)).FirstOrDefault();
            if (existsNV != null)
            {
                existsNV.TenNV = nv.TenNV;
                existsNV.SDT = nv.SDT;
                existsNV.NgaySinhNV = nv.NgaySinhNV;
                existsNV.DiaChiNV = nv.DiaChiNV;
                existsNV.MaCV = nv.MaCV;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Nhân viên này không tồn tại");
            }

        }

        public void doiMatKhau(Nhanvien nv, string mkm)
        {
            bool ktadmin = db.Nhanviens.Where(n => n.MaNV.Equals(nv.MaNV) && n.MaCV == "ADMIN").Count() > 0;
            bool ktnv = db.Nhanviens.Where(n => n.MaNV.Equals(nv.MaNV) && n.MaCV == "NV").Count() > 0;
            if (ktadmin || ktnv)
            {
                Nhanvien capnhatMK = db.Nhanviens.Single(n => n.MaNV == nv.MaNV);
                if (mkm != nv.MatKhau)
                {
                    throw new Exception("Mật khẩu không trùng khớp");
                }
                else
                {
                    capnhatMK.MatKhau = nv.MatKhau;
                    db.SubmitChanges();
                }
            }
            else
            {
                throw new Exception("Tài xế không có tài khoản");
            }
        }



        public IEnumerable<dynamic> loadNV(string macv)
        {
            var data = db.Nhanviens.Where(nv => nv.MaCV == macv).Select(nv => new
            {
                TENNV = nv.TenNV,
                sdt = nv.SDT,
                NGSINH = nv.NgaySinhNV,
                DCHI = nv.DiaChiNV,
                CV = nv.ChucVu.TenCV,
                ID = nv.MaNV,
                MK = nv.MatKhau
            });
            return data;

        }

        public bool ktAdmin(string manv)
        {
            bool ktadmin = db.Nhanviens.Where(n => n.MaNV.Equals(manv) && n.MaCV == "ADMIN").Count() > 0;
            if (ktadmin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ktNV(string manv)
        {
            bool ktnv = db.Nhanviens.Where(n => n.MaNV.Equals(manv) && n.MaCV == "NV").Count() > 0;
            if (ktnv)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool existsNV(string manv)
        {
            bool existsNV = db.Nhanviens.Where(n => n.MaNV == manv).Count() > 0;
            if (existsNV)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool kttx(string manv)
        {
            bool kttx = db.Nhanviens.Where(n => n.MaNV.Equals(manv) && n.MaCV == "TX").Count() > 0;
            if (kttx)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Nhanvien tim1NV(string manv)
        {
            return db.Nhanviens.Where(nv => nv.MaNV.Equals(manv)).FirstOrDefault();
        }


        public IEnumerable<dynamic> timNVTheoMa(string ma)
        {
            return db.Nhanviens.Where(nv => nv.MaNV == ma)
                .Select(nv => new
                {
                    TENNV = nv.TenNV,
                    sdt = nv.SDT,
                    NGSINH = nv.NgaySinhNV,
                    DCHI = nv.DiaChiNV,
                    CV = nv.ChucVu.TenCV,
                    ID = nv.MaNV,
                    MK = nv.MatKhau
                });
        }

        public IEnumerable<dynamic> timNVTheoTen(string ten)
        {
            return db.Nhanviens.Where(nv => nv.TenNV.Contains(ten))
                .Select(nv => new
                {
                    TENNV = nv.TenNV,
                    sdt = nv.SDT,
                    NGSINH = nv.NgaySinhNV,
                    DCHI = nv.DiaChiNV,
                    CV = nv.ChucVu.TenCV,
                    ID = nv.MaNV,
                    MK = nv.MatKhau
                });
        }

        public List<Nhanvien> loadTaiXe()
        {
            return db.Nhanviens.Where(n => n.MaCV == "TX").Select(n => n).ToList();
        }

        public int ktSLAdmin()
        {
            return db.Nhanviens.Where(n => n.MaCV == "ADMIN").Count();
        }
    }
}
