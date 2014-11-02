using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;



namespace Datos
{
    public class DatosAlquiler
    {

        public void AltaAlquiler(Alquiler alq) 
        {

            using (var context = new InmobiliariaEntities())
            {
                
                context.Alquileres.Add(alq);
             
              


                context.SaveChanges();
                

              

            }
        
        
        }


        public Int32 BuscaNumeroAlquiler(Alquiler alq) 
        {
            using (var context = new InmobiliariaEntities()) 
            {
                Alquiler a = context.Alquileres.First(i => i.cod_unidad == alq.cod_unidad && i.nro_inquilino == alq.nro_inquilino && i.estado=="habilitado");
                return (a.nro_alquiler);            
            
            }
        
        
        
        }





    }
}
