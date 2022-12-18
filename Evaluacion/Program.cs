using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    class Escuela
    {
        private int turno1;
        private int turno2;
        private int turno3;
        private int sumaEdad1 = 0;
        private int sumaEdad2 = 0;
        private int sumaEdad3 = 0;
        private float promedio1, promedio2, promedio3;
        private int i = 0;
        private int comparacion;

        public void solicitar()
        {
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Ingresa un edad turno 1: ");//Mensaje para el usuario
                turno1 = int.Parse(Console.ReadLine());//Convertir de texto a entero

                sumaEdad1 = sumaEdad1 + turno1;
            }

            promedio1 = sumaEdad1 / 5;
            Console.Clear();

            for (i = 1; i <= 5; i++)
            {
                Console.Write("Ingresa un edad turno 2: ");//Mensaje para el usuario
                turno2 = int.Parse(Console.ReadLine());//Convertir de texto a entero
                sumaEdad2 = sumaEdad2 + turno2;
            }
            promedio2 = sumaEdad2 / 5;
            Console.Clear();

            for (i = 1; i <= 5; i++)
            {
                Console.Write("Ingresa un edad turno 3: ");//Mensaje para el usuario
                turno3 = int.Parse(Console.ReadLine());//Convertir de texto a entero
                sumaEdad3 = sumaEdad3 + turno3;
            }
            promedio3 = sumaEdad3 / 5;
            Console.Clear();

        }

        public void Mostrar()
        {
            Console.WriteLine("suma de edades turno 1: ");
            Console.Write(sumaEdad1);
            Console.WriteLine();
            Console.Write("Promedio de turno 1: ");
            Console.WriteLine();
            Console.Write(promedio1);
            Console.WriteLine();
            Console.Write("suma de edades turno 2: ");
            Console.WriteLine();
            Console.Write(sumaEdad2);
            Console.WriteLine();
            Console.Write("Promedio de turno 2: ");
            Console.WriteLine();
            Console.Write(promedio2);
            Console.WriteLine();
            Console.Write("suma de edades turno 3: ");
            Console.WriteLine();
            Console.Write(sumaEdad3); Console.WriteLine();
            Console.Write("Promedio de turno 3: ");
            Console.WriteLine();
            Console.Write(promedio3);
            Console.WriteLine();
        }
        public void Promedios()
        {
            if (promedio1 > promedio2)
            {
                Console.Write("Promedio 2 es el menor");
            }
            else
            {
                if (promedio2 > promedio3)
                {
                    Console.Write("Promedio 3 es el menor");
                }
                else
                {
                    if (promedio3 > promedio1)
                    {
                        Console.Write("Promedio 1 es el menor");
                    }
                    else
                    {
                        if (promedio2 > promedio3)
                        {
                            Console.Write("Promedio 3 es el menor");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Escuela school = new Escuela();
            school.solicitar();
            school.Mostrar();
            school.Promedios();

            Console.ReadKey();
        }
    }
}
