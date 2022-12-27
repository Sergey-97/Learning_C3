Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();

if (num.Length == 5)
{
    if (num[0]==num[4] && num[1]==num[3])
    {
       Console.WriteLine($"число {num} является палиндромом");
    }
    else
    {
       Console.WriteLine($"число {num} не является палиндромом");
    }
}
 else
{
    Console.WriteLine("Ошибка, (введите пятизначное число) :");
}