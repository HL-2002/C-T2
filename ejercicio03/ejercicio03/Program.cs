using System;
using System.Threading;

namespace ejercicio03
{
    class Program
    {
        // Función de validación de inputs *
        private static string Validar(string input, int output)
        {
            bool validacion;

            validacion = int.TryParse(input, out output);
            while (validacion == false)
            {
                Console.WriteLine("Error, ingrese un número válido");
                input = Console.ReadLine();
                validacion = int.TryParse(input, out output);
            }
            return (input);
        }

        // Selección de opciones del usuario con validación
        private static int Entrada_Opcion(string input, int output, int primera_opcion, int ultima_opcion)
        {
            do
            {
                input = Console.ReadLine();
                input = Validar(input, output);
                output = Convert.ToInt32(input);
                if (!(output >= primera_opcion && output <= ultima_opcion))
                {
                    Console.WriteLine("Opción inválida, por favor seleccione una de las opciones");
                    Thread.Sleep(1000);
                }
            } while (!(output >= primera_opcion && output <= ultima_opcion));
            return (output);
        }

        static void Main(string[] args)
        {
            // Variables
            string input = "", tipo, actividad;
            int opcion = 0, continuar = 0, peso = 0, edad = 0;

            // Bienvenida
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido a TuPerro.exe");
            Console.WriteLine(" ");

            do
            {
                // Decidir qué quiere el usuario
                Thread.Sleep(1000);
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1: Conocer si su perro es un cachorro o un adulto");
                Console.WriteLine("2: Conocer el tamaño de su perro según su peso");
                Console.WriteLine("3: Conocer la cantidad de alimento que su perro requiere");
                Console.WriteLine(" ");

                // Entrada de la opción a elegir (Incluye repetición y validación de la entrada)
                opcion = Entrada_Opcion(input, opcion, 1, 3);

                Console.WriteLine("——————————————————————————————————————————————");
                Console.WriteLine(" ");

                // Programa
                Thread.Sleep(1000);
                switch (opcion)
                {
                    case 1:

                        // Pregunta al usuario por edad del perro **
                        Console.WriteLine("¿Tiene su perro más de 12 meses?");
                        Console.WriteLine("1: Sí | 0: No");

                        // Entrada del usuario con Validación
                        opcion = Entrada_Opcion(input, opcion, 0, 1);
                        Console.WriteLine(" ");

                        // Definir edad del perro según la respuesta
                        if (opcion == 1)
                        {
                            Console.WriteLine("Su perro es adulto");
                        }
                        else
                        {
                            Console.WriteLine("Su perro es un cachorro");
                        }

                        break;

                    case 2:

                        // Pregunta al usuario por peso del perro
                        Console.WriteLine("¿Cuánto pesa su perro? (kg)");
                        input = Console.ReadLine();
                        input = Validar(input, peso);
                        peso = Convert.ToInt32(input);
                        Console.WriteLine(" ");

                        // Definir tamaño del perro según la respuesta
                        if (peso < 1)
                        {
                            Console.WriteLine("¿¡Cómo es posible que pese tan poco!?");
                        }
                        else if (peso >= 2 && peso <= 5)
                        {
                            Console.WriteLine("Su perro es Miniatura");
                        }
                        else if (peso >= 5 && peso <= 10)
                        {
                            Console.WriteLine("Su perro es Pequeño");
                        }
                        else if (peso >= 10 && peso <= 15)
                        {
                            Console.WriteLine("Su perro es Mediano");
                        }
                        else if (peso >= 15 && peso <= 90)
                        {
                            Console.WriteLine("Su perro es Grande");
                        }
                        else if (peso > 90)
                        {
                            Console.WriteLine("Su perro es un mastodonte");
                        }

                        break;

                    case 3:

                        // Pregunta al usuario por edad del perro
                        Console.WriteLine("¿Tiene su perro más de 12 meses?");
                        Console.WriteLine("1: Sí | 0: No");
                        Console.WriteLine(" ");

                        // Entrada del usuario con validación
                        opcion = Entrada_Opcion(input, opcion, 0, 1);

                        // Definir edad del perro
                        if (opcion == 1)
                        {
                            tipo = "adulto";
                        }
                        else
                        {
                            tipo = "cachorro";
                        }

                        // Definir alimento según edad
                        if (tipo == "adulto")
                        {
                            // Conocer peso del perro
                            Console.WriteLine("¿Cuánto pesa su perro? (kg)");
                            Console.WriteLine(" ");
                            input = Console.ReadLine();
                            input = Validar(input, peso);
                            peso = Convert.ToInt32(input);

                            // Conocer nivel de actividad del perro
                            Console.WriteLine("¿Cuál es el nivel de actividad de su perro?");
                            Console.WriteLine("0: Baja | 1: Normal | 2: Alta");
                            Console.WriteLine(" ");

                            // Entrada del usuario con validación
                            opcion = Entrada_Opcion(input, opcion, 0, 2);

                            if (opcion == 0)
                            {
                                actividad = "baja";
                            }
                            else if (opcion == 1)
                            {
                               actividad = "normal";
                            }
                            else 
                            {
                                actividad = "alta";
                            }

                            // Definir alimento según peso y actividad
                            if (peso >= 2 && peso <= 5)
                            {
                                if (actividad == "baja")
                                {
                                    Console.WriteLine("Su perro necesita entre 45 y 85 gramos de alimento");
                                }
                                else if (actividad == "normal")
                                {
                                    Console.WriteLine("Su perro necesita entre 55 y 100 gramos de alimento");
                                }
                                else
                                {
                                    Console.WriteLine("Su perro necesita entre 60 y 115 gramos de alimento");
                                }
                            }
                            else if (peso >= 5 && peso <= 10)
                            {
                                if (actividad == "baja")
                                {
                                    Console.WriteLine("Su perro necesita entre 85 y 145 gramos de alimento");
                                }
                                else if (actividad == "normal")
                                {
                                    Console.WriteLine("Su perro necesita entre 100 y 170 gramos de alimento");
                                }
                                else
                                {
                                    Console.WriteLine("Su perro necesita entre 115 y 190 gramos de alimento");
                                }
                            }
                            else if (peso >= 10 && peso <= 15)
                            {
                                if (actividad == "baja")
                                {
                                    Console.WriteLine("Su perro necesita entre 145 y 195 gramos de alimento");
                                }
                                else if (actividad == "normal")
                                {
                                    Console.WriteLine("Su perro necesita entre 170 y 225 gramos de alimento");
                                }
                                else
                                {
                                    Console.WriteLine("Su perro necesita entre 190 y 255 gramos de alimento");
                                }
                            }
                            else if (peso >= 10 && peso <= 15)
                            {
                                if (actividad == "baja")
                                {
                                    Console.WriteLine("Su perro necesita entre 145 y 195 gramos de alimento");
                                }
                                else if (actividad == "normal")
                                {
                                    Console.WriteLine("Su perro necesita entre 170 y 225 gramos de alimento");
                                }
                                else
                                {
                                    Console.WriteLine("Su perro necesita entre 190 y 255 gramos de alimento");
                                }
                            }
                            else if (peso >= 15 && peso <= 25)
                            {
                                if (actividad == "baja")
                                {
                                    Console.WriteLine("Su perro necesita entre 195 y 285 gramos de alimento");
                                }
                                else if (actividad == "normal")
                                {
                                    Console.WriteLine("Su perro necesita entre 225 y 330 gramos de alimento");
                                }
                                else
                                {
                                    Console.WriteLine("Su perro necesita entre 255 y 380 gramos de alimento");
                                }
                            }
                            else if (peso >= 25 && peso <= 40)
                            {
                                if (actividad == "baja")
                                {
                                    Console.WriteLine("Su perro necesita entre 285 y 410 gramos de alimento");
                                }
                                else if (actividad == "normal")
                                {
                                    Console.WriteLine("Su perro necesita entre 330 y 475 gramos de alimento");
                                }
                                else
                                {
                                    Console.WriteLine("Su perro necesita entre 380 y 535 gramos de alimento");
                                }
                            }
                            else if (peso >= 40 && peso <= 55)
                            {
                                if (actividad == "baja")
                                {
                                    Console.WriteLine("Su perro necesita entre 410 y 520 gramos de alimento");
                                }
                                else if (actividad == "normal")
                                {
                                    Console.WriteLine("Su perro necesita entre 475 y 600 gramos de alimento");
                                }
                                else
                                {
                                    Console.WriteLine("Su perro necesita entre 535 y 680 gramos de alimento");
                                }
                            }
                            else if (peso >= 55 && peso <= 70)
                            {
                                if (actividad == "baja")
                                {
                                    Console.WriteLine("Su perro necesita entre 520 y 620 gramos de alimento");
                                }
                                else if (actividad == "normal")
                                {
                                    Console.WriteLine("Su perro necesita entre 600 y 720 gramos de alimento");
                                }
                                else
                                {
                                    Console.WriteLine("Su perro necesita entre 680 y 820 gramos de alimento");
                                }
                            }
                            else if (peso >= 70 && peso <= 90)
                            {
                                if (actividad == "baja")
                                {
                                    Console.WriteLine("Su perro necesita entre 620 y 750 gramos de alimento");
                                }
                                else if (actividad == "normal")
                                {
                                    Console.WriteLine("Su perro necesita entre 720 y 870 gramos de alimento");
                                }
                                else
                                {
                                    Console.WriteLine("Su perro necesita entre 820 y 995 gramos de alimento");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lo sentimos, no tenemos información para la alimentación de su perro." +
                                    "Por favor consulte un especialista");
                            }
                        }
                        else
                        {
                            // Conocer peso del perro
                            Console.WriteLine("¿Cuál es el peso ideal de su perro cuando sea adulto? (kg)");
                            input = Console.ReadLine();
                            input = Validar(input, peso);
                            peso = Convert.ToInt32(input);
                            Console.WriteLine(" ");

                            // Conocer edad del perro
                            Console.WriteLine("¿Cuántos meses de edad tiene su perro?");

                            // Entrada del usuario con validación
                            do
                            {
                                input = Console.ReadLine();
                                input = Validar(input, edad);
                                edad = Convert.ToInt32(input);

                                if (edad < 2)
                                {
                                    Console.WriteLine("Edad por debajo de los dos meses, por favor vuelva a ingresarla");
                                    Thread.Sleep(1000);
                                }
                                else if (edad > 12)
                                {
                                    Console.WriteLine("Edad por encima de los 12 meses, por favor vuelva a ingresarla");
                                    Thread.Sleep(1000);
                                }
                            } while (edad < 2 || edad > 12);

                            // Definir alimento según peso y edad
                            if (peso >= 2 && peso < 5)
                            {
                                if (edad == 2)
                                {
                                    Console.WriteLine("Su perro necesita 50 gramos de alimento");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Su perro necesita 60 gramos de alimento");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Su perro necesita 60 gramos de alimento");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Su perro necesita 60 gramos de alimento");
                                }
                                else if (edad >= 6 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro necesita 55 gramos de alimento");
                                }
                            }
                            else if (peso >= 5 && peso < 10)
                            {
                                if (edad == 2)
                                {
                                    Console.WriteLine("Su perro necesita 95 gramos de alimento");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Su perro necesita 110 gramos de alimento");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Su perro necesita 115 gramos de alimento");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Su perro necesita 115 gramos de alimento");
                                }
                                else if (edad >= 6 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro necesita 110 gramos de alimento");
                                }
                            }
                            else if (peso >= 10 && peso < 17)
                            {
                                if (edad == 2)
                                {
                                    Console.WriteLine("Su perro necesita 155 gramos de alimento");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Su perro necesita 185 gramos de alimento");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Su perro necesita 195 gramos de alimento");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Su perro necesita 190 gramos de alimento");
                                }
                                else if (edad >= 6 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro necesita 185 gramos de alimento");
                                }
                            }
                            else if (peso >= 17 && peso < 25)
                            {
                                if (edad == 2)
                                {
                                    Console.WriteLine("Su perro necesita 215 gramos de alimento");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Su perro necesita 265 gramos de alimento");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Su perro necesita 285 gramos de alimento");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Su perro necesita 285 gramos de alimento");
                                }
                                else if (edad >= 6 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro necesita 280 gramos de alimento");
                                }
                            }
                            else if (peso >= 25 && peso < 32)
                            {
                                if (edad == 2)
                                {
                                    Console.WriteLine("Su perro necesita 270 gramos de alimento");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Su perro necesita 350 gramos de alimento");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Su perro necesita 375 gramos de alimento");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Su perro necesita 375 gramos de alimento");
                                }
                                else if (edad >= 6 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro necesita 370 gramos de alimento");
                                }
                            }
                            else if (peso >= 32 && peso < 40)
                            {
                                if (edad == 2)
                                {
                                    Console.WriteLine("Su perro necesita 300 gramos de alimento");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Su perro necesita 400 gramos de alimento");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Su perro necesita 445 gramos de alimento");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Su perro necesita 450 gramos de alimento");
                                }
                                else if (edad >= 6 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro necesita 450 gramos de alimento");
                                }
                            }
                            else if (peso >= 40 && peso < 50)
                            {
                                if (edad == 2)
                                {
                                    Console.WriteLine("Su perro necesita 355 gramos de alimento");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Su perro necesita 475 gramos de alimento");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Su perro necesita 525 gramos de alimento");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Su perro necesita 530 gramos de alimento");
                                }
                                else if (edad >= 6 && edad <= 12)
                                {
                                    Console.WriteLine("Su perro necesita 530 gramos de alimento");
                                }
                            }
                            else if (peso >= 50 && peso < 60)
                            {
                                if (edad == 2)
                                {
                                    Console.WriteLine("Su perro necesita 405 gramos de alimento");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Su perro necesita 545 gramos de alimento");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Su perro necesita 610 gramos de alimento");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Su perro necesita 625 gramos de alimento");
                                }
                                else if (edad > 5)
                                {
                                    Console.WriteLine("Su perro debe alimentarse según indicaciones de un especialista");
                                }
                            }
                            else if (peso >= 60 && peso < 70)
                            {
                                if (edad == 2)
                                {
                                    Console.WriteLine("Su perro necesita 450 gramos de alimento");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Su perro necesita 605 gramos de alimento");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Su perro necesita 685 gramos de alimento");
                                }
                                else if (edad > 4)
                                {
                                    Console.WriteLine("Su perro debe alimentarse según indicaciones de un especialista");
                                }
                            }
                            else if (peso >= 70 && peso < 80)
                            {
                                if (edad == 2)
                                {
                                    Console.WriteLine("Su perro necesita 485 gramos de alimento");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Su perro necesita 670 gramos de alimento");
                                }
                                else if (edad > 3)
                                {
                                    Console.WriteLine("Su perro debe alimentarse según indicaciones de un especialista");
                                }
                            }
                            else if (peso >= 80 && peso <= 90)
                            {
                                if (edad == 2)
                                {
                                    Console.WriteLine("Su perro necesita 580 gramos de alimento");
                                }
                                else if (edad > 2)
                                {
                                    Console.WriteLine("Su perro debe alimentarse según indicaciones de un especialista");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lo sentimos, no tenemos información para la alimentación de su perro." +
                                    "Por favor consulte un especialista");
                            }
                        }

                        break;
                }

                // Continuar programa si se desea
                Thread.Sleep(1000);
                Console.WriteLine(" ");
                Console.WriteLine("¿Desea conocer otra información?");
                Console.WriteLine("1: Sí | 0: No");

                // Entrada del usuario con validación **
                opcion = Entrada_Opcion(input, opcion, 0, 1);
                Console.Clear();

            } while (continuar == 1);
        }
    }
}
