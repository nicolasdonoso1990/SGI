using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

//recordar que el archivo app.Config va en ENTIDADES (tiene el conexion sTring) y en GUI

namespace Datos
{

    public class DatosInquilino  //recordar pasar la clase a public
    {

        public void AgregarInquilino(Inquilino inq) 
        {

            using (var context = new InmobiliariaEntities()) 
            {
                Cuenta_corriente1 cuenta = new Cuenta_corriente1();
                cuenta.nro_inquilino = inq.nro_inquilino;
                cuenta.saldo = 0;
                cuenta.fecha = DateTime.Today;


                context.Cuenta_corriente.Add(cuenta);


                context.Inquilinos.Add(inq);
                context.SaveChanges();
           
            
            }

      
        
        }


        public List<Inquilino> TodosInquilinos() 
        {
        
         using (var context = new InmobiliariaEntities())
            {
                var query = from c in context.Inquilinos where c.estado=="habilitado" select c;
                return query.ToList();
            }
        
        
        }


        public Inquilino BuscaInquilino(string dni) 
        {
            using (var context = new InmobiliariaEntities()) 
            {

                Inquilino inq = context.Inquilinos.First(i => i.dni == dni);
                return inq;
        
            }
      
        
        }

        public Inquilino BuscaInquilinoNumero(string nro) 
        {
            using (var context = new InmobiliariaEntities()) 
            { 
            
            Int32 numero = Convert.ToInt32(nro);

            Inquilino inq = context.Inquilinos.First(i => i.nro_inquilino == numero);

            return (inq);


            }
        
        
        
        }



        public void ModificaInquilino(string[] datos) 
        {


            using (var context = new InmobiliariaEntities()) 
            {

                Int32 nro = Convert.ToInt32(datos[0]);
               
                Inquilino inq = context.Inquilinos.First(i => i.nro_inquilino == nro);

                inq.apellido = datos[2];
                inq.contrasena=datos[3];
                inq.direccion=datos[4];
                inq.dni=datos[5];
                inq.e_mail=datos[6];
                inq.nombre=datos[1];
                inq.telefono=datos[7];
                inq.usuario=datos[8];

                context.SaveChanges();

            }


        
        }

        public void BajaInquilino(string dni) 
        {

            using (var context = new InmobiliariaEntities()) 
            {
               Inquilino inq=context.Inquilinos.First(i => i.dni == dni && i.estado == "habilitado");
               inq.estado = "deshabilitado";
               context.SaveChanges();
            
            }
        
        
        
        }



    }
    public class InquilinoDBContext : DbContext
    {
        public DbSet<Inquilino> Inquilinos { get; set; }
    }
  
}
