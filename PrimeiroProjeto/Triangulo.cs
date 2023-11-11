﻿
namespace PrimeiroProjeto
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double calcArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}