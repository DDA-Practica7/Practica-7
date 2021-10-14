using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practica_7_Experiencias.Models;

namespace Practica_7_Experiencias.Datos
{
    public class CustomerAdmin
    {
        public IEnumerable<CUSTOMERS> Consultar()
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                return contexto.CUSTOMERS.AsNoTracking().ToList();
            }
        }
        public CUSTOMERS Consultar(int id)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                return contexto.CUSTOMERS.AsNoTracking().FirstOrDefault(c =>
               c.codigo == id);
            }
        }
        public void Guardar(CUSTOMERS modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                contexto.CUSTOMERS.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(CUSTOMERS modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(CUSTOMERS modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }


}