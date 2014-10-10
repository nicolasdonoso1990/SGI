using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;


namespace Datos
{
    public class DatosAdministrador
    {
       


        public Administrador BuscaAdministrador(string usu, string pas, string tipo)

        {
            using (var context = new InmobiliariaEntities()) 
            {



                Administrador adm = new Administrador();

                if (tipo == "SuperUsuario") 
                {
                    adm = context.Administradores.First(i => i.estado == "habilitado" && i.usuario == usu && i.contrasena == pas && i.tipo=="super");
                
                }

                if (tipo == "Administrador")
                {
                    adm = context.Administradores.First(i => i.estado == "habilitado" && i.usuario == usu && i.contrasena == pas && i.tipo == "normal");
                }

                return adm;
            
            }
        
        
        
        }

        public Administrador BuscaAdministradorNumero(string numero) 
        {

            Int32 num= Convert.ToInt32(numero);

            using (var context = new InmobiliariaEntities()) 
            {

                Administrador admin = new Administrador();
                admin = context.Administradores.First(i => i.IDadmin == num);
                return admin;
            }
        
        }




        public void AltaAdministrador(Administrador admin) 
        {


            using (var context = new InmobiliariaEntities())
            {

                context.Administradores.Add(admin);
                context.SaveChanges();


            }

            
        
        }


        public List<Administrador> TodosAdministradores()
        {

            using (var context = new InmobiliariaEntities())
            {
                var query = from c in context.Administradores where c.estado == "habilitado" select c;
                return query.ToList();
            }


        }

        public void ModificaAdministrador(string[] datos) 
        {

            using (var context = new InmobiliariaEntities()) 
            {

                Int32 numero = Convert.ToInt32(datos[0]);
                Administrador admin = context.Administradores.First(i => i.IDadmin == numero);
                admin.tipo = datos[1];
                admin.contrasena = datos[2];
                admin.usuario = datos[3];
                context.SaveChanges();

            
            
            }
        
      
        }


        public void BajaAdministrador(string numero)
        {

            using (var context = new InmobiliariaEntities())
           {
               Int32 num = Convert.ToInt32(numero);

               Administrador admin = context.Administradores.First(i => i.IDadmin == num && i.estado== "habilitado");
               admin.estado = "deshabilitado";
                context.SaveChanges();

            }



        }






    }
}
