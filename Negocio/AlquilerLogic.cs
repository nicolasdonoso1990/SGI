using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AlquilerLogic
    {
         public DatosAlquiler alquilerData { get; set; }  // declaramos las propiedades get set

        public AlquilerLogic()     //instanciamos el administrador Data
        {
            this.alquilerData = new DatosAlquiler();
        
        }

        public Int32 AltaAlquiler(Alquiler alq) 
        {

           Int32 numero=alquilerData.AltaAlquiler(alq);
           return numero;

        }




    }
}
