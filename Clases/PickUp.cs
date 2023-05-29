using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Progra.Clases
{
    public class PickUp : VehiculoBase
    {
        //PROPIEDADES PICKUP
        public string TipoCabina { get; set; }
        public int CapacidadCarga { get; set; }
        public string Estilo { get; set; }

        //METODO PICKUP
        public void subir_objetos(int cantidad = 20)
        {
            if (cantidad < CapacidadCarga)
            {
                Console.WriteLine($"Se han cargado {cantidad} objetos en la pick-up.");
            }
            else
            {
                Console.WriteLine($"No puedes cargar mas de {CapacidadCarga} objetos, no hay espacio.");
            }
        }
    }
}
