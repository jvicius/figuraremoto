using System;
using System.Dynamic;
using FiguraGeometricaDemo.Modelos;

namespace FiguraGeometricaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var figura = new Figura();
            figura._atributo1 = 2;
                var triangulo = new Triangulo();
                triangulo._atributo1 = 1;
                Console.WriteLine("hola");
                Console.ReadKey();

        }
    }
}
