using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practica_7_Experiencias.Datos;
using Practica_7_Experiencias.Models;
using System.Web.Mvc;

namespace Practica_7_Experiencias.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        CustomerAdmin admin = new CustomerAdmin();
        public ActionResult Index()
        {
            return View(admin.Consultar());
        }
        public ActionResult Detalle(int id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Guardar(CUSTOMERS modelo)
        {
            admin.Guardar(modelo);
            return View("Crear", modelo);
        }
        public ActionResult Editar(int id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Modificar(CUSTOMERS modelo)
        {
            admin.Modificar(modelo);
            return View("Editar", modelo);
        }
        public ActionResult Eliminar(int id)
        {
            CUSTOMERS modelo = admin.Consultar(id);
            admin.Eliminar(modelo);
            return View("Index", admin.Consultar());
        }
    }
}