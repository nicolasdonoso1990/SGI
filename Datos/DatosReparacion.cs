using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosReparacion
    {
        public void altaReparacion(Reparacion reparacion)
        {
            using (var context = new InmobiliariaEntities())
            {
                context.Reparaciones.Add(reparacion);
                context.SaveChanges();
            }
        }
        public Reparacion buscaReparacion(string numeroReparacion)
        {
            using (var context = new InmobiliariaEntities())
            {

                Int32 nro = Convert.ToInt32(numeroReparacion);

                Reparacion reparacion = context.Reparaciones.First(i => i.nro_reparacion == nro);
                return reparacion;

            }

        }

        public List<Reparacion> getAll()
        {
            using (var context = new InmobiliariaEntities())
            {

                List<Reparacion> lista = context.Reparaciones.ToList();
                return lista;

            }



        }

        public void modificarReparacion(Reparacion reparacionArgumento)
        {


            using (var context = new InmobiliariaEntities())
            {


                //Busco el contratista que quiero modificar con el codigo que me traje
                Reparacion reparacion = context.Reparaciones.First(i => i.nro_reparacion == reparacionArgumento.nro_reparacion);
                context.Reparaciones.Remove(reparacion);
                context.Reparaciones.Add(reparacionArgumento);
                context.SaveChanges();

            }



        }

        public void bajaReparacion(int nroReparacion)
        {
            using (var context = new InmobiliariaEntities())
            {
                Reparacion reparacion = context.Reparaciones.FirstOrDefault(i => i.nro_reparacion == nroReparacion);
                context.Reparaciones.Remove(reparacion);
                context.SaveChanges();
            }
        }
    }
}

