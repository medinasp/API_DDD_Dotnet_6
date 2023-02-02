using Domain.Interfaces;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class RepositoryEntrevista : RepositoryGenerics<Entrevista>, IEntrevista
    {
        private readonly DbContextOptions<ContextBase> _OptionBuilder;

        public RepositoryEntrevista()
        {
            _OptionBuilder = new DbContextOptions<ContextBase>();
        }

        //public async Task<List<Entrevista>> ListarEntrevista(Expression<Func<Entrevista, bool>> exMessage)
        //{
        //    using (var banco = new ContextBase(_OptionBuilder))
        //    {
        //        return await banco.Entrevista.Where(exMessage).AsNoTracking().ToListAsync();
        //    }
        //}
    }
}
