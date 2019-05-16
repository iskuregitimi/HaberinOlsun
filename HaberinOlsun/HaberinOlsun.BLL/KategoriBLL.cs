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
		public List<Kategori> GetKategori()
		{
			return repo.List();
		}
		public Kategori KategorileriGetir(int id)
		{
			return repo.Find(x => x.KategoriId == id);
		}

	


	}
}