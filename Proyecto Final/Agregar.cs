using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
namespace Proyecto_Final
{
    public partial class Agregar : Form
    {

        DatosP objetoD = new DatosP();


        public Agregar()
        {
            InitializeComponent();
        }

       

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpFecha_Enter(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblCiudad_Click(object sender, EventArgs e)
        {

        }

        private void lblDepart_Click(object sender, EventArgs e)
        {

        }

        private void lblPais_Click(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

      

       

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void grpPersonal_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpTrabajo_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblAgregar_Click(object sender, EventArgs e)
        {

        }

       

        

        private void Agregar_Load(object sender, EventArgs e)
        {


            Temas.ElegirTema("Defecto");
            panel1.BackColor = Temas.PanelPrin;

            grpPersonal.BackColor = Temas.PanelSec;
            grpTrabajo.BackColor = Temas.PanelSec;
            grpSeguimiento.BackColor = Temas.PanelSec;
            grpFecha.BackColor = Temas.PanelSec;


            txtNombre.BackColor = Temas.Barra;
            txtApellido.BackColor = Temas.Barra;
            txtTelefono.BackColor = Temas.Barra;
            txtCorreo.BackColor = Temas.Barra;
            txtDepartamento.BackColor = Temas.Barra;
            txtCiudad.BackColor = Temas.Barra;
            txtDireccion.BackColor = Temas.Barra;
            txtPais.BackColor = Temas.Barra;
            txtSeguimiento.BackColor = Temas.Barra;
            txtFecha.BackColor = Temas.Barra;
            txtTipoTrab.BackColor = Temas.Barra;


        
            btnAgregar.BackColor = Temas.PanelBtn;
            btnCancelar.BackColor = Temas.PanelBtn;
         

            btnAgregar.ForeColor = Temas.FuenteBtn;
            btnCancelar.ForeColor = Temas.FuenteBtn;






        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                objetoD.InsertarDat(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtPais.Text, txtDepartamento.Text, txtCiudad.Text, txtDireccion.Text, txtTipoTrab.Text, txtSeguimiento.Text, txtFecha.Text, txtFechaCita.Text);
                MessageBox.Show("Se inserto correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar correctamente por: " + ex);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDepartamento.Clear();
            txtCiudad.Clear();
            txtDireccion.Clear();
            txtNombre.Focus();
        }
    }
}
