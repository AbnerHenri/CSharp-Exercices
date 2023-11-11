





Console.Write("Digite dois números separados por espaço: ");
string[] numeros = Console.ReadLine().Split(' ');

Console.WriteLine($"O valor da soma: {calcularSoma(int.Parse(numeros[0]), int.Parse(numeros[1]))}");
Console.WriteLine($"O valor da subtração: {calcularSubtracao(int.Parse(numeros[0]), int.Parse(numeros[1]))}");
Console.WriteLine($"O valor da multiplicação: {calcularMultiplicacao(int.Parse(numeros[0]), int.Parse(numeros[1]))}");
Console.WriteLine($"O valor da divisão: {calcularDivisao(int.Parse(numeros[0]), int.Parse(numeros[1]))}");


static int calcularSoma(int n1, int n2)
{
    return n1 + n2;
}

static int calcularSubtracao(int n1, int n2)
{
    return n1 - n2;
}

static int calcularMultiplicacao(int n1, int n2)
{
    return n1 * n2;
}

static double calcularDivisao(int n1, int n2)
{
    return (double) n1 / n2;
}