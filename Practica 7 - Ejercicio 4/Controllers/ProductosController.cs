using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_7___Ejercicios.Models;
using Practica_7___Ejercicios.Models.ViewModels;

namespace Practica_7___Ejercicios.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            List<ProductosViewModel> lst;
            using (Practica7Entities db = new Practica7Entities())
            {
                lst = (from d in db.PRODUCTOS
                          select new ProductosViewModel
                          {
                              Codigo = d.codigo,
                              Nombre = d.nombre,
                              Descripcion = d.descripcion,
                              Precio = d.precio,
                              Stock = d.stock

                             
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