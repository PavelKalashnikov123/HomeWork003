// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x1 и нажмите Enter");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату y1 и нажмите Enter");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату z1 и нажмите Enter");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату x2 и нажмите Enter");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату y2 и нажмите Enter");
int y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату z2 и нажмите Enter");
int z2 = int.Parse(Console.ReadLine()!);

double AB(double x1, double x2,
double y1, double y2,
double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
    Math.Pow((y2 - y1), 2) +
    Math.Pow((z2 - z1), 2));
}
double segmentLength = Math.Round(AB(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Растояни {segmentLength}");
