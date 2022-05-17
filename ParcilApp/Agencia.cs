using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcilApp
{
     class Agencia
    {
        private PaqueteTuristico[] paquetes;
        private int totalPaquetes;

        // Creamos un vector de "cantidad" de referencias a objetos pero no creo objetos Crucero 
        public Agencia (int cantidad)

        {
           
            paquetes = new PaqueteTuristico[cantidad];
            totalPaquetes = cantidad;

        }

        public bool RegistrarPaquete(PaqueteTuristico oCrucero)
        {
            //foreach (Crucero x in paquetes)
            //{
            //    if(x == null)
            //    {
                   
            //    }
            //}


            for (int i = 0; i < totalPaquetes; i++)

                if (paquetes[i] == null)
                {
                    paquetes[i] = oCrucero;
                    return true;
                }
            return false;
        }


        public string MostrarCrucerosA(int destino)
        {
          
            string lista = string.Empty;
            foreach(Crucero c in paquetes)
                if(c != null && c.Destino == destino)
                {
                    lista += c.ToString() + "\n";

                }

            return lista;

        }

        public double CostoTotalDePaquetes()
        {
            //quiero devolver el costo total de los paquetes ofrecidos por la agencia
            double total = 0; ;

            foreach(PaqueteTuristico x in paquetes)
            {
                if(x != null)
                total += x.CalcularCostoFinal(); // x es polimorfica respecto del CalcularCostoFinal()
            }
            return total;
        }
    }
}

