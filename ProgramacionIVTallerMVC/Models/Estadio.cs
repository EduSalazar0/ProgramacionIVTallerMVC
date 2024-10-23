using System.ComponentModel.DataAnnotations;

namespace ProgramacionIVTallerMVC.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Direccion { get; set; }
        [StringLength(100)]
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }
        
    }
}
