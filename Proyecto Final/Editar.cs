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
    public partial class Editar : Form
        
    {
        
        DatosP objetosD = new DatosP();

        private string idDatosP = null;

        private bool Edit = false;

        


        public Editar()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            principalPanel mainMenu = new principalPanel();
            mainMenu.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar mainAgregar = new Agregar();
            mainAgregar.Show();
            this.Hide();
        }

       

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar mainConsultar = new Consultar();
            mainConsultar.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Editar_Load(object sender, EventArgs e)
        {

            
            MostrarDatos();

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



            btnGuardar.BackColor = Temas.PanelBtn;
            btnCancelar.BackColor = Temas.PanelBtn;
            btnEditar.BackColor = Temas.PanelBtn;


            btnGuardar.ForeColor = Temas.FuenteBtn;
            btnCancelar.ForeColor = Temas.FuenteBtn;
            btnEditar.ForeColor = Temas.FuenteBtn;

            



        }

        private void MostrarDatos()
        {
            
            dataGridView1.DataSource = objetosD.MostrarDat();
           

        }
        

        public void btnGuardar_Click(object sender, EventArgs e)
        {

          
           
                
            

        }

        

        

        private void limpiarForm()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDepartamento.Clear();
            txtCiudad.Clear();
            txtDireccion.Clear();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblCiudad_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (Edit == true)
            {
                try
                {
                    objetosD.EditarDat(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtCorreo.Text, txtPais.Text, txtDepartamento.Text, txtCiudad.Text, txtDireccion.Text, txtTipoTrab.Text, txtSeguimiento.Text, txtFecha.Text, txtFechaCita.Text, idDatosP);
                    MessageBox.Show("Datos Actualizados");

                    limpiarForm();


                    Edit = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Selecciones los datos a editar por favor.");
                }

            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Edit = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                txtPais.Text = dataGridView1.CurrentRow.Cells["Pais"].Value.ToString();
                txtDepartamento.Text = dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString();
                txtCiudad.Text = dataGridView1.CurrentRow.Cells["Ciudad"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTipoTrab.Text = dataGridView1.CurrentRow.Cells["Tipo de Trabajo"].Value.ToString();
                txtSeguimiento.Text = dataGridView1.CurrentRow.Cells["Seguimiento"].Value.ToString();
                txtFecha.Text = dataGridView1.CurrentRow.Cells["Fecha de ingreso"].Value.ToString();
                txtFechaCita.Text = dataGridView1.CurrentRow.Cells["Fecha de cita"].Value.ToString();
                idDatosP = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("Selecciones una fila por favor");
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpiarForm();
        }
    }
}
