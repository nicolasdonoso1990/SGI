using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosMejora
    {
         public void altaMejora(Mejora mejora)
        {
            using (var context = new InmobiliariaEntities())
            {
                context.Mejoras.Add(mejora);
                context.SaveChanges();
            }
        }
        public Mejora buscaMejora(string numeroMejora)
        {
            using (var context = new InmobiliariaEntities())
            {

                Int32 nro = Convert.ToInt32(numeroMejora);

                Mejora mejora = context.Mejoras.First(i => i.nro_mejora == nro);
                return mejora;

            }

        }

        public List<Mejora> getAll()
        {
            using (var context = new InmobiliariaEntities())
            {

                List<Mejora> lista = context.Mejoras.ToList();
                return lista;

            }



        }
        
        /*public void modificarContratista(string[] datos)
        {


            using (var context = new InmobiliariaEntities())
            {

                int cod_contratista = int.Parse(datos[0]);
                //Busco el contratista que quiero modificar con el codigo que me traje
                Contratista contratista = context.Contratistas.First(i => i.cod_contratista == cod_contratista);
                //lo modifico
               // contratista.cod_contratista = cod_contratista;
                contratista.nombre = datos[1];
                contratista.apellido = datos[2];
                contratista.direccion = datos[3];
                contratista.telefono = datos[4];
                contratista.disponibilidad = datos[5];
                //lo guardo
                context.SaveChanges();

            }



        }*/

        public void bajaMejora(int nroMejora)
        {
            using(var context = new InmobiliariaEntities())
            {
                Mejora mejora = context.Mejoras.FirstOrDefault(i => i.nro_mejora == nroMejora);
                context.Mejoras.Remove(mejora);
                context.SaveChanges();
            }
        }
    }
 }

