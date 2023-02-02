using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServices
{
    public interface IServiceCliente
    {
        //interface do serviço de adicionar com void
        void Adicionar(Cliente Objeto);
        
        ////interface do serviçod e adicionar com Task
        //Task Adicionar(Cliente Objeto);

        Task Atualizar(Cliente Objeto);

        //Task<List<Cliente>> ListarMessageAtivas();

    }
}
