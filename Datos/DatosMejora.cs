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
        
        public void modificarMejora(Mejora mejoraArgumento)
        {


            using (var context = new InmobiliariaEntities())
            {

                
                //Busco el contratista que quiero modificar con el codigo que me traje
                Mejora mejora = context.Mejoras.First(i => i.nro_mejora == mejoraArgumento.nro_mejora);
                context.Mejoras.Remove(mejora);
                context.Mejoras.Add(mejoraArgumento);
                context.SaveChanges();

            }



        }

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

