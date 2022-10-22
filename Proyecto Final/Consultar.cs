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
    public partial class Consultar : Form
    {

        DatosP objetosD = new DatosP();


        public Consultar()
        {
            InitializeComponent();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar mainEditar = new Editar();
            mainEditar.Show();
            this.Hide();
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblEditar_Click(object sender, EventArgs e)
        {

        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            MostrarDatos();



            Temas.ElegirTema("Defecto");
            panel1.BackColor = Temas.PanelPrin;

            dataGridView1.BackgroundColor = Temas.PanelSec;

            Proyecto_Final.principalPanel Prin = new Proyecto_Final.principalPanel();

            Proyecto_Final.Temas.ElegirTema("defecto");
            panel1.BackColor = Proyecto_Final.Temas.PanelPrin;
            dataGridView1 = Proyecto_Final.Temas.ElegirTema(Prin.txtTemas.Text)
           

        }

        private void MostrarDatos()
        {
            dataGridView1.DataSource = objetosD.MostrarDat();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
