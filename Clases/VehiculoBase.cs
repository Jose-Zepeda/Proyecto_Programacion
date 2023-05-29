using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Progra.Clases;

namespace Proyecto_Progra
{
    public class VehiculoBase : IVehiculo
    {
        //PROPIEDADES
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int anio { get; set; }
        public string placa { get; set; }
        public string tipo { get; set; }

        public bool encendido;
        public int velocidadMaxima { get; set; }

        public int velocidadActual { get; set; }

        //DEFINICION DE LOS METODOS
        void VehiculoBaseEstado()
        {
            velocidadMaxima = 100;
            velocidadActual = 0;
            encendido = false;

        }

        //ACELERAR AUTO
        public void acelerar(int cuanto)
        {

            if (encendido)
            {
                if (velocidadActual < velocidadMaxima)
                {
                    velocidadActual += cuanto;
                    Console.WriteLine($"El auto acelero y ahora va a {velocidadActual} km/h");
                }

                else
                {
                    Console.WriteLine("Alcanzaste la velocidad maxima de 100 km/h, ya no puedes seguir acelerando.");
                }
            }       
        }

        //APAGAR AUTO
        public void apagar()
        {
            if (encendido)
            {
                encendido = false;
                Console.WriteLine("El auto se ha apagado.");
            }
            else
            {
                Console.WriteLine("El auto ya estaba apagado.");
            }
        }

        //ENCENDER BOCINA DE AUTO
        public void bocina()
        {
            if (encendido)
            {
                Console.Beep();
                Console.WriteLine("Beep!!");
            }

            else
            {
                Console.WriteLine("Debes encender el auto antes.");
            }
        }

        //ENCENDER AUTO
        public void encender()
        {
            if (!encendido)
            {
                Console.WriteLine("El auto se ha encendido.");
                encendido = true;
            }
            else
            {
                Console.WriteLine("El auto ya estaba encendido.");
            }
        }

        //FRENAR AUTO
        public void frenar(int cuanto)
        {
            if ((encendido) && (velocidadActual > 0))
            {
                Console.WriteLine("Has frenado.");
                velocidadActual = 0;
            }
            if(!encendido)
            {
                Console.WriteLine("Tienes que encender el auto primero.");
            }
            if(velocidadActual == 0)
            {
                Console.WriteLine("El auto no se esta moviendo.");
            }
        }
    }
}
