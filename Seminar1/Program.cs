// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 > number2)
// {
//     Console.Write($"число {number1} большее, число {number2} меньшее");
// }
// else if (number1 < number2)
// {
//     Console.Write($"число {number2} большее, число {number1} меньшее");
// }
// else
// {
//     Console.Write($"числа {number1} и {number2} равны");
// }



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите третье число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int max = number1;
// if (number2 > number1)
// {
//     max = number2;
// }
// if (number3 > max)
// {
//     max = number3;
// }
// Console.Write($"максимальное число {max}");



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0)
// {
//     Console.Write($"число {number} - четное");
// }
// else
// {
//     Console.Write($"число {number} - нечетное");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.Write($"Искомые четные числа в диапозоне от 1 до {number}: ");
while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count += 1;
}
