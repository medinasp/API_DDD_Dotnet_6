using Domain.Interfaces;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceCliente : IServiceCliente
    {
        private readonly ICliente _ICliente;

        public ServiceCliente(ICliente ICliente)
        {
            _ICliente = ICliente;
        }

        ////Serviço de Adicionar usando TAsk
        //public async Task Adicionar(Cliente Objeto)
        //{
        //    await _ICliente.Add(Objeto);
        //}

        //Serviço de Adicionar usando o IserviceCliente
        async void IServiceCliente.Adicionar(Cliente Objeto)
        {
            await _ICliente.Add(Objeto);
        }

        public async Task Atualizar(Cliente Objeto)
        {
            await _ICliente.Update(Objeto);
        }

        //public async Task Atualizar(Message Objeto)
        //{
        //    var validatitulo = Objeto.ValidarPropriedadeString(Objeto.Titulo, "Titulo");
        //    if (validatitulo)
        //    {
        //        Objeto.DataAlteracao = DateTime.Now;
        //        await _IMessage.Update(Objeto);
        //    }
        //}

        //public async Task<List<Message>> ListarMessageAtivas()
        //{
        //    return await _IMessage.ListarMessage(n => n.Ativo);
        //}
    }
}
