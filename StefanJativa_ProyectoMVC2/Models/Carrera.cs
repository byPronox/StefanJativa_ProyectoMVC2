using System.ComponentModel.DataAnnotations;

namespace StefanJativa_ProyectoMVC2.Models
{
    public class Carrera
    {
        [Required]
        [Range(1,1000)]
        public string ID { get; set; }

        []
        public string Nombre { get; set; }
        
    }
}
