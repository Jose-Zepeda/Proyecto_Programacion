using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Progra.Clases
{
    internal interface IVehiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int anio { get; set; }
        public string placa { get; set; }
        public string tipo { get; set; }
        public int velocidadMaxima { get; }
        public int velocidadActual { get; }
        void bocina();
        void acelerar(int cuanto);
        void encender();
        void apagar();
        void frenar(int cuanto);
    }
}
