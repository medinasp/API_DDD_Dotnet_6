﻿using Domain.Interfaces;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class RepositoryGravacao : RepositoryGenerics<Gravacao>, IGravacao
    {
        private readonly DbContextOptions<ContextBase> _OptionBuilder;

        public RepositoryGravacao()
        {
            _OptionBuilder = new DbContextOptions<ContextBase>();
        }
    }
}
