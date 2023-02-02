using AutoMapper;
using Domain.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIs.Models;

namespace WebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GravacoesController : ControllerBase
    {
        private readonly IMapper _IMapper;
        private readonly IGravacao _IGravacao;

        public GravacoesController(IMapper IMapper, IGravacao IGravacao)
        {
            _IMapper = IMapper;
            _IGravacao = IGravacao;
        }

        [HttpGet]
        public async Task<List<GravacaoViewModel>> List()
        {
            var gravacoes = await _IGravacao.List();
            var gravacaomap = _IMapper.Map<List<GravacaoViewModel>>(gravacoes);
            return gravacaomap;
        }

        [Produces("application/json")]
        [HttpPost("/api/AddGrav")]
        public IActionResult Adicionar(GravacaoViewModel gravacaoViewModel)
        {
            var gravacaomap = _IMapper.Map<Gravacao>(gravacaoViewModel);
            _IGravacao.Add(gravacaomap);
            return Ok();
        }

        [Produces("application/json")]
        [HttpPost("/api/DelGrav")]
        public IActionResult Remover(GravacaoViewModel gravacaoViewModel)
        {
            var gravacaomap = _IMapper.Map<Gravacao>(gravacaoViewModel);
            _IGravacao.Delete(gravacaomap);
            return Ok();
        }

        [Produces("application/json")]
        [HttpPost("/api/GetlEGravById")]
        public async Task<GravacaoViewModel> GetEntityById(GravacaoViewModel gravacaoVM)
        {
            var gravacao = await _IGravacao.GetEntityById(gravacaoVM.Id);
            var gravacaoamap = _IMapper.Map<GravacaoViewModel>(gravacao);
            return gravacaoamap;
        }
    }
}
