using MultasAdmin.Models;
using System.ComponentModel.DataAnnotations;

namespace APIMultas.Models
{
    public class Boleto
    {
        [Key]
        public int ID { get; set; }
        public int Rec { get; set; }
        public string? NumBoleto { get; set; }
        public string? DeviceName { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string? Municipio { get; set; }
        public string? Tablilla { get; set; }
        public string? CMag { get; set; }
        public string? Cap { get; set; }
        public string? Articulo { get; set; }
        public string? CDtop { get; set; }
        public decimal Multa { get; set; }
        public string? Licencia { get; set; }
        public string? Falta { get; set; }
        public string? Sector { get; set; }
        public string? Lugar { get; set; }
        public string? LugarDesc { get; set; }
        public decimal CoordenadasX { get; set; }
        public decimal CoordenadasY { get; set; }
        public byte[]? Foto { get; set; }
        public bool Radar { get; set; }
        public string? Agente { get; set; }
        public string? Placa { get; set; }
        public string? Supervisor { get; set; }
        public string? Distrito { get; set; }
        public int Puntos { get; set; }
        public string? CodigoMultasAdm { get; set; }
        public string? UserLoginName { get; set; }
        public string? UserFullName { get; set; }
        public DateTime LastUpdateDate { get; set; }
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
