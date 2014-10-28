using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Datos
{
    public class DatosContrato
    {
        public void AltaContrato(Contrato cont) 
        {
            using (var context = new InmobiliariaEntities()) 
            {
                context.Contratos.Add(cont);
                context.SaveChanges();

            
            }
        
        
        }



    }
}
