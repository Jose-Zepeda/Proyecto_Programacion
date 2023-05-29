using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Progra.Clases
{
    public class _4X4 : VehiculoBase
    {
        public string SistemaTraccion { get; set; }
        public string material_sillones { get; set; }

        public bool BloqueoDiferencial = false;

        public void ActivarBloqueoDiferencial()
        {
            if (encendido)
            {

                if (BloqueoDiferencial)
                {
                    Console.WriteLine("El bloqueo de diferencial ya está activado.");
                }
                else
                {
                    BloqueoDiferencial = true;
                    Console.WriteLine("El bloqueo de diferencial se ha activado.");
                }
            }
            else
            {
                Console.WriteLine("Debes encender el vehículo primero.");
            }
        }

    }
}


