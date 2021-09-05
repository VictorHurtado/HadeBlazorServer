using System.Threading.Tasks;
using CititorServer.Data.Model;

namespace CititorServer.Data.Service
{
    public interface IArticleService
    {
        Task<bool> ArticleInsert(Article article);
        Task<bool> ArticleUpdate(Article article);
        Task<Article> ArticleGet(int idArticle);
    }
}