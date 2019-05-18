using HaberinOlsun.DAL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
	public class KategoriBLL
	{
		RepositoryPattern<Kategori> repo = new RepositoryPattern<Kategori>();
		RepositoryPattern<HaberKategori> repo1 = new RepositoryPattern<HaberKategori>();
		DataContext db = new DataContext();

		public List<Kategori> GetKategori(int id)
		{
			return repo.List(x => x.KategoriId == id);
		}
		public List<Kategori> GetKategoriler()
		{
			return repo.List();
		}
		public Kategori KategorileriGetir(int id)
		{
			return repo.Find(x => x.KategoriId == id);
		}




		//public  List<HaberKategoriDTO> HaberKategorileriGetir(int id)
		//{
		//	var sorgu = from h in db.Haberlers
		//				join hk in db.HaberKategoris on h.HaberId equals hk.HaberId
		//				join ka in
		//				db.Kategoris on hk.KategoriId equals ka.KategoriId
		//				where ka.KategoriId == id
		//				select new HaberKategoriDTO {Baslik= h.Baslik };
		//	return sorgu.ToList();

		//}


	}
}