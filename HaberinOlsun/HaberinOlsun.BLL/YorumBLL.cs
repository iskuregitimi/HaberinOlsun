using HaberinOlsun.DAL;
using HaberinOlsun.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
   public class YorumBLL
    {
        DataContext db = new DataContext();
        public List<Yorum> GetYorums()
        {
            return db.Yorum.ToList();
        }
        public Yorum GetYorum(int Id)
        {
            return db.Yorum.FirstOrDefault(x=>x.YorumId==Id);
        }

        public void Add(Yorum yrm)
        {
            db.Yorum.Add(yrm);
            db.SaveChanges();
        }
    }
}
