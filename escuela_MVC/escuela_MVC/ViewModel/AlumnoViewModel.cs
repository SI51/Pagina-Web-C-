using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using escuela_MVC.Models;

namespace escuela_MVC.ViewModel
{
    public class AlumnoViewModel
    {
        public static List<Alumno> ListarContenido()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Alumnos.Where(r => r.bStatus == true).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Alumno DatosAlumnos(int id)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Alumnos.Where(r => r.bStatus==true && r.pkAlumno==id).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }      

        public static void Actualizar(AlumnosViewModel Datos)
        {
            Alumno tAlumno = DatosAlumnos(Datos.txtID);
            tAlumno.sNombre = Datos.txtNombre;
            tAlumno.sApellido = Datos.txtApellido;
            tAlumno.sGrupo = Datos.txtGrupo;

            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Entry(tAlumno).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void borrar(int ID)
        {
            Alumno tAlumno = DatosAlumnos(ID);
            tAlumno.bStatus = false;
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Entry(tAlumno).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}