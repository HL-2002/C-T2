/* Para este ejercicio tendremos un número de tres dígitos que tiene la forma abc.

Por ejemplo -> 241

Para este caso

"a" sería el número 2
"b" sería el número 4
"c" sería el número 1

Has un programa que produzca números aacb, bca, bcbc.

*/

using System;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración e Inicialización de las variables
            byte a = 2, b = 4, c = 1;

            //Printf de los números
            Console.Write("{0}{1}{2}{3},  ", a, a, c, b);

            Console.Write("{0}{1}{2},  ", b, c, a);

            Console.Write("{0}{1}{2}{3}. ", b, c, b, c);
        }
    }
}
