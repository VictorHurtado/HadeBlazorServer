using System.Threading.Tasks;
using CititorServer.Data.Model;
using System;
using System.Collections.Generic;

namespace CititorServer.Data.Service
{
    public interface IBonoService
    {   
        Task<IEnumerable<Bono>> AllBonoGet();
        Task<Bono> bonoGet(String co_alpha);
    }
}