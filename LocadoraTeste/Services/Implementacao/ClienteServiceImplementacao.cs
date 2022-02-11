using LocadoraTeste.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace LocadoraTeste.Services.Implementacao
{
    public class ClienteServiceImplementacao : IClienteService
    {
        private volatile int count;

       
        public Cliente Create(Cliente cliente)
        {
            return cliente;
        }
        public List<Cliente> FindAll()
        {
            List<Cliente> clientes = new List<Cliente>();
            for (int i = 0; i < 8; i++)
            {
                Cliente cliente = MockPerson(i);
                clientes.Add(cliente);
            }
            return clientes;
        }
        public Cliente FindById(long id)
        {
            return new Cliente
            {
                Id = IncrementAndGet(),
                Nome = "Magdiel Mendes",
                Disponivel = true,
                Ativo = true,
                Data_Cadastro = new DateTime(2005, 07, 30)
           
            };
        }
        public Cliente Update(Cliente cliente)
        {
            return cliente;
        }

        private Cliente MockPerson(int i)
        {
            return new Cliente
            {
                Id = IncrementAndGet(),
                Nome = "Name Cliente" + i,
                Disponivel = true,
                Ativo = true,
                Data_Cadastro = DateTime.Now
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
        public void Delete(long id)
        {
        }
    }
}
