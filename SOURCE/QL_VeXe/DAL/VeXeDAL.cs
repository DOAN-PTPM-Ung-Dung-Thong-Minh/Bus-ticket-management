using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class VeXeDAL
    {
        DB_BanvexekhachDataContext db = new DB_BanvexekhachDataContext();
        public IEnumerable<dynamic> kiemTraTTVe(string cbocx, DateTime ngaydi)
        {
            return db.VeXes.Where(v => v.MaChuyen.Equals(cbocx)
                                                        && v.NgayDi.Equals(ngaydi))
                                .Select(v => new
                                {
                                    MAKH = v.CCCD,
                                    CH = v.ChuyenXe.TenChuyen,
                                    NGDI = v.NgayDi,
                                    VITRI = v.ViTri
                                });
        }
        public IEnumerable<dynamic> load_DataVeXe(string machuyen)
        {

            return db.VeXes.Where(v => v.MaChuyen.Equals(machuyen))
                                .Select(v => new
                                {
                                    MAVE = v.MaVe,
                                    MAKH = v.CCCD,
                                    TENKH = v.KhachHang.TenKH,
                                    CHUYENXE = v.ChuyenXe.TenChuyen,
                                    NGAYDI = v.NgayDi,
                                    SOXE = v.ChuyenXe.Xe.TTXe,
                                    VITRI = v.ViTri,
                                    GIAVE = v.ChuyenXe.TuyenXe.GiaVe
                                });
        }

        //Tim ve xe theo Ngay Di va Ma Chuyen
        public IEnumerable<dynamic> timVX1(DateTime ngaydi, string machuyen)
        {
            return db.VeXes.Where(v => v.NgayDi.Equals(ngaydi)
                                   && v.MaChuyen.Equals(machuyen))
                                .Select(v => new
                                {
                                    MAVE = v.MaVe,
                                    MAKH = v.CCCD,
                                    TENKH = v.KhachHang.TenKH,
                                    CHUYENXE = v.ChuyenXe.TenChuyen,
                                    NGAYDI = v.NgayDi,
                                    SOXE = v.ChuyenXe.Xe.TTXe,
                                    VITRI = v.ViTri
                                });

        }

        //Tim ve xe theo Ma Ve
        public IEnumerable<dynamic> timVX2(string mave)
        {
            return db.VeXes.Where(v => v.MaVe.Equals(mave))
                                .Select(v => new
                                {
                                    MAVE = v.MaVe,
                                    MAKH = v.CCCD,
                                    TENKH = v.KhachHang.TenKH,
                                    CHUYENXE = v.ChuyenXe.TenChuyen,
                                    NGAYDI = v.NgayDi,
                                    SOXE = v.ChuyenXe.Xe.TTXe,
                                    VITRI = v.ViTri
                                });
        }

        //Tim ve xe theo Ma Khach Hang
        public IEnumerable<dynamic> timVX3(string makh)
        {
            return db.VeXes.Where(v => v.CCCD.Equals(makh))
                              .Select(v => new
                              {
                                  MAVE = v.MaVe,
                                  MAKH = v.CCCD,
                                  TENKH = v.KhachHang.TenKH,
                                  CHUYENXE = v.ChuyenXe.TenChuyen,
                                  NGAYDI = v.NgayDi,
                                  SOXE = v.ChuyenXe.Xe.TTXe,
                                  VITRI = v.ViTri
                              });
        }
        //Tim ve xe theo Ma Khach Hang va Ma Ve
        public IEnumerable<dynamic> timVX4(string mave, string makh)
        {
            return db.VeXes.Where(v => v.CCCD.Equals(makh))
                                .Where(v => v.MaVe.Equals(mave))
                                .Select(v => new
                                {
                                    MAVE = v.MaVe,
                                    MAKH = v.CCCD,
                                    TENKH = v.KhachHang.TenKH,
                                    CHUYENXE = v.ChuyenXe.TenChuyen,
                                    NGAYDI = v.NgayDi,
                                    SOXE = v.ChuyenXe.Xe.TTXe,
                                    VITRI = v.ViTri
                                });
        }



        public void xoaVX(string mave, string makh)
        {
            VeXe existsVe = db.VeXes.Where(v => v.MaVe.Equals(mave)).FirstOrDefault();
            VeXe existsKH = db.VeXes.Where(v => v.CCCD.Equals(makh)).FirstOrDefault();
            if (existsVe == null)
            {
                throw new Exception("Không có vé này trên hệ thống");
            }
            if (existsKH == null)
            {
                throw new Exception("Khách hàng không có thông tin vé trên hệ thống");
            }
            db.VeXes.DeleteOnSubmit(existsVe);
            db.SubmitChanges();
        }

        public bool existKH(string makh)
        {
            bool exist = db.KhachHangs.Where(v => v.CCCD.Equals(makh)).Count() > 0;
            if (exist)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool existsKH_VE(string cbocx, DateTime ngaydi, string makh)
        {
            bool exists = db.VeXes.Where(v => v.MaChuyen.Equals(cbocx)
                                             && v.NgayDi.Equals(ngaydi)
                                           && v.CCCD.Equals(makh)).Count() > 0;
            if (exists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool existsVitri(string cbocx, DateTime ngaydi, string cbovt)
        {
            bool exists = db.VeXes.Where(v => v.MaChuyen.Equals(cbocx)
                      && v.NgayDi.Equals(ngaydi)
                                   && v.ViTri.Equals(cbovt)).Count() > 0;
            if (exists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void themVX(VeXe vx)
        {
            VeXe newVX = new VeXe();
            newVX.CCCD = vx.CCCD;
            newVX.MaChuyen = vx.MaChuyen;
            newVX.NgayDi = vx.NgayDi;
            newVX.ViTri = vx.ViTri;
            db.VeXes.InsertOnSubmit(newVX);
            db.SubmitChanges();
        }

        public bool existsVeXe(string ma)
        {
            bool exists = db.VeXes.Where(v => v.MaVe.Equals(ma)).Count() > 0;
            if (exists)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool existsVeXeTheoMaCX(string ma)
        {
            bool exists = db.VeXes.Where(v => v.MaChuyen.Equals(ma)).Count() > 0;
            if (exists)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool existsVeXeTheoKH(string makh)
        {
            bool exists = db.VeXes.Where(v => v.CCCD.Equals(makh)).Count() > 0;
            if (exists)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void suaVX(VeXe ve)
        {
            VeXe veXe = db.VeXes.Where(v => v.CCCD == ve.CCCD).FirstOrDefault();
            if (veXe == null)
            {
                throw new Exception("Không có thông tin vé xe này!");
            }
            else
            {
                veXe.MaChuyen = ve.MaChuyen;
                veXe.NgayDi = ve.NgayDi;
                veXe.ViTri = ve.ViTri;
                db.SubmitChanges();
            }
        }

//dựa vào ngày đi và mã chuyến xe để lấy ra các vị trí chưa được đặt

        //String[] vitri = { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" };

        //select ViTri from vitri where ViTri not in (select ViTri from VeXe where MaChuyen = 'SGVT17H' and NgayDi = '19/12/2022')
        public List<String> load_VitriChuaDuocDat(string machuyen, DateTime ngaydi)
        {
            String[] vitri = { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" };
            List<String> vitriChuaDuocDat = new List<string>();
            List<String> vitriDaDuocDat = new List<string>();
            vitriDaDuocDat = db.VeXes.Where(v => v.MaChuyen.Equals(machuyen)
                                                        && v.NgayDi.Equals(ngaydi))
                                             .Select(v => v.ViTri).ToList();
            for (int i = 0; i < vitri.Length; i++)
            {
                if (!vitriDaDuocDat.Contains(vitri[i] + " "))
                {
                    vitriChuaDuocDat.Add(vitri[i]);
                }
            }
            return vitriChuaDuocDat;
            
        }





    }
}
