﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using escuela_MVC.Models;
using System.Data.Entity.Validation;
namespace escuela_MVC.ViewModel
{
    public class AlumnoViewModel
    {
        public static List<Alumno> ListarContenido(String valor="")
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Alumnos.Where(r => r.bStatus == true && r.sApellido.Contains(valor)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Alumno DatosAlumnos(int ID)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Alumnos.Where(r => r.bStatus == true && r.pkAlumno == ID).FirstOrDefault();
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
            catch (DbEntityValidationException e)
            {       
                foreach(var ev in e.EntityValidationErrors)
                {
                    int x = 0;
                }     
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
        
        public static void Guardar(AlumnosViewModel Dato)
        {
            Alumno talumno = new Alumno();

            talumno.sNombre = Dato.txtNombre;
            talumno.sApellido = Dato.txtApellido;
            talumno.sGrupo = Dato.txtGrupo;

            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Entry(talumno).State = EntityState.Added;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}