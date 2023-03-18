using System.ComponentModel.DataAnnotations;

namespace MultasAdmin.Models
{
    public class Policia
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Tablilla { get; set; }

        [MaxLength(100)]
        public string? Marca { get; set; }

        [MaxLength(100)]
        public string? MarcaOtra { get; set; }

        [MaxLength(100)]
        public string? Modelo { get; set; }

        [MaxLength(50)]
        public string? Color { get; set; }

        [MaxLength(50)]
        public string? Registro { get; set; }

        [MaxLength(50)]
        public string? Licencia { get; set; }

        [MaxLength(50)]
        public string? SerieMotor { get; set; }

        public ICollection<Boleto>? Boletos { get; set; }
    }
}
