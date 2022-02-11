using LocadoraTeste.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace LocadoraTeste.Services.Implementacao
{
    public class FilmeServiceImplementacao
    {
        private volatile int count;

        public Filme Create(Filme filme)
        {
            return filme;
        }
        public List<Filme> FindAll()
        {
            List<Filme> filmes = new List<Filme>();
            for (int i = 0; i < 5; i++)
            {
                Filme filme = MockFilme(i);
                filmes.Add(filme);
            }
            return filmes;
        }

        public Filme FindById(long id)
        {
            return new Filme
            {
                Id = IncrementAndGet(),
                Nome = "Senhor dos Anéis",
                Disponivel = true,
                Ativo = true,
                Data_Cadastro = new DateTime(2015, 10, 01)
            };
        }

        public Filme Update(Filme filme)
        {
            return filme;
        }


        public Filme Delete(long id)
        {
            throw new NotImplementedException();
        }
        public Filme MockFilme(int i)
        {
            return new Filme
            {
                Id = IncrementAndGet(),
                Nome = "Filme Nome " + i,
                Disponivel = true,
                Ativo = true,
                Data_Cadastro = DateTime.Now
            };
        }

        private int IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
