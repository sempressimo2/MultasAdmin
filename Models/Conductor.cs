using System.ComponentModel.DataAnnotations;

namespace MultasAdmin.Models
{
    public class Conductor
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string? Licencia { get; set; }

        [MaxLength(50)]
        public string? SeguroSocial { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nombre { get; set; }

        [MaxLength(100)]
        public string? ApellidoPaterno { get; set; }

        [MaxLength(100)]
        public string? ApellidoMaterno { get; set; }

        [MaxLength(100)]
        public string? Dir1 { get; set; }

        [MaxLength(100)]
        public string? Pueblo { get; set; }

        [MaxLength(50)]
        public string? Pais { get; set; }

        [MaxLength(20)]
        public string? ZipCode { get; set; }

        public ICollection<Boleto>? Boletos { get; set; }
    }
}
