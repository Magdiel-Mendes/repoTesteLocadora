using LocadoraTeste.Model;
using System.Collections.Generic;

namespace LocadoraTeste.Services
{
    public interface IFilmeService
    {
        Filme Create(Filme cliente);

        Filme FindById(long id);

        List<Filme> FindAll();

        Filme Update(Filme filme);

        void Delete(long id);
    }
}
