using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosValorMensual
    {


        public void AltaValores(Valor_mensual valor) 
        {
            using (var context = new InmobiliariaEntities()) 
            {
                context.Valores_mensuales.Add(valor);
                context.SaveChanges();
            
            
            }
        
        
        }

        



    }
}
