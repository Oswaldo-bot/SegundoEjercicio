using System;

namespace SegundoEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                float valorhr, hrstrabMES, antigue;
                string nombre;

                Console.Write("Nombre:");
                nombre = Console.ReadLine();

                Console.Write("Valor hora:");
                valorhr = float.Parse(Console.ReadLine());

                Console.Write("Antiguedad:");
                antigue = float.Parse(Console.ReadLine());

                Console.Write("Horas trabajadas:");
                hrstrabMES = float.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Antiguedad: {0}", antigue);
                Console.WriteLine("Valor hora: {0}", valorhr);
                Console.WriteLine("Total a cobrar: {0}", valorhr * hrstrabMES + antigue * 50000);// TOTAL
                Console.WriteLine("Total del descuento: {0}", (valorhr * hrstrabMES + antigue * 50000) * 0.15);// TOTAL * 0,15
                Console.WriteLine("Total con descuento: {0}", ((valorhr * hrstrabMES + antigue * 50000) - (valorhr * hrstrabMES + antigue * 30) * 0.15));// TOTAL - DESC
                Console.Read();
            }
        }
    }
}

