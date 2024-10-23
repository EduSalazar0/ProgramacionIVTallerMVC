using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProgramacionIVTallerMVC.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Posicion { get; set; } = null!;

        [Range(0, 100)]
        public int Edad { get; set; }

        [ForeignKey("Equipo")]
        public int IDEquipo { get; set; }

        public virtual Equipo? Equipo { get; set; }
    }
}
