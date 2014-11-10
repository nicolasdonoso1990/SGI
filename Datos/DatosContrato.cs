using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;



namespace Datos
{
    public class DatosContrato
    {
        public Int32 buscarNroContrato(Int32 codAlq)
        {
            using (var context = new InmobiliariaEntities())
            {
                
                
               Contrato con = context.Contratos.First(i => i.cod_contrato == codAlq);

               Int32 nroContrato = con.cod_contrato;

                return nroContrato;


            }

        }
    }
}
