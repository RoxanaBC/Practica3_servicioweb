using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcularWS
{
    public class Calcular
    {
        public class Cuadrado
        {
            public double Lado { get; set; }

            public Cuadrado(double lado)
            {
                Lado = lado;
            }

            public double CalcularArea()
            {
                return Lado * Lado;
            }
        }

        public class Triangulo
        {
            public double Base { get; set; }
            public double Altura { get; set; }

            public Triangulo(double basee, double altura)
            {
                Base = basee;
                Altura = altura;
            }

            public double CalcularArea()
            {
                return (Base * Altura) / 2;
            }
        }

        public class Circulo
        {
            public double Radio { get; set; }

            public Circulo(double radio)
            {
                Radio = radio;
            }

            public double CalcularArea()
            {
                return Math.PI * Radio * Radio;
            }
        }
    }
}