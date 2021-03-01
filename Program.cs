/* Como ejercicio práctico para este segundo corte crearemos un programa el cual 
 * filtre por medio de la edad y de la estatura a las personas que desean entrar 
 * a un parque. Para lograr programar esto el uso de Console.ReadLine() y los 
 * condicionales IF será fundamental.
 * Les adjunto un ejemplo sencillo de como debería ser el programa.
*/

using System;
using System.Threading;

namespace ejericio02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string cadena;
            string nombres;
            int edad;
            int estatura;
            bool validacion;
            bool finish;
            string[] SavedName = new string[9999];
            bool[] approval = new bool[9999];
            int arrayn = 0;
            int SiNo;
            int n;

            // Ciclo para correr el programa cuantas veces se desee.
            do
            {
                // Inicialización para continuación de programa
                finish = false;
                n = 0;

                // Recibir nombre de las personas
                Console.WriteLine("Ingrese su Nombre y Apellido:");
                nombres = Console.ReadLine();

                // Comprobar si el acceso a la persona ya fue aprobado o denegado (Ahorro de secuencias)
                do
                {
                    if (nombres == SavedName[n] && approval[n] == false)
                    {
                        Console.WriteLine("De nuevo, no puedes pasar, supéralo y crece");
                        finish = true;
                    }
                    else if (nombres == SavedName[n] && approval[n] == true)
                    {
                        Console.WriteLine("Sabes que puedes pasar, no vuelvas a preguntar");
                        finish = true;
                    }
                    n++;
                } while (n <= arrayn);

                // Continuar programa de ser una nueva persona
                if (finish == false)
                {
                    // Recibir Edad
                    Console.WriteLine("Ingrese su edad:");
                    cadena = Console.ReadLine();

                    // Repetir en caso de recibir un dato inválido
                    validacion = int.TryParse(cadena, out edad);
                    if (validacion == false)
                        {
                            do
                            {
                                Console.WriteLine("Error, texto inválido, ingrese su Edad (número)");
                                cadena = Console.ReadLine();
                                validacion = int.TryParse(cadena, out edad);
                            } while (validacion == false);
                    }
                    edad = Convert.ToInt32(cadena);

                    // Recibir Estatura
                    Console.WriteLine("Ingrese su estatura (centímetros):");
                    cadena = Console.ReadLine();

                    // Repetir en caso de recibir un dato inválido
                    validacion = int.TryParse(cadena, out edad);
                    if (validacion == false)
                    {
                        do
                        {
                            Console.WriteLine("Error, texto inválido, ingrese su Estatura (número en cm)");
                            cadena = Console.ReadLine();
                            validacion = int.TryParse(cadena, out edad);
                        } while (validacion == false);
                    }
                    estatura = Convert.ToInt32(cadena);

                    // Aprobar o Denegar acceso de persona al parque
                    if (edad >= 16 && estatura >= 170)
                    {
                        Console.WriteLine("Puede pasar, ¡bienvenido al parque {0}!", nombres);
                        approval[arrayn] = true;
                    }
                    else
                    {
                        Console.WriteLine("No puede pasar, envejece y toma fororo.");
                        approval[arrayn] = true;
                    }

                    // Guardar nombres para comprobación en caso de reinicio
                    SavedName[arrayn] = nombres;
                    arrayn++;
                }

                // Pregunta para reniciar el programa si se desea
                Thread.Sleep(2000);
                Console.WriteLine("¿Otra persona desea entrar al parque? (Sí - 1 || No - 0)");
                cadena = Console.ReadLine();

                if (!(cadena == "1" || cadena == "0"))
                {
                    do
                    {
                        Console.WriteLine("Error, texto inválido, ingrese 1 (Sí) o 0 (No)");
                        cadena = Console.ReadLine();
                    } while (!(cadena == "1" || cadena == "0"));
                }
                SiNo = Convert.ToInt32(cadena);
                Console.WriteLine();

            } while (SiNo == 1);
        }
    }
}
