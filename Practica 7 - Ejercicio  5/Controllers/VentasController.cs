using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_7___Ejercicio_5.Models;
using Practica_7___Ejercicio_5.Models.ViewModels;

namespace Practica_7___Ejercicios.Controllers
{
    public class VentasController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            List<VentasViewModel> lst;
            using (Practica7Entities1 db = new Practica7Entities1())
            {
                lst = (from d in db.Venta
                          select new VentasViewModel
                          {
                              IDventa = d.IDventa,
                              cod = d.Cod,
                              importe = d.importe,
                              fecha = d.fecha,
                              Cantidad = d.Cantidad,
                              Vendedor = d.vendedor,
                              Cliente = d.cliente,
                             
                          }).ToList();
            }
            return View();
        }

        private void ToList()
        {
            throw new NotImplementedException();
        }
    }
}