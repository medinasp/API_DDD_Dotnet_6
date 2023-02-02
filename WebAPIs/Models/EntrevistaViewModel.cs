using Entities.Entities;

namespace WebAPIs.Models
{
    public class EntrevistaViewModel
    {
        public int IdEntrevista { get; set; }
        public int Codigo { get; set; }
        public DateTime? DataEntrevista { get; set; }
        public DateTime? HoraEntrevista { get; set; }
        public Int64? TelefoneFeito { get; set; }
        public int? NumTratado { get; set; }
        public string Gravacao { get; set; }
        public int? Ddd1 { get; set; }
        public int? Fone1 { get; set; }
        public int? Ddd2 { get; set; }
        public int? Fone2 { get; set; }
        public int? Ddd3 { get; set; }
        public int? Fone3 { get; set; }
        public int? Ddd4 { get; set; }
        public int? Fone4 { get; set; }
        public string Entrevistador { get; set; }
        public int ProjetoId { get; set; }
        public string Usuario { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
