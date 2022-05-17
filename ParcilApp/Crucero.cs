using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcilApp
{
     class Crucero: PaqueteTuristico
    {
        private AtraccionTuristica atraccion;
        private int cantidadEstrellas;

        public Crucero():base()
        {
            this.atraccion = new AtraccionTuristica();
            this.cantidadEstrellas = 0;

        }
        public Crucero(AtraccionTuristica atraccion, int cantidadEstrellas, int numero, string descripcion, float costoDiario, int duracion,int destino)
                      :base(numero,descripcion,costoDiario,duracion,destino)

        {
            this.atraccion=atraccion;
            this.cantidadEstrellas = cantidadEstrellas;
        }

        public AtraccionTuristica Atraccion
        {
            get { return atraccion; }
            set { atraccion = value; }
        }

        public int CantidadEstrellas
        {
            get { return cantidadEstrellas; }
            set { cantidadEstrellas = value; }
        }

        //sobre escribiendo para especializar comportamientos
        public override string ToString()
        {
            // atraccion solo a la derecha de una cadena implica que llama automaticamente al ToString() de la clase Atraccion
            return base.ToString() + "|Con Atraccion: " + atraccion.ToString() + " | Cantidad de estrellas: " + cantidadEstrellas;
        }

        public override double CalcularCostoFinal()
        {
            //double costoFinal = 0;

            //utilizando las propertis heredadas calculamos el costo del crucero como:
            return  base.CostoDiario * Duracion + atraccion.pCosto;// le delegamos a la atraccion que nos diga cual es su costo

            //return costoFinal;
        }


    }
}
