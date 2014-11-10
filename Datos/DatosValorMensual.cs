using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Datos
{
     public class DatosValorMensual
    {
         public Int32 buscarValorPago( int codigoContrato, DateTime fechaElegida){

             ;

         using (var context = new InmobiliariaEntities())
     {
         Valor_mensual vm = context.Valores_mensuales.FirstOrDefault(i => i.cod_contrato == codigoContrato && i.fechaDesde <= fechaElegida && i.fechaHasta >= fechaElegida);
         Int32 valorMensual;

         if (vm != null)
         {
             valorMensual = Convert.ToInt32(vm.valor);
         }
         else {
             valorMensual = 0; 
         }


         return valorMensual;
     }
         }
    }
}
