
double a = 2.0, b = 6.0, c = 35.0;
double sqrtB = Math.Pow(b, 2.0);

double delta = sqrtB - 4.0 * a * c;

double xa = (-sqrtB + Math.Sqrt(delta)) / 2 * a;
double xb = (-sqrtB - Math.Sqrt(delta)) / 2 * a;

Console.WriteLine($"Delta: {delta}");
Console.WriteLine($"X1: {xa}");
Console.WriteLine($"X2: {xb}");