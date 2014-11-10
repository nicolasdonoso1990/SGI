using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Collections;



namespace Negocio
{
    public class AlquilerLogic
    {
   
        public DatosAlquiler AlquilerData { get; set; }

        public AlquilerLogic()
        {
            this.AlquilerData = new DatosAlquiler();
        }

        public IEnumerable  UnidadesAlquiladasActualesDeUnInquilino(Int32 numero)
        {
          List<Alquiler> AlcAct = this.AlquilerData.buscarAlquileresActuales(); //Busco todos los alquileres actuales
            
            UnidadLogic ul = new UnidadLogic(); // Instancio capa de negocio perteneciente a Unidades
           
            List<Unidad> UnHab = ul.buscarUnidadesHabilitadas();//Busco todas las unidades habilitadas

            PropiedadLogic pl = new PropiedadLogic();

            List<Propiedad> TodasLasprop = pl.todasPropiedades(); //Busco todas las propiedades para extraer de ellas el campo domicilio




        /*Ahora realizo un Inner join entre las dos listas uniéndolas
         * por cod_unidad. 
         * De esta manera tengo todas las unidades de los alquilers actuales.
         * En la consulta pongo en el where el número del inquilino para terminar el filtrado.
         * De esta manera tenemos: Todas las unidades actuales alquiladas por nuestroinquilino seleccionado.
         */

          IEnumerable query = from alq in AlcAct
                              join uni in UnHab on alq.cod_unidad equals uni.cod_unidad
                              join pro in TodasLasprop on uni.cod_propiedad equals pro.cod_propiedad  
                        where alq.nro_inquilino == numero
                        select new { coduni = uni.cod_unidad, des = uni.descripcion, dom = pro.direccion, mcuadrados=uni.m2.ToString(),numalq=alq.nro_alquiler,numinq=alq.nro_inquilino };



          return query;

       
            }

        public Int32 BuscarNumeroAlquiler(int nroInquilino,int codUnidad )
        {
            List<Alquiler> AlcAct = this.AlquilerData.buscarAlquileresActuales(); //Busco todos los alquileres actuales

          /*  Int32 nroAlq = from alq in AlcAct
                           where alq.cod_unidad == codUnidad || alq.nro_inquilino == nroInquilino
                           select new { nroAlq = alq.nro_alquiler };

*/
            Alquiler alq =  AlcAct.First(i => i.nro_inquilino == nroInquilino && i.cod_unidad == codUnidad);

            Int32 nroAlquiler = alq.nro_alquiler;

            return nroAlquiler;
        }
       
    }
}
