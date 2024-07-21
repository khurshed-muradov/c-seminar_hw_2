// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
System.Console.WriteLine("Введите число: ");
int weekDay = int.Parse(Console.ReadLine()!);
while (weekDay <= 7)
{
    if (weekDay <= 5)
    {
        System.Console.WriteLine("Нет");
        break;
    }
    else
    {
        System.Console.WriteLine("Да");
        break;
    }

}