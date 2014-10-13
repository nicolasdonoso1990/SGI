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
    public class FotoLogic
    {
        public DatosFoto FotoData { get; set; }  // declaramos las propiedades get set


        public FotoLogic() 
        {
            this.FotoData = new DatosFoto();
        
        }


       public void AltaFotos(Foto[] fotos)
       {
       
       FotoData.AltaFotos(fotos);
       
       
       
       }

       public List<Foto> BuscaFoto(string codUni) 
       {


          List<Foto>fotos= FotoData.BuscaFoto(codUni);
          return fotos;
       }


    }
}
