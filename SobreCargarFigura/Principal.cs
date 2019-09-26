using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargarFigura
{
    class Principal
    {
        Operaciones R = new Operaciones(); //Instanciando la Clase Operaciones

        public void Menu() //Menu para Ingresar datos e Imprimir los resultados
        {
            
            Console.WriteLine("Ingrese 2 Datos:");
            Console.WriteLine(" ");

            Console.WriteLine("Lado A:");
            double N1 = Convert.ToDouble(Console.ReadLine()); //Asignando valor a el lado 1 (N1)

            Console.WriteLine(" ");

            Console.WriteLine("Lado B:");
            double N2 = Convert.ToDouble(Console.ReadLine()); //Asignando valor a el lado 2 (N2)

            int valor = 2;

            Console.Clear();

            double Res1 = R.CalcularArea(N1); //Resultado1 es igual a el Metodo del Area del Cuadrado
            double Res2 = R.CalcularArea(N1, N2); //Resultado2 es igual a el Metodo del Area de un Rectangulo
            double Res3 = R.CalcularArea(N1, N2, valor); //Resultado3 es igual a el Metodo del Area de un Triangulo

            Console.WriteLine("Area de un Cuadrado:");
            Console.WriteLine(Res1); //Imprimir Resultados

            Console.WriteLine(" ");

            Console.WriteLine("Area de un Rectangulo:");
            Console.WriteLine(Res2); //Imprimir Resultados

            Console.WriteLine(" ");

            Console.WriteLine("Area de un Triangulo:");
            Console.WriteLine(Res3); //Imprimir Resultados

            Console.WriteLine(" ");

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
