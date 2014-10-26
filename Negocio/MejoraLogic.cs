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


        
        public void modificarMejora(Mejora mejora)
        {
            datosMejora.modificarMejora(mejora);

        }


        public void bajaMejora(int nro)
        {
            
            datosMejora.bajaMejora(nro);

        }
        public Mejora buscaMejora(string numero)
        {
            //var num = Int32.Parse(numero);
            var buscado = datosMejora.buscaMejora(numero);
            return buscado;
        }
    }
}
