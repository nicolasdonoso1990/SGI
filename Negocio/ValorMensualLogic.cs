using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
    public class ValorMensualLogic
    {
        public DatosValorMensual ValorMensualData { get; set; }

        public ValorMensualLogic()
        {
            this.ValorMensualData = new DatosValorMensual();
        }

        public Int32 BuscarValorPago(int codigoContrato, DateTime fechaElegida)
        {
            Int32 valorMensual = this.ValorMensualData.buscarValorPago(codigoContrato,fechaElegida);

            return valorMensual;
        }

        public void altaValoresMensuales(Valor_mensual valor) 
       {

           ValorMensualData.AltaValores(valor);
       
       }


       
      




    }
}
