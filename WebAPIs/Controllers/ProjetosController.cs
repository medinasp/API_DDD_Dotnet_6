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
    public class ProjetosController : ControllerBase
    {

        private readonly IMapper _IMapper;
        private readonly IProjeto _IProjeto;

        public ProjetosController(IMapper IMapper, IProjeto IProjeto)
        {
            _IMapper = IMapper;
            _IProjeto = IProjeto;
        }

        // GET: api/<ProjetosController>
        [HttpGet]
        public async Task<List<ProjetoViewModel>> List()
        {
            var projetos = await _IProjeto.List();
            var projetoMap = _IMapper.Map<List<ProjetoViewModel>>(projetos);
            return projetoMap;
        }

        [Produces("application/json")]
        [HttpPost("/api/AddProj")]
        public IActionResult Adicionar(ProjetoViewModel projetoViewModel)
        {
            var projetomap = _IMapper.Map<Projeto>(projetoViewModel);
            _IProjeto.Add(projetomap);
            return Ok();
        }

        [Produces("application/json")]
        [HttpPost("/api/DelProj")]
        public IActionResult Remover (ProjetoViewModel projetoViewModel)
        {
            var projetomap = _IMapper.Map<Projeto>(projetoViewModel);
            _IProjeto.Delete(projetomap);
            return Ok();
        }

        [Produces("application/json")]
        [HttpPost("/api/GetProjById")]
        public async Task<ProjetoViewModel> GetEntityById (ProjetoViewModel projetoVM)
        {
            var projeto = await _IProjeto.GetEntityById(projetoVM.ProjetoId);
            var projetomap = _IMapper.Map<ProjetoViewModel>(projeto);
            return projetomap;
        }

    }
}
