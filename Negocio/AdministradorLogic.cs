using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class AdministradorLogic
    {

        public DatosAdministrador administradorData { get; set; }  // declaramos las propiedades get set

        public AdministradorLogic()     //instanciamos el administrador Data
        {
            this.administradorData = new DatosAdministrador();
        
        
        }



        public Administrador BuscaAdministrador(string usu, string pas, string tipo) 
        {

            Administrador adm = new Administrador();
            adm = administradorData.BuscaAdministrador(usu, pas, tipo);
            return (adm);
        }


        public Administrador BuscaAdministradorNumero(string numero) 
        {
            Administrador adm = new Administrador();
            adm = administradorData.BuscaAdministradorNumero(numero);
            return adm;
        
        
        
        }



        public void AltaAdministrador(Administrador admin) 
        {

            administradorData.AltaAdministrador(admin);
        
        
        }

        public List<Administrador> TodosAdministradores()
        {

            List<Administrador> Lista = new List<Administrador>();
            Lista = administradorData.TodosAdministradores();

            return (Lista);

        }


        public void ModificaAdministrador(string[] datos) 
        {
            administradorData.ModificaAdministrador(datos);
        
        
        
        }


        public void BajaAdministrador(string numero) 
        {
            administradorData.BajaAdministrador(numero);
        
        }



    }
}
