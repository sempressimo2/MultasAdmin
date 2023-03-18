using System.ComponentModel.DataAnnotations;

namespace MultasAdmin.Models
{
    public class Vehiculo
    {
        [Key]
        public int ID { get; set; }
        public string? Tablilla { get; set; }
        public string? Marca { get; set; }
        public string? MarcaOtra { get; set; }
        public string? Modelo { get; set; }
        public string? Color { get; set; }
        public string? Registro { get; set; }
        public string? Licencia { get; set; }
        public string? SerieMotor { get; set; }
    }
}