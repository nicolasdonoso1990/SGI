using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;


namespace Datos
{
    public class DatosUnidad
    {

        public void altaUnidad(Unidad uni) 
        {
     

            using (var context = new InmobiliariaEntities())
            {

                context.Unidades.Add(uni);
                context.SaveChanges();


            }

            
        
        }

        public List<Unidad> BuscaUnidades(Propiedad pro) 
        {

            using (var context = new InmobiliariaEntities()) 
            {

                var query=from c in context.Unidades where c.cod_propiedad==pro.cod_propiedad && c.estado=="habilitado" || c.estado=="alquilado" select c;
                return query.ToList();


            
            }
        
        
        
        
        }


        public List<Unidad> BuscaUnidadesNoAlquiladas(Propiedad pro)
        {

            using (var context = new InmobiliariaEntities())
            {

                var query = from c in context.Unidades where c.cod_propiedad == pro.cod_propiedad && c.estado == "habilitado"  select c;
                return query.ToList();



            }




        }


        public void BajaUnidad(string codigo) 
        {
            using (var context = new InmobiliariaEntities())
            {

                Int32 num = Convert.ToInt32(codigo);
                Unidad uni = context.Unidades.First(i => i.cod_unidad == num);
                uni.estado = "deshabilitado";
                context.SaveChanges();

            }

        
        }

        public Unidad BuscaUnidad(string codUni) 
        {

            using (var context = new InmobiliariaEntities()) 
            {
                Int32 cod = Convert.ToInt32(codUni);
                Unidad uni = context.Unidades.First(i => i.cod_unidad == cod);
                return uni;

            
            }


        
        }


        public void ModificaUnidad(string [] datos) 
        {

            using (var context = new InmobiliariaEntities()) 
            {
                Int32 num = Convert.ToInt32(datos[0]);

                Unidad uni = context.Unidades.First(i => i.cod_unidad == num);
                uni.descripcion=datos[1];
                uni.m2 = Convert.ToDouble(datos[2]);
                context.SaveChanges();
            
            }
        
        
        
        
        }




        public void CambiaEstadoUnidad(Unidad uni)
        {
            using (var context = new InmobiliariaEntities()) 
            {
                Unidad u = context.Unidades.First(i => i.cod_unidad == uni.cod_unidad);
                u.estado = "alquilado";
                context.SaveChanges();
            
            }



        }



        }
 




    }
