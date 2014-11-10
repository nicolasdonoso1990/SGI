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
        public List<Alquiler> buscarAlquileresActuales()
        {
            using (var context = new InmobiliariaEntities())
            {

                var query = from c in context.Alquileres where c.estado == "Alquilando" select c; 
                return query.ToList();

            }   

    }
    }
}
