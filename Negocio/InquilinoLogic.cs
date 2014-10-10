using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.Entity;
using Entidades;

namespace Negocio
{
    public class InquilinoLogic
    {

        public DatosInquilino InquilinoData { get; set; }  // declaramos las propiedades get set


        public InquilinoLogic() 
        {

            this.InquilinoData = new DatosInquilino();
        
        }

        public void AltaInquilino(Inquilino inq)
        {

            InquilinoData.AgregarInquilino(inq);
        
        
        }



        public List<Inquilino> TodosInquilinos() 
        {
        
        List<Inquilino> Lista=new List<Inquilino>();
        Lista = InquilinoData.TodosInquilinos();
        
        return (Lista);

        }


        public Inquilino BuscaInquilino(string dni) 
        {

            Inquilino inq = InquilinoData.BuscaInquilino(dni);
            return (inq);
        
        
        }

        public Inquilino BuscaInquilinoNumero(string nro) 
        {

            Inquilino inq = InquilinoData.BuscaInquilinoNumero(nro);
            return (inq);
        
        }


        public void ModificaInquilino(string[] datos) 
        {


            InquilinoData.ModificaInquilino(datos);
        
        
        }

        public void BajaInquilino(string dni) 
        {
            InquilinoData.BajaInquilino(dni);
        
        
        
        }



    }
}
