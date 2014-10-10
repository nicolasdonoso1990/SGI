using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
    public class UnidadLogic
    {


            public DatosUnidad UnidadData { get; set; }

        public UnidadLogic() 
        {

            this.UnidadData = new DatosUnidad();
        
        }


        public void AltaUnidad(Unidad uni) 
        {

            UnidadData.altaUnidad(uni);
        
        }





    }
}
