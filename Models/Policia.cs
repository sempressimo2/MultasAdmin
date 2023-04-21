using System.ComponentModel.DataAnnotations;

namespace MultasAdmin.Models
{
    public class Policia
    {
        [Key]
        public int ID { get; set; }

        public int Rec { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nombre { get; set; }

        [MaxLength(50)]
        public string? Placa { get; set; }

        [MaxLength(100)]
        public string? Supervisor { get; set; }

        public bool Activo { get; set; }

        [MaxLength(50)]
        public string? Unidad { get; set; }
    }
}
