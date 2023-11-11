



Console.Write("Entre com as medidas do triângulo X: ");
string x = Console.ReadLine();
x.Split(' ');


Console.Write("Entre com as medidas do triângulo Y: ");
string y = Console.ReadLine();
y.Split(' ');

double areaX = calcArea(x[0], x[1], x[2]);
double areaY = calcArea(y[0], y[1], y[2]);

Console.WriteLine($"Área de X: {areaX}");
Console.WriteLine($"Área de Y: {areaY}");

if(areaX > areaX)
{
    Console.WriteLine("Maior Área: X");
}
else
{
    Console.WriteLine("Maior Área: Y");
}

static double calcArea(double a, double b, double c)
{
    double p = (a + b + c) / 2;
    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
}