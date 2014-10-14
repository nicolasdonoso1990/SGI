using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ContratistaLogic
    {
        public DatosContratista datosContratista { get; set; }

        public ContratistaLogic()
        {
            this.datosContratista = new DatosContratista();
        }

        public void altaContratista (Contratista contratista)
        {
            datosContratista.altaContratista(contratista);
        }

        public Contratista buscaContratista(string apellido)
        {

            Contratista contratista = datosContratista.buscaContratista(apellido);
            return (contratista);


        }

        public List<Contratista> getAll()
        {
            List<Contratista> listaContratistas = new List<Contratista>();
            listaContratistas = datosContratista.getAll();
            return (listaContratistas);



        }

        public void modificarContratista(string[] datos)
        {


            datosContratista.modificarContratista(datos);


        }

        public void bajaContratista(int codigo)
        {
            datosContratista.bajaContratista(codigo);
        }
    }
}
