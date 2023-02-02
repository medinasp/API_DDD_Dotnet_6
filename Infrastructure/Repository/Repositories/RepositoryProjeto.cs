using Entities.Entities;
using Infrastructure.Repository.Generics;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Configuration;
using System.Linq.Expressions;

namespace Infrastructure.Repository.Repositories
{
    public class RepositoryProjeto : RepositoryGenerics<Projeto>, IProjeto
    {
        private readonly DbContextOptions<ContextBase> _OptionBuilder;

        public RepositoryProjeto()
        {
            _OptionBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<List<Projeto>> ListarProjeto(Expression<Func<Projeto, bool>> exMessage)
        {
            using (var banco = new ContextBase(_OptionBuilder))
            {
                return await banco.Projeto.Where(exMessage).AsNoTracking().ToListAsync();
            }
        }
    }
}
