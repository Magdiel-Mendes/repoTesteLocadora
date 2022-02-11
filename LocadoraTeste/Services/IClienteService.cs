using LocadoraTeste.Model;
using System.Collections.Generic;

namespace LocadoraTeste.Services
{
    public interface IClienteService
    {
        Cliente Create(Cliente cliente);

        Cliente FindById(long id);

        List<Cliente> FindAll();

        Cliente Update(Cliente cliente);

        void Delete(long id);

    }
}
