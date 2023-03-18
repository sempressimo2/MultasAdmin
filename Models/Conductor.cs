using System.ComponentModel.DataAnnotations;

namespace APIMultas.Models
{
    public class Conductor
    {
        [Key]
        public int ID { get; set; }
        public string? Licencia { get; set; }
        public string? SeguroSocial { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Dir1 { get; set; }
        public string? Pueblo { get; set; }
        public string? Pais { get; set; }
        public string? ZipCode { get; set; }

        public ICollection<Boleto>? Boletos { get; set; }
    }
}
