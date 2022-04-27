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
    public partial class Form1 : Form
    {
        Deportivo[] arr = new Deportivo[50];

        #region contadores
        //Contador hombres y mujeres = 0
        int cantHombres = 0;
        int cantMujeres = 0;
        //Contador voley futbol = 0
        int cantVoley = 0;
        int cantFutbol= 0;
        //Contador Titulares y Suplentes = 0
        int cantTitVoley = 0;
        int cantTitFutbol = 0;
        int cantSupVoley = 0;
        int cantSupFutbol = 0;
        //Contador EQUIPOS A y B = 0
        int cantEquipoAF = 0;
        int cantEquipoBF = 0;
        int cantEquipoAV = 0;
        int cantEquipoBV = 0;
        #endregion

        int indice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        #region Valores del Formulario
        string darNombre()
        {
            return txtnombre.Text;
        }
        string darApellido()
        {
            return txtapellido.Text;
        }
        int darPeso()
        {
            return int.Parse(txtpeso.Text);
        }
        int darTalla()
        {
            return int.Parse(txttalla.Text);
        }
        string darDeporte()
        {
            return cbxDeporte.Text;
        }
        string darEquipo()
        {
            return cbxEquipo.Text;
        }
        string darSexo()
        {
            return cbxSexo.Text;
        }
        string darEstado()
        {
            return cbxEstado.Text;
        }
        #endregion

        void AgregarAumnosArreglo()
        {
            string nombre = darNombre();
            string apellido = darApellido();
            int peso = darPeso();
            int talla = darTalla();
            string deporte = darDeporte();
            string equipo = darEquipo();
            string sexo = darSexo();
            string estado = darEstado();

            if (darSexo() == "HOMBRE" && cantHombres <= 20)
            {
                if (darDeporte() == "FUTBOL" && cantFutbol <= 11)
                {
                    if (darEquipo() == "EQUIPOA" && cantEquipoAF <= 11)
                    {
                        if (darEstado() == "TITULAR" && cantTitFutbol <= 11)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantHombres++;
                            cantFutbol++;
                            cantTitFutbol++;
                            cantEquipoAF++;
                        }
                        else if (darEstado() == "SUPLENTE")
                        {
                            MessageBox.Show("ERROR SOLO PUEDEN SER TITULARES");
                        }
                        else if (cantTitFutbol >= 12)
                        {
                            MessageBox.Show("EXCEDIO EL NUMERO DE JUGADORES " + cbxEstado.Text);
                        }
                    }
                    if (darEquipo() == "EQUIPOB" && cantEquipoBF <= 11)
                    {
                        if (darEstado() == "TITULAR" && cantTitFutbol <= 11)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantHombres++;
                            cantFutbol++;
                            cantTitFutbol++;
                            cantEquipoBF++;
                        }
                        else if (darEstado() == "SUPLENTE")
                        {
                            MessageBox.Show("ERROR SOLO PUEDEN SER TITULARES");
                        }
                        else if (cantTitFutbol >= 12)
                        {
                            MessageBox.Show("EXCEDIO EL NUMERO DE JUGADORES " + cbxEstado.Text);
                        }
                    }


                }
                else if (darDeporte() == "VOLEY" && cantVoley <= 16)
                {
                    if (darEquipo() == "EQUIPOA" && cantEquipoAV <= 16)
                    {
                        if (darEstado() == "TITULAR" && cantTitVoley <= 6)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantHombres++;
                            cantVoley++;
                            cantTitVoley++;
                            cantEquipoAV++;
                        }
                        else if (darEstado() == "SUPLENTE" && cantSupVoley <= 10)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantHombres++;
                            cantVoley++;
                            cantSupVoley++;
                            cantEquipoAV++;
                        }
                        else if (cantTitVoley >= 7 || cantSupVoley >= 11)
                        {
                            MessageBox.Show("EXCEDIO EL NUMERO DE JUGADORES " + cbxEstado.Text);
                        }
                    }
                    else if (darEquipo() == "EQUIPOB" && cantEquipoBV <= 16)
                    {

                        if (darEstado() == "TITULAR" && cantTitVoley <= 6)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantHombres++;
                            cantVoley++;
                            cantTitVoley++;
                            cantTitVoley++;
                            cantEquipoBV++;
                        }
                        else if (darEstado() == "SUPLENTE" && cantSupVoley <= 10)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantHombres++;
                            cantVoley++;
                            cantSupVoley++;
                            cantSupVoley++;
                            cantEquipoBV++;
                        }
                        else if (cantTitVoley >= 7 || cantSupVoley >= 11)
                        {
                            MessageBox.Show("EXCEDIO EL NUMERO DE JUGADORES " + cbxEstado.Text);
                        }
                    }
                    
                    
                }
                else if (cantFutbol >= 12 || cantVoley <= 17)
                {
                    MessageBox.Show("EXCEDIO EL NUMERO DE JUGADORES DE" + cbxDeporte.Text);
                }
            }
            else if (darSexo() == "MUJER" && cantMujeres <= 15)
            {
                if (darDeporte() == "FUTBOL" && cantFutbol <= 11)
                {
                    if (darEquipo() == "EQUIPOA" && cantEquipoBF <= 11)
                    {
                        if (darEstado() == "TITULAR" && cantTitFutbol <= 11)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantMujeres++;
                            cantFutbol++;
                            cantTitFutbol++;
                            cantEquipoAF++;
                        }
                        else if (darEstado() == "SUPLENTE" && cantSupFutbol <= 8)
                        {
                            MessageBox.Show("ERROR SOLO PUEDEN SER TITULARES");
                        }
                        else if (cantTitFutbol >= 12)
                        {
                            MessageBox.Show("EXCEDIO EL NUMERO DE JUGADORES " + cbxEstado.Text);
                        }
                    }
                    else if (darEquipo() == "EQUIPOB" && cantEquipoBF <= 11)
                    {
                        if (darEstado() == "TITULAR" && cantTitFutbol <= 11)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantMujeres++;
                            cantFutbol++;
                            cantTitFutbol++;
                            cantEquipoBF++;
                        }
                        else if (darEstado() == "SUPLENTE" && cantSupFutbol <= 8)
                        {
                            MessageBox.Show("ERROR SOLO PUEDEN SER TITULARES");
                        }
                        else if (cantTitFutbol >= 12)
                        {
                            MessageBox.Show("EXCEDIO EL NUMERO DE JUGADORES " + cbxEstado.Text);
                        }
                    }
                    
                }
                else if (darDeporte() == "VOLEY" && cantVoley <= 16)
                {
                    if (darEquipo() == "EQUIPOA" && cantEquipoAV <= 16)
                    {
                        if (darEstado() == "TITULAR" && cantTitVoley <= 6)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantMujeres++;
                            cantVoley++;
                            cantTitVoley++;
                            cantEquipoAV++;
                        }
                        else if (darEstado() == "SUPLENTE" && cantSupVoley <= 10)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantMujeres++;
                            cantVoley++;
                            cantSupVoley++;
                            cantEquipoAV++;
                        }
                        else if (cantTitVoley >= 7 || cantSupVoley >= 11)
                        {
                            MessageBox.Show("EXCEDIO EL NUMERO DE JUGADORES " + cbxEstado.Text);
                        }
                    }
                    else if (darEquipo() == "EQUIPOB" && cantEquipoBV <= 16)
                    {

                        if (darEstado() == "TITULAR" && cantTitVoley <= 6)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantMujeres++;
                            cantVoley++;
                            cantTitVoley++;
                            cantEquipoBV++;
                        }
                        else if (darEstado() == "SUPLENTE" && cantSupVoley <= 10)
                        {
                            Deportivo de = new Deportivo(nombre, apellido, peso, talla, deporte, equipo, sexo, estado);

                            arr[indice] = de;
                            indice++;
                            LimpiarFormulario();
                            cantMujeres++;
                            cantVoley++;
                            cantSupVoley++;
                            cantSupVoley++;
                            cantEquipoBV++;
                        }
                        else if (cantTitVoley >= 7 || cantSupVoley >= 11)
                        {
                            MessageBox.Show("EXCEDIO EL NUMERO DE JUGADORES " + cbxEstado.Text);
                        }
                    }


                }
                else if (cantFutbol >= 12 || cantVoley <= 17)
                {
                    MessageBox.Show("EXCEDIO EL NUMERO DE JUGADORES DE" + cbxDeporte.Text);
                }
            }
            else if (cantHombres >= 21 || cantMujeres >= 15)
            {
                MessageBox.Show("EXCEDIO EL NUMERO DE" + cbxSexo.Text);
            }
        }

        void AgregarEncabezadoColumnas()
        {
            dataGridView1.Columns.Add("nombre", "NOMBRE");
            dataGridView1.Columns.Add("apellido", "APELLIDO");
            dataGridView1.Columns.Add("peso", "PESO");
            dataGridView1.Columns.Add("talla", "TALLA");
            dataGridView1.Columns.Add("deporte", "DEPORTE");
            dataGridView1.Columns.Add("equipo", "EQUIPO");
            dataGridView1.Columns.Add("sexo", "SEXO");
            dataGridView1.Columns.Add("estado", "ESTADO");
        }

        void AnchoColumnas()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
        }

        void Listar()
        {
            dataGridView1.Columns.Clear();

            AgregarEncabezadoColumnas();

            for (int i = 0; i < indice; i++)
            {
                dataGridView1.Rows.Add(
                    arr[i].getNombre(),
                    arr[i].getApellido(),
                    arr[i].getPeso(),
                    arr[i].getTalla(),
                    arr[i].getDeporte(),
                    arr[i].getEquipo(),
                    arr[i].getSexo(),
                    arr[i].getEstado()
                    );
            }

            AnchoColumnas();
        }

        void LimpiarFormulario()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtpeso.Text = "";
            txttalla.Text = "";
            cbxDeporte.SelectedIndex = -1;
            cbxEquipo.SelectedIndex = -1;
            cbxSexo.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;
            txtnombre.Focus();
        }


        #region Botones

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarAumnosArreglo();
        }
        private void btnFutbol_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
            this.Hide();
        }
        private void btnVoley_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show();
            this.Hide();
        }
        #endregion
        
    }
}

        