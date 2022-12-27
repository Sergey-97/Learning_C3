Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int i = 1;

while (i<=N)
{
    Console.Write(Math.Pow(i, 3) + ", ");
    i++;
}