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

        public DatosContrato contratoData { get; set; }  // declaramos las propiedades get set

        public ContratoLogic()     //instanciamos el administrador Data
        {
            this.contratoData = new DatosContrato();
        
        }

        public void AltaContrato(Contrato cont) 
        {
            contratoData.AltaContrato(cont);

        
        }



    }
}
