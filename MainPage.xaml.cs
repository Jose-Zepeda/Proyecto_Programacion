using System.Reflection;
using System.Xml.Linq;

namespace Proyecto_Progra;


public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    internal interface IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; }
        public int VelocidadActual { get; }
        void bocina();
        void acelerar(int cuanto);
        void encender();
        void apagar();
        void frenar(int cuanto);
    }
    public class VehiculoBase : IVehiculo
    {
        //PROPIEDADES
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }

        public bool encendido;
        public int VelocidadMaxima { get; set; }

        public int VelocidadActual { get; set; }

        //DEFINICION DE LOS METODOS
        void VehiculoBaseEstado()
        {
            VelocidadMaxima = 100;
            VelocidadActual = 0;
            encendido = false;

        }

        //ACELERAR AUTO
        public void acelerar(int cuanto)
        {

            if (encendido)
            {
                if (VelocidadActual < VelocidadMaxima)
                {
                    VelocidadActual += cuanto;
                    Console.WriteLine($"El auto acelero y ahora va a {VelocidadActual} km/h");
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
            if ((encendido) && (VelocidadActual > 0))
            {
                Console.WriteLine("Has frenado.");
                VelocidadActual = 0;
            }
            if (!encendido)
            {
                Console.WriteLine("Tienes que encender el auto primero.");
            }
            if (VelocidadActual == 0)
            {
                Console.WriteLine("El auto no se esta moviendo.");
            }
        }
    }
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
    public class _4X4 : VehiculoBase
    {
        public string SistemaTraccion { get; set; }
        public string Material_sillones { get; set; }

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




    private void mostrarPickup(object sender, EventArgs e)
    {
        PickUp pickup = new();
        string propiedadesTexto = string.Empty;
        Type type = typeof(PickUp);
        PropertyInfo[] properties = type.GetProperties();
        pickup.Marca = "PickUp";
        pickup.Modelo = "Ford Ranger";
        pickup.Color = "Rojo";
        pickup.Anio = 2020;
        pickup.Placa = "P324HKJ";
        pickup.Tipo = "Todo terreno";
        pickup.VelocidadMaxima = 100;
        pickup.VelocidadActual = 0;
        pickup.TipoCabina = "Doble Cabina";
        pickup.CapacidadCarga = 50;
        pickup.Estilo = "Space Cab";

        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(pickup);
            propiedadesTexto += $"{property.Name}: {value}\n";
        }

        AutosLabel.Text = propiedadesTexto;
        SemanticScreenReader.Announce(AutosLabel.Text);
    }
    private void mostrarSedan(object sender, EventArgs e)
    {
        Sedan sedan = new();
        string propiedadesTexto = string.Empty;
        Type type = typeof(Sedan);
        PropertyInfo[] properties = type.GetProperties();

        sedan.Marca = "Sedan";
        sedan.Modelo = "Honda Accord";
        sedan.Color = "Azul";
        sedan.Anio = 2018;
        sedan.Placa = "P344UKJ";
        sedan.Tipo = "Crossover";
        sedan.VelocidadMaxima = 100;
        sedan.VelocidadActual = 0;
        sedan.numeropuertas = 4;
        sedan.tipoluces = "Neon";
        sedan.colorsillones = "Cafes";

        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(sedan);
            propiedadesTexto += $"{property.Name}: {value}\n";
        }

        AutosLabel.Text = propiedadesTexto;
        SemanticScreenReader.Announce(AutosLabel.Text);
    }
    private void mostrarSuv(object sender, EventArgs e)
    {
        SUV suv = new();
        string propiedadesTexto = string.Empty;
        Type type = typeof(SUV);
        PropertyInfo[] properties = type.GetProperties();

        suv.Marca = "Suv";
        suv.Modelo = "Hyundai Kona";
        suv.Color = "Amarillo";
        suv.Anio = 2019;
        suv.Placa = "P654UKJ";
        suv.Tipo = "Urbano";
        suv.VelocidadMaxima = 100;
        suv.VelocidadActual = 0;
        suv.CapacidadPasajeros = 4;
        suv.CantidadFilas = "3 filas de sillones";
        suv.Traccion = "AWD";


        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(suv);
            propiedadesTexto += $"{property.Name}: {value}\n";
        }

        AutosLabel.Text = propiedadesTexto;
        SemanticScreenReader.Announce(AutosLabel.Text);
    }
    private void mostrarCXC(object sender, EventArgs e)
    {
        _4X4 _4x4 = new();
        string propiedadesTexto = string.Empty;
        Type type = typeof(_4X4);
        PropertyInfo[] properties = type.GetProperties();

        _4x4.Marca = "4X4";
        _4x4.Modelo = "Mercedes Benz";
        _4x4.Color = "Verde";
        _4x4.Anio = 2017;
        _4x4.Placa = "P789UKJ";
        _4x4.Tipo = "Familiar";
        _4x4.VelocidadMaxima = 100;
        _4x4.VelocidadActual = 0;
        _4x4.SistemaTraccion = "Traccion trasera";
        _4x4.Material_sillones = "Cuero";

        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(_4x4);
            propiedadesTexto += $"{property.Name}: {value}\n";
        }

        AutosLabel.Text = propiedadesTexto;
        SemanticScreenReader.Announce(AutosLabel.Text);
    }

    string propiedadesTexto = string.Empty;
    int VelocidadActual = 0, VelocidadMaxima = 100;
    bool encendido = false;

    private void fEncender(object sender, EventArgs e)
    {


        if (!encendido)
        {

            propiedadesTexto = "El auto se ha encendido.";
            encendido = true;
        }
        else
        {
            propiedadesTexto = "El auto ya estaba encendido.";
        }

        EstadoAutoLabel.Text = propiedadesTexto;
        SemanticScreenReader.Announce(EstadoAutoLabel.Text);
    }

    private void fAcelerar(object sender, EventArgs e)
    {
        if (encendido)
        {
            if (VelocidadActual < VelocidadMaxima)
            {
                VelocidadActual += 10;
                propiedadesTexto = $"El auto acelero y ahora va a {VelocidadActual} km/h";
            }

            else
            {
                propiedadesTexto = "Alcanzaste la velocidad maxima de 100 km/h, ya no puedes seguir acelerando.";
            }

            EstadoAutoLabel.Text = propiedadesTexto;
            SemanticScreenReader.Announce(EstadoAutoLabel.Text);
        }
    }

    private void fApagar(object sender, EventArgs e)
    {
        if (encendido)
        {
            encendido = false;
            propiedadesTexto = "El auto se ha apagado.";
        }
        else
        {
            propiedadesTexto = "El auto ya estaba apagado.";
        }

        EstadoAutoLabel.Text = propiedadesTexto;
        SemanticScreenReader.Announce(EstadoAutoLabel.Text);

    }

    private void fFrenar(object sender, EventArgs e)
    {
        if ((encendido) && (VelocidadActual > 0))
        {
            propiedadesTexto = "Has frenado.";
            VelocidadActual = 0;
        }
        if (!encendido)
        {
            propiedadesTexto = "Tienes que encender el auto primero.";
        }
        if (VelocidadActual == 0)
        {
            propiedadesTexto = "El auto no se esta moviendo.";
        }

        EstadoAutoLabel.Text = propiedadesTexto;
        SemanticScreenReader.Announce(EstadoAutoLabel.Text);
    }



    }



    



