
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Retangulo
    {
        public double altura;
        public double largura;

        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public string retornaArea()
        {
            return "Área do Retângulo: " + (largura * altura);
        }

        public string retornaPerimetro()
        {
            return "Perímetro do Retângulo: " + ((largura + altura) * 2);
        }

        public string retornaDiagonal()
        {
            double quadradoAltura = altura * altura;
            double quadradoLargura = largura * largura;

            return "Diagonal do Retângulo: " + Math.Sqrt(quadradoLargura + quadradoAltura);
        }
    }
}
