using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

double sum = 0;
int numberOfGrades = 5;

for (int i = 0; i < numberOfGrades; i++)
{
    Console.Write($"Введіть оцінку {i + 1}: ");
    double grade = double.Parse(Console.ReadLine());
    sum += grade;
}
double average = sum / numberOfGrades;
Console.WriteLine($"Середній бал: {average}");
if (average >= 50)
{
    Console.WriteLine("Студент допущений до екзамену.");
}
else
{
    Console.WriteLine("Студент не допущений до екзамену.");
}

