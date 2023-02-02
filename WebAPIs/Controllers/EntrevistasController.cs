using AutoMapper;
using Domain.Interfaces;
using Entities.Entities;
using Infrastructure.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIs.Models;

namespace WebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrevistasController : ControllerBase
    {
        private readonly IMapper _IMapper;
        private readonly IEntrevista _IEntrevista;

        public EntrevistasController(IMapper IMapper, IEntrevista IEntrevista)
        {
            _IMapper = IMapper;
            _IEntrevista = IEntrevista;
        }

        [HttpGet]
        public async Task<List<EntrevistaViewModel>> List()
        {
            var entrevistas = await _IEntrevista.List();
            var entrevistamap = _IMapper.Map<List<EntrevistaViewModel>>(entrevistas);
            return entrevistamap;
        }

        [Produces("application/json")]
        [HttpPost("/api/AddEntrev")]
        public IActionResult Adicionar(EntrevistaViewModel entrevistaViewModel)
        {
            var entrevistamap = _IMapper.Map<Entrevista>(entrevistaViewModel);
            _IEntrevista.Add(entrevistamap);
            return Ok();
        }

        [Produces("application/json")]
        [HttpPost("/api/DelEntrev")]
        public IActionResult Remover (EntrevistaViewModel entrevistaViewModel)
        {
            var entrevistamap = _IMapper.Map<Entrevista>(entrevistaViewModel);
            _IEntrevista.Delete(entrevistamap);
            return Ok();
        }

        [Produces("application/json")]
        [HttpPost("/api/GetlEntrevById")]
        public async Task<EntrevistaViewModel> GetEntityById (EntrevistaViewModel entrevistaVM)
        {
            var entrevista = await _IEntrevista.GetEntityById(entrevistaVM.IdEntrevista);
            var entrevistamap = _IMapper.Map<EntrevistaViewModel>(entrevista);
            return entrevistamap;
        }
    }
}
