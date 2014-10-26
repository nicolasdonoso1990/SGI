using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ReparacionLogic
    {
        public DatosReparacion datosReparacion { get; set; }

        public ReparacionLogic()
        {
            this.datosReparacion = new DatosReparacion();
        }

        public void altaReparacion(Reparacion reparacion)
        {

            datosReparacion.altaReparacion(reparacion);


        }

        public List<Reparacion> getAll()
        {

            List<Reparacion> Lista = new List<Reparacion>();
            Lista = datosReparacion.getAll();

            return (Lista);

        }



        public void modificarReparacion(Reparacion reparacion)
        {
            datosReparacion.modificarReparacion(reparacion);

        }


        public void bajaReparacion(int nro)
        {

            datosReparacion.bajaReparacion(nro);

        }
        public Reparacion buscaReparacion(string numero)
        {
            //var num = Int32.Parse(numero);
            var buscado = datosReparacion.buscaReparacion(numero);
            return buscado;
        }
    }
}
