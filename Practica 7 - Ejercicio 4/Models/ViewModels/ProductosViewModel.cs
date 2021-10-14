using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica_7___Ejercicios.Models.ViewModels
{
    public class ProductosViewModel
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }


    }
}