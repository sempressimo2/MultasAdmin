using MultasAdmin.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultasAdmin.Models
{
    public class Boleto
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Rec { get; set; }

        [MaxLength(50)]
        public string? NumBoleto { get; set; }

        [MaxLength(100)]
        public string? DeviceName { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public TimeSpan Hora { get; set; }

        [MaxLength(100)]
        public string? Municipio { get; set; }

        [MaxLength(20)]
        public string? Tablilla { get; set; }

        [MaxLength(50)]
        public string? CMag { get; set; }

        [MaxLength(50)]
        public string? Cap { get; set; }

        [MaxLength(50)]
        public string? Articulo { get; set; }

        [MaxLength(50)]
        public string? CDtop { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Multa { get; set; }

        [MaxLength(50)]
        public string? Licencia { get; set; }

        [MaxLength(50)]
        public string? Falta { get; set; }

        [MaxLength(50)]
        public string? Sector { get; set; }

        [MaxLength(100)]
        public string? Lugar { get; set; }

        [MaxLength(100)]
        public string? LugarDesc { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,10)")]
        public decimal CoordenadasX { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,10)")]
        public decimal CoordenadasY { get; set; }

        public byte[]? Foto { get; set; }

        [Required]
        public bool? Radar { get; set; }

        [MaxLength(100)]
        public string? Agente { get; set; }

        [MaxLength(50)]
        public string? Placa { get; set; }

        [MaxLength(100)]
        public string? Supervisor { get; set; }

        [MaxLength(100)]
        public string? Distrito { get; set; }

        [Required]
        public int Puntos { get; set; }

        [MaxLength(50)]
        public string? CodigoMultasAdm { get; set; }

        [MaxLength(100)]
        public string? UserLoginName { get; set; }

        [MaxLength(100)]
        public string? UserFullName { get; set; }

        [Required]
        public DateTime LastUpdateDate { get; set; }

        [Required]
        public bool EnviadoDTOP { get; set; }

        public DateTime? FechaEnviado { get; set; }

        public int? VehiculoId { get; set; }
        public Vehiculo? Vehiculo { get; set; }

        public int? ConductorId { get; set; }
        public Conductor? Conductor { get; set; }

        public int? PoliciaId { get; set; }
        public Policia? Policia { get; set; }
    }
}
