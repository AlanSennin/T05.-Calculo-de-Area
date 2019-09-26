using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargarFigura
{
    class Operaciones
    {
        public double CalcularArea(double ladoA) //Metodo para Calcular el Area del Cuadrado
        {
            return ladoA*ladoA; 
        }

        public double CalcularArea(double ladoA, double ladoB) //Metodo para Calcular el Area de un Rectangulo
        {
            return ladoA*ladoB;
        }

        public double CalcularArea(double ladoA, double ladoB, int valor) //Metodo para Calcular el Area de un Triangulo
        {
            valor = 2;

            return (ladoA * ladoB) / valor;
        }
    }
}
