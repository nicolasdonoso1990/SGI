using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;
using Datos;
 

namespace Negocio
{
    public class UltimoNumeroLogic
    {
        //public DatosFoto FotoData { get; set; }  // declaramos las propiedades get set
        public DatosUltimoNumeroFoto UltimoData { get; set; }

        public UltimoNumeroLogic() 
        {

            this.UltimoData = new DatosUltimoNumeroFoto();
        
        }

        public int BuscaUltimoNumero() 
        {
            int ult = UltimoData.BuscaUltimoNumero();
            return ult;
        
        
        }

        public void IncrementaUltimoNumero(int ulti) 
        {

            UltimoData.IncrementaUltimoNumero(ulti);
        
        
        }



    }
}
