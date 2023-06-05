Console.Write("Введите значение a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите значение b: ");
double b = double.Parse(Console.ReadLine());
double result = Math.Pow(a + b, 2);
Console.WriteLine("({0}+{1})^2={2} при a={0}, b={1}", a, b, result);