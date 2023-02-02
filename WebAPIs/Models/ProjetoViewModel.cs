using Entities.Entities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebAPIs.Models
{
    public class ProjetoViewModel
    {
        public int ProjetoId { get; set; }
        public string Nome { get; set; }
        public int ClienteId { get; set; }
        public string Status { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
