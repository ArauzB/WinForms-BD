using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaDeSoporte.Cache;

namespace Proyecto_Final
{
    public partial class principalPanel : Form
    {
        public principalPanel()
        {
            InitializeComponent();
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Agregar());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Editar());
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Consultar());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login mainLogin = new Login();
            mainLogin.Show();
            this.Hide();
        }


        private void AbrirFormHija(object formHija)
        {
            if (this.panelPrin.Controls.Count > 0)
                this.panelPrin.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            this.panelPrin.Controls.Add(fh);
            this.panelPrin.Tag = fh;
            fh.Show();



        }

        private void principalPanel_Load(object sender, EventArgs e)
        {
            Usuario();
            Temas.ElegirTema("Defecto");
            panelPrin.BackColor = Temas.PanelPrin;
            panel2.BackColor = Temas.PanelSec;
            panel1.BackColor = Temas.Barra;
            lblCorreo.BackColor = Temas.PanelSec;
            lblNombre.BackColor = Temas.PanelSec;
            lblRango.BackColor = Temas.PanelSec;
            btnMin.BackColor = Temas.Barra;
            btnClose.BackColor = Temas.Barra;
            btnInicio.BackColor = Temas.PanelBtn;
            btnAgregar.BackColor = Temas.PanelBtn;
            btnConsultar.BackColor = Temas.PanelBtn;
            btnEditar.BackColor = Temas.PanelBtn;


            txtTemas.BackColor = Temas.Barra;
            txtTemas.ForeColor = Temas.FuenteBtn;

            lblCorreo.ForeColor = Temas.FuenteLogin;
            lblNombre.ForeColor = Temas.FuenteLogin;
            lblRango.ForeColor = Temas.FuenteLogin;



            btnInicio.ForeColor = Temas.FuenteBtn;
            btnAgregar.ForeColor = Temas.FuenteBtn;
            btnConsultar.ForeColor = Temas.FuenteBtn;
            btnEditar.ForeColor = Temas.FuenteBtn;

            
        }

       

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Inicio());
        }

        private void btnAgregar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void panelPrin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Usuario()
        {
            lblNombre.Text = CacheLogin.FirstName+ ", " +CacheLogin.LastName;
            lblRango.Text = CacheLogin.Position;
            lblCorreo.Text = CacheLogin.Email;


        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            
        }

        public void txtTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temas.ElegirTema(txtTemas.Text);
            panelPrin.BackColor = Temas.PanelPrin;
            panel2.BackColor = Temas.PanelSec;
            panel1.BackColor = Temas.Barra;
            lblCorreo.BackColor = Temas.PanelSec;
            lblNombre.BackColor = Temas.PanelSec;
            lblRango.BackColor = Temas.PanelSec;
            btnMin.BackColor = Temas.Barra;
            btnClose.BackColor = Temas.Barra;
            btnInicio.BackColor = Temas.PanelBtn;
            btnAgregar.BackColor = Temas.PanelBtn;
            btnConsultar.BackColor = Temas.PanelBtn;
            btnEditar.BackColor = Temas.PanelBtn;


            txtTemas.BackColor = Temas.Barra;
            txtTemas.ForeColor = Temas.FuenteBtn;

            lblCorreo.ForeColor = Temas.FuenteLogin;
            lblNombre.ForeColor = Temas.FuenteLogin;
            lblRango.ForeColor = Temas.FuenteLogin;

            dataGridView1.BackColor = Temas.PanelSec;


            btnInicio.ForeColor = Temas.FuenteBtn;
            btnAgregar.ForeColor = Temas.FuenteBtn;
            btnConsultar.ForeColor = Temas.FuenteBtn;
            btnEditar.ForeColor = Temas.FuenteBtn;
        }

        public void Temass()
        {






        }
    }
}
