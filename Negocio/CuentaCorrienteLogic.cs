using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
   public class CuentaCorrienteLogic
    {
       public DatosCuentaCorriente CuentaCorrienteData { get; set; }

       public CuentaCorrienteLogic()
       {
           this.CuentaCorrienteData = new DatosCuentaCorriente();
       }

       public double TraerSaldoInquilino(int numero)
       {
           double saldo = CuentaCorrienteData.TraerSaldoInquilino(numero);

           return saldo;
       }

       public void ActualizarSaldo(Int32 saldoActual,Int32 nroInq) 
       {
           this.CuentaCorrienteData.ActualizarSaldo(saldoActual, nroInq);
       }

    }
}
