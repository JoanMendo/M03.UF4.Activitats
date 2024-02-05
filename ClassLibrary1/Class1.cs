namespace M03.UF4
{
    //Exercici 1
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Persona(string nombre, string apellido, int edad, string direccion, string telefono, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }


    }

    //Exercici 2

    public class Lampara
    {
        public string Modelo { get; set; }

        public string Tipo { get; set; }

        public string Color { get; set; }

        public string Tamaño { get; set; }

        public string Potencia { get; set; }

        public bool Encendida { get; set; }

        public Lampara(string modelo, string tipo, string color, string tamaño, string potencia, bool encendida)
        {
            Modelo = modelo;
            Tipo = tipo;
            Color = color;
            Tamaño = tamaño;
            Potencia = potencia;
            Encendida = encendida;
        }
        
        public bool Encender()
        {

            Encendida = !(Encendida);
            return Encendida;
        }
        
    }
    
    public class Card
    {
        public string Color { get; set; }

        public string Numero { get; set; }

        public string Tipo { get; set; }

        public string Tamaño { get; set; }

        public string Material { get; set; }

        public Card(string color, string numero, string tipo, string tamaño, string material)
        {
            Color = color;
            Numero = numero;
            Tipo = tipo;
            Tamaño = tamaño;
            Material = material;
        }
    }

    public class Fligth 
    {
        public string Origen { get; set; }

        public string Tipo { get; set; }

        public string Destino { get; set; }

        public string Recorrido { get; set; }

        public string Fecha { get; set; }

        public Fligth(string origen, string tipo, string destino, string recorrido, string fecha)
        {
            Origen = origen;
            Tipo = tipo;
            Destino = destino;
            Recorrido = recorrido;
            Fecha = fecha;
        }
    }

    //Exercici 3

    public class Bike
    {
        public string Marca { get; set; }

        public string Tipo { get; set; }

        public string Color { get; set; }

        public string Tamaño { get; set; }

        public string Material { get; set; }

        public bool Ruedines { get; set; }

        public Bike(string marca, string tipo, string color, string tamaño, string material, bool ruedines)
        {
            Marca = marca;
            Tipo = tipo;
            Color = color;
            Tamaño = tamaño;
            Material = material;
            Ruedines = ruedines;
        }

        public bool QuitarRuedines()
        {
            Ruedines = false;
            return Ruedines;
        }
    }

    //Exercici 4
    public class Cat {       
        public string Nombre { get; set; }
    
           public string Raza { get; set; }

        public string ComidaFavorita { get; set; }


        public string Edad { get; set; }

        public Cat(string nombre, string raza, string comidaFavorita,  string edad)
        {
            Nombre = nombre;
            Raza = raza;
            ComidaFavorita = comidaFavorita;
            Edad = edad;
        }

        public string Maullar()
        {
            return "Miau";
        }

        public string Jugar()
        {
            return "Gato Jugando";
        }

        public string Wash()
        {
            return "Gato Lavandose";
        }

        public string Comer()
        {
            return "Gato Comiendo";
        }

        public string Hunt()
        {
            return "Gato Cazando";
        }
    }


    //Exercici 6

    public class Vehicle
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Color { get; set; }

        public string Tamaño { get; set; }

        public string Potencia { get; set; }

        public int VelocidadMàxima { get; set; }

        public string FuenteEnergia { get; set; }

        public Vehicle(string marca, string modelo, string color, string tamaño, string potencia, int velocidadMaxima, string fuenteEnergia)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Tamaño = tamaño;
            Potencia = potencia;
            VelocidadMàxima = velocidadMaxima;
            FuenteEnergia = fuenteEnergia;
        }

        public string Arrancar()
        {
            return "Arrancando";
        }

        public string Parar()
        {
            return "Parando";
        }

        public string Acelerar()
        {
            return "Acelerando";
        }

        public string Frenar()
        {
            return "Frenando";
        }

        public string Girar()
        {
            return "Girando";
        }
    }

    public class Ship : Vehicle 
    {
        public int Velas { get; set; }

        public string TipoMotor { get; set; }

        public Ship(string marca, string modelo, string color, string tamaño, string potencia, int velocidadMaxima, string fuenteEnergia, int velas, string tipoMotor) : base(marca, modelo, color, tamaño, potencia, velocidadMaxima, fuenteEnergia)
        {
            Velas = velas;
            TipoMotor = tipoMotor;
        }
    }

    public class WheeledVehicle : Vehicle
    {
        public int Ruedas { get; set; }

        public string TipoRuedas { get; set; }

        public int Puertas { get; set; }

        public WheeledVehicle(string marca, string modelo, string color, string tamaño, string potencia, int velocidadMaxima, string fuenteEnergia, int ruedas, string tipoRuedas, int puertas) : base(marca, modelo, color, tamaño, potencia, velocidadMaxima, fuenteEnergia)
        {
            Ruedas = ruedas;
            TipoRuedas = tipoRuedas;
            Puertas = puertas;
        }
    }
}
