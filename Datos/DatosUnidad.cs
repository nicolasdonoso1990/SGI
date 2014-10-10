using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;


namespace Datos
{
    public class DatosUnidad
    {

        public void altaUnidad(Unidad uni) 
        {
     

            using (var context = new InmobiliariaEntities())
            {

                context.Unidades.Add(uni);
                context.SaveChanges();


            }

            
        
        }
        
        
        }
 






    }
