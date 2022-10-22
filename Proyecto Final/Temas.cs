using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto_Final
{
    class Temas
    


    {
        public static Color PanelPrin;
        public static Color PanelBtn;
        public static Color Barra;
        public static Color PanelSec;
        public static Color FuenteBtn;
        public static Color FuenteLogin;


        //Colores Defecto
        private static readonly Color PanelPrinD = Color.FromArgb(58, 71, 80);
        private static readonly Color PanelBtnD = Color.FromArgb(238, 238, 238);
        private static readonly Color BarraD = Color.FromArgb(246, 201, 14);
        private static readonly Color PanelSecD = Color.FromArgb(48, 56, 65);
        private static readonly Color FuenteBtnD = Color.FromArgb(48, 56, 65);
        private static readonly Color FuenteLoginD = Color.FromArgb(246, 201, 14);

        //Tema Coral
        private static readonly Color PanelPrinC = Color.FromArgb(8, 32, 50);
        private static readonly Color PanelBtnC = Color.FromArgb(255, 76, 41);
        private static readonly Color BarraC = Color.FromArgb(44, 57, 75);
        private static readonly Color PanelSecC = Color.FromArgb(51, 71, 86);
        private static readonly Color FuenteBtnC = Color.FromArgb(51, 71, 86);
        private static readonly Color FuenteLoginC = Color.FromArgb(44, 57, 75);

        //Tema Claro/White
        private static readonly Color PanelPrinW = Color.FromArgb(221, 221, 221);
        private static readonly Color PanelBtnW = Color.FromArgb(240, 84, 84);
        private static readonly Color BarraW = Color.FromArgb(34, 40, 49);
        private static readonly Color PanelSecW = Color.FromArgb(48, 71, 94);
        private static readonly Color FuenteBtnW = Color.FromArgb(48, 71, 94);
        private static readonly Color FuenteLoginW = Color.FromArgb(34, 40, 49);

      
        //SeleccionarColores
        #region -> Metodos
        public static void ElegirTema(string Tema)
        {
            if (Tema == "Defecto")
            {
                PanelPrin = PanelPrinD;
                PanelBtn = PanelBtnD;
                Barra = BarraD;
                PanelSec = PanelSecD;
                FuenteBtn = FuenteBtnD;
                FuenteLogin = FuenteLoginD;
            }
            if (Tema == "Coral")
            {
                PanelPrin = PanelPrinC;
                PanelBtn = PanelBtnC;
                Barra = BarraC;
                PanelSec = PanelSecC;
                FuenteBtn = FuenteBtnC;
                FuenteLogin = FuenteLoginC;
            }
            if (Tema == "Claro")
            {
                PanelPrin = PanelPrinW;
                PanelBtn = PanelBtnW;
                Barra = BarraW;
                PanelSec = PanelSecW;
                FuenteBtn = FuenteBtnW;
                FuenteLogin = FuenteLoginW;
            }
        }
        #endregion
    }
}