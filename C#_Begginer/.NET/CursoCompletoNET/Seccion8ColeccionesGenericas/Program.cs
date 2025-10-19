// object numeroEntero = 16;
// object cadena = "Hola";
// object flotante = 3.1416;
//
// object[] numeros = new object[2];
// numeros[0] = 1;
// numeros[1] = "Luis";
//
// object objeto;
// objeto = "Antonio";
// objeto = 34.56;
//
// object numero1 = 5;
// object numero2 = 20;
// object resultado;
//
// resultado = numero1 + 10;


//=====================================================CASTING=====================================================
// int numGrande = 500;
// byte numPeque = (byte)numGrande;

//(T)E
// string num1 = "45";
// int num2 = (int)num1;

//(T)E
//Boxing [tipo de valor -> object] implicita/explicita
// object numero1 = 5;
// object numero2 = 20;
// object resultado;
//
// // resultado = numero1 + 10;
// //La conversion Boxing copia el valor de "a" dentro del objeto "obj"
// int a = 50;
// object obj = a;
//
// //Unboxing [object -> tipo de valor] explicita
// resultado = (int)numero1 + 10;
//
// Console.WriteLine(resultado);

//=====================================================GENERICS=====================================================
// EjemploGenerico<string> generico1 = new EjemploGenerico<string>();
// EjemploGenerico<int> generico2 = new EjemploGenerico<int>();
//
//
// class EjemploGenerico<T>
// {
//     
// }

//Variables locales
// Alumno valorElemento;
//
// //Instanciando la clase
// GuardaObjetos<Alumno> objetos1 = new GuardaObjetos<Alumno>(3);
//
// //Instanciamos a la clase "Alumno"
// Alumno alumno1 = new Alumno(8.5);
// Alumno alumno2 = new Alumno(10);
// Alumno alumno3 = new Alumno(6.8);
//
// //Agregar objetos a la clase "GuardarObjetos"
// objetos1.AgregarElementos(alumno1);
// objetos1.AgregarElementos(alumno2);
// objetos1.AgregarElementos(alumno3);
//
// //Agregar objetos
// // objetos1.AgregarElementos("Luis");
// // objetos1.AgregarElementos("Jose");
// // objetos1.AgregarElementos("Antonio");
//
// //Obtener elementos
// valorElemento = (Alumno)objetos1.ObtenerElemento(1);
// Console.WriteLine(valorElemento.Calificacion);
//
// class GuardaObjetos<T>
// {
//     //Campos
//     private int i = 0;
//     private T[] matrizElementos;
//     
//     //Constructor
//     public GuardaObjetos(int elementos)
//     {
//         matrizElementos = new T[elementos];
//     }
//     
//     //Metodos
//     public void AgregarElementos(T elemento)
//     {
//         matrizElementos[i] = elemento;
//         i++;
//     }
//
//     public T ObtenerElemento(int elemento)
//     {
//         return matrizElementos[elemento];
//     }
// }
//
// class Alumno
// {
//     //Campos
//     private double calificacion;
//     
//     //Constructor
//     public Alumno(double calificacion)
//     {
//         this.calificacion = calificacion;
//     }
//     
//     //Propiedades
//     public double Calificacion
//     {
//         get => calificacion;
//     }
// }

//=====================================================LISTAS=====================================================

//Variables necesarias
// String elem;
// int opcion;
//
// //Instancia de List
// List<string> Personas = new List<string>();

//Agregamos objetos en la List
// Personas.Add("Hugo");
// Personas.Add("Miguel");
// Personas.Add("Diana");
// Personas.Add("Erick");

// Console.WriteLine($"El numero de elementos contenido en neustra Lista es: {Personas.Count}");



// do
// {
//     Console.WriteLine("1. Agregar Elemento");
//     Console.WriteLine("2. Salir");
//     opcion = Convert.ToInt32(Console.ReadLine());
//
//     if (opcion == 1)
//     {
//         Console.WriteLine("Ingresa el elemento a agregar en la lista: ");
//         elem = Console.ReadLine();
//
//         Personas.Add(elem);
//     }
//     
// } while (opcion == 1);

// Personas.Add("Hugo");
// Personas.Add("Miguel");
// Personas.Add("Diana");
// Personas.Add("Antonio");
//
// Console.WriteLine("Informacion en la List: \n");
// //Instruccion "foreach" para recorrer una coleccion
// foreach (var persona in Personas)
// {
//     Console.WriteLine(persona);
// }

// Console.WriteLine("\nIngresa el elemento a buscar en la List: ");
// elem = Console.ReadLine();
//
// //Buscar el elemento en la List
// Console.WriteLine($"El elemento se encuentra en el indice {Personas.IndexOf(elem)}");

//Insertamos un elemento en la List
// Personas.Insert(2, "Victor");
//
//
// Console.WriteLine("Informacion en la List actualizada: \n");
// //Instruccion "foreach" para recorrer una coleccion
// foreach (var persona in Personas)
// {
//     Console.WriteLine(persona);
// }
//
// //Quitando un elemento de la List
// Personas.RemoveAt(4);

// Console.WriteLine("Informacion en la List actualizada: \n");
// //Instruccion "foreach" para recorrer una coleccion
// foreach (var persona in Personas)
// {
//     Console.WriteLine(persona);
// }

//Limpiar la List
// Personas.Clear();
//
// Console.WriteLine("Informacion en la List: \n");
// foreach (var persona in Personas)
// {
//     Console.WriteLine(persona);
// }

//=====================================================EJERCICIOS LISTAS=====================================================

// //Variables necesarias
// int opcion, indice;
// string alumno;
//
// //Instancia de List
// var Alumnos = new List<string>();
//
// do
// {
//     Console.Clear();
//     Console.WriteLine("1. Agregar estudiante");
//     Console.WriteLine("2. Eliminar estudiante");
//     Console.WriteLine("3. Mostrar estudiantes");
//     Console.WriteLine("4. Buscar por nombre");
//     
//     //Escoger opcion
//     Console.WriteLine("Escoge una opcion");
//     opcion = Convert.ToInt32(Console.ReadLine());
//     Console.Clear();
//
//     switch (opcion)
//     {
//         case 1:
//             Console.WriteLine("Ingresa el nombre del alumno: ");
//             alumno = Console.ReadLine();
//             
//             Alumnos.Add(alumno);
//             break;
//         case 2:
//             Console.WriteLine("Ingrese el numero del estudiante que quiera eliminar: ");
//             indice = Convert.ToInt32(Console.ReadLine());
//             indice--; //Reducimos en 1 a indice, porque el usuario no sabe que el indice empieza en cero;
//             if (indice >= Alumnos.Count || indice < 0)
//             {
//                 Console.WriteLine("El alumno no existe...");
//             }
//             else
//             {
//                 var alumnoElim = Alumnos[indice];
//                 
//                 Alumnos.RemoveAt(indice);
//                 Console.WriteLine($"El alumno {alumnoElim} a sido eliminado exitosamente!");
//             }
//
//             Console.WriteLine("\nPresione cualquier tecla para regresar al menu");
//             Console.ReadKey();
//             break;
//         case 3:
//             var i = 1;
//             foreach (string estudiante in Alumnos)
//             {
//                 Console.WriteLine($"{i++}. {estudiante}");
//             }
//             Console.WriteLine("\nPresione cualquier tecla para regresar al menu");
//             Console.ReadKey();
//             break;
//         case 4:
//             string name;
//             int j; //numero de lista
//             Console.WriteLine("Ingresa el nombre del alumno a buscar: ");
//             alumno = Console.ReadLine();
//             
//             //Verificar si el elemento(alumno) esta o no en la lista
//             if (Alumnos.IndexOf(alumno) >= 0)
//             {
//                 name = Alumnos[Alumnos.IndexOf(alumno)]; //Alumno[3]
//                 j = Alumnos.IndexOf(alumno) + 1; //Alumno[4]
//
//                 Console.WriteLine($"El estudiante {name} se encuentra en el numero de lista {j}");
//             }
//             else
//             {
//                 Console.WriteLine($"El estudiante {alumno} no se encuentra en la lista");
//             }
//             Console.WriteLine("\nPresione cualquier tecla para regresar al menu");
//             Console.ReadKey();
//             break;
//             
//     }
//     
//     
// } while (opcion >= 1 && opcion <= 4);

//=====================================================STACK/PILA--LIFO=====================================================

// Stack<double> miPila = new Stack<double>();
//
// //Insertar objetos al principio del stack
// miPila.Push(5.9);
// miPila.Push(13.1);
// miPila.Push(8.7);
// miPila.Push(3.2);
// miPila.Push(10.5);
//
// int i = 0;
//
// foreach (var elemento in miPila)
// {
//     Console.WriteLine($"{i}. {elemento}");
//     i++;
// }
//
// //Después de insertar un elemento
// Console.WriteLine("\nDespues de insertar un elemento\n");
// miPila.Push(1.5);
// i = 0;
//
// foreach (var elemento in miPila)
// {
//     Console.WriteLine($"{i}. {elemento}");
//     i++;
// }
//
// //Después de quitar el elemento
// Console.WriteLine("\nDespues de quitar un elemento\n");
// var eliminado = miPila.Pop();
// i = 0;
//
// foreach (var elemento in miPila)
// {
//     Console.WriteLine($"{i}. {elemento}");
//     i++;
// }
//
// Console.WriteLine($"El elemento {eliminado} a sido eliminado con exito!");
//
// //Después de usar Peek
// Console.WriteLine("\nDespués de usar Peek\n");
// var primerObj = miPila.Peek();
// i = 0;
//
// foreach (var elemento in miPila)
// {
//     Console.WriteLine($"{i}. {elemento}");
//     i++;
// }
//
// Console.WriteLine($"El primer elemento en la pila es {primerObj}");
//
// //Saber si el stack contiene un elemento
// bool contiene;
// double buscarElem;
//
// Console.WriteLine("\nIngresa el elemento a buscar: ");
// buscarElem = double.Parse(Console.ReadLine());
//
// contiene = miPila.Contains(buscarElem);
//
// if (contiene)
// {
//     Console.WriteLine($"El objeto ({buscarElem}) se encuentra en el stack");
// }
// else
// {
//     Console.WriteLine($"No se encontro el objeto {buscarElem} en el stack");
// }
//
// Console.WriteLine($"\nEl stack tiene {miPila.Count} elementos");
//
// //Borrando el stack
// Console.WriteLine("\nDespues de borrar el Stack");
//
// miPila.Clear();
// Console.WriteLine($"\nEl stack tiene {miPila.Count} elementos");

//=====================================================QUEUE/COLA--FIFO=====================================================

// Queue<char> miFila = new Queue<char>();
//
// //Agregar objetos al Queue
// miFila.Enqueue('a');
// miFila.Enqueue('b');
// miFila.Enqueue('c');
// miFila.Enqueue('d');
//
// int i = 0;
//
// //Recorriendo la Queue
// foreach (var elemento in miFila)
// {
//     Console.WriteLine($"{i}. {elemento}");
//     i++;
// }
//
// //Agregando otro elemento
// Console.WriteLine("\nDespues de agregar a 'e' ");
// miFila.Enqueue('e');
//
// i = 0;
//
// foreach (var elemento in miFila)
// {
//     Console.WriteLine($"{i}. {elemento}");
//     i++;
// }
//
// //Después de quitar un elemento
// Console.WriteLine("\nDespues de quitar el elemento");
// var objEliminado = miFila.Dequeue();
//
// i = 0;
// foreach (var elemento in miFila)
// {
//     Console.WriteLine($"{i}. {elemento}");
//     i++;
// }
//
// Console.WriteLine($"\n{objEliminado} fue eliminado correctamente"); 
// //Se elimina "a" porque es el primero en la fila
//

//=====================================================DICCIONARIO=====================================================

// Dictionary<string, int> empleados = new Dictionary<string, int>();
//
// //Agregando un key-value paris a la coleccion
// empleados.Add("Antonio", 23);
// empleados.Add("Erica", 20);
//
// //Recorrer dictionary
// foreach (KeyValuePair<string, int> elemento in empleados)
// {
//     Console.WriteLine($"Key = {elemento.Key}, Value = {elemento.Value}");
// }
//
// //collection[key] = value;
// empleados["Miguel"] = 45; //Con Add: empleados.Add("Miguel",45);
//
// //Después de agregar un elemento con Item
// Console.WriteLine("\nDespués de agregar un elemento con Item");
//
// foreach (KeyValuePair<string, int> elemento in empleados)
// {
//     Console.WriteLine($"Key = {elemento.Key}, Value = {elemento.Value}");
// }
//
// //Comprobando que Item[] reemplaza la "key"
// Console.WriteLine("\nComprobando que Item[] reemplaza la (key)");
//
// empleados["Antonio"] = 19;
//
// foreach (KeyValuePair<string, int> elemento in empleados)
// {
//     Console.WriteLine($"Key = {elemento.Key}, Value = {elemento.Value}");
// }
//
// //Usando el "get" de la propiedad Item[] para obtener el Value
// Console.WriteLine($"\nLa edad de Antonio es: {empleados["Antonio"]}");
//
// Console.WriteLine("\nDespués de remover un elemento");
//
// empleados.Remove("Erica");
//
// foreach (KeyValuePair<string, int> elemento in empleados)
// {
//     Console.WriteLine($"Key = {elemento.Key}, Value = {elemento.Value}");
// }
//
// Console.WriteLine();
//
// if (empleados.ContainsKey("Erica"))
// {
//     Console.WriteLine("La Key se encuentra en la coleccion");
// }
// else
// {
//     Console.WriteLine("La Key no se encuentra en la coleccion");
// }
//
// Console.WriteLine();
//
// if (empleados.ContainsValue(50))
// {
//     Console.WriteLine("Existe alguien con esa edad");
// }
// else
// {
//     Console.WriteLine("No se encontró nadie con esa edad");
// }

//=====================================================EJERCICIO DICTIONARY=====================================================
// int opcion;
// string nombre;
// long numero;
//
// var contactos = new Dictionary<string, long>();
//
// do
// {
//     Console.Clear();
//     
//     //Menu
//     Console.WriteLine("1. Agregar contacto");
//     Console.WriteLine("2. Buscar contacto");
//     Console.WriteLine("3. Eliminar contacto");
//     Console.WriteLine("4. Mostrar contacto");
//     Console.WriteLine("5. Actualizar contacto");
//
//     Console.WriteLine("\nEscoje una opcion");
//     opcion = int.Parse(Console.ReadLine());
//
//     Console.Clear();
//     switch (opcion)
//     {
//         case 1:
//             Console.WriteLine("Nombre: ");
//             nombre = Console.ReadLine();
//
//             Console.WriteLine("Numero: ");
//             numero = long.Parse(Console.ReadLine());
//
//             contactos.Add(nombre, numero);
//
//             Console.WriteLine($"{nombre} se a agregado a tus contactos");
//             
//             Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
//             Console.ReadKey();
//             
//             break;
//         case 2:
//             Console.WriteLine("Buscar contacto por nombre: ");
//             nombre = Console.ReadLine();
//
//             if (contactos.ContainsKey(nombre))
//             {
//                 Console.WriteLine($"\nContacto encontrado!");
//                 Console.WriteLine($"{nombre}: {contactos[nombre]}");
//                 
//                 Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
//                 Console.ReadKey();
//             }
//             else
//             {
//                 Console.WriteLine($"\nEl contacto {nombre} no existe!");
//                 
//                 Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
//                 Console.ReadKey();
//             }
//             
//             break;
//         case 3:
//             Console.WriteLine("Contacto a eliminar: ");
//             nombre = Console.ReadLine();
//             
//             if (contactos.ContainsKey(nombre))
//             {
//                 contactos.Remove(nombre);
//
//                 Console.WriteLine($"{nombre} a sido eliminado con exito!");
//                 
//                 Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
//                 Console.ReadKey();
//             }
//             else
//             {
//                 Console.WriteLine($"\nEl contacto {nombre} no existe!");
//                 
//                 Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
//                 Console.ReadKey();
//             }
//             
//             break;
//         case 4:
//
//             Console.WriteLine("Contactos en tu agenda: \n");
//
//             foreach (KeyValuePair<string, long> contacto in contactos)
//             {
//                 Console.WriteLine($"{contacto.Key}: {contacto.Value}");
//             }
//             
//             Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
//             Console.ReadKey();
//             break;
//         case 5:
//             Console.WriteLine("Contacto a actualizar: ");
//             nombre = Console.ReadLine();
//
//             Console.WriteLine("Telefono nuevo: ");
//             numero = long.Parse(Console.ReadLine());
//             
//             if (contactos.ContainsKey(nombre))
//             {
//                 contactos[nombre] = numero;
//                 Console.WriteLine($"El contacto {nombre} a sido actualizado!");
//                 
//                 Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
//                 Console.ReadKey();
//             }
//             else
//             {
//                 Console.WriteLine($"\nEl contacto {nombre} no existe!");
//                 
//                 Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...");
//                 Console.ReadKey();
//             }
//             
//             break;
//     }
// } while (opcion >= 1 || opcion <= 4);

//=====================================================EJERCICIO INTEGRADOR=====================================================

int opcion;
double monto = 0;
var gastos = new Stack<double>();

do
{
    Console.Clear();

    Console.WriteLine("1. Ingresar gasto");
    Console.WriteLine("2. Mostrar gastos");
    Console.WriteLine("3. Total a pagar");

    Console.WriteLine("Que operacion deseas realizar: ");
    opcion = Int32.Parse(Console.ReadLine());

    Console.Clear();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingresa el monto del gasto: ");
            monto = double.Parse(Console.ReadLine());
            
            gastos.Push(monto);
            break;
        case 2:
            Console.WriteLine("Estos son los gastos que tienes hasta el momento: ");

            foreach (var gasto in gastos)
            {
                Console.WriteLine(gasto);
            }

            Console.WriteLine("Pulsa cualquier tecla para regresar al menu...");
            Console.ReadKey();

            break;
        case 3:
            foreach (var gasto in gastos)
            {
                monto += gasto;
            }
            Console.WriteLine($"Pago para no generar intereses: {monto}");
            
            Console.WriteLine("\nPulsa cualquier tecla para regresar al menu...");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Saliendo del programa...");
            break;
    }
    
}while (opcion >= 1 || opcion <= 3);