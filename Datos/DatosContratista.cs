using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

namespace Datos
{
    public class DatosContratista
    {

        public void altaContratista(Contratista contratista)
        {
            using (var context = new InmobiliariaEntities())
            {
                context.Contratistas.Add(contratista);
                context.SaveChanges();
            }
        }
        public Contratista buscaContratista(string apellido)
        {
            using (var context = new InmobiliariaEntities())
            {

                Contratista contratista = context.Contratistas.FirstOrDefault(i => i.apellido == apellido);
                return contratista;

            }

        }

        public List<Contratista> getAll()
        {
            using (var context = new InmobiliariaEntities())
            {

                List<Contratista> lista = context.Contratistas.ToList();
                return lista;

            }



        }

        public void modificarContratista(string[] datos)
        {


            using (var context = new InmobiliariaEntities())
            {

                int cod_contratista = int.Parse(datos[0]);
                /*Busco el contratista que quiero modificar con el codigo que me traje*/
                Contratista contratista = context.Contratistas.First(i => i.cod_contratista == cod_contratista);
                /*lo modifico*/
                contratista.cod_contratista = cod_contratista;
                contratista.nombre = datos[1];
                contratista.apellido = datos[2];
                contratista.direccion = datos[3];
                contratista.telefono = datos[4];
                contratista.disponibilidad = datos[5];
                /*lo guardo*/
                context.SaveChanges();

            }



        }

        public void bajaContratista(int codigo)
        {
            using(var context = new InmobiliariaEntities())
            {
                Contratista contratista = context.Contratistas.FirstOrDefault(i => i.cod_contratista == codigo);
                context.Contratistas.Remove(contratista);
                context.SaveChanges();
            }
        }
    }
}
