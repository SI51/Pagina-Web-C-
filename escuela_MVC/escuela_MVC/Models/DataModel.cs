using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace escuela_MVC.Models
{
    public class DataModel:DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        /// <summary>
        /// CONSTRUCTOR DE LA CLASE Y SE LE INDICA EL NOMBRE DE LA CADENA DE 
        /// CONCECCION
        /// </summary>
        public DataModel() : base("DataModel") { }
    }
}