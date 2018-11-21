using Diarista.Classifiers;
using System;
using System.ComponentModel.DataAnnotations;

namespace Diarista.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string ContratanteId { get; set; }
        public string DiaristaId { get; set; }
        public int CasaId { get; set; }
        public string Descricao { get; set; }
        public int Avaliacao { get; set; }
        public Perfil Contratante { get; set; }
        public Perfil Diarista { get; set; }
        public Casa Casa { get; set; }
        public StatusServico Status { get; set; }
        public DateTime DataPublicacao { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataContratacao { get; set; }
    }
}