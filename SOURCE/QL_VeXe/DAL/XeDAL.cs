using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class XeDAL
    {
        DB_BanvexekhachDataContext db = new DB_BanvexekhachDataContext();


        public IEnumerable<dynamic> loadDataXe()
        {
            return db.Xes.Select(x => new
            {
                TTXE = x.TTXe,
                TENTX = x.Nhanvien.TenNV,
                MATX = x.Nhanvien.MaNV
            });
        }

        public void themXe(Xe xe)
        {
            bool existsXe = db.Xes.Where(x => x.TTXe.Equals(xe.TTXe)).Count() > 0;
            bool ktTaixe = db.Xes.Where(x => x.TTXe.Equals(xe.TTXe)).Count() == 1;
            if (existsXe)
            {
                throw new Exception("Mã xe này đã tồn tại");
            }
            else
            {
                Xe newXe = new Xe();
                newXe.TTXe = xe.TTXe;
                if (!ktTaixe)
                {
                    newXe.MaNV = xe.MaNV;
                }
                else
                {
                    throw new Exception("Tài xế này đã nhận xe");
                }
                db.Xes.InsertOnSubmit(newXe);
                db.SubmitChanges();
            }
        }

        public void xoaXe(string ma)
        {
            Xe existsXe = db.Xes.Where(x => x.TTXe.Equals(ma)).FirstOrDefault();
            if (existsXe == null)
            {
                throw new Exception("Không có thông tin xe này!");
            }
            else
            {
                db.Xes.DeleteOnSubmit(existsXe);
                db.SubmitChanges();
            }
        }

        public bool kiemTraXe(string ma)
        {
            return db.Xes.Where(x => x.TTXe.Equals(ma)).Count() > 0;
        }

        public Xe timXe(string maxe)
        {
            return db.Xes.Where(x => x.TTXe.Equals(maxe)).FirstOrDefault();
        }

        public bool kiemTraTX(string ma)
        {
            return db.Xes.Where(x => x.TTXe.Equals(ma)).Count() > 0;
        }

        public void capNhatXe(Xe xe)
        {
            bool ktTaixe = db.Xes.Where(x => x.MaNV.Equals(xe.MaNV)).Count() == 1;
            Xe xe1 = db.Xes.Where(x => x.TTXe.Equals(xe.TTXe)).FirstOrDefault();
            if (!ktTaixe)
            {
                xe1.MaNV = xe.MaNV;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Tài xế này đã nhận xe");
            }

        }

    }
}
