// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму первой и последней цифры этого числа.
// 456  =>  10
// 782  =>  9
// 918  =>  17

Console.WriteLine("Введите число");
int number = Convert.ToInt32(System.Console.ReadLine());
if (number > 99 && number < 999)
{
     int first = number / 100;
    int last = number % 10;
    int sum = first + last;
Console.WriteLine("Сумма первой и последней цыфры равна:" +sum);
}
else
{
    Console.WriteLine("Число не трехзначное");
}