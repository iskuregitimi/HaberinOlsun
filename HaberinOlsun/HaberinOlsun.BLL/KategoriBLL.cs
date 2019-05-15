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
		public List<Kategori> GetKategori(int id)
		{
			return repo.List(x => x.KategoriId == id);
		}
		public List<Kategori> GetKategori()
		{
			return repo.List();
		}

	}
}
