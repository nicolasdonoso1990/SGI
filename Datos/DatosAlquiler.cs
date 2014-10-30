﻿using System;
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






    }
}
