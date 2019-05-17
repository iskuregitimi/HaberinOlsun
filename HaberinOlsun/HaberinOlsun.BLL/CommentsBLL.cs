using HaberinOlsun.DAL;
using HaberinOlsun.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
    public class CommentsBLL
    {
        Repository<Comment> repo = new Repository<Comment>();

        //eğer haberse habere göre listelesin
        //eğer yorumsa yoruma göre listelesin

        public List<Comment> GetComments()
        {
            return repo.List();
        }

        public Comment GetComment(int id)
        {
            return repo.Find(x => x.CommentId == id);
        }

        public List<Comment> GetCommentListesi(int id)
        {
            return repo.List(x => x.CommentId == id);
        }
        public void AddComment(Comment yorum)
        {
            repo.Insert(yorum);
        }

    }
}
