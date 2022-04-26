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
    public partial class Form3 : Form
    {
        public Form3()
        {
            _stageA = _stageB = 0;
            InitializeComponent();
        }

        #region Atributo
        private int _stageA;
        private int _stageB;
        #endregion

        #region Aumentar Genericos
        private void AumentarPunto(Set set, Equipo equipo)
        {
            switch (set)
            {
                case Set.Set1:
                    switch (equipo)
                    {
                        case Equipo.EquipoA:
                            AgregaPuntoTextBox(txtSet1A);
                            break;
                        case Equipo.EquipoB:
                            AgregaPuntoTextBox(txtSet1B);
                            break;
                    }
                    if (ComparaPuntajes(set, txtSet1A, txtSet1B, txtGanaSet1))
                    {
                        CerrarStage(set);
                    }
                    break;
                case Set.Set2:
                    switch (equipo)
                    {
                        case Equipo.EquipoA:
                            AgregaPuntoTextBox(txtSet2A);
                            break;
                        case Equipo.EquipoB:
                            AgregaPuntoTextBox(txtSet2B);
                            break;
                    }
                    if (ComparaPuntajes(set, txtSet2A, txtSet2B, txtGanaSet2))
                    {
                        CerrarStage(set);
                    }
                    break;
                case Set.Set3:
                    switch (equipo)
                    {
                        case Equipo.EquipoA:
                            AgregaPuntoTextBox(txtSet3A);
                            break;
                        case Equipo.EquipoB:
                            AgregaPuntoTextBox(txtSet3B);
                            break;
                        default:
                            break;
                    }
                    if (ComparaPuntajes(set, txtSet3A, txtSet3B, txtGanaSet3))
                    {
                        CerrarStage(set);
                    }
                    break;
                case Set.Set4:
                    switch (equipo)
                    {
                        case Equipo.EquipoA:
                            AgregaPuntoTextBox(txtSet4A);
                            break;
                        case Equipo.EquipoB:
                            AgregaPuntoTextBox(txtSet4B);
                            break;
                        default:
                            break;
                    }
                    if (ComparaPuntajes(set, txtSet4A, txtSet4B, txtGanaSet4))
                    {
                        CerrarStage(set);
                    }
                    break;
                case Set.Set5:
                    switch (equipo)
                    {
                        case Equipo.EquipoA:
                            AgregaPuntoTextBox(txtSet5A);
                            break;
                        case Equipo.EquipoB:
                            AgregaPuntoTextBox(txtSet5B);
                            break;
                        default:
                            break;
                    }
                    if (ComparaPuntajes(set, txtSet5A, txtSet5B, txtGanaSet5))
                    {
                        CerrarStage(set);
                    }
                    break;
            }
        }

        private void AgregaPuntoTextBox(TextBox textbox)
        {
            textbox.Text = (int.Parse(textbox.Text) + 1).ToString();
        }
        #endregion

        #region Comparaciones
        private int GetPuntajeMinimoSet(Set set)
        {
            switch (set)
            {
                case Set.Set1:
                case Set.Set2:
                case Set.Set3:
                case Set.Set4:
                    return 15;
                case Set.Set5:
                    return 8;
            }
            return -1; // Si se ingresa otro valor
        }

        private bool ComparaPuntajes(Set set, TextBox txtEquipoA, TextBox txtEquipoB, TextBox txtGanador)
        {
            int puntajeEquipoA = int.Parse(txtEquipoA.Text);
            int puntajeEquipoB = int.Parse(txtEquipoB.Text);
            int puntajeMinimoSet = GetPuntajeMinimoSet(set);
            bool hayGanador = false;    

            if (puntajeEquipoA == puntajeMinimoSet && puntajeEquipoB < puntajeMinimoSet - 1)
            {
                txtGanador.Text = "EQUIPO A";
                _stageA++;
                hayGanador = true;
            }
            else if (puntajeEquipoB == puntajeMinimoSet && puntajeEquipoA < puntajeMinimoSet -1)
            {
                txtGanador.Text = "EQUIPO B";
                _stageB++;
                hayGanador = true;
            }
            else if (puntajeEquipoA >= puntajeMinimoSet -1 && puntajeEquipoB >= puntajeMinimoSet - 1)
            {
                if (puntajeEquipoA - puntajeEquipoB == 2)
                {
                    txtGanador.Text = "EQUIPO A";
                    _stageA++;
                    hayGanador = true;
                }
                else if (puntajeEquipoB - puntajeEquipoA == 2)
                {
                    txtGanador.Text = "EQUIPO B";
                    _stageB++;
                    hayGanador = true;
                }
            }
            return hayGanador;
        }

        private void CerrarStage(Set set)
        {
            switch (set)
            {
                case Set.Set1:
                    btnSet1A.Enabled = btnSet1B.Enabled = false;
                    btnSet2A.Enabled = btnSet2B.Enabled = true;
                    break;
                case Set.Set2:
                    btnSet2A.Enabled = btnSet2B.Enabled = false;
                    btnSet3A.Enabled = btnSet3B.Enabled = true;
                    break;
                case Set.Set3:
                    btnSet3A.Enabled = btnSet3B.Enabled = false;
                    btnSet4A.Enabled = btnSet4B.Enabled = true;
                    break;
                case Set.Set4:
                    btnSet4A.Enabled = btnSet4B.Enabled = false;
                    btnSet5A.Enabled = btnSet5B.Enabled = true;
                    break;
                case Set.Set5:
                    btnSet5A.Enabled = btnSet5B.Enabled = false;
                    break;
                default:
                    break;
            }

            if (_stageA == 3 || _stageB == 3)
            {
                string mensajeGanadorPartido = "";
                if (_stageA == 3)
                {
                    mensajeGanadorPartido = "El GANADOR ES EL EQUIPO A";
                }
                else if (_stageB == 3)
                {
                    mensajeGanadorPartido = "EL GANADOR ES EL EQUIPO B";
                }
                MessageBox.Show(mensajeGanadorPartido);
            }
        }
        #endregion

        #region Botones
        private void btnSet1A_Click(object sender, EventArgs e)
        {
            AumentarPunto(Set.Set1,Equipo.EquipoA);
        }

        private void btnSet1B_Click(object sender, EventArgs e)
        {
            AumentarPunto(Set.Set1, Equipo.EquipoB);
        }

        private void btnSet2A_Click(object sender, EventArgs e)
        {
            AumentarPunto(Set.Set2, Equipo.EquipoA);
        }

        private void btnSet2B_Click(object sender, EventArgs e)
        {
            AumentarPunto(Set.Set2, Equipo.EquipoB);
        }

        private void btnSet3A_Click(object sender, EventArgs e)
        {
            AumentarPunto(Set.Set3, Equipo.EquipoA);
        }

        private void btnSet3B_Click(object sender, EventArgs e)
        {
            AumentarPunto(Set.Set3, Equipo.EquipoB);
        }

        private void btnSet4A_Click(object sender, EventArgs e)
        {
            AumentarPunto(Set.Set4, Equipo.EquipoA);
        }

        private void btnSet4B_Click(object sender, EventArgs e)
        {
            AumentarPunto(Set.Set4, Equipo.EquipoB);
        }

        private void btnSet5A_Click(object sender, EventArgs e)
        {
            AumentarPunto(Set.Set5, Equipo.EquipoA);
        }

        private void btnSet5B_Click(object sender, EventArgs e)
        {
            AumentarPunto(Set.Set5, Equipo.EquipoB);
        }
        #endregion
    }
}
