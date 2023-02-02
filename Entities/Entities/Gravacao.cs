using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities.Entities
{
    public class Gravacao
    {
        public int Id { get; set; }
        public int? IdEntrevista { get; set; }
        public string? Numero { get; set; }
        public string? NomeDoArquivo { get; set; }
        public int? FileSize { get; set; }
        public string? FilePath { get; set; }
        public string? Ramal { get; set; }
        public virtual Entrevista Entrevista { get; set; }
    }
}
