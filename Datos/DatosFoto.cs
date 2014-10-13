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


        public List<Foto> BuscaFoto(string codUni) 
        {

            using (var context = new InmobiliariaEntities()) 
            {
                Int32 num=Convert.ToInt32(codUni);

                var query= from c in context.Fotos where c.cod_unidad==num select c;
                return query.ToList();

            
            }


        }












    }
}
