using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
    public class Pagos_AlquilerLogic
    {
        public DatosPagos_Alquiler Pagos_AlquilerData { get; set; }

        public Pagos_AlquilerLogic()
        { 
            this.Pagos_AlquilerData = new DatosPagos_Alquiler(); 
        }
        public void AltaPagos_Alquiler(Pago_alquiler pa)
        {
            this.Pagos_AlquilerData.AltaPagosAlquiler(pa);

            
        }

    }
}
