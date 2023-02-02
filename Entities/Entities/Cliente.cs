using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{

    [Table("TB_CLIENTE")]
    public  class Cliente
    {
        [Column("CLI_ID")]
        public int Id { get; set; }

        [Column("CLI_TITULO")]
        [MaxLength(255)]
        public string ClienteNome { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<Projeto> Projetos { get; set; }

    }
}
