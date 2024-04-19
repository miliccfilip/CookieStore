using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataInterface
{
    public interface IArticleRepository
    {
         List<Article> GetAllArticles();
         int InsertArticle(Article a);
         int UpdateArticle(Article a);
         int DeleteArticle(int id);
         int GetNewArticleId();
    }
}
