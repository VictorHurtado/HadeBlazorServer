using System.Threading.Tasks;
using CititorServer.Data.Model;
using System;
using System.Collections.Generic;

namespace CititorServer.Data.Service
{
    public interface IDesignService
    {   

        Task<bool> DesignInsert(Design design);
        Task<bool> DesignUpdate(Design design);
        Task<Design> DesignGet(int idDiseño);
        Task<IEnumerable<Design>> AllDesignsGet();
    }
}