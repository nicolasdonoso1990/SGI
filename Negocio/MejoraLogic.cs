using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class MejoraLogic
    {
        public DatosMejora datosMejora { get; set; }

        public MejoraLogic()
        {
            this.datosMejora = new DatosMejora();
        }

        public void altaMejora(Mejora mejora)
        {

            datosMejora.altaMejora(mejora);


        }

        public List<Mejora> getAll()
        {

            List<Mejora> Lista = new List<Mejora>();
            Lista = datosMejora.getAll();

            return (Lista);

        }


       /* public void modificarMejora(string[] datos)
        {
            datosMejora.modificarMejora(datos);



        }*/


        public void bajaMejora(string numeroMejora)
        {
            Int32 nro = Convert.ToInt32(numeroMejora);
            datosMejora.bajaMejora(nro);

        }
    }
}
