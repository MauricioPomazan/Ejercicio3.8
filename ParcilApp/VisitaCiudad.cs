using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcilApp
{
     class VisitaCiudad : PaqueteTuristico
    {
        private string nomCiudad;
        private double costoFinal;

        public VisitaCiudad(string nomCiudad) : base()
        {
            this.nomCiudad = nomCiudad;
            this.costoFinal = 0;
        }
        public double CostoFinal
        {
            get { return costoFinal; }
            set { costoFinal = value; }
        }

        // Toda visita a ciudad deberia resolver el mensaje CalcularCostoFinal

        public override double  CalcularCostoFinal() { return costoFinal; }

    }


}
