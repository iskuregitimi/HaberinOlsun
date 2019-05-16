﻿using HaberinOlsun.DAL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
	public class YazarlarBLL
	{

		RepositoryPattern<Yazarlar> repo = new RepositoryPattern<Yazarlar>();
		public List<Yazarlar> GetYazar(int id)
		{
			return repo.List(x => x.YazarId == id);
		}
		public List<Yazarlar> GetYazar()
		{
			return repo.List();
		}

	}
}
