// See https://aka.ms/new-console-template for more information
Console.WriteLine("Здраствуйте! давайте узнаем сколько четный и нечетных чисел в том диапазоне, который вы указали введите первое число");
int OneNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int TwoNumber = int.Parse(Console.ReadLine());
while (TwoNumber < 0)
{
    TwoNumber++;
}
