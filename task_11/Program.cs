// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
while (true)
{
    int im_userInput = int.Parse(Console.ReadLine()!);
    if (im_userInput < 100)
    {
        System.Console.Write(im_userInput + " -> третьей цифры нет");
        break;
    }
    if (im_userInput < 1000)
    {
        System.Console.Write(im_userInput + " -> " + (im_userInput % 10));
        break;
    }
    if (im_userInput < 10000)
    {
        System.Console.Write(im_userInput + " -> " + (((im_userInput % 100) / 10)));
        break;
    }
}