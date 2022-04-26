using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intento1
{
    class Deportivo
    {
        private string nombre;
        private string apellido;
        private int peso;
        private int talla;
        private string deporte;
        private string equipo;
        private string sexo;
        private string estado;
        
        
        public Deportivo(
            string nombre, 
            string apellido,
            int peso,
            int talla, 
            string deporte,
            string equipo,
            string sexo,
            string estado
        )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.peso = peso;
            this.talla = talla;
            this.deporte = deporte;
            this.equipo = equipo;
            this.sexo = sexo;
            this.estado = estado;
        }

        public Deportivo()
        {

        }

        public string getNombre()
        {
            return nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public int getPeso()
        {
            return peso;
        }
        public int getTalla()
        {
            return talla;
        }
        public string getDeporte()
        {
            return deporte;
        }
        public string getEquipo()
        {
            return equipo;
        }
        public string getSexo()
        {
            return sexo;
        }
        public string getEstado()
        {
            return estado;
        }
    }
}
