using System;
using System.Threading;
using System.Text;
using System.Security.Cryptography;

namespace ejercicio04_JuegoDeLaVida
{
    class Program
    {
        const int Columns = 20;
        const int Rows = 20;
        static bool run = true;

        public enum Estado
        {
            Vivo,
            Muerto,
        }

        static void Main(string[] args)
        {
            // Crear Matriz
            var Grid = new Estado[Rows, Columns];
            var FutureGrid = new Estado[Rows, Columns];

            // Inicializar Matriz
            // Manual
            for (int row = 0; row < Rows; row++)
            {
                for (int column = 0; column < Columns; column++)
                {
                    Grid[row, column] = Estado.Muerto;
                }
            }

            // Inserte cuantas células desee
            Grid[8, 9] = Estado.Vivo;
            Grid[9, 9] = Estado.Vivo;
            Grid[9, 8] = Estado.Vivo;
            Grid[9, 10] = Estado.Vivo;
            Grid[10, 9] = Estado.Vivo;

            // Aleatorio
            /*
            for (int row = 0; row < Rows; row++)
            {
                for (int column = 0; column < Columns; column++)
                {
                    Grid[row, column] = (Estado)RandomNumberGenerator.GetInt32(0, 2);
                }
            }
            */

            // Juego de la Vida
            do
            {
                // Imprimir Matriz

                for (int row = 0; row < Rows; row++)
                {
                    for (int column = 0; column < Columns; column++)
                    {
                        if (Grid[row, column] == Estado.Muerto)
                        {
                            Console.Write("⬛");
                        }
                        else
                        {
                            Console.Write("⬜️");
                        }
                    }
                    Console.Write("\n");
                }
                Thread.Sleep(3000);
                Console.Clear();

                // Actualizar Matriz basado en reglas

                // Tomar matriz inicial y recorrer cada célula
                for (int row = 0; row < Rows; row++)
                {
                    for (int column = 0; column < Columns; column++)
                    {
                        // Recorrer vecinos de la célula
                        var VecinosVivos = 0;
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                if ((row + i > 0 && column + j > 0) &&
                                    (row + i < Rows && column + j < Columns) &&
                                    Grid[row + i, column + j] == Estado.Vivo)
                                {
                                    VecinosVivos++;
                                }
                            }
                        }

                        // Descontar la célula de los vecinos
                        if (Grid[row, column] == Estado.Vivo)
                        {
                            VecinosVivos -= 1;
                        }

                        // Actualizar en nueva matriz según reglas de la vida

                        // Célula Muerta nace si tiene 3 vecinos vivos
                        if (VecinosVivos == 3)
                        {
                            FutureGrid[row, column] = Estado.Vivo;
                        }

                        // Célula Viva con 2 ó 3 vecinas vivas sobrevive, de otro caso muere
                        else if (VecinosVivos < 2 || VecinosVivos > 3)
                        {
                            FutureGrid[row, column] = Estado.Muerto;
                        }
                        else
                        {
                            FutureGrid[row, column] = Grid[row, column];
                        }
                    }
                }

                // Actualizar matriz inicial
                for (int row = 0; row < Rows; row++)
                {
                    for (int column = 0; column < Columns; column++)
                    {
                        Grid[row, column] = FutureGrid[row, column];
                    }
                }
            } while(run);
        }
    }
}
