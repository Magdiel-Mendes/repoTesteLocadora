using LocadoraTeste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraTeste.Services
{
    public interface ILocacaoService
    {
        Locacao Create(Locacao locacao);

        Locacao FindById(long id);

        List<Locacao> FindAll();

        Locacao Update(Locacao locacao);
    }
}
