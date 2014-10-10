using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;




namespace Datos
{
    public class DatosFoto
    {



        public void AltaFotos(Foto[] fotos)
        {
        
         using (var context = new InmobiliariaEntities()) 
            {

            
               
                    for (int i = 0; i < 4; i++) 
                    {
                        if (fotos[i].ruta_foto!=null)
                        {
                            context.Fotos.Add(fotos[i]);
                           
                        }
                        
                        

                    }

                    context.SaveChanges();
                
                
            
            
            }
        
        
        
        }















    }
}
