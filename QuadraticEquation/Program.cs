using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

double a, b, c;

Console.WriteLine("Введіть a: ");
string input = Console.ReadLine();
a = double.Parse(input);

Console.WriteLine("Введіть b: ");
input = Console.ReadLine();
b = double.Parse(input);

Console.WriteLine("Введіть c: ");
input = Console.ReadLine();
c = double.Parse(input);

double discriminant = b * b - 4 * a * c;
Console.WriteLine($"Дискримінант: {discriminant}");
if (discriminant > 0)
{
    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    Console.WriteLine($"Розв'язки рівняння: x1 = {x1}, x2 = {x2}");
}
else if (discriminant == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"Розв'язок рівняння: x = {x}");
}
else
{
    Console.WriteLine("Рівняння не має дійсних коренів.");
}
   