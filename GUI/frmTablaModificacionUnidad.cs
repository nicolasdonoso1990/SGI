using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;


namespace GUI
{
    public partial class frmTablaModificacionUnidad : Form
    {

        public IEnumerable<Propiedad> ListaPropiedades { get; set; }
        public IEnumerable<Unidad> ListaUnidades { get; set; }

        public List<Foto> fotos { get; set; }

        Propiedad prop;
        public frmTablaModificacionUnidad()
        {

            InitializeComponent();
            this.LLenarGrilla();

        }



        public void LLenarGrilla() 
        {

            dataGridView1.AutoGenerateColumns = false;

            PropiedadLogic propLog = new PropiedadLogic();



            ListaPropiedades = propLog.todasPropiedades();

            dataGridView1.DataSource = ListaPropiedades;

        
        }

        private void btnSeleccionarPropiedad_Click(object sender, EventArgs e)
        {
            Int32 cantidadFilasSeleccionadas = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                DataGridViewRow fila = dataGridView1.CurrentRow; //devuelve la fila que esta siendo seleccionada


                string cod = fila.Cells[0].Value.ToString();

                Int32 codigo = Convert.ToInt32(cod);


                PropiedadLogic proLog = new PropiedadLogic();
                prop = proLog.buscaPropiedad(codigo);

                groupUnidades.Enabled = true;

                UnidadLogic unLog=new UnidadLogic();

                ListaUnidades = unLog.BuscaUnidades(prop);

                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = ListaUnidades;



            } 
        }

        private void btnBajaUni_Click(object sender, EventArgs e)
        {
            Int32 cantidadFilasSeleccionadas = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                DataGridViewRow fila = dataGridView2.CurrentRow; //devuelve la fila que esta siendo seleccionada


                string cod = fila.Cells[0].Value.ToString();

                UnidadLogic unLog = new UnidadLogic();
                unLog.BajaUnidad(cod);


                List<Unidad> Unidadess = unLog.BuscaUnidades(prop);
                dataGridView2.DataSource = Unidadess;


            }
        }

        private void btnModificarUni_Click(object sender, EventArgs e)
        {
            Int32 cantidadFilasSeleccionadas = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadFilasSeleccionadas > 0)
            {

                groupDatosUni.Enabled = true;

                DataGridViewRow fila = dataGridView2.CurrentRow; //devuelve la fila que esta siendo seleccionada

                string codUni = fila.Cells[0].Value.ToString();

                UnidadLogic unLog = new UnidadLogic();

                Unidad uni = unLog.BuscaUnidad(codUni);

           

                txtCodigo.Text = uni.cod_unidad.ToString();
               
                txtDescripcion.Text = uni.descripcion;
                txtMetro.Text = uni.m2.ToString();


                FotoLogic foLog = new FotoLogic();
                fotos = foLog.BuscaFoto(uni.cod_unidad.ToString());

                if (fotos.Count() == 1) 
                {

             
                    foto1.Load(fotos[0].ruta_foto);
                    foto1.SizeMode = PictureBoxSizeMode.StretchImage;
                   

                }
                if (fotos.Count() == 2) 
                {
                    foto1.Load(fotos[0].ruta_foto);
                    foto2.Load(fotos[1].ruta_foto);
                    foto1.SizeMode = PictureBoxSizeMode.StretchImage;
                    foto2.SizeMode = PictureBoxSizeMode.StretchImage;
                
                }
                if (fotos.Count() == 3) 
                {
                    foto1.Load(fotos[0].ruta_foto);
                    foto2.Load(fotos[1].ruta_foto);
                    foto3.Load(fotos[2].ruta_foto);
                    foto1.SizeMode = PictureBoxSizeMode.StretchImage;
                    foto2.SizeMode = PictureBoxSizeMode.StretchImage;
                    foto3.SizeMode = PictureBoxSizeMode.StretchImage;
                
                }

                if (fotos.Count() == 4) 
                {
                    foto1.Load(fotos[0].ruta_foto);
                    foto2.Load(fotos[1].ruta_foto);
                    foto3.Load(fotos[2].ruta_foto);
                    foto4.Load(fotos[3].ruta_foto);

                    foto1.SizeMode = PictureBoxSizeMode.StretchImage;
                    foto2.SizeMode = PictureBoxSizeMode.StretchImage;
                    foto3.SizeMode = PictureBoxSizeMode.StretchImage;
                    foto4.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
 
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {

            string[] datos = new string[3];

            datos[0] = txtCodigo.Text;
            datos[1] = txtDescripcion.Text;
            datos[2] = txtMetro.Text;

            UnidadLogic unLog = new UnidadLogic();
            unLog.ModificaUnidad(datos);

            if (fotos.Count() == 1)
            {
                string dir = "C:\\Fotos_inmobiliaria\\" + fotos[0].cod_foto.ToString();

                foto1.Image.Save(dir, System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            if (fotos.Count() == 2)
            {
                string dir1 = "C:\\Fotos_inmobiliaria\\" + fotos[0].cod_foto.ToString();

                foto1.Image.Save(dir1, System.Drawing.Imaging.ImageFormat.Jpeg);

                string dir2 = "C:\\Fotos_inmobiliaria\\" + fotos[1].cod_foto.ToString();

                foto2.Image.Save(dir2, System.Drawing.Imaging.ImageFormat.Jpeg);





            }
            if (fotos.Count() == 3)
            {
                string dir1 = "C:\\Fotos_inmobiliaria\\" + fotos[0].cod_foto.ToString();

                foto1.Image.Save(dir1, System.Drawing.Imaging.ImageFormat.Jpeg);

                string dir2 = "C:\\Fotos_inmobiliaria\\" + fotos[1].cod_foto.ToString();

                foto2.Image.Save(dir2, System.Drawing.Imaging.ImageFormat.Jpeg);

                string dir3 = "C:\\Fotos_inmobiliaria\\" + fotos[2].cod_foto.ToString();

                foto3.Image.Save(dir3, System.Drawing.Imaging.ImageFormat.Jpeg);

            }

            if (fotos.Count() == 4)
            {
                string dir1 = "C:\\Fotos_inmobiliaria\\" + fotos[0].cod_foto.ToString();

                foto1.Image.Save(dir1, System.Drawing.Imaging.ImageFormat.Jpeg);

                string dir2 = "C:\\Fotos_inmobiliaria\\" + fotos[1].cod_foto.ToString();

                foto2.Image.Save(dir2, System.Drawing.Imaging.ImageFormat.Jpeg);

                string dir3 = "C:\\Fotos_inmobiliaria\\" + fotos[2].cod_foto.ToString();

                foto3.Image.Save(dir3, System.Drawing.Imaging.ImageFormat.Jpeg);

                string dir4 = "C:\\Fotos_inmobiliaria\\" + fotos[3].cod_foto.ToString();

                foto4.Image.Save(dir4, System.Drawing.Imaging.ImageFormat.Jpeg);


            }



        }

     

      
    }
}
