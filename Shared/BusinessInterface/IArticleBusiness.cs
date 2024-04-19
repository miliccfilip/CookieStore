using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.BusinessInterface
{
    public interface IArticleBusiness
    {
         bool InsertArticle(Article a);
         List<Article> GetAllArticles();
         bool DeleteArticle(int idSelected);
         bool UpdateArticle(Article a);
         Article GetSelectedArticle(int id);
         bool IsArticleConnectedToBill(int articleId);
         int GetNewArticleId();
    }
}
