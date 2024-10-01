using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace StefanJativa_ProyectoMVC2.Models
{

    [Authorize]
    public class EstudianteUDLA
    {
        
        [Required]
        public string IDBanner { get; set; }

        [AllowNull]
        public string Correo { get; set; }

        [MaxLength(100)]
        public string Nombre { get; set; }
        //public List<Carrera> carreras { get; set; }

        public Carrera carreras { get; set; }
    }
}
