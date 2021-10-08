using System;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {/* EJERCICIO 1
            int user, password;
            do
            {
                Console.WriteLine("Ingrese su numero de usuario: ");
                user = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su contrasena: ");
                password = Convert.ToInt32(Console.ReadLine());

                if (user != 1234 && password != 1111)
                    Console.WriteLine("El usuario/contrasena es incorrecta.");
            }
            while (user != 1234 && password != 1111);
            Console.WriteLine("Bienvenido!! {0}", user);
            Console.ReadKey();

            
            
            
            EJERCICIO 2

            

            int numero, contador;
            contador = 0;

            Console.WriteLine("Introduzca un numero entero positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)

            {
                numero = numero / 10;
                contador = contador + 1;

            }
            Console.WriteLine("La cantidad de digitos que tiene el numero ingresado es {0}", contador);



            EJERCICIO 3

            

            int num = 9;

            Console.WriteLine("Tabla de multiplicar de 9 ");
            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i++)
            {
                int multiplicador = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, multiplicador);
            }



            
            EJERCICIO 4

            

            int contador;

            for (contador = 1; ; contador++)
                Console.WriteLine("{0}", contador);




            EJERCICIO 5
            

            string saludo = "Hola!";

            while (saludo == "Hola!")
                Console.WriteLine("{0}", saludo);



            EJERCICIO 6

            

            int a = 5, b = ++a, c = a++;
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            b = b * 5; a = a * 2;
            Console.WriteLine("Despues de multiplicar ax2 es {0} y multiplicar bx5 es {1}", a, b);

            
            EJERCICIO 7

            int a = 5, b = a + 2, c = -3;
            Console.WriteLine("a={0}, b ={1}, c={2}", a, b, c);
            b -= 3; c *= 2;
            Console.WriteLine("B = {0}, C = {1}", b, c);
            ++c; a *= b;
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);



            TAREA 8
            

            char letra;
            bool esVocal;

            Console.WriteLine("Introduzca una letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            esVocal = (letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u') || (letra == 'A') || (letra == 'E') || (letra == 'I') || (letra == 'O') || (letra == 'U');
            if (esVocal)
                Console.WriteLine("Es una vocal");
            else
                Console.WriteLine("Es una consonante u otro simbolo");


            
            TAREA 9

            
            int contra1, contra2;
            do
            {
                Console.WriteLine("Introduzca la primera contrasena: ");
                contra1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca la segunda contrasena: ");
                contra2 = Convert.ToInt32(Console.ReadLine());

                if (contra1 != contra2)
                    Console.WriteLine("Ambas contrasenas no coinciden");

            }
            while (contra1 != contra2);
            Console.WriteLine("Ambas contrasenas coinciden!");




            TAREA 10

            */

            string nombre = "Gabriela";
            Console.WriteLine("Cual es tu nombre?");
            nombre = Console.ReadLine();

            if(nombre != "Gabriela")
                Console.WriteLine("No te conozco");
            else
                Console.WriteLine("Hola!");



        }
    }
}
