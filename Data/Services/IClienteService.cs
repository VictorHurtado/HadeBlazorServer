using System.Threading.Tasks;
using CititorServer.Data.Model;

namespace CititorServer.Data.Service
{
    public interface IClienteService
    {
        Task<bool> ClienteInsert(Cliente cliente);
        Task<bool> ClienteUpdate(Cliente cliente);
        Task<Cliente> ClienteGet(int dnicliente);
    }
}