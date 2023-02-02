using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IEntrevista : IGeneric<Entrevista>
    {
//        Task<List<Entrevista>> ListarEntrevista(Expression<Func<Entrevista, bool>> exMessage);
    }
}
