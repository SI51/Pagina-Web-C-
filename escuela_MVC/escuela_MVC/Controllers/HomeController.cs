﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using escuela_MVC.Models;
using System.Web.Mvc;
using System.Data.Entity;
using escuela_MVC.ViewModel;
using escuela_MVC.Comun;

namespace escuela_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(String txtValor = "")
        {
            List<Alumno> Datos = AlumnoViewModel.ListarContenido(txtValor);
            ViewBag.Datos = Datos;
            ViewBag.Title = "";
            ViewBag.txtValor = txtValor;
            return View();
        }

        public ActionResult VerDetalle(int ID)
        {
            Alumno datos = AlumnoViewModel.DatosAlumnos(ID);
            ViewBag.datos = datos;
            ViewBag.Title = "";
            return View();
        }

        public ActionResult GetImage(int ID)
        {
            Alumno TemAlumno = AlumnoViewModel.DatosAlumnos(ID);
            var temImage = ToolImage.Base64StringToBitmap(TemAlumno.sImage);
            var temMapBytes = ToolImage.bitmapToBytes(temImage);
            return File(temMapBytes, "image/jpeg");
        }

        public ActionResult frmActualizacion(int ID)
        {
            Alumno alumno = AlumnoViewModel.DatosAlumnos(ID);
            ViewBag.Datos = alumno;
            return View();
        }

        /* public ActionResult Actualizar(int id, String txtNombre, String txtApellido, String txtGrupo)
         {
             int x = 1;
             return View();
         }*/

        public ActionResult Actualizar(AlumnosViewModel Datos)
        {
            AlumnoViewModel.Actualizar(Datos);
            return View();
        }

        public ActionResult borrar(int id)
        {
            ViewBag.Dato = AlumnoViewModel.DatosAlumnos(id);
            return View();
        }

        public ActionResult borrar2(int txtID)
        {
            AlumnoViewModel.borrar(txtID);
            return View();
        }

        public ActionResult frmNuevo()
        {
            return View();
        }

        public ActionResult Guardar(AlumnosViewModel Dato)
        {
            AlumnoViewModel.Guardar(Dato);
            return View();
        }
    }
}