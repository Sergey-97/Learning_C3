// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int getValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double getCoordinates (int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double result = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2)+ Math.Pow(Az - Bz, 2));
    return result;
}
Console.Write("Введите X1: ");
int Ax = int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int Ay = int.Parse(Console.ReadLine());
Console.Write("Введите Z1: ");
int Az = int.Parse(Console.ReadLine());

Console.Write("Введите X2: ");
int Bx = int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int By = int.Parse(Console.ReadLine());
Console.Write("Введите Z2: ");
int Bz = int.Parse(Console.ReadLine());

double distance = getCoordinates(Ax, Ay, Az, Bx, By, Bz);
Console.Write($"Расстояние = {getCoordinates(Ax, Ay, Az, Bx, By, Bz):f2}");