// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

// Console.WriteLine("Введите пятизначное число ");
// int number = Convert.ToInt32(Console.ReadLine());

// string IfPalindrome(int num)
// {
//     if(num > 99999 || num < 10000) return $"{num} не является пятизначным числом";
//     int FirstDigit = num / 10000;
//     int SecondDigit = (num / 1000) % 10;
//     int FourthDigit = (num / 10) % 10;
//     int FifthDigit = num % 10;
//     if(FirstDigit == FifthDigit && SecondDigit == FourthDigit) return $"{num} является палиндромом";
//     else return $"{num} не является палиндромом";
// }

// string result = IfPalindrome(number);
// System.Console.WriteLine(result);



// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты первой точки");
// Console.Write("X: ");
// int numAX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int numAY = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z: ");
// int numAZ = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки");
// Console.Write("X: ");
// int numBX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int numBY = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z: ");
// int numBZ = Convert.ToInt32(Console.ReadLine());

// double findLength(int ax, int ay, int az, int bx, int by, int bz)
// {
//     int x = bx - ax;
//     int y = by - ay;
//     int z = bz - az;
//     return Math.Sqrt(x * x + y * y + z * z);
// }

// double lenghtAB = findLength(numAX, numAY, numAZ, numBX, numBY, numBZ);
// double lenght = Math.Round(lenghtAB, 2, MidpointRounding.ToZero);
// Console.WriteLine($"Расстояние между двумя точками равно {lenght}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

void TripleNumber(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int triple = i * i * i;
        Console.WriteLine($"{i} {triple}");
    }
}
TripleNumber(number);