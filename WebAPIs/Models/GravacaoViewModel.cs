using Entities.Entities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebAPIs.Models
{
    public class GravacaoViewModel
    {
        public int Id { get; set; }
        public int? IdEntrevista { get; set; }
        public string? Numero { get; set; }
        public string? NomeDoArquivo { get; set; }
        public int? FileSize { get; set; }
        public string? FilePath { get; set; }
        public string? Ramal { get; set; }
    }
}
