using System.Threading.Tasks;
using CititorServer.Data.Model;

namespace CititorServer.Data.Service
{
    public interface IDesignService
    {
        Task<bool> DesignInsert(Design design);
        Task<bool> DesignUpdate(Design design);
        Task<Design> DesignGet(int idDiseño);
    }
}