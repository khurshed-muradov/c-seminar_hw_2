// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int UserInput()
{
    while (true)
    {
        int userInput = int.Parse(Console.ReadLine()!);
        if (userInput >= 100 && userInput < 1000)
        {
            return userInput;
        }
        else
        {
            System.Console.WriteLine("Число не трехзначное! Пожалуйста, введите трехзначное число.");

        }
    }
}
int userInput = UserInput();
int firstDigit = userInput / 100;
int secondDigit = (userInput % 100) / 10;
int thirdDigit = userInput % 10;

System.Console.WriteLine(userInput + " -> " + secondDigit);







