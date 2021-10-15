using System.Threading.Tasks;
using CititorServer.Data.Model;
using System;
using System.Collections.Generic;

namespace CititorServer.Data.Service
{
    public interface IListdeService
    {   

        Task<bool> ListdeInsert(Listde listde);
        Task<bool> ListdeUpdate(Listde listde);
        Task<Listde> ListdeGet(int idListde);
        Task<IEnumerable<Listde>> AllListdeGet();
        Task<IEnumerable<Article>> AllArticleListDe();
        Task<bool> ListdeUpdateDesign(int idArticle, int idDesign);
    }
}