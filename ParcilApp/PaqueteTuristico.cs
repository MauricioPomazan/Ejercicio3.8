using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcilApp
{
    
    
        internal class PaqueteTuristico
        {
            private int numero;
            private string descripcion;
            private float costoDiario;
            private int duracion;
            private int destino;

            public PaqueteTuristico()
            {
                numero = 0;
                descripcion = String.Empty;
                costoDiario = 0;
                duracion = 0;
                destino = 0;
            }

            public PaqueteTuristico(int numero, string descripcion, float costoDiario, int duracion, int destino)
            {
                this.numero = numero;
                this.descripcion = descripcion;
                this.costoDiario = costoDiario;
                this.duracion = duracion;
                this.destino = destino;
            }

            public int Numero
            {
                get { return numero; }
                set { numero = value; }
            }
         public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public float CostoDiario
        {
            get { return costoDiario; }
            set { costoDiario = value; }
        }

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public int Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public override string ToString()
        {
            return $"Paquete Nro: {numero} | Descripcion: {descripcion} | Costo Diario: {costoDiario}" +
                $" | Duracion: {duracion} | Destino: {destino}\n";
        }

        public virtual double CalcularCostoFinal()
        {
            return 0;
        }



    }
}
