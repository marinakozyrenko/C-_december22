// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int showSecondDigit(int number)
// {
//     int firstDigit = number / 100;
//     int thirdDigit = number % 10; 
//     int secondDigit = (number - firstDigit*100 - thirdDigit)/10;
//     return secondDigit; 
// }

// Console.WriteLine("введите 3-х значное число (100-999): ");
// int userNumber = Convert.ToInt32(Console.ReadLine());
// int newNumber = showSecondDigit(userNumber);
// Console.WriteLine($"2-я цифра числа {userNumber} = {newNumber}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int showThirdDigit(int number)
// {
//     while (number / 1000 >= 1)
//     number = number / 10;
//     int thirdDigit = number % 10;
//     return thirdDigit;
// }

// Console.WriteLine("введите число: ");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// if (userNumber < 100) 
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     int result = showThirdDigit(userNumber);
//     Console.WriteLine($"Третья цифра числа {userNumber} равна {result}");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели (пн = 1, вт = 2...) ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 6)
    {
        Console.WriteLine("введенный день не выходной");
    }
else if (number == 6 || number == 7)
    {
        Console.WriteLine("введенный день выходной");
    }
else if (number < 1 || number > 7)
    {
        Console.WriteLine("введите число от 1 до 7");
    }