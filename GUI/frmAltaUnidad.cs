﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using System.IO; //para crear el directorio

namespace GUI
{


    public partial class frmAltaUnidad : Form
    {

        public IEnumerable<Propiedad> ListaPropiedades { get; set; }

        public frmAltaUnidad()
        {
            InitializeComponent();
            this.RellenarGrilla();
            this.CrearDirectorio();
            this.btnRegistrar.Enabled = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        public void RellenarGrilla()
        {
            dataGridView1.AutoGenerateColumns = false;

           

            PropiedadLogic propLog = new PropiedadLogic();

            dataGridView1.Columns[4].Width = 225;

            ListaPropiedades = propLog.todasPropiedades();

            dataGridView1.DataSource = ListaPropiedades;


        }

        private void button3_Click(object sender, EventArgs e)
        {
             Int32 cantidadFilasSeleccionadas = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

             if (cantidadFilasSeleccionadas > 0)
             {

                 DataGridViewRow fila = dataGridView1.CurrentRow; //devuelve la fila que esta siendo seleccionada

               
                 string codigo=fila.Cells[0].Value.ToString();

                 groupBox2.Enabled = true;
                 txtCodigo.Text = codigo;

             }
             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAltaPropiedad altaProp = new frmAltaPropiedad();
            altaProp.ShowDialog();

            PropiedadLogic proLog = new PropiedadLogic();

            ListaPropiedades = proLog.todasPropiedades();
            dataGridView1.DataSource = ListaPropiedades;
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            bool todolleno = true;
            lblErrorCampos.Visible = false;

            if (txtDescripcion.Text == "")
            {
                txtDescripcion.BackColor = Color.Red;
                todolleno=false;

            }
           

            if (txtMetro.Text == "")
            {
                txtMetro.BackColor = Color.Red;
                todolleno = false;
            }

            

            if (todolleno==true) 
            {
                groupBox3.Enabled = true;

                lblErrorCampos.Visible = false;

                btnRegistrar.Enabled = true;

                if (chkFotos.Checked == false)
                {
                    groupBox3.Enabled = false;
                }

            }
            else
            {
                lblErrorCampos.Visible = true;
            }
    

        }

     

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Unidad uni = new Unidad();
            
            Int32 num = Convert.ToInt32(txtCodigo.Text);

            double metros = Convert.ToDouble(txtMetro.Text);

            uni.cod_propiedad = num;
            uni.m2 = metros;
            uni.estado = "habilitado";
            uni.descripcion = txtDescripcion.Text;

            UnidadLogic unLog = new UnidadLogic();
            unLog.AltaUnidad(uni);



            Foto fotoUno = new Foto();
            Foto fotoDos = new Foto();
            Foto fotoTres = new Foto();
            Foto fotoCuatro = new Foto();
            
            
            Foto []fotos =new Foto[4];


            UltimoNumeroLogic ulNum = new UltimoNumeroLogic();

            


            if (foto1.Image != null) 
            {
              
                fotoUno.cod_unidad = uni.cod_unidad;
                

                int nu = ulNum.BuscaUltimoNumero();

                string numer = ulNum.BuscaUltimoNumero().ToString();

                ulNum.IncrementaUltimoNumero(nu);
              
                string dir = "C:\\Fotos_inmobiliaria\\"+numer;

                foto1.Image.Save(dir, System.Drawing.Imaging.ImageFormat.Jpeg);

                fotoUno.ruta_foto = dir;

                

            }


            if (foto2.Image != null)
            {
               
                fotoDos.cod_unidad = uni.cod_unidad;


                int nu = ulNum.BuscaUltimoNumero();

                string numer = ulNum.BuscaUltimoNumero().ToString();

                ulNum.IncrementaUltimoNumero(nu);

                string dir = "C:\\Fotos_inmobiliaria\\"+numer;

                foto2.Image.Save(dir, System.Drawing.Imaging.ImageFormat.Jpeg);

                fotoDos.ruta_foto = dir;


               
               
            }

            if (foto3.Image != null)
            {
               
                fotoTres.cod_unidad = uni.cod_unidad;

                int nu = ulNum.BuscaUltimoNumero();

                string numer = ulNum.BuscaUltimoNumero().ToString();

                ulNum.IncrementaUltimoNumero(nu);

                string dir = "C:\\Fotos_inmobiliaria\\" + numer;

                foto3.Image.Save(dir, System.Drawing.Imaging.ImageFormat.Jpeg);

                fotoTres.ruta_foto = dir;


            }




            if (foto4.Image != null)
            {
                
                fotoCuatro.cod_unidad = uni.cod_unidad;

                int nu = ulNum.BuscaUltimoNumero();

                string numer = ulNum.BuscaUltimoNumero().ToString();

                ulNum.IncrementaUltimoNumero(nu);

                string dir = "C:\\Fotos_inmobiliaria\\" + numer;

                foto4.Image.Save(dir, System.Drawing.Imaging.ImageFormat.Jpeg);

                fotoCuatro.ruta_foto = dir;



            }


            FotoLogic foLog = new FotoLogic();

            fotos[0] = fotoUno;
            fotos[1] = fotoDos;
            fotos[2] = fotoTres;
            fotos[3] = fotoCuatro;




            foLog.AltaFotos(fotos);

            MessageBox.Show("La unidad fue dada de alta con exito", "Alta Unidad");

            if (MessageBox.Show("¿Desea agregar otra unidad?. Confirme", "Otra unidad", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtCodigo.Clear();
                txtDescripcion.Clear();
                txtMetro.Clear();
                foto1.InitialImage = null;
                foto2.InitialImage = null;
                foto3.InitialImage=null;
                foto4.InitialImage=null;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                btnRegistrar.Enabled = false;

            }
            else
            {
                this.Dispose();
            }

        }




        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

            int a; //Variable a, a la cual se le asigna la comparación

            int cero = 0;
            string filtro = txtDireccion.Text;

            if (cero != (a = String.Compare(txtDireccion.Text, ""))) //Si la comparación da 0 no hay diferncias, por lo tanto el textbox está en blanco
            {
                dataGridView1.AutoGenerateColumns = false;

                PropiedadLogic propLog = new PropiedadLogic();

                ListaPropiedades = propLog.todasPropiedades();



                List<Propiedad> listaFiltrada = (from prop in ListaPropiedades
                                                 where prop.direccion.ToString().Contains(filtro)
                                                 select prop).ToList();

                dataGridView1.DataSource = listaFiltrada;



            }
            else
            {
                this.RellenarGrilla();
            }



        }


        public void CrearDirectorio() 
        {



            if (!Directory.Exists("C:\\Fotos_inmobiliaria"))
            {
                Directory.CreateDirectory("C:\\Fotos_inmobiliaria");
            }
            else
            { 
            
            }
        
        
        }

        private void txtMetro_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMetro.BackColor = Color.White;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }

        private void frmAltaUnidad_Load(object sender, EventArgs e)
        {

        }
        private void btnFoto1_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                foto1.SizeMode = PictureBoxSizeMode.StretchImage;

                foto1.Image = Image.FromFile(dialog.FileName);


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFoto2_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                foto2.SizeMode = PictureBoxSizeMode.StretchImage;
                foto2.Image = Image.FromFile(dialog.FileName);

            }

        }

        private void btnFoto3_Click(object sender, EventArgs e)
        {

            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                foto3.SizeMode = PictureBoxSizeMode.StretchImage;
                foto3.Image = Image.FromFile(dialog.FileName);

            }




        }

        private void btnFoto4_Click(object sender, EventArgs e)
        {

            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                foto4.SizeMode = PictureBoxSizeMode.StretchImage;
                foto4.Image = Image.FromFile(dialog.FileName);

            }

        }

        private void txtMetro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtMetro.BackColor = Color.White;
        }

    }
}


