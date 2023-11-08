using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ChucVuDAL
    {
        DB_BanvexekhachDataContext db = new DB_BanvexekhachDataContext();
        public List<ChucVu> loadChucVu()
        {
            return db.ChucVus.Select(cv => cv).ToList();
        }
    }
}
