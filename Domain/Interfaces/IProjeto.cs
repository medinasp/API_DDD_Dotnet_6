﻿using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProjeto : IGeneric<Projeto>
    {
        Task<List<Projeto>> ListarProjeto(Expression<Func<Projeto, bool>> exMessage);
    }
}
