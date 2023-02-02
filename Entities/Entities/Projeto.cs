using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities.Entities
{
    public class Projeto
    {
        [Key]
        public int ProjetoId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public string Status { get; set; }

        [Display(Name = "Data Criação")]
        public DateTime DataCriacao { get; set; }

        [Display(Name = "Data Alteração")]
        public DateTime? DataAlteracao { get; set; }

        public virtual ICollection<Entrevista> Entrevistas { get; set; }
        public virtual Cliente Clientes { get; set; }
    }
}
