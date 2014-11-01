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


       public DatosValorMensual valorData {get;set;}
           

       public ValorMensualLogic()
        {
            this.valorData = new DatosValorMensual();

        }

       public void altaValoresMensuales(Valor_mensual valor) 
       {

           valorData.AltaValores(valor);
       
       }
      



    }
}
