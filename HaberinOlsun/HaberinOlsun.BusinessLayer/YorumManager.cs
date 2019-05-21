using HaberinOlsun.DataAccessLayer.EntityFramework;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BusinessLayer
{
    public class YorumManager
    {
        Repository<Yorum> repo = new Repository<Yorum>();

        public void Insert(Yorum yorum)
        {
            repo.Insert(yorum);
        }
    }
}
