using System.Collections.Generic;
using System.Threading.Tasks;
using CititorServer.Data.Model;

namespace CititorServer.Data.Service
{
    public interface IMenuService
    {
        Task<IEnumerable<MenuInfo>> GetMenuData();
     
    }
}