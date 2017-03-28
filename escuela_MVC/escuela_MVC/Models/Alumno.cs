using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace escuela_MVC.Models
{
    [Table("Alumnos")]
    public class Alumno
    {
        [Key]
        public int pkAlumno { get; set; }

        [Required(ErrorMessage = "Nombre")]
        [StringLength(50)]
        public String sNombre { get; set; }

        [Required(ErrorMessage = "Apellido")]
        [StringLength(50)]
        public String sApellido { get; set; }

        [Required(ErrorMessage = "Grupo")]
        [StringLength(50)]
        public String sGrupo { get; set; }

        [Required(ErrorMessage = "imagen")]
        [StringLength(50)]
        public String sImage { get; set; }

        public Boolean bStatus { get; set; }

        public Alumno()
        {
            this.bStatus = true;
        }
    }
}