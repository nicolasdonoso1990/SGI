using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace Datos
{
   public class DatosCuentaCorriente
    {

       public double TraerSaldoInquilino(int numero)
       {
           using (var context = new InmobiliariaEntities())
           {

               Cuenta_corriente ctacte = context.Cuenta_corriente.First(i => i.nro_inquilino == numero);

               double saldo = Convert.ToDouble(ctacte.saldo);
               
               return saldo;

           }
      
       }

       public void ActualizarSaldo (Int32 saldoActual,Int32 nroInq)
       {
           DateTime hoy = DateTime.Today;
           using ( var context = new InmobiliariaEntities())
           {
               Cuenta_corriente cc = context.Cuenta_corriente.First(i => i.nro_inquilino == nroInq);
               cc.saldo = saldoActual;
               cc.fecha = hoy;

               context.SaveChanges();

           }
       }


    }
}
