﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int num = new Random().Next(10, 100);
Console.WriteLine($"Сгенерировано случайное число {num}");
int max = num / 10;
if (num % 10 > max) max = num % 10;
Console.WriteLine($"Наибольшая цифра в этом числе {max}");

//добавим цикл for - для четкого количества раз
// while - для неопределенного
for (int i = 0; i <= num; i++) Console.Write($"{i} ");