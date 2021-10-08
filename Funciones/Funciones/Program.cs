using System;

namespace Funciones
{


    class Program
    {
        static void Main(string[] args)
        {


            /*
            //TAREA 1

            float real;
            Console.WriteLine("Ingrese un número real: ");
            real = Convert.ToSingle(Console.ReadLine());
            Signo(real);
        }
        public static void Signo(float n)
        {
            if (n < 0)
                Console.Write("-1");
            else if (n > 0)
                Console.Write("1");
            else
                Console.Write("0");
        }



        //TAREA 2



            int n1, n2;
            Console.Write("Ingrese un número entero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro número entero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Menor(n1, n2);
        }

        public static void Menor(int m1, int m2)
        {
            if (m1 < m2)
                Console.Write("El menor es {0}", m1);
            else
                Console.Write("El menor es {0}", m2);

        }


        TAREA 3

              static public bool EsPrimo(float n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            //Crea una función "EsPrimo", que reciba un número y devuelva el valor
            // booleano "true" si es un número primo o "false" en caso contrario.

            Console.WriteLine("Ingrese numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (EsPrimo(numero)) 
            {
                Console.Write("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
        }

            


        TAREA 4

    

            for (int fila = 1; fila <= 7; fila++)
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                {
                    Console.Write(" ");
                }
                for (int conta = 1; conta < (2 * fila); conta++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");

            }


            TAREA 5

    
            Console.WriteLine("Ingrese operacion (Ej: calcula 2 + 3 o calcula 5 * 60)");
            string linea = Console.ReadLine();
            string[] operacion = linea.Split(' ');

            string calcula = operacion[0];
            float n1 = float.Parse(operacion[1]);
            float n2 = float.Parse(operacion[3]);
            string operador = operacion[2];


            switch (operador)
            {
                case "+":
                    Console.WriteLine("Resultado: {0:N2}", calcularSuma(n1, n2));
                    break;
                case "-":
                    Console.WriteLine("Resultado: {0:N2}", calcularResta(n1, n2));
                    break;
                case "*":
                    Console.WriteLine("Resultado: {0:N2}", calcularMultiplicacion(n1, n2));
                    break;
                case "/":
                    Console.WriteLine("Resultado: {0:N2}", calcularDivision(n1, n2));
                    break;
            }

        }

        public static float calcularSuma(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float calcularResta(float n1, float n2)
        {
            return n1 - n2;
        }

        public static float calcularMultiplicacion(float n1, float n2)
        {
            return n1 * n2;
        }

        public static float calcularDivision(float n1, float n2)
        {
            if (n2 != 0)
                return n1 / n2;
            else
            {
                Console.WriteLine("No se puede dividir entre 0");
                return 0;
            }

        }

            */







        //TAREA 6

        //Crea una función "SumaCifras" que reciba un numero cualquiera y que
        //devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera 123 la
        //suma sería 6.

        Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("La suma de los digitos de {0} es {1}", numero, SumaCifras(numero));

        }

        static public int SumaCifras(int numero)
        {
            int suma = 0;

            while (numero != 0)
            {
                suma += numero % 10;
                numero /= 10;
            }

            return suma;
        }


    //TAREA 7

    static void Triangulo(int n, string x)
            {


                for (int fila = n; fila >= 0; fila--)
                {
                    //dibuja espacios en blanco (1er bucle interno)
                    for (int espacios = n - fila; espacios > 0; espacios--)
                        Console.Write(" "); //espai en blanc

                    //dibuja estrellas (2do bucle interno)
                    for (int conta = 1; conta < (2 * fila); conta++)
                        Console.Write(x);

                    Console.WriteLine(" ");
                }

                Console.ReadKey();  // Se ve un triangulo de 7 pisos de estrellitas




            }
        }
    }

















