using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Entrevista> Entrevista { get; set; }
        public DbSet<Gravacao> Gravacao { get; set; }
        public DbSet<Projeto> Projeto { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Para colocar a string de conexão aqui, basta descomentar abaixo, descomentar o método ObterStringConexao mais abaixo e colocar a senha. Ou então coloca direto no option builder abaixo
                //optionsBuilder.UseSqlServer(ObterStringConexao());
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=API_DDD_2022;Integrated Security=True");
                base.OnConfiguring(optionsBuilder);
            }
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            {
               builder.Entity<Gravacao>()
                    .HasOne(g => g.Entrevista)
                    .WithOne(e => e.Gravacao) 
                    .HasForeignKey<Gravacao>(g => g.IdEntrevista);
            }

            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }


        //public string ObterStringConexao()
        //{
        //   return  "Data Source=localhost\\SQLEXPRESS;Initial Catalog=API_DDD_2022;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        //}

    }
}
