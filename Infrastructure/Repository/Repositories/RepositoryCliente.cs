using Infrastructure.Repository.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Infrastructure.Repository.Repositories
{
    public class RepositoryCliente : RepositoryGenerics<Cliente>, ICliente
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositoryCliente()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<List<Cliente>> ListarCliente(Expression<Func<Cliente, bool>> exMessage)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.Cliente.Where(exMessage).AsNoTracking().ToListAsync();
            }
        }
    }
}
