namespace ClassLibrary1
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

}
