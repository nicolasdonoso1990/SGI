using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;



namespace Negocio
{
     public class ContratoLogic
    {
        public DatosContrato ContratoData { get; set; }

         public ContratoLogic()
         {
             this.ContratoData= new DatosContrato();
         }

         public Int32 BuscarNroContrato(Int32 nroAlquiler)
        {
            Int32 nroCon = this.ContratoData.buscarNroContrato(nroAlquiler);
            return nroCon;

         }

          public void AltaContrato(Contrato cont) 
        {
            ContratoData.AltaContrato(cont);

        
        }

     }
}


