using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Progra
{
    public class Sedan : VehiculoBase
    {
        public int numeropuertas { get; set; }
        public string tipoluces { get; set; }
        public string colorsillones { get; set; }

        void encenderluces()
        {
            if (encendido)
            {
                Console.WriteLine("Se han encendido las luces.");
            }

            else
            {
                Console.WriteLine("Tienes que encender el carro primero");
            }
        }

        void apagarluces()
        {
            if (encendido)
            {
                Console.WriteLine("Se han apagado las luces.");
            }

            else
            {
                Console.WriteLine("Tienes que encender el carro primero");
            }
        }
    }


}
