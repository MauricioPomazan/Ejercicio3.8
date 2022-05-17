using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcilApp
{
     class AtraccionTuristica
    {
        private string nombre;
        private double costo;

        public AtraccionTuristica()
        {
            nombre = string.Empty;
            costo = 0;
        }

        public AtraccionTuristica(string nombre, double costo)
        {
            this.nombre = nombre;
            this.costo = costo;
        }

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double pCosto
        {
            get { return costo; }
            set { costo = value; }
        }
        public override string ToString()
        {
            return "Nombre atracción turística: " + nombre + " | Costo: " + costo;
        }




    }
}
