using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;


namespace Datos
{
  public  class DatosPagos_Alquiler
    {
      public void AltaPagosAlquiler (Pago_alquiler pa)
      {
      using (var context = new InmobiliariaEntities())
      {
          context.Pagos_alquiler.Add(pa);
          context.SaveChanges();
      }

      }
    }
}
