using Intento1.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intento1
{
    public partial class Form2 : Form
    {
        #region Atributo
        private bool _enDescanso;
        #endregion

        #region Constructor
        public Form2()
        {
            _enDescanso = false;
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void btnIniciarPartido_Click(object sender, EventArgs e)
        {
            btnIniciarPartido.Enabled = false;
            btnGolA1.Enabled = btnGolB1.Enabled = btnDescanso.Enabled = true; 
        }

        private void btnDescanso_Click(object sender, EventArgs e)
        {
            if (!_enDescanso)
            {
                btnGolA1.Enabled = btnGolB1.Enabled = false;
                btnDescanso.Text = "REANUDAR";
                lblMensaje.Text = "REGRESAREMOS EN 15 MINUTOS";
                _enDescanso = true;
            }
            else 
            {
                btnGolA1.Enabled = btnGolB1.Enabled = true;
                btnDescanso.Enabled = false;
                btnFinalizar.Enabled = true;
                lblMensaje.Text = "";
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            btnGolA1.Enabled = btnGolB1.Enabled = btnFinalizar.Enabled = false;
            CompararPuntajes(txtEquipoA, txtEquipoB, txtGanador);
        }

        private void btnGolA1_Click(object sender, EventArgs e)
        {
            AumentarPunto(EquipoFutbol.EquipoA);
        }

        private void btnGolB1_Click(object sender, EventArgs e)
        {
            AumentarPunto(EquipoFutbol.EquipoB);
        }
        #endregion

        #region Ayuda
        private void AumentarPunto(EquipoFutbol equipoFutbol)
        {
            switch (equipoFutbol)
            {
                case EquipoFutbol.EquipoA:
                    AgregaPuntoTextBox(txtEquipoA);
                    break;
                case EquipoFutbol.EquipoB:
                    AgregaPuntoTextBox(txtEquipoB);
                    break;
                default:
                    break;
            }
        }

        private void AgregaPuntoTextBox(TextBox textbox)
        {
            textbox.Text = (int.Parse(textbox.Text) + 1).ToString();
        }

        private bool CompararPuntajes(TextBox txtEquipoA, TextBox txtEquipoB, TextBox txtGanador)
        {
            int puntajeEquipoA = int.Parse(txtEquipoA.Text);
            int puntajeEquipoB = int.Parse(txtEquipoB.Text);
            bool hayGanador = false;
            if (puntajeEquipoA > puntajeEquipoB)
            {
                txtGanador.Text = "EQUIPO A";
                hayGanador = true;
                
            }
            else if (puntajeEquipoB > puntajeEquipoA)
            {
                txtGanador.Text = "EQUIPO B";
                hayGanador = true;
                
            }
            else if (puntajeEquipoA == puntajeEquipoB )
            {
                txtGanador.Text = "EMPATE";
                hayGanador = true;
            }
            return hayGanador;
        }
        #endregion
    }
}
