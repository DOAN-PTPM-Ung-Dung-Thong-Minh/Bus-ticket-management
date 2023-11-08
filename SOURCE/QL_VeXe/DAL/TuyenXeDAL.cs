using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class TuyenXeDAL
    {
        DB_BanvexekhachDataContext db = new DB_BanvexekhachDataContext();


        public IEnumerable<dynamic> load_DataTX()
        {
            return db.TuyenXes.Select(t => new
            {
                MATUYEN = t.MaTuyen,
                TENTUYEN = t.TenTuyen,
                GIAVE = t.GiaVe
            });


        }

        public List<TuyenXe> loadDaTaTX()
        {
            return db.TuyenXes.Select(t => t).ToList();
        }

        public IEnumerable<dynamic> timTX(string ma)
        {
            return db.TuyenXes.Where(t => t.MaTuyen == ma)
                    .Select(t => new
                    {
                        MATUYEN = t.MaTuyen,
                        TENTUYEN = t.TenTuyen,
                        GIAVE = t.GiaVe
                    });
        }

        public void themTX(TuyenXe tx)
        {
            bool existTX = db.TuyenXes.Where(k => k.MaTuyen == tx.MaTuyen).Count() > 0;
            if (existTX)
            {
                throw new Exception("Tuyến xe này đã tồn tại");
            }
            else
            {
                TuyenXe newTX = new TuyenXe();
                newTX.MaTuyen = tx.MaTuyen;
                newTX.TenTuyen = tx.TenTuyen;
                newTX.GiaVe = tx.GiaVe;
                db.TuyenXes.InsertOnSubmit(newTX);
                db.SubmitChanges();
            }
        }

        public void xoaTuyenXe(string ma)
        {
            TuyenXe existsTX = db.TuyenXes.Where(t => t.MaTuyen.Equals(ma)).FirstOrDefault();
            if (existsTX == null)
            {
                throw new Exception("Không có thông tin chuyến xe này!");
            }
            else
            {
                ChuyenXe chuyenXe = db.ChuyenXes.Where(c => c.MaTuyen.Equals(ma)).FirstOrDefault();
                if (chuyenXe != null)
                {
                    throw new Exception("Không thể xóa tuyến xe này!");
                }
                else
                {
                    db.TuyenXes.DeleteOnSubmit(existsTX);
                    db.SubmitChanges();
                }
            }
        }



        public void suaTuyenXe(TuyenXe tx)
        {
            TuyenXe existsTX = db.TuyenXes.Where(t => t.MaTuyen.Equals(tx.MaTuyen)).FirstOrDefault();
            if (existsTX == null)
            {
                throw new Exception("Không có thông tin chuyến xe này!");
            }
            else
            {
                existsTX.TenTuyen = tx.TenTuyen;
                existsTX.GiaVe = tx.GiaVe;
                db.SubmitChanges();
            }
        }

        public bool checkMaTuyen(string ma)
        {
            return db.TuyenXes.Where(t => t.MaTuyen.Equals(ma)).Count() > 0;
        }

    }
}
