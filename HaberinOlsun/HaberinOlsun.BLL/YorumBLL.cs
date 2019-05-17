using HaberinOlsun.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberinOlsun.BLL
{
  public static  class YorumBLL
    {
       static DataContext datacontext = new DataContext();

        public static void YorumYap(Comments comments)
        {
          
                datacontext.Comments.Add(comments);
                datacontext.SaveChanges();

           
        }
        public static List<Comments> getYorum(Comments comment)
        {
            if (comment.YazıID!=null)
            {
                return datacontext.Comments.Where(x => x.YazıID != null).ToList();

            }
            else if (comment.HaberID!=null)
            {
                return datacontext.Comments.Where(x => x.HaberID != null).ToList();


            }
            else
            {
                return datacontext.Comments.ToList();
            }

        }

    }
}
