using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.Entity;
using Entidades;

namespace Negocio
{
    public class PropiedadLogic   //hay que declararla publica para que otras clases tengan acceso
    {
         public  DatosPropiedad PropiedadData{ get; set; }  // declaramos las propiedades get set


        public PropiedadLogic() 
        {

            this.PropiedadData = new DatosPropiedad();
        
        }

        public void altaPropiedad(Propiedad pro) 
        {

            PropiedadData.altaPropiedad(pro);
        
        }

        public List<Propiedad> todasPropiedades() 
        {
            List<Propiedad> propiedades = new List<Propiedad>();
            propiedades = PropiedadData.todasPropiedades();
            return (propiedades);
           
        
        
        }

        public Propiedad buscaPropiedad(int codigo) 
        {
            Propiedad pro=PropiedadData.buscaPropiedad(codigo);
            return (pro);
        
        }


        public void ModificaPropiedad(string[] datos) 
        {

            PropiedadData.ModificaPropiedad(datos);        
        
        }

        public void BajaPropiedad(int codigo) 
        {
            PropiedadData.BajaPropiedad(codigo);
        
        
        }



    }
}
