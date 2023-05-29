using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Progra
{
    public class SUV : VehiculoBase


    {
        public int CapacidadPasajeros { get; set; }
        public string CantidadFilas { get; set; }
        public string Traccion { get; set; }


        public void ActivarModoOffRoad()
        {
            if (encendido)
            {
                Console.WriteLine("Modo off-road activado. Prepárate para la aventura.");
            }
            else
            {
                Console.WriteLine("Debes encender el auto primero.");
            }
        }
    }
}
