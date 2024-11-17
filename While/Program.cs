using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

int n;
Console.WriteLine("Введіть натуральне число n:");
string input = Console.ReadLine();
n = int.Parse(input);

double sumA = 0;
int i = 1;
while (i <= n)
{
    sumA += Math.Pow(-1, i) / (2 * i + 1);
    i++;
}
Console.WriteLine("a = " + sumA);

double sumB = 0;
i = 1;
while (i <= n)
{
    sumB += 1 + 1.0 / (i * i);
    i++;
}
Console.WriteLine("b = " + sumB);

double sumC = 0;
double factorial = 1;
i = 1;
while (i <= n)
{
    factorial *= i;
    sumC += factorial;
    i++;
}
Console.WriteLine("c = " + sumC);
    

