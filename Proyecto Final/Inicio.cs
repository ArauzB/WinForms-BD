using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Final
{
    public partial class Inicio : Form
    {


        

        public Inicio()
        {
            InitializeComponent();
        }

        

        private void Inicio_Load(object sender, EventArgs e)
        {

            Proyecto_Final.Temas.ElegirTema("defecto");
            panel1.BackColor = Proyecto_Final.Temas.PanelPrin;
        }

        






    }
}
