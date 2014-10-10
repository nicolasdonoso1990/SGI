using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

namespace Datos
{
    public class DatosPropiedad
    {

        public void altaPropiedad(Propiedad pro) 
        {
            using (var context = new InmobiliariaEntities())
            {

                context.Propiedades.Add(pro);
                context.SaveChanges();


            }        
        
        
        }

        public List<Propiedad> todasPropiedades() 
        {
            using (var context = new InmobiliariaEntities())
            {

                var query = from c in context.Propiedades where c.estado == "habilitado" select c;
                return query.ToList();
            
            }
        
        
        
        }


        public Propiedad buscaPropiedad(Int32 codigo) 
        {

            using (var context = new InmobiliariaEntities())
            {

                Propiedad prop = new Propiedad();
                prop = context.Propiedades.First(i => i.cod_propiedad == codigo);
                return prop;

            
            
            }
        
        
        }


        public void ModificaPropiedad(string[] datos) 
        {

            using (var context = new InmobiliariaEntities()) 
            {

                Int32 num = Convert.ToInt32(datos[0]);

                Propiedad pro = context.Propiedades.First(i => i.cod_propiedad == num);
                pro.ciudad = datos[1];
                pro.direccion = datos[2];
                pro.m2 = Convert.ToDouble(datos[3]);
                pro.descripcion = datos[4];

                context.SaveChanges();

            
            }
                
        
        }


        public void BajaPropiedad(int codigo) 
        {
            using (var context = new InmobiliariaEntities()) 
            {
                Propiedad pro = context.Propiedades.First(i => i.cod_propiedad == codigo);
                pro.estado = "deshabilitado";
                context.SaveChanges();
            
            
            }
        
        
        
        
        }




    }
}
