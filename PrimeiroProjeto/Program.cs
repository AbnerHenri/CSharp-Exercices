

using PrimeiroProjeto;

Triangulo X = new Triangulo();
Triangulo Y = new Triangulo();

Console.WriteLine("Digite as medidas do triângulo X: ");

X.A = double.Parse(Console.ReadLine());
X.B = double.Parse(Console.ReadLine());
X.C = double.Parse(Console.ReadLine());

Console.WriteLine("Digite as medidas do triângulo Y: ");

Y.A = double.Parse(Console.ReadLine());
Y.B = double.Parse(Console.ReadLine());
Y.C = double.Parse(Console.ReadLine());


Console.WriteLine($"Área do triângulo X: {X.calcArea()}");
Console.WriteLine($"Área do triângulo Y: {Y.calcArea()}");

string maiorArea = X.calcArea() >= Y.calcArea() ? "X" : "Y";

Console.WriteLine($"Triângulo da Área maior: {maiorArea}");