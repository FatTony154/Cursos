
//variable para recibir desde Concatenar
string nombreYapellido;

//Instancia
var nombres = new Nombres();

nombreYapellido = nombres.Concatenar("Antonio", "Narvaez", "Guzman");

//Mostrando las cadenas ya concatenadas
Console.WriteLine(nombreYapellido);

//Instanciando a la clase Automovil
// Automovil auto1 = new Automovil();
//
//
// // bool acelerar = false;
// //
// // acelerar = auto1.Acelerar();
// //
// // if(acelerar)
// //     Console.WriteLine("Acelerando, rum rum...");
//
// //Mostrando el campo privado
// // Console.WriteLine($"El color es {auto1.Color}");
//
// //Asignando valor a un campo privado
// auto1.Combustible = "Diesel";
// // Console.WriteLine($"El combustible es: {auto1.Combustible}");
//
// Console.WriteLine(auto1.ToString());
//
// public class Automovil
// {
//     //Campos
//     private string color = "rojo";
//     private string modelo = "ZB30";
//     private string combustible;
//     private string year = "1998";
//     private string numPuertas = "4";
//
//     private int ccMotor = 1500;
//     
//     //Ejemplo para campos inicializados con el constructor
//     private string asientos, colorTablero;
//     private bool camaraTrasera;
//     
//     //Constructor - la razon principal del constructor es
//     //inicializar los campos de la clase en el momento que es
//     //instanciada la clase
//     public Automovil()
//     {
//         asientos = "Piel";
//         colorTablero = "Cafe";
//         camaraTrasera = false;
//     }
//     
//     //Propiedades
//     
//     //descriptor de acceso get
//     public string Color => color;
//
//     public string Combustible
//     {
//         get => combustible;
//
//         //descriptor de acceso set
//         set => combustible = value;
//     }
//     
//     //miembro => expresion;
//     
//
//     //Metodos
//     public bool Acelerar()
//     {
//         bool acelerar = true;
//         Console.WriteLine("Acelerar");
//         return acelerar;
//     }
//     
//     public bool Frenar()
//     {
//         bool frenar = true;
//         Console.WriteLine("Frenar");
//         return frenar;
//     }
//     
//     public bool Seguros()
//     {
//         bool seguros = true;
//         Console.WriteLine("Seguros");
//         return seguros;
//     }
//     
//     public bool Luces()
//     {
//         bool luces = true;
//         Console.WriteLine("Luces");
//         return luces;
//     }
//     
//     //Metodo estatico
//     public void Velocidades(ref byte velocidad)
//     {
//         velocidad++;
//         Console.WriteLine("Cambio de velocidad");
//     }
//     
//     //Invalidando el metodo ToString
//     public override string ToString()
//     {
//         string mensaje;
//         mensaje = $"Modelo: {modelo}" +
//                   $"\nColor: {color}" +
//                   $"\nYear: {year}" +
//                   $"\nPuertas: {numPuertas}" +
//                   $"\nCombustible: {combustible}" +
//                   $"\nMotor: {ccMotor}" +
//                   $"\nAsientos: {asientos}" +
//                   $"\nColor del tablero: {colorTablero}" +
//                   $"\nCamaraTrasera: {camaraTrasera}";
//
//         return mensaje;
//     }
// }
//


class Nombres
{
    public string Concatenar(string nombre, string apellido)
    {
        string nombreApellido;

        nombreApellido = nombre + " " + apellido;

        return nombreApellido;
    }

    public string Concatenar(string nombre, string apellido, string apellido2)
    {
        string nombreApellido;

        nombreApellido = nombre + " " + apellido + " " + apellido2;

        return nombreApellido;
    }
}