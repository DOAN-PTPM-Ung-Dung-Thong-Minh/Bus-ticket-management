using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class ChuyenXeDAL
    {
        DB_BanvexekhachDataContext db = new DB_BanvexekhachDataContext();



        public IEnumerable<dynamic> loadChuyenXe(string ma)
        {
            return db.ChuyenXes.Where(c => c.MaTuyen == ma)
                    .Select(c => new
                    {
                        MACH = c.MaChuyen,
                        TENCH = c.TenChuyen,
                        TTXE = c.Xe.TTXe,
                        GIOXP = c.GioXuatPhat,
                    });

        }
        public IEnumerable<dynamic> loadChuyenXe_DatVe()
        {
            return db.ChuyenXes.Select(c => new
            {
                MACH = c.MaChuyen,
                TENCH = c.TenChuyen,
                TTXE = c.Xe.TTXe,
                GIOXP = c.GioXuatPhat,
            });
        }
        //kiem tra chuyen xe bang ma xe
        public bool ktCXBangMaXe(string ma)
        {
            return db.ChuyenXes.Where(c => c.TTXe.Equals(ma)).Count() > 0;
        }

        public List<TuyenXe> load_TX()
        {
            return db.TuyenXes.Select(t => t).ToList();
        }

        public List<ChuyenXe> load_CX()
        {
            return db.ChuyenXes.Select(c => c).ToList();
        }

        public bool checkMaChuyen(string ma)
        {
            return db.ChuyenXes.Where(c => c.MaChuyen.Equals(ma)).Count() > 0;
        }

        public bool checkMaTuyen(string ma)
        {
            return db.ChuyenXes.Where(c => c.MaTuyen.Equals(ma)).Count() > 0;
        }





        public void themChuyenXe(ChuyenXe cx)
        {
            bool existCX = db.ChuyenXes.Where(p => p.MaChuyen.Equals(cx.MaChuyen)).Count() > 0;
            if (existCX)
            {
                throw new Exception("Mã chuyến xe này đã tồn tại");
            }
            else
            {
                ChuyenXe newChuyen = new ChuyenXe();
                newChuyen.MaChuyen = cx.MaChuyen;
                newChuyen.TenChuyen = cx.TenChuyen;
                newChuyen.MaTuyen = cx.MaTuyen;
                newChuyen.TTXe = cx.TTXe;
                newChuyen.GioXuatPhat = cx.GioXuatPhat;
                db.ChuyenXes.InsertOnSubmit(newChuyen);
                db.SubmitChanges();
            }
        }

        public void xoaChuyenXe(string ma)
        {
            ChuyenXe existCX = db.ChuyenXes.Where(c => c.MaChuyen.Equals(ma)).FirstOrDefault();
            if (existCX == null)
            {
                throw new Exception("Không có thông tin chuyến xe này!");
            }
            else
            {
                VeXe vx = db.VeXes.Where(v => v.MaChuyen.Equals(ma)).FirstOrDefault();
                if (vx != null)
                {
                    throw new Exception("Không thể xóa chuyến xe này!");
                }
                else
                {
                    db.ChuyenXes.DeleteOnSubmit(existCX);
                    db.SubmitChanges();
                }
            }
        }


    }
}
