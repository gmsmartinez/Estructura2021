using System;
using System.Collections; // Para usar pilas y colas

namespace PilaColaEjercicioss
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCIO 1
            //Crea un programa que pida al usuario 6 números enteros y luego los muestre en orden contrario,
            // utilizando una pila.

            // Instanciamos una pila llamada miPila
            Stack miPila = new Stack();
            int n;

            // Agregamos los 6 numeros en orden a la pila
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese numero {0}:", i + 1);
                n = int.Parse(Console.ReadLine());
                miPila.Push(n);
            }

            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                //Imprimimos el ultimo elemento añadido a la pila
                Console.WriteLine(miPila.Peek());

                //Removemos el ultimo elemento añadido a la pila
                miPila.Pop();
            }



            // TAREA 2:

            /*
              // Crea un programa que pida al usuario 6 números reales de doble precisión, los guarde en una cola y luego los muestre en pantalla.

            Queue miCola = new Queue();
            double n;

            
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine("Ingrese numero {0}: ", i+1);
                n = double.Parse(Console.ReadLine());

                // Agregamos numeros a la cola
                miCola.Enqueue(n);
            }

            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                // Muestra el primer elemento de la cola
                Console.WriteLine( miCola.Peek() );

                // Quita el primer elemento de la cola
                miCola.Dequeue();
            
            */



            // TAREA 3


            /*
             / Crea un programa que pida frases al usuario, hasta que introduzca una frase vacía. En ese
            // momento, mostrará todas las frases que se habían introducido.

            Queue miCola = new Queue();
            string frase = string.Empty;

            // Guardamos frases en cola
            do
            {
                Console.WriteLine("Ingrese una frase o ingrese una frase vacia para salir: ");
                frase = Console.ReadLine();
                miCola.Enqueue(frase);
            } while (frase != string.Empty);

            Console.WriteLine("Frases ingresadas: ");
            // Imprimimos frases de la cola
            foreach (var item in miCola)
            {
                Console.WriteLine(item);
            }

            */



        }
    }
    
}
