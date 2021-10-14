using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica_7___Ejercicio_5.Models.ViewModels
{
    public class VentasViewModel
    {
        public string IDventa { get; set; }
        public string cod { get; set; }
        public decimal importe { get; set; }
        public DateTime fecha { get; set; }
        public int Cantidad { get; set; }
        public string Vendedor { get; set; }
        public string Cliente { get; set; }



    }
}