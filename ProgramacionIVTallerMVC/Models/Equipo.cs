using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProgramacionIVTallerMVC.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = null!;

        [MaxLength(100)]
        public string Ciudad { get; set; } = null!;

        [Range(0, 100)]
        public int Titulos { get; set; }

        public bool AceptaExtranjeros { get; set; }

        [ForeignKey("Estadio")]
        public int IDEstadio { get; set; }

        public virtual Estadio? Estadio { get; set; } = null!;
    }
}
