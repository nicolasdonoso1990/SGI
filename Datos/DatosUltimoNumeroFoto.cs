using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;




namespace Datos
{
    public class DatosUltimoNumeroFoto
    {




        public int BuscaUltimoNumero() 
        {

            using (var context = new InmobiliariaEntities())
            {
                Int32 numero;

                if (context.NumeroUltimaFoto.Count() == 0)
                {

                    NumeroUltimaFoto ult = new NumeroUltimaFoto();
                    ult.numero = 0;
                    ult.NumeroFoto = 0;
                    context.NumeroUltimaFoto.Add(ult);
                    context.SaveChanges();

                    numero = 0;


                }

                else 
                {

                    numero = context.NumeroUltimaFoto.Max(r=> r.numero) ;

                   // numero = context.NumeroUltimaFoto.Max(r => r.numero);
                  //  var maxReservationID = db.reservations.Max(r => r.ReservationID);
                }
                return numero;


            }
        
        
        
        
        }

        public void IncrementaUltimoNumero(int num) 
        {
            Int32 numero=num+1;

            using (var context = new InmobiliariaEntities())
            {
                NumeroUltimaFoto ulti=context.NumeroUltimaFoto.First(c => c.numero == num);
                ulti.numero = numero;
                context.SaveChanges();


            }
        
        
        
        }




    }
}
