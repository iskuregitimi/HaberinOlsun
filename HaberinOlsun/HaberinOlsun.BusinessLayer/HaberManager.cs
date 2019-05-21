using HaberinOlsun.DataAccessLayer.EntityFramework;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BusinessLayer
{
    public class HaberManager
    {
        Repository<Haber> repo = new Repository<Haber>();
        Repository<HaberKategori> repo_haberkate = new Repository<HaberKategori>();
        Repository<Kategori> repo_kate = new Repository<Kategori>();

        public List<Haber> GetHabers()
        {
            return repo.List();
        }

        public Haber GetHaber(int id)
        {
            return repo.Find(x => x.ID == id);
        }

        public void Update(Haber haber)
        {
            repo.Update(haber);
        }

        public IQueryable<HaberKateModel> KateHaber(int id)
        {
            IQueryable<HaberKateModel> kateHaber = from haber in repo.GetT()
                                                   join hk in repo_haberkate.GetT() on haber.ID equals hk.HaberID
                                                   join kate in repo_kate.GetT() on hk.KategoriID equals kate.ID
                                                   where kate.ID == id
                                                   select new HaberKateModel
                                                   {
                                                       ID = haber.ID,
                                                       Baslik = haber.Baslik,
                                                       Detay = haber.Detay,
                                                       Kaynak = haber.Kaynak,
                                                       OkunmaSayisi = haber.OkunmaSayisi,
                                                       Ozet = haber.Ozet,
                                                       ResimURL = haber.ResimURL,
                                                       Tarih = haber.Tarih
                                                   };


            return kateHaber;
        }
    }
}
