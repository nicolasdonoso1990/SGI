using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
    public class UnidadLogic
    {


            public DatosUnidad UnidadData { get; set; }

        public UnidadLogic() 
        {

            this.UnidadData = new DatosUnidad();
        
        }


        public void AltaUnidad(Unidad uni) 
        {

            UnidadData.altaUnidad(uni);
        
        }

        public List<Unidad> BuscaUnidades(Propiedad pro) 
        {
            List<Unidad> unidades = UnidadData.BuscaUnidades(pro);
            return unidades;
        
        }

        public void BajaUnidad(string codigo) 
        {
            UnidadData.BajaUnidad(codigo);

        
        }

        public Unidad BuscaUnidad(string codUni) 
        {
            Unidad uni = UnidadData.BuscaUnidad(codUni);
            return uni;
        
        }

        public void ModificaUnidad(string[] datos) 
        {

            UnidadData.ModificaUnidad(datos);
        
        
        }

        public void CambiaEstadoAlquilado(Unidad uni) 
        {
            UnidadData.CambiaEstadoUnidad(uni);
        }

        public List<Unidad> BuscaUnidadesNoAlquiladas(Propiedad pro)
        {

            List<Unidad> unidades = UnidadData.BuscaUnidadesNoAlquiladas(pro);
            return unidades;
        
        
        }




    }
}
