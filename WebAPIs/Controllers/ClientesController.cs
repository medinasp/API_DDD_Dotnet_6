using Entities.Entities;
using Infrastructure.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Domain.Interfaces;
using Domain.Interfaces.InterfaceServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using WebAPIs.Models;
using Domain.Interfaces.InterfaceServices;
using Domain.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        private readonly ContextBase _context;
        private readonly IMapper _IMapper;
        private readonly ICliente _ICliente;
        private readonly IServiceCliente _IServiceCliente;


        public ClientesController(IMapper IMapper, ICliente ICliente, ContextBase context, IServiceCliente IServiceCliente)
        {
            _context = context;
            _IMapper = IMapper;
            _ICliente = ICliente;
            _IServiceCliente = IServiceCliente;
        }

        //get fazendo mapeamento da viewmodel com a Entities com o Map
        // GET: api/<Clientes>
        [HttpGet]
        public async Task<List<ClienteViewModel>> List()
        {
            var clientes = await _ICliente.List();
            var clienteMap = _IMapper.Map<List<ClienteViewModel>>(clientes);
            return clienteMap;
            //return await _context.Cliente.ToListAsync(); //chamada direta sem passar pelas interfaces
        }

        ////get chamando diretamente a entitie sem mapear com a viewmodel
        //// GET: api/<Clientes>
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Cliente>>> List()
        //{
        //    var clientes = await _ICliente.List();
        //    return clientes;
        //}

        ////get usando a viewmodel e fazendo o mapeamento manual
        //// GET: api/<Clientes>
        //[HttpGet]
        //public async Task<List<ClienteViewModel>> List()
        //{
        //    var clientes = await _context.Cliente.Select(b => new ClienteViewModel()
        //    {
        //        Nome = b.ClienteNome
        //    }).ToListAsync();
        //    return clientes;
        //}


        //post adicionar sem usar mapper
        //[Authorize]
        //[Produces("application/json")]
        //[HttpPost]
        //public IActionResult Adicionar([FromBody] Cliente cliente)
        //{
        //    _IServiceCliente.Adicionar(cliente);
        //    return CreatedAtAction(nameof(GetType), new { id = cliente.ClienteId }, cliente);
        //}

        ////post adicionar usando mapper mas já indo direto p Cliente sem passar pelo IServiceCliente e ServiceCliente
        //[HttpPost]
        //public IActionResult Adicionar(ClienteViewModel clienteViewModel)
        //{
        //    var clientemap = _IMapper.Map<Cliente>(clienteViewModel);
        //    _ICliente.Add(clientemap);
        //    return Ok();
        //}

        //post adicionar com Task usando mapper e passando pelo  IServiceCliente e ServiceCliente
        //[Produces("application/json")]
        //[HttpPost("/api/AddCli")]
        //public async Task Adicionar(ClienteViewModel clienteViewModel)
        //{
        //    var clientemap = _IMapper.Map<Cliente>(clienteViewModel);
        //    _IServiceCliente.Adicionar(clientemap);
        //    //return Ok();
        //}

        //post adicionar com IActionResult usando mapper e passando pelo  IServiceCliente e ServiceCliente
        [Produces("application/json")]
        [HttpPost("/api/AddCli")]
        public IActionResult Adicionar(ClienteViewModel clienteViewModel)
        {
            var clientemap = _IMapper.Map<Cliente>(clienteViewModel);
            _IServiceCliente.Adicionar(clientemap);
            return Ok();
        }

        //[Authorize]
        [Produces("application/json")]
        [HttpPost("/api/DelCli")]
        public IActionResult Remover(ClienteViewModel clienteViewModel)
        {
            var clientemap = _IMapper.Map<Cliente>(clienteViewModel);
            _ICliente.Delete(clientemap);
            return Ok();
        }

        //[Authorize]
        [Produces("application/json")]
        [HttpPost("/api/GetCliById")]
        public async Task<ClienteViewModel> GetEntityById(ClienteViewModel clienteVM)
        {
            var cliente = await _ICliente.GetEntityById(clienteVM.Id);
            //Aqui o MAP faz o processo inverso, ele vai no banco, via model, pra pegar os dados pelo ID e chama a viewmodel pra mostrar
            var clientemap = _IMapper.Map<ClienteViewModel>(cliente);
            return clientemap;
        }

    }
}
