using System.ComponentModel.DataAnnotations;

namespace APIMultas.Models
{
    public class Policia
    {
        [Key]
        public int ID { get; set; }
        public int Rec { get; set; }
        public string? Nombre { get; set; }
        public string? Placa { get; set; }
        public string? Supervisor { get; set; }
        public bool Activo { get; set; }
        public string? Unidad { get; set; }
    }
}
