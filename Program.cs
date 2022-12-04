


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


int number = new Random().Next(100, 10000);
Console.WriteLine($"Введите число {number}:");

string str = number.ToString();
Console.WriteLine(str[2]);
        